namespace XtraReportsDemos.MailMerge {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.MailMergeName;
            DisplayName = ReportNames.MailMerge;
        }
    }
}
