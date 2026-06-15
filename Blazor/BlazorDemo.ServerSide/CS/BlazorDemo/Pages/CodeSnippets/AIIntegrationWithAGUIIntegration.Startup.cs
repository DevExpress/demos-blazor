using System;
using System.Net.Http;
using BlazorDemo.Services;
using BlazorDemo.Agents;
using BlazorDemo.Agents.Weather;
using DevExpress.AIIntegration.Chat;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();

        services.AddSingleton<WeatherService>();
        services.AddSingleton<WeatherAgentTools>();

        services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.AGUIWeather, (provider, key) => {
            var httpClient = provider.GetRequiredService<HttpClient>();
            var navigationManager = provider.GetRequiredService<NavigationManager>();
            string endpoint = new Uri(new Uri(navigationManager.BaseUri), $"api/{AIChatResourcesEndpoints.WeatherAgentEndpoint}").ToString();

            return BlazorDemo.ServerSide.Services.AguiWeatherAgentFactory.CreateAGUIWeatherResponseProvider(httpClient, endpoint);
        });

        services.AddDevExpressAI();
    }
}
