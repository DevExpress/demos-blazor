using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.Wasm.Server.DataProviders;

namespace BlazorDemo.DataProviders.Implementation;

public record IconMetadataProvider(IDataSourcesFileContentProvider FileContentProvider) : IIconMetadataProvider {
    DemoIconMetadataDocument iconMetadata;

    public async Task<DemoIconMetadataDocument> GetIconMetadata() {
        if(iconMetadata == null) {
            string json = await FileContentProvider.GetIconMetadataContentAsync();
            iconMetadata = JsonSerializer.Deserialize<DemoIconMetadataDocument>(json);
        }
        return iconMetadata;
    }
}
