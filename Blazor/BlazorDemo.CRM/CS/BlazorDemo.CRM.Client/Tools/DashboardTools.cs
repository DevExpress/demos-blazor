using System.ComponentModel;
using BlazorDemo.CRM.Client.Services;
using BlazorDemo.CRM.Models;
using BlazorDemo.CRM.Services.DataProviders;
using DevExpress.AIIntegration;

namespace BlazorDemo.CRM.Client.Tools;

public class DashboardTools {
    [AIIntegrationTool]
    [Description("Retrieves historical sales data within a date range. Use this to analyze trends over time.")]
    public Task<List<Sale>?> GetSales([AIIntegrationToolTarget] AnalyticDataProvider dataProvider, DateOnly start, DateOnly end, CancellationToken ct = default) {
        return AnalyticsDashboardDataHelper.GetSales(new(dataProvider, start, end, ct));
    }

    [AIIntegrationTool]
    [Description("Provides revenue totals grouped by product category for comparative performance analysis.")]
    public Task<List<SaleByCategory>?> GetSalesByCategory([AIIntegrationToolTarget] AnalyticDataProvider dataProvider, DateOnly start, DateOnly end, CancellationToken ct = default) {
        return AnalyticsDashboardDataHelper.GetSalesByCategory(new(dataProvider, start, end, ct));
    }

    [AIIntegrationTool]
    [Description("Calculates the total aggregated revenue for the specified period.")]
    public Task<string> GetRevenueTotal([AIIntegrationToolTarget] AnalyticDataProvider dataProvider, DateOnly start, DateOnly end, CancellationToken ct = default) {
        return AnalyticsDashboardDataHelper.GetRevenueTotal(new(dataProvider, start, end, ct));
    }


    [AIIntegrationTool]
    [Description("Calculates the total projected revenue from potential deals (opportunities) for the specified period.\"")]
    public Task<string> GetOpportunitiesTotal([AIIntegrationToolTarget] AnalyticDataProvider dataProvider, DateOnly start, DateOnly end, CancellationToken ct = default) {
        return AnalyticsDashboardDataHelper.GetOpportunitiesTotal(new(dataProvider, start, end, ct));
    }

    [AIIntegrationTool]
    [Description("Retrieves sales performance metrics grouped by a geographic region or state.")]
    public Task<IEnumerable<SaleByLocation>?> GetSalesByLocation([AIIntegrationToolTarget] AnalyticDataProvider dataProvider, DateOnly start, DateOnly end, CancellationToken ct = default) {
        return AnalyticsDashboardDataHelper.GetSalesByLocation(new(dataProvider, start, end, ct));
    }

    [AIIntegrationTool]
    [Description("Adds visual annotations onto the chart.")]
    public void AddChartAnnotations([AIIntegrationToolTarget] ChartAnnotationsProvider annotationsProvider, List<Annotation> newAnnotations) {
        annotationsProvider.ChartAnnotations.AddRange(newAnnotations);
        annotationsProvider.Notify();
    }
}
