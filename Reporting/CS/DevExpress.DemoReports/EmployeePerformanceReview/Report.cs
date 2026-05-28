namespace XtraReportsDemos.EmployeePerformanceReview {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.EmployeePerformanceReviewName;
            DisplayName = ReportNames.EmployeePerformanceReview;
        }
    }
}
