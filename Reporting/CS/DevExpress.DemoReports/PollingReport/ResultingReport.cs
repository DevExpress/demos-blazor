using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.PollingReport {
    public class ResultingReport : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private System.ComponentModel.IContainer components;
        private BottomMarginBand bottomMarginBand1;
        public XRLabel PollingLink;
        private ReportFooterBand ReportFooter;
        private ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter paramPollCount;
        private XRChart xrChart1;
        private XRControlStyle ghStyle1;
        private XRControlStyle ghStyle2;
        private XRControlStyle detStyle1Odd;
        private XRTable xrTable1;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRControlStyle detStyle1Even;
        private XRLine xrLine2;
        private XRLine xrLine1;
        private XRSubreport xrSubreport1;
        private GroupHeaderBand GroupHeader1;
        public DevExpress.DataAccess.ObjectBinding.ObjectDataSource ResultingReportDS;

        public ResultingReport() {
            InitializeComponent();

            ResultingTableReport subreport = xrSubreport1.ReportSource as ResultingTableReport;
            if(subreport != null) {
                subreport.ResultingTableReportDS.DataSource = ResultingReportDS;
                subreport.Colors = GetColorList(xrChart1.PaletteRepository[xrChart1.PaletteName]);
            }
        }

        List<Color> GetColorList(Palette palette) {
            List<Color> list = new List<Color>();
            foreach(PaletteEntry item in palette)
                list.Add(item.Color);
            return list;
        }

        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            PollingLink = new DevExpress.XtraReports.UI.XRLabel();
            xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            paramPollCount = new DevExpress.XtraReports.Parameters.Parameter();
            ghStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            ghStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            detStyle1Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            detStyle1Even = new DevExpress.XtraReports.UI.XRControlStyle();
            GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            ResultingReportDS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(components);
            ((System.ComponentModel.ISupportInitialize)(xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ResultingReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            detailBand1.HeightF = 0F;
            detailBand1.Name = "detailBand1";
            detailBand1.StylePriority.UseFont = false;
            // 
            // xrChart1
            // 
            xrChart1.AnchorHorizontal = (DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right);
            xrChart1.AnchorVertical = (DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom);
            xrChart1.AppearanceNameSerializable = "Light";
            xrChart1.BorderColor = System.Drawing.Color.Black;
            xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            simpleDiagram1.EqualPieSize = true;
            simpleDiagram1.LayoutDirection = DevExpress.XtraCharts.LayoutDirection.Vertical;
            xrChart1.Diagram = simpleDiagram1;
            xrChart1.Legend.Name = "Default Legend";
            xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(350F, 37.5F);
            xrChart1.Name = "xrChart1";
            xrChart1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            xrChart1.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("parameterQuestionID", null, "QuestionID")});
            series1.ArgumentDataMember = "Answer";
            series1.FilterString = "[QuestionID] = ?parameterQuestionID";
            pieSeriesLabel1.TextPattern = "{A}";
            series1.Label = pieSeriesLabel1;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "AnswerCount";
            pieSeriesView1.MinAllowedSizePercentage = 75D;
            series1.View = pieSeriesView1;
            xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            xrChart1.SizeF = new System.Drawing.SizeF(300F, 187.5F);
            xrChart1.StylePriority.UsePadding = false;
            // 
            // bottomMarginBand1
            // 
            bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // PollingLink
            // 
            PollingLink.BackColor = System.Drawing.Color.FromArgb(255, 114, 45);
            PollingLink.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            PollingLink.ForeColor = System.Drawing.Color.White;
            PollingLink.LocationFloat = new DevExpress.Utils.PointFloat(25F, 25F);
            PollingLink.Name = "PollingLink";
            PollingLink.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            PollingLink.SizeF = new System.Drawing.SizeF(150F, 32.5F);
            PollingLink.StylePriority.UseBackColor = false;
            PollingLink.StylePriority.UseFont = false;
            PollingLink.StylePriority.UseForeColor = false;
            PollingLink.StylePriority.UseTextAlignment = false;
            PollingLink.Text = "Start a new poll";
            PollingLink.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            xrLine1.AnchorHorizontal = (DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right);
            xrLine1.ForeColor = System.Drawing.Color.FromArgb(226, 226, 226);
            xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            xrLine1.Name = "xrLine1";
            xrLine1.SizeF = new System.Drawing.SizeF(650F, 12.49997F);
            xrLine1.StylePriority.UseForeColor = false;
            // 
            // ReportFooter
            // 
            ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            PollingLink});
            ReportFooter.HeightF = 57.5F;
            ReportFooter.Name = "ReportFooter";
            // 
            // ReportHeader
            // 
            ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrLine2,
            xrTable1});
            ReportHeader.HeightF = 62.49999F;
            ReportHeader.Name = "ReportHeader";
            ReportHeader.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            xrLine2.AnchorHorizontal = (DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right);
            xrLine2.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112);
            xrLine2.LineWidth = 2F;
            xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrLine2.Name = "xrLine2";
            xrLine2.SizeF = new System.Drawing.SizeF(650F, 2.083333F);
            xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrTable1
            // 
            xrTable1.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            xrTable1.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112);
            xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 25F);
            xrTable1.Name = "xrTable1";
            xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow5});
            xrTable1.SizeF = new System.Drawing.SizeF(600F, 33F);
            xrTable1.StylePriority.UseFont = false;
            xrTable1.StylePriority.UseForeColor = false;
            xrTable1.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRow5
            // 
            xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell9,
            xrTableCell10});
            xrTableRow5.Name = "xrTableRow5";
            xrTableRow5.Weight = 0.65999999999999992D;
            // 
            // xrTableCell9
            // 
            xrTableCell9.Font = new DevExpress.Drawing.DXFont("Tahoma", 18F);
            xrTableCell9.ForeColor = System.Drawing.Color.FromArgb(255, 114, 45);
            xrTableCell9.Name = "xrTableCell9";
            xrTableCell9.StylePriority.UseFont = false;
            xrTableCell9.StylePriority.UseForeColor = false;
            xrTableCell9.StylePriority.UseTextAlignment = false;
            xrTableCell9.Text = "Polling results";
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell9.Weight = 1.4950000859781933D;
            // 
            // xrTableCell10
            // 
            xrTableCell10.Name = "xrTableCell10";
            xrTableCell10.StylePriority.UseTextAlignment = false;
            xrTableCell10.Text = "Number of people polled : [Parameters.paramPollCount]";
            xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell10.Weight = 1.26500004317221D;
            xrTableCell10.WordWrap = false;
            // 
            // paramPollCount
            // 
            paramPollCount.Description = "Poll Count";
            paramPollCount.Name = "paramPollCount";
            paramPollCount.Type = typeof(int);
            paramPollCount.ValueInfo = "0";
            paramPollCount.Visible = false;
            // 
            // ghStyle1
            // 
            ghStyle1.Font = new DevExpress.Drawing.DXFont("Tahoma", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            ghStyle1.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112);
            ghStyle1.Name = "ghStyle1";
            ghStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            ghStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ghStyle2
            // 
            ghStyle2.BackColor = System.Drawing.Color.FromArgb(141, 141, 141);
            ghStyle2.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            ghStyle2.ForeColor = System.Drawing.Color.White;
            ghStyle2.Name = "ghStyle2";
            ghStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // detStyle1Odd
            // 
            detStyle1Odd.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            detStyle1Odd.Name = "detStyle1Odd";
            // 
            // detStyle1Even
            // 
            detStyle1Even.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            detStyle1Even.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            detStyle1Even.Name = "detStyle1Even";
            // 
            // GroupHeader1
            // 
            GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrLine1,
            xrSubreport1,
            xrChart1});
            GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            GroupHeader1.HeightF = 225F;
            GroupHeader1.KeepTogether = true;
            GroupHeader1.Name = "GroupHeader1";
            // 
            // xrSubreport1
            // 
            xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 37.5F);
            xrSubreport1.Name = "xrSubreport1";
            xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("paramQuestionID", null, "QuestionID"));
            xrSubreport1.ReportSource = new XtraReportsDemos.PollingReport.ResultingTableReport();
            xrSubreport1.SizeF = new System.Drawing.SizeF(325F, 187.5F);
            // 
            // ResultingReportDS
            // 
            ResultingReportDS.DataSource = typeof(XtraReportsDemos.PollingReport.ResultingData);
            ResultingReportDS.Name = "ResultingReportDS";
            // 
            // ResultingReport
            // 
            Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            topMarginBand1,
            detailBand1,
            bottomMarginBand1,
            ReportFooter,
            ReportHeader,
            GroupHeader1});
            ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            ResultingReportDS});
            DataSource = ResultingReportDS;
            Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            paramPollCount});
            SnappingMode = (DevExpress.XtraReports.UI.SnappingMode.SnapLines | DevExpress.XtraReports.UI.SnappingMode.SnapToGrid);
            StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            ghStyle1,
            ghStyle2,
            detStyle1Odd,
            detStyle1Even});
            Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ResultingReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
