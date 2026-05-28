using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemo.Data;
using System.Net.Http;

namespace BlazorDemo.DataProviders.Implementation;

public class IconMetadataProviderWasm : IIconMetadataProvider {
#pragma warning disable DX0006
    DemoIconMetadataDocument iconMetadata;

    public IconMetadataProviderWasm(HttpClient httpClient) {
        HttpClient = httpClient;
    }

    HttpClient HttpClient { get; }

    public async Task<DemoIconMetadataDocument> GetIconMetadata() {
        if(iconMetadata == null) {
            string json = await HttpClient.GetStringAsync("api/get-icon-metadata");
            iconMetadata = JsonSerializer.Deserialize<DemoIconMetadataDocument>(json);
        }
        return iconMetadata;
    }
#pragma warning restore DX0006
}
