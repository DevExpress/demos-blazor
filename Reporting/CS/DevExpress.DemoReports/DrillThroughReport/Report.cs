namespace XtraReportsDemos.DrillThroughReport {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.DrillThroughName;
            DisplayName = ReportNames.DrillThrough;
        }
    }
}
