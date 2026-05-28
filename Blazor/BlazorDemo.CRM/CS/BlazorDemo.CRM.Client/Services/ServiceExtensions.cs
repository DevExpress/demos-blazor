using Azure;
using Azure.AI.OpenAI;
using BlazorDemo.CRM.Client.Services;
using BlazorDemo.CRM.Services;
using BlazorDemo.CRM.Services.DataProviders;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Chat;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.AI;

namespace BlazorDemo.CRM.Client.Utils {
    public static class ServiceExtensions {
        public static void AddAppServices(this IServiceCollection services) {
            services.AddScoped(sp =>
                new HttpClient {
                    BaseAddress = new Uri("https://js.devexpress.com/Demos/RwaService/api/")
                });
            services.AddDevExpressBlazor();
            services.AddScoped<SearchManager>();
            services.AddScoped<ModuleLoader>();
            services.AddScoped<ThemeManager>();
            services.AddScoped<ClipboardManager>();
            services.AddScoped<SizeModeManager>();
            services.AddScoped<ContactDataProvider>();
            services.AddScoped<AnalyticDataProvider>();
            services.AddScoped<TasksDataProvider>();
            services.AddCascadingValue("NotificationCount", sp => 4);
            services.AddScoped(sp => new CascadingValueSource<SizeMode>("ParentSizeMode", SizeMode.Medium, false));
            services.AddCascadingValue(sp => sp.GetRequiredService<CascadingValueSource<SizeMode>>());
            services.AddDevExpressAI();
        }

        public static void AddChatClient(this IServiceCollection services, string aiEndpoint, string aiKey, string deployment) {
            services.AddKeyedScoped<IChatResponseProvider>(ChatResponseProviderServiceKeys.Dashboard, (sp, _) => CreateChatResponseProvider(sp, aiEndpoint, aiKey, deployment));
            services.AddKeyedScoped<IChatResponseProvider>(ChatResponseProviderServiceKeys.Scheduler, (sp, _) => CreateChatResponseProvider(sp, aiEndpoint, aiKey, deployment));
        }

        static IChatResponseProvider CreateChatResponseProvider(IServiceProvider sp, string aiEndpoint, string aiKey, string deployment) {
            var azureClient = new AzureOpenAIClient(new Uri(aiEndpoint), new AzureKeyCredential(aiKey));
            return azureClient
                   .GetChatClient(deployment)
                   .AsIChatClient()
                   .AsBuilder()
                   .UseDXTools()
                   .UseFunctionInvocation()
                   .Build(sp)
                   .AsIChatResponseProvider();
        }
    }
}
