using BlazorDemo.CRM.Authorization;
using BlazorDemo.CRM.Client.Utils;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAppServices();
builder.Services.AddChatClient(builder.HostEnvironment.BaseAddress + "api/chat", "proxykey", "proxychat");
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

await builder.Build().RunAsync();
