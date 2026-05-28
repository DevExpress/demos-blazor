using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders;

public interface IIconMetadataProvider {
    public Task<DemoIconMetadataDocument> GetIconMetadata();
}
