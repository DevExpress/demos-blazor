using Markdig;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.CRM.Client.Services;

public static class MarkdownRenderer {
    private static readonly MarkdownPipeline SafeMarkdownPipeline =
        new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .DisableHtml()
            .Build();

    public static MarkupString ToSafeHtml(string text) => (MarkupString)Markdown.ToHtml(text, SafeMarkdownPipeline);
}
