namespace XtraReportsDemos.Subreports {
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        public MasterReport() {
            InitializeComponent();
            Name = ReportNames.SubreportsName;
            DisplayName = ReportNames.Subreports;
        }
        void Detail_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            if(subreport1.ReportSource != null) {
                subreport1.ApplyParameterBindings();
                subreport1.ReportSource.ApplyFiltering();
                e.Cancel = subreport1.ReportSource.RowCount == 0;
            }
        }
        void MasterReport_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            if(subreport1.ReportSource != null)
                subreport1.ReportSource.FillDataSource();
        }
    }
}
