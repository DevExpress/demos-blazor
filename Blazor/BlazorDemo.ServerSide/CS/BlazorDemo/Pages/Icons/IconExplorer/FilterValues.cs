using System.Collections.Generic;
using BlazorDemo.Data;
using DevExpress.Images.Blazor.Internal;

namespace BlazorDemo.Pages.Icons.IconExplorer;

public class FilterValues {
    public IconSet IconSet { get; set; } = IconSet.Auto;
    public HashSet<IconSize> IconSizes { get; } = new();
    public HashSet<IconStyle> IconStyles { get; } = new();
    public HashSet<IconColor> IconColors { get; } = new();

    public bool HasActiveFilters =>
        IconSet != IconSet.Auto || IconSizes.Count > 0 || IconStyles.Count > 0 || IconColors.Count > 0;

    public bool Matches(DemoIcon icon) =>
        (IconSet == IconSet.Auto || icon.Key.Set == IconSet) &&
        (IconStyles.Count == 0 || IconStyles.Contains(icon.Key.Style)) &&
        (IconColors.Count == 0 || IconColors.Contains(icon.Key.Color)) &&
        (IconSizes.Count == 0 || IconSizes.Contains(icon.Key.Size));
}
