using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorDemo.Wasm.Server.DataProviders;

public interface IDataSourcesFileContentProvider {
    public Task<string> GetFileSystemDataItemsContentAsync();
    public Task<string> GetIconMetadataContentAsync();
}

public class DataSourcesFileContentProvider : IDataSourcesFileContentProvider {
    string fileSystemDataItemsContent;
    string iconMetadataContent;

    public async Task<string> GetFileSystemDataItemsContentAsync() {
        if(fileSystemDataItemsContent == null) {
            string pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "FileSystemDataItems.json");
            fileSystemDataItemsContent = await File.ReadAllTextAsync(pathToDataFile);
        }
        return fileSystemDataItemsContent;
    }

    public async Task<string> GetIconMetadataContentAsync() {
        if(iconMetadataContent == null) {
            string pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "IconMetadata.json");
            iconMetadataContent = await File.ReadAllTextAsync(pathToDataFile);
        }
        return iconMetadataContent;
    }
}
