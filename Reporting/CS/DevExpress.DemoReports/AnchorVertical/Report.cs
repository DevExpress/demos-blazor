using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.AnchorVertical {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.AnchorName;
            DisplayName = ReportNames.Anchor;
        }
    }
    public class ReportWeb : Report {
        private DevExpress.XtraReports.Parameters.Parameter LandscapeParameter;
        public ReportWeb() {
            InitializeComponent();
        }
        private void InitializeComponent() {
            LandscapeParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // LandscapeParameter
            // 
            LandscapeParameter.Description = "Landscape";
            LandscapeParameter.Name = "LandscapeParameter";
            LandscapeParameter.Type = typeof(bool);
            LandscapeParameter.ValueInfo = "False";
            // 
            // Report
            // 
            Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            LandscapeParameter});
            ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Landscape", "[Parameters.LandscapeParameter]")});
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
    }
}
