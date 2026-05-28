namespace XtraReportsDemos.ProfitAndLossReport {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.ProfitAndLossName;
            DisplayName = ReportNames.ProfitAndLoss;
        }
    }
}
