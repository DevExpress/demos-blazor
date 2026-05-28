# Blazor AI Chat

An AI-powered chat component for Blazor applications.

*   **Namespace:** DevExpress.AIIntegration.Blazor.Chat
*   **Assembly:** DevExpress.AIIntegration.Blazor.Chat.v26.1.dll
*   **NuGet Package:** [DevExpress.AIIntegration.Blazor.Chat](https://www.nuget.org/packages/DevExpress.AIIntegration.Blazor.Chat)

## Declaration

```csharp
public class DxAIChat : DxComponentBase, IAsyncDisposable, IAIChat, INestedSettingsOwner
```

## Remarks

DevExpress Blazor AI Chat (`<DxAIChat>`) allows users to interact with AI services. It is compatible with major cloud AI providers (OpenAI, Azure OpenAI, Gemini, etc.) and self-hosted language models (Ollama).

> **Note:** DevExpress AI-powered extensions operate on a **"bring your own key" (BYOK)** model. You must configure your own AI provider parameters (endpoint, API key, etc.) at application startup.

## Add an AI Chat to a Project

1. **Register the AI Model** in your project's entry point (e.g., `Program.cs`):

```csharp
public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        /* Define chat clients */
        builder.Services.AddChatClient(azureOpenAIChatClient);
        builder.Services.AddKeyedChatClient("Gemini", geminiChatClient);
        builder.Services.AddKeyedChatClient("Ollama", ollamaChatClient);

        builder.Services.AddDevExpressBlazor();
        builder.Services.AddDevExpressAI();
        // ...
    }
}
```

2. **Add the markup** to a `.razor` file:

```razor
@using DevExpress.AIIntegration.Blazor.Chat
<DxAIChat />
```

## AI Model Settings

Configure the following properties to control AI behavior:
*   **FrequencyPenalty:** Penalizes new tokens based on their frequency in the text.
*   **MaxTokens:** Limits the maximum number of tokens generated.
*   **Temperature:** Controls response randomness.

## Streaming Response

Enable `UseStreaming` for a more responsive experience where the AI displays text as it is generated.

```razor
<DxAIChat UseStreaming="true" />
```

## Rich Formatted Response

By default, responses are plain text. To support Markdown, set `ResponseContentFormat` and use a library like Markdig.

> **Important:** Always sanitize HTML generated from Markdown to prevent XSS attacks.

```razor
@using Markdig
@using Ganss.Xss

<DxAIChat ResponseContentFormat="ResponseContentFormat.Markdown">
    <MessageContentTemplate>
        @ToHtml(context.Content)
    </MessageContentTemplate>
</DxAIChat>

@code {
    private readonly HtmlSanitizer sanitizer = new HtmlSanitizer();

    MarkupString ToHtml(string markdown) {
        string html = Markdown.ToHtml(markdown);
        return new MarkupString(sanitizer.Sanitize(html));
    }
}
```

## File Attachments

Enable file uploads by setting `FileUploadEnabled="true"`. You can configure validation (size, extension) via `<DxAIChatFileUploadSettings>`.

```razor
<DxAIChat FileUploadEnabled="true">
    <AIChatSettings>
        <DxAIChatFileUploadSettings
            MaxFileCount="2"
            MaxFileSize="20000"
            AllowedFileExtensions="@(new List<string> { ".jpg", ".pdf" })" />
    </AIChatSettings>
</DxAIChat>
```

## Save and Load Messages

Use `LoadMessages` and `SaveMessages` to manage chat history.

```razor
<DxAIChat Initialized="ChatInitialized" />

@code {
    void ChatInitialized(IAIChat chat) {
        chat.LoadMessages(new[] {
            new BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.Assistant, "Hello! How can I help?")
        });
    }
}
```

## Prompt Suggestions

Display hint bubbles when the chat is empty to guide the user.

```razor
<DxAIChat>
    <PromptSuggestions>
        <DxAIChatPromptSuggestion Title="Summarize" Text="Summarize a document" PromptMessage="Summarize this: " />
        <DxAIChatPromptSuggestion Title="Fix Writing" Text="Check for grammar" PromptMessage="Fix this text: " />
    </PromptSuggestions>
</DxAIChat>
```

## AI Tool Calling

The `DxAIChat` component supports **AI Tool Calling** (Function Calling), allowing the AI to invoke C# methods in your application based on user prompts.

1.  **Define a Tool:**
    ```csharp
    [AIIntegrationTool("ExpandGroups")]
    public static string ExpandGroups(GridControl target) {
        target.ExpandAllGroups();
        return "Groups expanded.";
    }
    ```
2.  **Register with the AI Client:**
    ```csharp
    builder.Services.AddScoped((sp) => {
        return azureOpenAIChatClient.AsBuilder()
            .UseDXTools() // DevExpress Tool Calling
            .UseFunctionInvocation()
            .Build(sp);
    });
    ```
