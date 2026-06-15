using BlazorDemo.Services;
using BlazorDemo.Agents;
using DevExpress.AIIntegration.Chat;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();

        services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.WorkflowAsAgent, (provider, key) => {
            var baseClient = provider.GetService<IChatClient>();
            var agentWorkflowClient = baseClient.AsBuilder()
                .UseFunctionInvocation()
                .Build();
            var agentFactory = new AgentFactory(agentWorkflowClient);

            return agentFactory.CreateShakespeareanPoetAgenticWorkflow();
        });

        services.AddDevExpressAI();
    }
}
