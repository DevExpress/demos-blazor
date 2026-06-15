using System.Net.Http;
using BlazorDemo.Agents.Shakespearean;
using BlazorDemo.Agents.TextProcessing;
using DevExpress.AIIntegration.Agents;
using DevExpress.AIIntegration.Chat;
using Microsoft.Agents.AI;
using Microsoft.Agents.AI.AGUI;
using Microsoft.Agents.AI.Workflows;
using Microsoft.Extensions.AI;

namespace BlazorDemo.Agents {
    public class AgentFactory {
        readonly IChatClient chatClient;

        const string WeatherAgentInstructions =
            "You are a weather assistant that provides instant weather information.\n\n" +
            "CRITICAL RULES:\n" +
            "1. When a user asks about weather, IMMEDIATELY call the GetWeather tool with the city name - do NOT ask for clarification.\n" +
            "2. If the city name is ambiguous (e.g., 'Paris'), assume the most well-known location (Paris, France).\n" +
            "3. Extract the city name from the user's question even if it's informal (e.g., 'weather in london' → 'London').\n" +
            "4. NEVER ask follow-up questions like 'Which Paris?' or 'Can you provide more details?'\n" +
            "5. If the city cannot be determined, make your best guess based on context.\n" +
            "6. After calling the tool, provide a brief, friendly summary like 'Here's the current weather for [City]!' - keep it SHORT.\n" +
            "7. Do NOT repeat the raw weather data in your text response since a weather widget is rendered automatically from the tool result.";

        public AgentFactory(IChatClient chatClient) {
            this.chatClient = chatClient;
        }

        public IChatResponseProvider CreateShakespeareanPoetAgenticWorkflow() {
            var poemAgent = CreatePoemAgent();
            var shakespeareanAgent = CreateShakespeareanAgent();

            var workflow = new WorkflowBuilder(poemAgent)
                .AddEdge(poemAgent, shakespeareanAgent)
                .Build();

            return workflow
                .AsAIAgent(name: "ShakespeareanPoetWorkflow")
                .AsIChatResponseProvider();
        }

        public Workflow CreateShakespeareanPoetWorkflow() {
            var poemAgent = CreatePoemAgent();
            var shakespeareanAgent = CreateShakespeareanAgent();

            return new WorkflowBuilder(poemAgent)
                .AddEdge(poemAgent, shakespeareanAgent)
                .Build();
        }

        public static Workflow CreateTextProcessingWorkflow() {
            var uppercase = new UppercaseExecutor();
            var reverse = new ReverseTextExecutor();

            return new WorkflowBuilder(uppercase)
                .AddEdge(uppercase, reverse)
                .Build();
        }

        public ChatClientAgent CreatePoemAgent() {
            const string instructions =
                "You are a creative poet AI. Your task is to generate a short, lyrical poem (5-7 lines) " +
                "from a few keywords provided by the user.\n\n" +
                "Rules:\n" +
                "- The user will send 2-3 words separated by spaces or commas.\n" +
                "- Weave ALL provided keywords into the poem naturally.\n" +
                "- Use vivid imagery, optional rhyme, and pleasant rhythm.\n" +
                "- Output ONLY the poem text - no titles, no explanations, no extra commentary.\n" +
                "- In the beginning of your response always add [Response from the PoemAgent] and a new line.";

            return chatClient.AsAIAgent(
                name: "PoemAgent",
                instructions: instructions);
        }

        public ChatClientAgent CreateShakespeareanAgent() {
            const string instructions =
                "You are a literary AI that transforms text into the style of William Shakespeare.\n\n" +
                "Rules:\n" +
                "- Before rewriting, call the GetShakespeareanDictionary tool to retrieve a list of " +
                "authentic Elizabethan words and their meanings.\n" +
                "- Use as many words from the dictionary as naturally fit in the rewritten text.\n" +
                "- Rewrite the provided text using Elizabethan English (thee, thou, hath, doth, etc.).\n" +
                "- Preserve the original meaning and imagery of the text.\n" +
                "- Add dramatic flair, poetic cadence, and Shakespearean vocabulary.\n" +
                "- Output ONLY the rewritten text - no titles, no explanations, no extra commentary.\n" +
                "- In the beginning of your response always add [Response from the ShakespeareanAgent] and a new line.";

            return chatClient.AsAIAgent(
                name: "ShakespeareanAgent",
                instructions: instructions,
                tools: [ShakespeareanTools.GetDictionaryTool()]);
        }

        public AIAgent CreateWeatherAgent(AIFunction weatherTool, string name) {
            return chatClient.AsAIAgent(
                name: name,
                instructions: WeatherAgentInstructions,
                tools: [weatherTool]);
        }

#pragma warning disable DX0006 // AGUIChatClient requires an HttpClient instance; AsyncDownloader is not applicable
        public static IChatResponseProvider CreateAGUIWeatherResponseProvider(
            HttpClient httpClient,
            string agUiEndpoint
        ) {
            var aguiChatClient = new AGUIChatClient(httpClient, agUiEndpoint);
            var agent = aguiChatClient.AsAIAgent(name: "weather-client", description: "AG-UI Weather Client Agent",
                instructions: null, tools: []);

            return agent.AsIChatResponseProvider();
        }
#pragma warning restore DX0006
    }
}
