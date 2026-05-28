using System.Net;
using System.Text;
using BlazorDemo.CRM.Client.Utils;
using BlazorDemo.CRM.Components;
using BlazorDemo.CRM.Components.Account;
using BlazorDemo.CRM.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddAppServices();

var azureOpenAIEndpoint = builder.Configuration.GetSection("AIIntegrationSettings")["EndpointUrl"];
var azureOpenAIKey = builder.Configuration.GetSection("AIIntegrationSettings")["Key"];
var deploymentName = builder.Configuration.GetSection("AIIntegrationSettings")["DeploymentName"];

if(azureOpenAIEndpoint != null && azureOpenAIKey != null && deploymentName != null)
    builder.Services.AddChatClient(azureOpenAIEndpoint, azureOpenAIKey, deploymentName);
builder.Services.AddScoped<DemoData>();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingServerAuthenticationStateProvider>();
builder.Services.AddScoped<CookieEvents>();
builder.Services.AddHttpClient();
builder.Services.ConfigureApplicationCookie(o => {
    o.EventsType = typeof(CookieEvents);
});

var configuration = builder.Configuration;
builder.Services.AddDbContext<ApplicationDbContext>((provider, options) => {
    var accessor = provider.GetRequiredService<IHttpContextAccessor>();
    var context = accessor?.HttpContext;
    if(context != null) {
        string? dataKey = context.Request.Cookies["DemoDataKey"];
        if(dataKey == null) {
            dataKey = Guid.NewGuid().ToString();
            context.Response.Cookies.Append("DemoDataKey", dataKey);
        }
        options.UseInMemoryDatabase(dataKey);
    }
    // Use the following lines of code to configures the context to connect to a SQL Server database.
    // var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    // options.UseSqlServer(connectionString);
});
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

builder.WebHost.UseStaticWebAssets();

var app = builder.Build();

string? pathBase = configuration.GetValue<string>("pathbase");
if(!string.IsNullOrEmpty(pathBase)) {
    string pathString = pathBase.StartsWith('/') ? pathBase : "/" + pathBase;
    app.UsePathBase(pathString);
}

app.UseRouting();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment()) {
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
} else {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if(azureOpenAIEndpoint != null) {
    app.MapPost("/api/chat/{*path}", async (string path, HttpContext context, CancellationToken ct) => {
        var httpClientFactory = context.RequestServices.GetRequiredService<IHttpClientFactory>();
        if(context.User.Identity?.IsAuthenticated != true) {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            await context.Response.BodyWriter.WriteAsync(Encoding.UTF8.GetBytes("Not authorized"), ct);
            return;
        }
        var client = httpClientFactory.CreateClient();
        client.BaseAddress = new(azureOpenAIEndpoint);
        client.DefaultRequestHeaders.Authorization = new("Bearer", azureOpenAIKey);

        var newPath = path.Replace("proxychat", deploymentName);
        var endpointUri = new Uri(azureOpenAIEndpoint);
        var uriBuilder = new UriBuilder(endpointUri) {
            Path = $"{endpointUri.AbsolutePath}/{newPath}",
            Query = context.Request.QueryString.Value
        };
        var body = await new StreamReader(context.Request.Body).ReadToEndAsync(ct);

        var response = await client.PostAsync(uriBuilder.Uri, new StringContent(body, Encoding.UTF8, "application/json"), ct);
        context.Response.StatusCode = (int)response.StatusCode;
        await response.Content.CopyToAsync(context.Response.Body, ct);
    }).RequireAuthorization();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapStaticAssets();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorDemo.CRM.Client.Components._Imports).Assembly);


app.MapAdditionalIdentityEndpoints();

app.Run();
