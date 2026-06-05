using System.Globalization;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.Sparkline {
    public class Report : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand Detail;
        private BottomMarginBand bottomMarginBand1;
        private GroupHeaderBand GroupHeader;
        private CalculatedField calcSum;
        private CalculatedField calcAverage;
        private GroupFooterBand GroupFooter;
        private XRTable tableDetail;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell4;
        private XRSparkline sparkline;
        private XRTable tableGroupFooter;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private PageHeaderBand PageHeader;
        private XRTable tablePageHeader;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell5;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTable tableGroupHeader;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell14;
        private XRTableCell xrTableCell15;
        internal XRPictureBox xrPictureBox1;
        private XRPageInfo xrPageInfo1;
        private XRTableCell xrTableCell16;
        private XRControlStyle oddStyle;
        private DevExpress.DataAccess.Sql.SqlDataSource dsContacts1;
        private System.ComponentModel.IContainer components;
        private XRControlStyle evenStyle;

        public Report() {
            InitializeComponent();
            Name = ReportNames.SparklineName;
            DisplayName = ReportNames.Sparkline;
        }

        void xrSparkline1_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            sparkline.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).Select(x => GetCurrentColumnValue(x)).ToArray();
        }

        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            Detail = new DevExpress.XtraReports.UI.DetailBand();
            sparkline = new DevExpress.XtraReports.UI.XRSparkline();
            tableDetail = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            tableGroupHeader = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            calcSum = new DevExpress.XtraReports.UI.CalculatedField();
            calcAverage = new DevExpress.XtraReports.UI.CalculatedField();
            GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            tableGroupFooter = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            tablePageHeader = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            oddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            evenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            dsContacts1 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            ((System.ComponentModel.ISupportInitialize)(tableDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tableGroupHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tableGroupFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tablePageHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            topMarginBand1.Name = "topMarginBand1";
            topMarginBand1.StylePriority.UseFont = false;
            // 
            // Detail
            // 
            Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            sparkline,
            tableDetail});
            Detail.EvenStyleName = "evenStyle";
            Detail.HeightF = 43F;
            Detail.Name = "Detail";
            Detail.OddStyleName = "oddStyle";
            // 
            // sparkline
            // 
            sparkline.Borders = (DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right);
            sparkline.LocationFloat = new DevExpress.Utils.PointFloat(435F, 0F);
            sparkline.Name = "sparkline";
            sparkline.SizeF = new System.Drawing.SizeF(215F, 43F);
            sparkline.StylePriority.UseBorders = false;
            lineSparklineView1.Color = System.Drawing.Color.FromArgb(116, 197, 195);
            lineSparklineView1.HighlightMaxPoint = true;
            lineSparklineView1.HighlightMinPoint = true;
            lineSparklineView1.MaxPointColor = System.Drawing.Color.FromArgb(150, 3, 94);
            lineSparklineView1.MaxPointMarkerSize = 6;
            lineSparklineView1.MinPointColor = System.Drawing.Color.FromArgb(17, 116, 167);
            lineSparklineView1.MinPointMarkerSize = 6;
            lineSparklineView1.ScaleFactor = 1F;
            sparkline.View = lineSparklineView1;
            sparkline.XlsxFormatString = null;
            sparkline.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(xrSparkline1_BeforePrint);
            // 
            // tableDetail
            // 
            tableDetail.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            tableDetail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            tableDetail.Name = "tableDetail";
            tableDetail.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            tableDetail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow1});
            tableDetail.SizeF = new System.Drawing.SizeF(435F, 43F);
            tableDetail.StylePriority.UseBorders = false;
            tableDetail.StylePriority.UsePadding = false;
            tableDetail.StylePriority.UseTextAlignment = false;
            tableDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow1
            // 
            xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell1,
            xrTableCell2,
            xrTableCell3,
            xrTableCell4});
            xrTableRow1.Name = "xrTableRow1";
            xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ID")});
            xrTableCell1.Name = "xrTableCell1";
            xrTableCell1.Text = "xrTableCell1";
            xrTableCell1.Weight = 0.280021918927671D;
            // 
            // xrTableCell2
            // 
            xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer Name]")});
            xrTableCell2.Name = "xrTableCell2";
            xrTableCell2.StylePriority.UseTextAlignment = false;
            xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell2.Weight = 1.4401123702185D;
            // 
            // xrTableCell3
            // 
            xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "calcSum")});
            xrTableCell3.Name = "xrTableCell3";
            xrTableCell3.TextFormatString = "{0:c}";
            xrTableCell3.Weight = 0.880068677022519D;
            // 
            // xrTableCell4
            // 
            xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "calcAverage")});
            xrTableCell4.Name = "xrTableCell4";
            xrTableCell4.StylePriority.UseTextAlignment = false;
            xrTableCell4.TextFormatString = "{0:c}";
            xrTableCell4.Weight = 0.880068815054061D;
            // 
            // bottomMarginBand1
            // 
            bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrPageInfo1,
            xrPictureBox1});
            bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrPageInfo1
            // 
            xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(570.75F, 10.00001F);
            xrPageInfo1.Name = "xrPageInfo1";
            xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrPageInfo1.SizeF = new System.Drawing.SizeF(79.25F, 21.16667F);
            xrPageInfo1.StylePriority.UseFont = false;
            xrPageInfo1.TextFormatString = "Page : {0} / {1}";
            // 
            // xrPictureBox1
            // 
            xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"));
            xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(249F, 30F);
            xrPictureBox1.Name = "xrPictureBox1";
            xrPictureBox1.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/";
            xrPictureBox1.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            xrPictureBox1.UseImageResolution = false;
            // 
            // GroupHeader
            // 
            GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            tableGroupHeader});
            GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Year", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            GroupHeader.HeightF = 36F;
            GroupHeader.Name = "GroupHeader";
            // 
            // tableGroupHeader
            // 
            tableGroupHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            tableGroupHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            tableGroupHeader.Name = "tableGroupHeader";
            tableGroupHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            tableGroupHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow4});
            tableGroupHeader.SizeF = new System.Drawing.SizeF(650F, 36F);
            tableGroupHeader.StylePriority.UseTextAlignment = false;
            tableGroupHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow4
            // 
            xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell14,
            xrTableCell15});
            xrTableRow4.Name = "xrTableRow4";
            xrTableRow4.Weight = 1D;
            // 
            // xrTableCell14
            // 
            xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Year")});
            xrTableCell14.Name = "xrTableCell14";
            xrTableCell14.StylePriority.UseTextAlignment = false;
            xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell14.TextFormatString = "Year: {0}";
            xrTableCell14.Weight = 1.40576914860652D;
            // 
            // xrTableCell15
            // 
            xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([Customer Name])")});
            xrTableCell15.Name = "xrTableCell15";
            xrTableCell15.StylePriority.UseBorders = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            xrTableCell15.Summary = xrSummary1;
            xrTableCell15.TextFormatString = "(count={0})";
            xrTableCell15.Weight = 1.59423085139348D;
            // 
            // calcSum
            // 
            calcSum.DataMember = "CustomersPayment";
            calcSum.DisplayName = "Sum";
            calcSum.Expression = "[April] + [August] + [December] + [February] + [January] + [July] + [June] + [Mar" +
    "ch] + [May] + [November] + [October] + [September]";
            calcSum.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            calcSum.Name = "calcSum";
            // 
            // calcAverage
            // 
            calcAverage.DataMember = "CustomersPayment";
            calcAverage.DisplayName = "Average";
            calcAverage.Expression = "[calcSum] / 12.0";
            calcAverage.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            calcAverage.Name = "calcAverage";
            // 
            // GroupFooter
            // 
            GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            tableGroupFooter});
            GroupFooter.HeightF = 30F;
            GroupFooter.Name = "GroupFooter";
            // 
            // tableGroupFooter
            // 
            tableGroupFooter.Borders = ((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            tableGroupFooter.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            tableGroupFooter.Name = "tableGroupFooter";
            tableGroupFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            tableGroupFooter.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow3});
            tableGroupFooter.SizeF = new System.Drawing.SizeF(650F, 30F);
            tableGroupFooter.StylePriority.UseBorders = false;
            tableGroupFooter.StylePriority.UsePadding = false;
            tableGroupFooter.StylePriority.UseTextAlignment = false;
            tableGroupFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow3
            // 
            xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell10,
            xrTableCell16,
            xrTableCell11,
            xrTableCell12,
            xrTableCell13});
            xrTableRow3.Name = "xrTableRow3";
            xrTableRow3.Weight = 1D;
            // 
            // xrTableCell10
            // 
            xrTableCell10.Name = "xrTableCell10";
            xrTableCell10.Weight = 0.203225842748793D;
            // 
            // xrTableCell16
            // 
            xrTableCell16.Name = "xrTableCell16";
            xrTableCell16.Weight = 1.04516120486701D;
            // 
            // xrTableCell11
            // 
            xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(calcSum)")});
            xrTableCell11.Name = "xrTableCell11";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            xrTableCell11.Summary = xrSummary2;
            xrTableCell11.TextFormatString = "{0:c}";
            xrTableCell11.Weight = 0.638709829467386D;
            // 
            // xrTableCell12
            // 
            xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg(calcAverage)")});
            xrTableCell12.Name = "xrTableCell12";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            xrTableCell12.Summary = xrSummary3;
            xrTableCell12.TextFormatString = "{0:c}";
            xrTableCell12.Weight = 0.638709652268553D;
            // 
            // xrTableCell13
            // 
            xrTableCell13.Borders = (((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTableCell13.Name = "xrTableCell13";
            xrTableCell13.StylePriority.UseBorders = false;
            xrTableCell13.Weight = 1.24838687041697D;
            // 
            // PageHeader
            // 
            PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            tablePageHeader});
            PageHeader.HeightF = 26F;
            PageHeader.Name = "PageHeader";
            PageHeader.StylePriority.UseFont = false;
            // 
            // tablePageHeader
            // 
            tablePageHeader.BackColor = System.Drawing.Color.FromArgb(143, 143, 143);
            tablePageHeader.BorderColor = System.Drawing.Color.FromArgb(122, 122, 122);
            tablePageHeader.Borders = (((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            tablePageHeader.ForeColor = System.Drawing.Color.White;
            tablePageHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            tablePageHeader.Name = "tablePageHeader";
            tablePageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 3, 0, 0, 100F);
            tablePageHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow2});
            tablePageHeader.SizeF = new System.Drawing.SizeF(650F, 26F);
            tablePageHeader.StylePriority.UseBackColor = false;
            tablePageHeader.StylePriority.UseBorderColor = false;
            tablePageHeader.StylePriority.UseBorders = false;
            tablePageHeader.StylePriority.UseForeColor = false;
            tablePageHeader.StylePriority.UsePadding = false;
            tablePageHeader.StylePriority.UseTextAlignment = false;
            tablePageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell5,
            xrTableCell6,
            xrTableCell7,
            xrTableCell8,
            xrTableCell9});
            xrTableRow2.Name = "xrTableRow2";
            xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            xrTableCell5.Name = "xrTableCell5";
            xrTableCell5.Text = "ID";
            xrTableCell5.Weight = 0.161538455669696D;
            // 
            // xrTableCell6
            // 
            xrTableCell6.Name = "xrTableCell6";
            xrTableCell6.StylePriority.UseBackColor = false;
            xrTableCell6.Text = "Customer Name";
            xrTableCell6.Weight = 0.830769260113056D;
            // 
            // xrTableCell7
            // 
            xrTableCell7.Name = "xrTableCell7";
            xrTableCell7.Text = "Sum";
            xrTableCell7.Weight = 0.507692295954778D;
            // 
            // xrTableCell8
            // 
            xrTableCell8.Name = "xrTableCell8";
            xrTableCell8.Text = "Average";
            xrTableCell8.Weight = 0.507692319429838D;
            // 
            // xrTableCell9
            // 
            xrTableCell9.Name = "xrTableCell9";
            xrTableCell9.Text = "Payments";
            xrTableCell9.Weight = 0.992307668832632D;
            // 
            // oddStyle
            // 
            oddStyle.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
            oddStyle.Name = "oddStyle";
            oddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // evenStyle
            // 
            evenStyle.BackColor = System.Drawing.Color.FromArgb(247, 247, 247);
            evenStyle.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
            evenStyle.Name = "evenStyle";
            evenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // dsContacts1
            // 
            dsContacts1.ConnectionName = "ContactsConnectionString";
            dsContacts1.Name = "dsContacts1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "CustomersPayment";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Customer Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Year";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "January";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "February";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "March";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "April";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "May";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "June";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "July";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "August";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "September";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "October";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "November";
            columnExpression14.Table = table1;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "December";
            columnExpression15.Table = table1;
            column15.Expression = columnExpression15;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Columns.Add(column14);
            selectQuery1.Columns.Add(column15);
            selectQuery1.Name = "CustomersPayment";
            selectQuery1.Tables.Add(table1);
            dsContacts1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            dsContacts1.ResultSchemaSerializable = resources.GetString("dsContacts1.ResultSchemaSerializable");
            // 
            // Report
            // 
            Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            topMarginBand1,
            Detail,
            bottomMarginBand1,
            GroupHeader,
            GroupFooter,
            PageHeader});
            BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
            CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            calcSum,
            calcAverage});
            DataMember = "CustomersPayment";
            DataSource = dsContacts1;
            Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F);
            StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            oddStyle,
            evenStyle});
            Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(tableDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tableGroupHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tableGroupFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tablePageHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
