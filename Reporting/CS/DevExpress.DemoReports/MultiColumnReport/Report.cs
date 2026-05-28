using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.MultiColumnReport {
    /// <summary>
    /// Summary description for Report.
    /// </summary>
    public partial class Report : XtraReport {
        static Report() {
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(typeof(Band), "PageBreak", new DevExpress.XtraReports.Expressions.ExpressionBindingDescription(new[] { "BeforePrint" }, 1000, Array.Empty<string>()));
        }

        public Report() {
            InitializeComponent();
            Name = ReportNames.MultiColumnName;
            DisplayName = ReportNames.MultiColumn;
        }

        void Report_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            XtraReport report = sender as XtraReport;
            DetailBand detailBand = report.Bands[BandKind.Detail] as DetailBand;

            detailBand.MultiColumn.Layout = (bool)columnLayoutParameter.Value
                ? ColumnLayout.AcrossThenDown
                : ColumnLayout.DownThenAcross;
        }
    }
}
