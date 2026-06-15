using BlazorDemo.Services;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        var azureClient = new Azure.AI.OpenAI.AzureOpenAIClient(
            new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey));

        services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.Reasoning, (provider, key) => {
            IChatClient chatClient = azureClient.GetResponsesClient()
                .AsIChatClient(deployment)
                .AsBuilder()
                .ConfigureOptions(o => {
                    o.Reasoning = new() {
                        Effort = ReasoningEffort.Medium,
                        Output = ReasoningOutput.Full,
                    };
                })
                .Build();
            return chatClient.AsIChatResponseProvider();
        });

        services.AddDevExpressAI();
    }
}
