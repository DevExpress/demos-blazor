using System.Threading.Tasks;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Wasm.Server.Controllers;

[Route("api")]
[ApiController]
public class IconMetadataController(IDataSourcesFileContentProvider fileContentProvider) : Controller {
    IDataSourcesFileContentProvider FileContentProvider { get; } = fileContentProvider;

    [HttpGet("get-icon-metadata")]
    public async Task<string> GetIconMetadata() {
        return await FileContentProvider.GetIconMetadataContentAsync();
    }
}
