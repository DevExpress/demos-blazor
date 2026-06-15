using BlazorDemo.Services;
using BlazorDemo.Agents;
using BlazorDemo.Agents.WorkflowInfra;
using DevExpress.AIIntegration.Chat;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();

        services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.WorkflowWithExecutors, (provider, key) => {
            return new WorkflowResponseProvider<string>(
                AgentFactory.CreateTextProcessingWorkflow(),
                GetLastUserText);
        });

        services.AddDevExpressAI();
    }

    static string GetLastUserText(IEnumerable<ChatMessage> messages) {
        ChatMessage userMessage = messages.LastOrDefault(message => message.Role == ChatRole.User);
        if(userMessage is null || string.IsNullOrWhiteSpace(userMessage.Text)) {
            throw new InvalidOperationException("The workflow requires a user text message.");
        }

        return userMessage.Text;
    }
}
