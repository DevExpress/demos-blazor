namespace XtraReportsDemos.SwissQRCode {
    public partial class SwissQRBill : DevExpress.XtraReports.UI.XtraReport {
        public SwissQRBill() {
            InitializeComponent();
            Name = ReportNames.SwissQRBillName;
            DisplayName = ReportNames.SwissQRBill;
        }

        void SwissQRBill_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            string languageString = Language.Value as string;
            ApplyLocalization(languageString);
        }
    }
}
