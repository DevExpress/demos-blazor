using System.Net.Http.Json;

namespace BlazorDemo.CRM.Services.DataProviders {
    public abstract class DataProvider {
        readonly HttpClient _httpClient;

        private protected DataProvider(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        protected abstract string GetBasePath();

        protected Task<T?> LoadDataAsync<T>(string[]? pathItems = null, CancellationToken cancellationToken = default) {
            var resultPath = GetBasePath();
            if(pathItems != null) {
                foreach(var pathItem in pathItems)
                    resultPath += $"/{pathItem.ToString()}";
            }
            return _httpClient!.GetFromJsonAsync<T>(resultPath, cancellationToken);
        }
    }
}
