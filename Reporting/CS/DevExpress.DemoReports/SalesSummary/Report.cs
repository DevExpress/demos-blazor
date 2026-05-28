namespace XtraReportsDemos.SalesSummary {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.SalesSummaryName;
            DisplayName = ReportNames.SalesSummary;
        }
    }
}
