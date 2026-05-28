using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.FormattingRules {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.FormattingRulesName;
            DisplayName = ReportNames.FormattingRules;
        }

        void Report_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            UpdateFormattingRule();
        }

        void UpdateFormattingRule() {
            formattingRule1.Condition = (string)ConditionParameter.Value;
            formattingRule1.ApplyStyle(StyleSheet[(string)StyleParameter.Value]);
        }
    }
}
