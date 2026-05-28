using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.ReportMerging {
    public class MergedReport : NorthwindTraders.CatalogReport {
        private GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowChartTitle;
        private XRSubreport chartSubreport;

        public MergedReport() {
            InitializeComponent();
            Name = ReportNames.ReportMergingName;
            DisplayName = ReportNames.ReportMerging;
        }
        private void InitializeComponent() {
            GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            chartSubreport = new DevExpress.XtraReports.UI.XRSubreport();
            parameterShowChartTitle = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // GroupFooter1
            // 
            GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            chartSubreport});
            GroupFooter1.HeightF = 23F;
            GroupFooter1.Name = "GroupFooter1";
            // 
            // chartSubreport
            // 
            chartSubreport.GenerateOwnPages = true;
            chartSubreport.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            chartSubreport.Name = "chartSubreport";
            chartSubreport.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ShowTitle", parameterShowChartTitle));
            chartSubreport.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LowCategory", null, "Products.CategoryID"));
            chartSubreport.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HighCategory", null, "Products.CategoryID"));
            chartSubreport.ReportSource = new XtraReportsDemos.ReportMerging.ChartReport();
            chartSubreport.SizeF = new System.Drawing.SizeF(649F, 23F);
            // 
            // parameterShowChartTitle
            // 
            parameterShowChartTitle.Description = "Show Chart Title";
            parameterShowChartTitle.Name = "parameterShowChartTitle";
            parameterShowChartTitle.Type = typeof(bool);
            parameterShowChartTitle.ValueInfo = "False";
            parameterShowChartTitle.Visible = false;
            // 
            // MergedReport
            // 
            Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            GroupFooter1});
            Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            parameterShowChartTitle});
            ReportPrintOptions.DetailCountAtDesignTime = 6;
            Version = "19.1";
            Controls.SetChildIndex(GroupFooter1, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
