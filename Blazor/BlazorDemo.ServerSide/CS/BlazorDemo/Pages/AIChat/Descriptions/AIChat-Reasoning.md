<div class="alert dxbl-alert alert-primary" role="alert">Note: AI services used for this demo have been rate limited. As such, you may experience performance-related delays when exploring the capabilities of DevExpress AI-powered Extensions.
<br />When connected to your own AI model/service without rate limits, DevExpress AI-powered Extensions will perform seamlessly, without artificial delays.</div>

DevExpress Blazor [AI Chat](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat) can inspect individual [AIContent](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.aicontent) items received from the model and render a custom UI for specific content types in chat history.

When you use reasoning models, [message contents](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.BlazorChatMessage.Contents) can include [TextReasoningContent](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.textreasoningcontent) items together with final response text. This demo uses the [MessageContentTemplate](https://docs.devexpress.com/Blazor/DevExpress.AIIntegration.Blazor.Chat.DxAIChat.MessageContentTemplate) to detect reasoning content and render model thoughts directly in the chat.

The demo displays reasoning steps in an expandable panel and renders the final answer in a separate message area.