using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Data;
using DevExpress.Images.Blazor.Internal;

namespace BlazorDemo.DataProviders.Implementation;

public record DemoIconDataProvider(IIconMetadataProvider MetadataProvider) : IDemoIconDataProvider {
    readonly DemoIcon[] icons = IconRegistry.EnumerateExistingIconKeys()
        .Select(x => new DemoIcon(x))
        .OrderBy(i => i.Name)
        .ThenBy(i => i.Key.Set)
        .ThenBy(i => i.Key.Style)
        .ThenByDescending(i => i.Key.Color)
        .ThenBy(i => i.Key.Size)
        .ToArray();

    Dictionary<string, DemoIconMetadata> iconMetadata;

    public DemoIcon[] GetIcons() => icons;

    public async Task<Dictionary<string, DemoIconMetadata>> GetIconMetadata() {
        if(iconMetadata == null) {
            iconMetadata = (await MetadataProvider.GetIconMetadata()).Icons
                .Select(x => (
                    Key: IconKeyConverter.TryParseKey(x.Key, out IconKey key) ? key.Id.ToString() : null,
                    Value: x.Value))
                .Where(x => !string.IsNullOrEmpty(x.Key))
                .ToDictionary();
        }
        return iconMetadata;
    }
}
