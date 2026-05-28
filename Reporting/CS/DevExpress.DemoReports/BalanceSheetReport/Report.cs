using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.BalanceSheetReport {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.BalanceSheetReportName;
            DisplayName = ReportNames.BalanceSheetReport;
        }
    }
}
