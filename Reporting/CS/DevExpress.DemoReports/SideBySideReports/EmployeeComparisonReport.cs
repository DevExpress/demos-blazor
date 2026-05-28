using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.SideBySideReports {
    public partial class EmployeeComparisonReport : DevExpress.XtraReports.UI.XtraReport {
        public EmployeeComparisonReport() {
            InitializeComponent();
            Name = ReportNames.SideBySideReportsName;
            DisplayName = ReportNames.SideBySideReports;
        }
        protected override void OnDisposing() {
            DisposeReportSource(xrSubreport1);
            DisposeReportSource(xrSubreport2);
            base.OnDisposing();
        }
        void DisposeReportSource(XRSubreport subreport) {
            XtraReport report = subreport.ReportSource;
            if(report != null && !report.IsDisposed)
                report.Dispose();
        }
    }
}
