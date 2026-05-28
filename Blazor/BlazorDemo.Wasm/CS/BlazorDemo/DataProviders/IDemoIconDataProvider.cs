using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders;

public interface IDemoIconDataProvider {
    public DemoIcon[] GetIcons();
    public Task<Dictionary<string, DemoIconMetadata>> GetIconMetadata();
}
