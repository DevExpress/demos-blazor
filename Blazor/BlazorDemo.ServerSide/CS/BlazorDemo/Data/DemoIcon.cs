using System;
using DevExpress.Blazor.Internal;
using DevExpress.Images.Blazor;
using DevExpress.Images.Blazor.Internal;

namespace BlazorDemo.Data;

public record DemoIcon(IconKey Key) {
    public string Name => Key.Id.ToString();
    public string Uri => IconUri.GetIconUri(Key);
    public string AdaptiveApi => $"{nameof(Icon)}.{Key.Id}";
    public string StaticApi => $"{nameof(IconStatic)}.{Key.Id}.{Key.Set}.{Key.Style}.{Key.Color}.{Key.Size}";

    public string Size => SizeToText(Key.Size);
    public string Color => Key.Color.ToString();
    public string Set => Key.Set.ToString();
    public string Style => Key.Style.ToString();

    public string IconPreviewCssClass =>
        Utils.CombineCssClasses("icon-preview", $"size-{(int)Key.Size}", Name.Contains("white", StringComparison.OrdinalIgnoreCase) ? "icon-white" : null);

    public static string SizeToText(IconSize size) => size == IconSize.Auto ? "All" : $"{(int)size}px";
}
