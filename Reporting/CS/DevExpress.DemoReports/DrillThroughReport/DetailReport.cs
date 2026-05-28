namespace XtraReportsDemos.DrillThroughReport {
    public partial class DetailReport : DevExpress.XtraReports.UI.XtraReport {
        public DetailReport() {
            InitializeComponent();
            Name = ReportNames.DrillThroughDetailName;
            DisplayName = ReportNames.DrillThroughDetail;
        }
    }
}
