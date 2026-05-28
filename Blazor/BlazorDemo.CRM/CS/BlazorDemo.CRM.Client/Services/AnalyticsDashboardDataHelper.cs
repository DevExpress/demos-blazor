using System.Globalization;
using BlazorDemo.CRM.Models;
using BlazorDemo.CRM.Services.DataProviders;

namespace BlazorDemo.CRM.Client.Services;

public class AnalyticsDashboardFunctionModel(AnalyticDataProvider dataProvider, DateOnly start, DateOnly end, CancellationToken token = default) {
    public AnalyticDataProvider DataProvider { get; set; } = dataProvider;
    public DateOnly Start { get; set; } = start;
    public DateOnly End { get; set; } = end;
    public CancellationToken Token { get; set; } = token;
}

public static class AnalyticsDashboardDataHelper {
    public const string Conversion = "16%";
    public const string LeadsCount = "51";

    public static Task<List<Sale>?> GetSales(AnalyticsDashboardFunctionModel model) {
        return model.DataProvider.GetSalesAsync(model.Start, model.End, model.Token);
    }

    public static Task<List<SaleByCategory>?> GetSalesByCategory(AnalyticsDashboardFunctionModel model) {
        return model.DataProvider.GetSalesByCategoryAsync(model.Start, model.End, model.Token);
    }

    public static async Task<string> GetRevenueTotal(AnalyticsDashboardFunctionModel model) {
        var salesByCategory = await model.DataProvider.GetSalesByCategoryAsync(model.Start, model.End, model.Token);
        return TotalAsCurrency(salesByCategory);
    }


    public static async Task<string> GetOpportunitiesTotal(AnalyticsDashboardFunctionModel model) {
        var opportunitiesByCategory = await model.DataProvider.GetOpportunitiesByCategoryAsync(model.Start, model.End, model.Token);
        return TotalAsCurrency(opportunitiesByCategory);
    }

    public static async Task<IEnumerable<SaleByLocation>?> GetSalesByLocation(AnalyticsDashboardFunctionModel model) {
        return (await model.DataProvider
            .GetSalesByLocationAsync(model.Start, model.End, model.Token))?
            .GroupBy(i => i.StateName!)
            .Select(g => new SaleByLocation {
                StateName = g.Key,
                Total = g.Sum(i => i.Total),
                Percentage = g.Sum(i => i.Percentage)
            });
    }

    public static string TotalAsCurrency<T>(IEnumerable<T>? items) where T : IValueProvider {
        var total = items?.Aggregate(0.0, (v, s) => s.Value.HasValue ? (s.Value.Value + v) : v) ?? 0.0;
        return total.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
