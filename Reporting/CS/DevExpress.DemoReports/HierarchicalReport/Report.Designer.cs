using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.HierarchicalReport {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrCrossBandLine1 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.xrCrossBandLine2 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 85F;
            this.TopMargin.Name = "TopMargin";
            // 
            // Detail
            // 
            this.Detail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.Detail.BorderWidth = 1F;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox1,
            this.label6,
            this.label5,
            this.label4,
            this.label3,
            this.label2,
            this.label1});
            this.Detail.DrillDownControl = this.xrCheckBox1;
            this.Detail.EvenStyleName = "EvenStyle";
            this.Detail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "[RegionID] == -1"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([DataSource.CurrentRowHierarchyLevel] == 0, Rgb(231,235,244), ?)")});
            this.Detail.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.Detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.Detail.HeightF = 32F;
            this.Detail.HierarchyPrintOptions.Indent = 30F;
            this.Detail.HierarchyPrintOptions.KeyFieldName = "ID";
            this.Detail.HierarchyPrintOptions.ParentFieldName = "RegionID";
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Region", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBackColor = false;
            this.Detail.StylePriority.UseBorderColor = false;
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.StylePriority.UseFont = false;
            this.Detail.StylePriority.UseForeColor = false;
            this.Detail.StylePriority.UsePadding = false;
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCheckBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[ReportItems].[Detail].[DrillDownExpanded]")});
            this.xrCheckBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox1.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Checked"));
            this.xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked"));
            this.xrCheckBox1.GlyphOptions.Style = DevExpress.XtraPrinting.GlyphStyle.Toggle;
            this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(1.001602F, 0F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.SizeF = new System.Drawing.SizeF(30.9984F, 32F);
            this.xrCheckBox1.StylePriority.UsePadding = false;
            this.xrCheckBox1.Text = "xrCheckBox1";
            // 
            // label6
            // 
            this.label6.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.label6.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.label6.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label6.CanGrow = false;
            this.label6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MarketShare]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "[RegionID] == -1"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([MarketShare] >= 0.85, Rgb(203,239,230),\niif([MarketShare] <= 0.25, Rgb(245,2" +
                    "20,225), ?))")});
            this.label6.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(735F, 0F);
            this.label6.Multiline = true;
            this.label6.Name = "label6";
            this.label6.SizeF = new System.Drawing.SizeF(165F, 31.99999F);
            this.label6.StylePriority.UseBackColor = false;
            this.label6.StylePriority.UseBorders = false;
            this.label6.StylePriority.UseFont = false;
            this.label6.StylePriority.UseForeColor = false;
            this.label6.StylePriority.UsePadding = false;
            this.label6.StylePriority.UseTextAlignment = false;
            this.label6.Text = "label6";
            this.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.label6.TextFormatString = "{0:0%}";
            // 
            // label5
            // 
            this.label5.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.label5.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.label5.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label5.CanGrow = false;
            this.label5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "iif(([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales] > 0, Rgb(66,163," +
                    "137),\niif(([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales]  < 0, Rgb" +
                    "(202,87,112), ?))")});
            this.label5.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(610F, 0F);
            this.label5.Multiline = true;
            this.label5.Name = "label5";
            this.label5.SizeF = new System.Drawing.SizeF(125F, 31.99999F);
            this.label5.StylePriority.UseBorders = false;
            this.label5.StylePriority.UseFont = false;
            this.label5.StylePriority.UseForeColor = false;
            this.label5.StylePriority.UsePadding = false;
            this.label5.StylePriority.UseTextAlignment = false;
            this.label5.Text = "label5";
            this.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.label5.TextFormatString = "{0:0.00%}";
            // 
            // label4
            // 
            this.label4.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.label4.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.label4.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label4.CanGrow = false;
            this.label4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "([MarchSales] - [MarchSalesPrev]) / [MarchSales]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "iif(([MarchSales] - [MarchSalesPrev]) / [MarchSales] > 0, Rgb(66,163,137),\niif(([" +
                    "MarchSales] - [MarchSalesPrev]) / [MarchSales]  < 0, Rgb(202,87,112), ?))")});
            this.label4.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(485F, 0F);
            this.label4.Multiline = true;
            this.label4.Name = "label4";
            this.label4.SizeF = new System.Drawing.SizeF(125F, 31.99999F);
            this.label4.StylePriority.UseBorders = false;
            this.label4.StylePriority.UseFont = false;
            this.label4.StylePriority.UseForeColor = false;
            this.label4.StylePriority.UsePadding = false;
            this.label4.StylePriority.UseTextAlignment = false;
            this.label4.Text = "label4";
            this.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.label4.TextFormatString = "{0:0.00%}";
            // 
            // label3
            // 
            this.label3.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.label3.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.label3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label3.CanGrow = false;
            this.label3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SeptemberSales]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([SeptemberSales] >= 28000, Rgb(203,239,230),\niif([SeptemberSales] <= 6000, Rg" +
                    "b(245,220,225), ?))")});
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(360F, 0F);
            this.label3.Multiline = true;
            this.label3.Name = "label3";
            this.label3.SizeF = new System.Drawing.SizeF(125F, 31.99999F);
            this.label3.StylePriority.UseBorders = false;
            this.label3.StylePriority.UsePadding = false;
            this.label3.StylePriority.UseTextAlignment = false;
            this.label3.Text = "label3";
            this.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.label3.TextFormatString = "{0:c2}";
            // 
            // label2
            // 
            this.label2.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.label2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.label2.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label2.CanGrow = false;
            this.label2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MarchSales]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif([MarchSales] >= 25000, Rgb(203,239,230),\niif([MarchSales] <= 6000, Rgb(245,22" +
                    "0,225), ?))")});
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(235F, 0F);
            this.label2.Multiline = true;
            this.label2.Name = "label2";
            this.label2.SizeF = new System.Drawing.SizeF(125F, 31.99999F);
            this.label2.StylePriority.UseBorders = false;
            this.label2.StylePriority.UsePadding = false;
            this.label2.StylePriority.UseTextAlignment = false;
            this.label2.Text = "label2";
            this.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.label2.TextFormatString = "{0:c2}";
            // 
            // label1
            // 
            this.label1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.label1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.label1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.label1.CanGrow = false;
            this.label1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Region]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Padding.Left", "iif([DataSource.CurrentRowHierarchyLevel] == 0, 0, ?)")});
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(32F, 0F);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(203F, 32F);
            this.label1.StylePriority.UseBorders = false;
            this.label1.StylePriority.UsePadding = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "label1";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 85F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label7});
            this.ReportHeader.HeightF = 95F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBackColor = false;
            this.ReportHeader.StylePriority.UseBorderColor = false;
            this.ReportHeader.StylePriority.UseBorderWidth = false;
            this.ReportHeader.StylePriority.UseFont = false;
            this.ReportHeader.StylePriority.UsePadding = false;
            // 
            // label7
            // 
            this.label7.Font = new DevExpress.Drawing.DXFont("Arial", 26F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label7.Multiline = true;
            this.label7.Name = "label7";
            this.label7.SizeF = new System.Drawing.SizeF(900F, 95F);
            this.label7.StylePriority.UseFont = false;
            this.label7.StylePriority.UseForeColor = false;
            this.label7.StylePriority.UsePadding = false;
            this.label7.StylePriority.UseTextAlignment = false;
            this.label7.Text = "Market Share Report";
            this.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader
            // 
            this.GroupHeader.BorderWidth = 1F;
            this.GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupHeader.HeightF = 66F;
            this.GroupHeader.Name = "GroupHeader";
            this.GroupHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F);
            this.GroupHeader.RepeatEveryPage = true;
            this.GroupHeader.StylePriority.UseBorderWidth = false;
            this.GroupHeader.StylePriority.UseFont = false;
            this.GroupHeader.StylePriority.UsePadding = false;
            // 
            // table1
            // 
            this.table1.BorderWidth = 1F;
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2,
            this.tableRow1,
            this.tableRow3});
            this.table1.SizeF = new System.Drawing.SizeF(899.9999F, 66F);
            this.table1.StylePriority.UseBorders = false;
            this.table1.StylePriority.UseBorderWidth = false;
            this.table1.StylePriority.UsePadding = false;
            this.table1.StylePriority.UseTextAlignment = false;
            this.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // tableRow2
            // 
            this.tableRow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.tableRow2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(147)))), ((int)(((byte)(157)))));
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell10,
            this.tableCell12});
            this.tableRow2.ForeColor = System.Drawing.Color.White;
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.StylePriority.UseBackColor = false;
            this.tableRow2.StylePriority.UseBorderColor = false;
            this.tableRow2.StylePriority.UseBorderWidth = false;
            this.tableRow2.StylePriority.UseForeColor = false;
            this.tableRow2.Weight = 6.4912228827233625D;
            // 
            // tableCell7
            // 
            this.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell7.Multiline = true;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StylePriority.UseBorders = false;
            this.tableCell7.Text = "Sales";
            this.tableCell7.Weight = 6.0560158592110644D;
            // 
            // tableCell10
            // 
            this.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StylePriority.UseBorders = false;
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.Text = "Change From Prior Year";
            this.tableCell10.Weight = 3.1216591210081677D;
            // 
            // tableCell12
            // 
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.Text = "Current Market Share";
            this.tableCell12.Weight = 2.0602940017162554D;
            // 
            // tableRow1
            // 
            this.tableRow1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tableRow1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6});
            this.tableRow1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(154)))), ((int)(((byte)(172)))));
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.StylePriority.UseBorderColor = false;
            this.tableRow1.StylePriority.UseBorders = false;
            this.tableRow1.StylePriority.UseBorderWidth = false;
            this.tableRow1.StylePriority.UseForeColor = false;
            this.tableRow1.Weight = 6.4912226244229609D;
            // 
            // tableCell1
            // 
            this.tableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.Text = "Region";
            this.tableCell1.Weight = 2.9343590482749389D;
            // 
            // tableCell2
            // 
            this.tableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell2.Multiline = true;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StylePriority.UseBorders = false;
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.Text = "March";
            this.tableCell2.Weight = 1.560829246522067D;
            // 
            // tableCell3
            // 
            this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell3.Multiline = true;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StylePriority.UseBorders = false;
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "September";
            this.tableCell3.Weight = 1.5608292471577983D;
            // 
            // tableCell4
            // 
            this.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StylePriority.UseBorders = false;
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.Text = "March";
            this.tableCell4.Weight = 1.5608292487471154D;
            // 
            // tableCell5
            // 
            this.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell5.Multiline = true;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StylePriority.UseBorders = false;
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "September";
            this.tableCell5.Weight = 1.5608292566851554D;
            // 
            // tableCell6
            // 
            this.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StylePriority.UseBorders = false;
            this.tableCell6.StylePriority.UseTextAlignment = false;
            this.tableCell6.Text = "Market Share";
            this.tableCell6.Weight = 2.0602929345484107D;
            // 
            // tableRow3
            // 
            this.tableRow3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.tableRow3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableRow3.BorderWidth = 2F;
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell8});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.StylePriority.UseBorderColor = false;
            this.tableRow3.StylePriority.UseBorders = false;
            this.tableRow3.StylePriority.UseBorderWidth = false;
            this.tableRow3.Weight = 0.40570144920414519D;
            // 
            // tableCell8
            // 
            this.tableCell8.Multiline = true;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Weight = 11.237968981935484D;
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.EvenStyle.Name = "EvenStyle";
            // 
            // GroupFooter
            // 
            this.GroupFooter.HeightF = 1.041667F;
            this.GroupFooter.Name = "GroupFooter";
            this.GroupFooter.RepeatEveryPage = true;
            // 
            // xrCrossBandLine1
            // 
            this.xrCrossBandLine1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrCrossBandLine1.EndBand = this.GroupFooter;
            this.xrCrossBandLine1.EndPointFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCrossBandLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.xrCrossBandLine1.Name = "xrCrossBandLine1";
            this.xrCrossBandLine1.StartBand = this.GroupHeader;
            this.xrCrossBandLine1.StartPointFloat = new DevExpress.Utils.PointFloat(0F, 66F);
            this.xrCrossBandLine1.WidthF = 1F;
            // 
            // xrCrossBandLine2
            // 
            this.xrCrossBandLine2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandLine2.EndBand = this.GroupFooter;
            this.xrCrossBandLine2.EndPointFloat = new DevExpress.Utils.PointFloat(0F, 1.041667F);
            this.xrCrossBandLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.xrCrossBandLine2.Name = "xrCrossBandLine2";
            this.xrCrossBandLine2.StartBand = this.GroupFooter;
            this.xrCrossBandLine2.StartPointFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCrossBandLine2.WidthF = 900F;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataMember = "GetData";
            this.objectDataSource1.DataSource = typeof(XtraReportsDemos.HierarchicalReport.DataSource);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader,
            this.GroupFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandLine2,
            this.xrCrossBandLine1});
            this.DataSource = this.objectDataSource1;
            this.DisplayName = "Hierarchical Report";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(100, 100, 85, 85);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EvenStyle});
            this.Version = "21.1";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox1;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter;
        private DevExpress.XtraReports.UI.XRCrossBandLine xrCrossBandLine1;
        private DevExpress.XtraReports.UI.XRCrossBandLine xrCrossBandLine2;
    }
}
