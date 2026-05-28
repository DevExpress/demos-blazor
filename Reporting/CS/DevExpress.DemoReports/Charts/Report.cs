using System.Drawing;
using DevExpress.Drawing;
using DevExpress.XtraCharts;

namespace XtraReportsDemos.Charts {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            int currentYear = 2025;
            CurrentYear.Value = new System.DateTime(currentYear, 1, 1);

            Name = ReportNames.ChartName;
            DisplayName = ReportNames.Chart;
        }

        private void xrChart6_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            Color color = xrChart3.PaletteRepository["Palette 1"][DetailReport2.CurrentRowIndex].Color;
            xrChart6.PaletteRepository["Palette 1"][0].Color = color;

            xrChart6.Series[0].Points.BeginUpdate();
            xrChart6.Series[0].Points.Clear();
            long categorySalesValue = DetailReport2.GetCurrentColumnValue<long>("Sales");
            decimal totalSalesValue = DetailReport2.GetCurrentColumnValue<decimal>("Totals");
            decimal otherSalesValue = totalSalesValue - categorySalesValue;
            xrChart6.Series[0].Points.Add(new SeriesPoint("Category Sales", categorySalesValue));
            xrChart6.Series[0].Points.Add(new SeriesPoint("Other Sales", otherSalesValue));
            xrChart6.Series[0].Points.EndUpdate();

            decimal percentageOfSales = totalSalesValue == 0 ? 0 : categorySalesValue / totalSalesValue;
            ((DoughnutSeriesView)xrChart6.Series[0].View).TotalLabel.TextPattern = string.Format("{0:0%}", percentageOfSales);
            ((DoughnutSeriesView)xrChart6.Series[0].View).TotalLabel.TextColor = color;
        }

        private void xrChart_CustomDrawLegendMarker(object sender, CustomDrawSeriesEventArgsBase e) {
            DXBitmap markerImage = new DXBitmap(e.LegendMarkerSize.Width, e.LegendMarkerSize.Height);
            using(DXGraphics gr = DXGraphics.FromImage(markerImage)) {
                gr.Clear(e.LegendDrawOptions.Color);
            }
            e.DXLegendMarkerImage = markerImage;
        }
    }
}
