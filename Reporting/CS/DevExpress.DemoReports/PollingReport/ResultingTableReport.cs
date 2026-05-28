using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.PollingReport {
    public class ResultingTableReport : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private System.ComponentModel.IContainer components;
        private BottomMarginBand bottomMarginBand1;
        private XRTable dtlTable1;
        private XRTableRow detailTableRow;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell3;
        private XRTable ghTable1;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.Parameter paramQuestionID;
        private XRControlStyle questionStyle;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell8;
        private XRControlStyle headerStyle;
        private XRControlStyle detailStyleEven;
        private XRTableCell xrTableCell12;
        internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource ResultingTableReportDS;
        private GroupHeaderBand GroupHeader1;
        private XRLabel xrLabel1;
        private XRControlStyle detailStyleOdd;
        private XRTableCell xrTableCell5;
        private XRShape xrShape1;
        private readonly System.Drawing.Color emptyAnswerTextColor;

        internal List<Color> Colors { get; set; }

        public ResultingTableReport() {
            InitializeComponent();
            emptyAnswerTextColor = detailTableRow.ForeColor;
        }

        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            dtlTable1 = new DevExpress.XtraReports.UI.XRTable();
            detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ghTable1 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            paramQuestionID = new DevExpress.XtraReports.Parameters.Parameter();
            questionStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            headerStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            detailStyleEven = new DevExpress.XtraReports.UI.XRControlStyle();
            detailStyleOdd = new DevExpress.XtraReports.UI.XRControlStyle();
            GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            ResultingTableReportDS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(components);
            ((System.ComponentModel.ISupportInitialize)(dtlTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ghTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ResultingTableReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            topMarginBand1.HeightF = 100F;
            topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            dtlTable1});
            detailBand1.HeightF = 30F;
            detailBand1.Name = "detailBand1";
            detailBand1.StylePriority.UseFont = false;
            // 
            // dtlTable1
            // 
            dtlTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            dtlTable1.Name = "dtlTable1";
            dtlTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            detailTableRow});
            dtlTable1.SizeF = new System.Drawing.SizeF(325F, 30F);
            dtlTable1.StylePriority.UseTextAlignment = false;
            dtlTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // detailTableRow
            // 
            detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell5,
            xrTableCell1,
            xrTableCell2,
            xrTableCell3});
            detailTableRow.EvenStyleName = "detailStyleEven";
            detailTableRow.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            detailTableRow.Name = "detailTableRow";
            detailTableRow.OddStyleName = "detailStyleOdd";
            detailTableRow.StylePriority.UseForeColor = false;
            detailTableRow.Weight = 1D;
            detailTableRow.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(detailTableRow_BeforePrint);
            // 
            // xrTableCell5
            // 
            xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrShape1});
            xrTableCell5.Name = "xrTableCell5";
            xrTableCell5.StylePriority.UsePadding = false;
            xrTableCell5.StylePriority.UseTextAlignment = false;
            xrTableCell5.Weight = 0.26494085357768737D;
            // 
            // xrShape1
            // 
            xrShape1.ForeColor = System.Drawing.Color.Transparent;
            xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(5F, 2.5F);
            xrShape1.Name = "xrShape1";
            xrShape1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrShape1.Shape = shapeRectangle1;
            xrShape1.SizeF = new System.Drawing.SizeF(24.99998F, 25F);
            xrShape1.StylePriority.UseForeColor = false;
            xrShape1.StylePriority.UsePadding = false;
            // 
            // xrTableCell1
            // 
            xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Answer")});
            xrTableCell1.Multiline = true;
            xrTableCell1.Name = "xrTableCell1";
            xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            xrTableCell1.StylePriority.UsePadding = false;
            xrTableCell1.StylePriority.UseTextAlignment = false;
            xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell1.Weight = 1.5749258970746736D;
            // 
            // xrTableCell2
            // 
            xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "AnswerCount")});
            xrTableCell2.Name = "xrTableCell2";
            xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableCell2.StylePriority.UsePadding = false;
            xrTableCell2.StylePriority.UseTextAlignment = false;
            xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell2.Weight = 0.45996698152369797D;
            // 
            // xrTableCell3
            // 
            xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumPercentage(AnswerCount)")});
            xrTableCell3.Name = "xrTableCell3";
            xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableCell3.StylePriority.UsePadding = false;
            xrTableCell3.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            xrTableCell3.Summary = xrSummary1;
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell3.Weight = 0.5703587583536065D;
            xrTableCell3.TextFormatString = "{0:0.0%}";
            // 
            // bottomMarginBand1
            // 
            bottomMarginBand1.HeightF = 100F;
            bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ghTable1
            // 
            ghTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            ghTable1.Name = "ghTable1";
            ghTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow2,
            xrTableRow4});
            ghTable1.SizeF = new System.Drawing.SizeF(325F, 63.54F);
            // 
            // xrTableRow2
            // 
            xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell4});
            xrTableRow2.Name = "xrTableRow2";
            xrTableRow2.StylePriority.UseTextAlignment = false;
            xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            xrTableRow2.Weight = 1.7039473665263247D;
            // 
            // xrTableCell4
            // 
            xrTableCell4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrLabel1});
            xrTableCell4.Name = "xrTableCell4";
            xrTableCell4.StylePriority.UsePadding = false;
            xrTableCell4.Weight = 3.8269230769230766D;
            // 
            // xrLabel1
            // 
            xrLabel1.AnchorHorizontal = (DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right);
            xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Question")});
            xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrLabel1.Name = "xrLabel1";
            xrLabel1.SizeF = new System.Drawing.SizeF(325F, 25F);
            xrLabel1.StyleName = "questionStyle";
            xrLabel1.StylePriority.UsePadding = false;
            // 
            // xrTableRow4
            // 
            xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell12,
            xrTableCell8,
            xrTableCell6});
            xrTableRow4.Name = "xrTableRow4";
            xrTableRow4.StyleName = "headerStyle";
            xrTableRow4.StylePriority.UseTextAlignment = false;
            xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRow4.Weight = 1.1052630062961615D;
            // 
            // xrTableCell12
            // 
            xrTableCell12.Name = "xrTableCell12";
            xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            xrTableCell12.StylePriority.UsePadding = false;
            xrTableCell12.StylePriority.UseTextAlignment = false;
            xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell12.Weight = 2.2579717305482263D;
            // 
            // xrTableCell8
            // 
            xrTableCell8.Name = "xrTableCell8";
            xrTableCell8.StylePriority.UseBorderColor = false;
            xrTableCell8.StylePriority.UseBorders = false;
            xrTableCell8.StylePriority.UseBorderWidth = false;
            xrTableCell8.StylePriority.UsePadding = false;
            xrTableCell8.StylePriority.UseTextAlignment = false;
            xrTableCell8.Text = "Voted";
            xrTableCell8.Weight = 0.56449296046847441D;
            // 
            // xrTableCell6
            // 
            xrTableCell6.Name = "xrTableCell6";
            xrTableCell6.Text = "Percent";
            xrTableCell6.Weight = 0.69997138007444848D;
            // 
            // paramQuestionID
            // 
            paramQuestionID.Description = "Question ID";
            paramQuestionID.Name = "paramQuestionID";
            paramQuestionID.Type = typeof(int);
            paramQuestionID.ValueInfo = "0";
            paramQuestionID.Visible = false;
            // 
            // questionStyle
            // 
            questionStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            questionStyle.ForeColor = System.Drawing.Color.FromArgb(112, 112, 112);
            questionStyle.Name = "questionStyle";
            questionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // headerStyle
            // 
            headerStyle.BackColor = System.Drawing.Color.FromArgb(141, 141, 141);
            headerStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Name = "headerStyle";
            headerStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // detailStyleEven
            // 
            detailStyleEven.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            detailStyleEven.Name = "detailStyleEven";
            // 
            // detailStyleOdd
            // 
            detailStyleOdd.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            detailStyleOdd.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            detailStyleOdd.Name = "detailStyleOdd";
            // 
            // GroupHeader1
            // 
            GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            ghTable1});
            GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            GroupHeader1.HeightF = 63.54168F;
            GroupHeader1.Name = "GroupHeader1";
            // 
            // ResultingTableReportDS
            // 
            ResultingTableReportDS.DataMember = "";
            ResultingTableReportDS.DataSource = typeof(XtraReportsDemos.PollingReport.ResultingData);
            ResultingTableReportDS.Name = "ResultingTableReportDS";
            // 
            // ResultingTableReport
            // 
            Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            topMarginBand1,
            detailBand1,
            bottomMarginBand1,
            GroupHeader1});
            ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            ResultingTableReportDS});
            DataSource = ResultingTableReportDS;
            FilterString = "[QuestionID] = ?paramQuestionID";
            Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            paramQuestionID});
            SnappingMode = (DevExpress.XtraReports.UI.SnappingMode.SnapLines | DevExpress.XtraReports.UI.SnappingMode.SnapToGrid);
            StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            questionStyle,
            headerStyle,
            detailStyleEven,
            detailStyleOdd});
            Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(dtlTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ghTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ResultingTableReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void detailTableRow_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            int voted = Report.GetCurrentColumnValue<int>("AnswerCount");
            if(Colors == null || Colors.Count == 0) {
                detailTableRow.ForeColor = voted > 0 ? Color.Black : emptyAnswerTextColor;
                xrShape1.FillColor = System.Drawing.Color.Transparent;
            }
            else if(voted > 0) {
                int colorIndex = Report.CurrentRowIndex % Colors.Count;
                detailTableRow.ForeColor = xrShape1.FillColor = Colors[colorIndex];
            }
            else {
                detailTableRow.ForeColor = emptyAnswerTextColor;
                xrShape1.FillColor = System.Drawing.Color.Transparent;
            }
        }
    }
}
