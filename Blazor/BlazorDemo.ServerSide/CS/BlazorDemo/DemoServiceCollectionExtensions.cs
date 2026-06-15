using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Net.Http;
using Azure.AI.OpenAI;
using BlazorDemo.Agents;
using BlazorDemo.Agents.Weather;
using BlazorDemo.Agents.WorkflowInfra;
using BlazorDemo.Configuration;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Services;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Chat;
using DevExpress.Blazor.DocumentMetadata;
using DevExpress.Blazor.RichEdit.SpellCheck;
using Microsoft.Agents.AI;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;


namespace BlazorDemo {

    public static class DemoServiceCollectionExtensions {
        public static void AddDemoServices(this IServiceCollection services, string azureOpenAIEndpoint, string azureOpenAIKey, string deploymentName, bool blazorWasm = false) {
            services.AddSingleton<WeatherService>();
            services.AddSingleton<WeatherAgentTools>();
            services.AddScoped<WeatherForecastService>();
            services.AddScoped<RentInfoDataService>();
            services.AddScoped<ContosoRetailDataService>();
            services.AddScoped<NwindDataService>();
            services.AddScoped<HomesDataService>();
            services.AddScoped<IssuesDataService>();
            services.AddScoped<WorldcitiesDataService>();
            services.AddScoped<DictionaryEntryDataProvider>();
            services.AddScoped<AIHttpResponseProcessor>();
            services.AddScoped<ToolApprovalAIFunctions>();

            services.AddScoped((provider) => {
                return new AzureOpenAIClient(
                    new Uri(azureOpenAIEndpoint),
                    new System.ClientModel.ApiKeyCredential(azureOpenAIKey),
                    new AzureOpenAIClientOptions() {
                        Transport = new PromoteHttpStatusErrorsPipelineTransport(provider.GetService<AIHttpResponseProcessor>())
                 });
            });
            services.AddScoped<IChatClient>((provder) => {
                var client = provder.GetService<AzureOpenAIClient>();
                return client.GetChatClient(deploymentName).AsIChatClient();
            });

            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.FunctionCallingWithGrid, (provider, key) => {
                var baseClient = provider.GetService<IChatClient>();
                return baseClient.AsBuilder()
                   .UseDXTools()
                   .UseFunctionInvocation()
                   .Build(provider).AsIChatResponseProvider();
            });

            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.FunctionCalling, (provider, key) => {
                var baseClient = provider.GetService<IChatClient>();
                return baseClient
                    .AsBuilder()
                    .ConfigureOptions(x => {
                        x.Tools = [
                            CustomAIFunctions.GetWeatherTool,
                            CustomAIFunctions.TestExceptionTool,
                            CustomAIFunctions.GetTimeTool
                        ];
                    })
                    .UseFunctionInvocation()
                    .Build().AsIChatResponseProvider();
            });

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
#pragma warning disable OPENAI001
            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.Reasoning, (provider, key) => {
                var azureClient = provider.GetService<AzureOpenAIClient>();
                IChatClient chatClient = azureClient.GetResponsesClient()
                    .AsIChatClient(deploymentName)
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
#pragma warning restore OPENAI001

            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.WorkflowAsAgent, (provider, key) => {
                var baseClient = provider.GetService<IChatClient>();
                var agentWorkflowClient = baseClient.AsBuilder().UseFunctionInvocation().Build();
                var agentFactory = new AgentFactory(agentWorkflowClient);

                return agentFactory.CreateShakespeareanPoetAgenticWorkflow();
            });

            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.WorkflowResponseStreaming,
                (provider, key) => {
                    var baseClient = provider.GetService<IChatClient>();
                    var agentWorkflowClient = baseClient.AsBuilder().UseFunctionInvocation().Build();
                    var agentFactory = new AgentFactory(agentWorkflowClient);

                    return new WorkflowResponseProvider<string>(agentFactory.CreateShakespeareanPoetWorkflow(),
                        GetLastUserText);
                });

            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.WorkflowWithExecutors, (provider, key) => {
                return new WorkflowResponseProvider<string>(
                    AgentFactory.CreateTextProcessingWorkflow(),
                    GetLastUserText);
            });

            services.AddKeyedSingleton<AIAgent>(ChatClientKeys.WeatherAgent, (provider, key) => {
                var chatClient = provider.GetRequiredService<IChatClient>();
                var weatherTools = provider.GetRequiredService<WeatherAgentTools>();
                var agentFactory = new AgentFactory(chatClient);

                return agentFactory.CreateWeatherAgent(weatherTools.GetWeatherTool(), (string)key);
            });

#pragma warning disable DX0006 // AGUIChatClient requires an HttpClient instance; AsyncDownloader is not applicable
            services.AddKeyedScoped<IChatResponseProvider>(ChatClientKeys.AGUIWeather, (provider, key) => {
                var httpClient = provider.GetRequiredService<HttpClient>();
                var navigationManager = provider.GetRequiredService<NavigationManager>();
                string endpoint = new Uri(new Uri(navigationManager.BaseUri), $"api/{AIChatResourcesEndpoints.WeatherAgentEndpoint}").ToString();

                return AgentFactory.CreateAGUIWeatherResponseProvider(httpClient, endpoint);
            });
#pragma warning restore DX0006

            services.AddScoped<IAIExceptionHandler, AIExceptionHandler>();
            services.AddDevExpressAI();
            services.AddSingleton<SmartFilterProvider>();
            services.AddDevExpressBlazor()
                    .AddSpellCheck(opts => {
                        opts.FileProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly(), "BlazorDemo");
                        opts.MaxSuggestionCount = 6;
                        opts.AddToDictionaryAction = (word, culture) => {
                            //Write the selected word to a dictionary file
                        };
                        opts.Dictionaries.Add(new ISpellDictionary {
                            DictionaryPath = "Data.Dictionaries.english.xlg",
                            GrammarPath = "Data.Dictionaries.english.aff",
                            Culture = "en-US"
                        });
                        opts.Dictionaries.Add(new Dictionary {
                            DictionaryPath = "Data.Dictionaries.custom.dic",
                            AlphabetPath = "Data.Dictionaries.english.txt",
                            Culture = "en-US"
                        });
                    });

            if(blazorWasm) {
                services.AddScoped<DevExpress.XtraReports.Services.IReportProviderAsync, DemoReportSourceWasm>();
                services.AddDevExpressWebAssemblyBlazorPdfViewer();
                services.AddDevExpressWebAssemblyBlazorReportViewer();

                DevExpress.XtraPrinting.PrintingOptions.Pdf.RenderingEngine = DevExpress.XtraPrinting.XRPdfRenderingEngine.Skia;
            }
            services.AddDocumentMetadata(ConfigureMetadata);
            services.AddSingleton<DemoConfiguration>();

            static void ConfigureMetadata(IServiceProvider sp, IDocumentMetadataCollection metadataCollection) {
                sp.GetService<DemoConfiguration>().ConfigureMetadata(metadataCollection);
            }

            static string GetLastUserText(IEnumerable<ChatMessage> messages) {
                ChatMessage userMessage = messages.LastOrDefault(message => message.Role == ChatRole.User);
                if(userMessage is null || string.IsNullOrWhiteSpace(userMessage.Text)) {
                    throw new InvalidOperationException("The workflow requires a user text message.");
                }

                return userMessage.Text;
            }
        }
    }
}
