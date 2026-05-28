namespace XtraReportsDemos.VehicleInspectionReport {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.VehicleInspectionReportName;
            DisplayName = ReportNames.VehicleInspectionReport;
        }
        void Report_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            string language = parameterLanguage.Value as string;
            ApplyLocalization(language);
        }
    }
}
