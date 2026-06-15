using BlazorDemo.Services;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        services.AddScoped<ToolApprovalAIFunctions>();

        IChatClient asChatClient = new Azure.AI.OpenAI.AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
            new System.ClientModel.ApiKeyCredential(azureOpenAIKey))
            .GetChatClient(deployment).AsIChatClient();

        services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.ToolApproval, (provider, key) => {
            var baseClient = provider.GetService<IChatClient>();
            var toolApprovalFunctions = provider.GetRequiredService<ToolApprovalAIFunctions>();
            return baseClient
                .AsBuilder()
                .ConfigureOptions(x => {
                    x.Tools = [
                        toolApprovalFunctions.UpdateAccountTierTool,
                        toolApprovalFunctions.SendBulkEmailTool,
                        toolApprovalFunctions.ArchiveOrdersTool
                    ];
                })
                .UseFunctionInvocation()
                .Build().AsIChatResponseProvider();
        });

        services.AddDevExpressAI();
    }
}
