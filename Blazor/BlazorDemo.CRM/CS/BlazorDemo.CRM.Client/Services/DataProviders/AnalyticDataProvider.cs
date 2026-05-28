using BlazorDemo.CRM.Models;

namespace BlazorDemo.CRM.Services.DataProviders {
    public class AnalyticDataProvider : DataProvider {
        public AnalyticDataProvider(HttpClient httpClient)
            : base(httpClient) {
        }

        protected override string GetBasePath() => "Analytics";

        public Task<List<OpportunityByCategory>?> GetOpportunitiesByCategoryAsync(DateOnly start, DateOnly end, CancellationToken cancellationToken = default) =>
            LoadDataAsync<List<OpportunityByCategory>>(["OpportunitiesByCategory", start.ToString("o"), end.ToString("o")], cancellationToken);

        public Task<List<SaleByCategory>?> GetSalesByCategoryAsync(DateOnly start, DateOnly end, CancellationToken cancellationToken = default) =>
            LoadDataAsync<List<SaleByCategory>>(["SalesByCategory", start.ToString("o"), end.ToString("o")], cancellationToken);

        public Task<List<Sale>?> GetSalesByOrderDateAsync(string orderDate, CancellationToken cancellationToken = default) =>
            LoadDataAsync<List<Sale>>(["SalesByOrderDate", orderDate], cancellationToken);

        public Task<List<Sale>?> GetSalesAsync(DateOnly start, DateOnly end, CancellationToken cancellationToken = default) =>
            LoadDataAsync<List<Sale>>(["Sales", start.ToString("o"), end.ToString("o")], cancellationToken);

        public Task<List<SaleByLocation>?> GetSalesByLocationAsync(DateOnly start, DateOnly end, CancellationToken cancellationToken = default) =>
            LoadDataAsync<List<SaleByLocation>>(["SalesByStateAndCity", start.ToString("o"), end.ToString("o")], cancellationToken);
    }
}
