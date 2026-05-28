namespace XtraReportsDemos.NorthwindTraders {
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport {
        public InvoiceReport() {
            InitializeComponent();
            Name = ReportNames.NorthwindTraders_InvoiceName;
            DisplayName = ReportNames.NorthwindTraders_Invoice;
        }
    }
}
