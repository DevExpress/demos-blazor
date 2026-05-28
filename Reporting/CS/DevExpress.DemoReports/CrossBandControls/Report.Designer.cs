using System;
using System.Collections.Generic;
using System.Text;
using XtraReportsDemos.CrossBandControls;

namespace XtraReportsDemos.CrossBandControls {
    public partial class Report {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel lbCategory;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.UI.XRLabel lbUnitPrice;
        private DevExpress.XtraReports.UI.XRLabel lbQuantity;
        private DevExpress.XtraReports.UI.XRLabel lbProduct;
        public DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox1;
        private DevExpress.XtraReports.UI.XRCrossBandLine xrCrossBandLine1;
        private DevExpress.XtraReports.UI.XRLabel lbItemsCount;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.XRCrossBandLine xrCrossBandLine2;
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
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
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lbUnitPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.lbQuantity = new DevExpress.XtraReports.UI.XRLabel();
            this.lbProduct = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbItemsCount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandLine1 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrCrossBandLine2 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.DrawZBelowTheTableParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsOddEvenStyles1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbUnitPrice,
            this.lbQuantity,
            this.lbProduct});
            this.Detail.HeightF = 27.00001F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbUnitPrice.EvenStyleName = "EvenStyle";
            this.lbUnitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")});
            this.lbUnitPrice.LocationFloat = new DevExpress.Utils.PointFloat(528.0416F, 0F);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.OddStyleName = "OddStyle";
            this.lbUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.lbUnitPrice.SizeF = new System.Drawing.SizeF(101.9167F, 27.00001F);
            this.lbUnitPrice.Text = "lbUnitPrice";
            this.lbUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lbUnitPrice.TextFormatString = "{0:$0.00}";
            // 
            // lbQuantity
            // 
            this.lbQuantity.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbQuantity.EvenStyleName = "EvenStyle";
            this.lbQuantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "QuantityPerUnit")});
            this.lbQuantity.LocationFloat = new DevExpress.Utils.PointFloat(231F, 0F);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.OddStyleName = "OddStyle";
            this.lbQuantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.lbQuantity.SizeF = new System.Drawing.SizeF(296F, 27F);
            this.lbQuantity.Text = "lbQuantity";
            this.lbQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbProduct
            // 
            this.lbProduct.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbProduct.EvenStyleName = "EvenStyle";
            this.lbProduct.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")});
            this.lbProduct.LocationFloat = new DevExpress.Utils.PointFloat(20.04166F, 0F);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.OddStyleName = "OddStyle";
            this.lbProduct.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.lbProduct.SizeF = new System.Drawing.SizeF(209.9583F, 27.00001F);
            this.lbProduct.Text = "lbProduct";
            this.lbProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCategory
            // 
            this.lbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(237)))));
            this.lbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.lbCategory.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCategory.BorderWidth = 1F;
            this.lbCategory.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CategoryName")});
            this.lbCategory.Font = new DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbCategory.LocationFloat = new DevExpress.Utils.PointFloat(20.04166F, 7.041677F);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategory.SizeF = new System.Drawing.SizeF(609.9165F, 32.95833F);
            this.lbCategory.Text = "lbCategory";
            this.lbCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbCategory});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 40.00001F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.ReportHeader.HeightF = 67F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Tahoma", 21.75F);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(19F, 2F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(612F, 64F);
            this.xrLabel2.Text = "Product List by Category";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 77F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(249F, 27F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xrPictureBox4.UseImageResolution = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(534F, 7F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(98F, 17F);
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrPageInfo1.TextFormatString = "Page : {0 } / {1}";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel1,
            this.lbItemsCount});
            this.GroupFooter1.HeightF = 47F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.GroupFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(528.0416F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(101.9168F, 45.89999F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(231F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(296F, 45.89999F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            // 
            // lbItemsCount
            // 
            this.lbItemsCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.lbItemsCount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lbItemsCount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount(ProductName)")});
            this.lbItemsCount.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbItemsCount.LocationFloat = new DevExpress.Utils.PointFloat(20.04166F, 0F);
            this.lbItemsCount.Name = "lbItemsCount";
            this.lbItemsCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.lbItemsCount.SizeF = new System.Drawing.SizeF(209.9583F, 45.95833F);
            this.lbItemsCount.StylePriority.UseBorderColor = false;
            this.lbItemsCount.StylePriority.UseBorders = false;
            this.lbItemsCount.StylePriority.UseFont = false;
            this.lbItemsCount.StylePriority.UsePadding = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.lbItemsCount.Summary = xrSummary1;
            this.lbItemsCount.Text = "lbItemsCount";
            this.lbItemsCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbItemsCount.TextFormatString = "Items count: {0}";
            this.lbItemsCount.XlsxFormatString = "\"Items count: \"0";
            // 
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.xrCrossBandBox1.BorderWidth = 1F;
            this.xrCrossBandBox1.EndBand = this.GroupFooter1;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(19F, 47F);
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.GroupHeader1;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(19F, 6F);
            this.xrCrossBandBox1.WidthF = 612F;
            // 
            // xrCrossBandLine1
            // 
            this.xrCrossBandLine1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandLine1.EndBand = this.GroupFooter1;
            this.xrCrossBandLine1.EndPointFloat = new DevExpress.Utils.PointFloat(527F, 45.9F);
            this.xrCrossBandLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.xrCrossBandLine1.Name = "xrCrossBandLine1";
            this.xrCrossBandLine1.StartBand = this.Detail;
            this.xrCrossBandLine1.StartPointFloat = new DevExpress.Utils.PointFloat(527F, 0F);
            this.xrCrossBandLine1.WidthF = 1F;
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.Transparent;
            this.EvenStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.EvenStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.EvenStyle.BorderWidth = 1F;
            this.EvenStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.EvenStyle.ForeColor = System.Drawing.Color.Black;
            this.EvenStyle.Name = "EvenStyle";
            // 
            // OddStyle
            // 
            this.OddStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.OddStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.OddStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.OddStyle.BorderWidth = 1F;
            this.OddStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.OddStyle.ForeColor = System.Drawing.Color.Black;
            this.OddStyle.Name = "OddStyle";
            // 
            // xrCrossBandLine2
            // 
            this.xrCrossBandLine2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandLine2.EndBand = this.GroupFooter1;
            this.xrCrossBandLine2.EndPointFloat = new DevExpress.Utils.PointFloat(230F, 45.9F);
            this.xrCrossBandLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.xrCrossBandLine2.Name = "xrCrossBandLine2";
            this.xrCrossBandLine2.StartBand = this.Detail;
            this.xrCrossBandLine2.StartPointFloat = new DevExpress.Utils.PointFloat(230F, 0F);
            this.xrCrossBandLine2.WidthF = 1F;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // DrawZBelowTheTableParameter
            // 
            this.DrawZBelowTheTableParameter.Description = "Draw Z below the table";
            this.DrawZBelowTheTableParameter.Name = "DrawZBelowTheTableParameter";
            this.DrawZBelowTheTableParameter.Type = typeof(bool);
            this.DrawZBelowTheTableParameter.ValueInfo = "False";
            // 
            // dsOddEvenStyles1
            // 
            this.dsOddEvenStyles1.ConnectionName = "NWindConnectionString";
            this.dsOddEvenStyles1.Name = "dsOddEvenStyles1";
            columnExpression1.ColumnName = "ProductName";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "CategoryID";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "QuantityPerUnit";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "CategoryName";
            table2.Name = "Categories";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "CategoryID";
            relationColumnInfo1.ParentKeyColumn = "CategoryID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.dsOddEvenStyles1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsOddEvenStyles1.ResultSchemaSerializable = resources.GetString("dsOddEvenStyles1.ResultSchemaSerializable");
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.BottomMargin,
            this.GroupFooter1,
            this.topMarginBand1});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox1,
            this.xrCrossBandLine1,
            this.xrCrossBandLine2});
            this.DataMember = "Products";
            this.DataSource = this.dsOddEvenStyles1;
            this.Margins = new DevExpress.Drawing.DXMargins(100, 100, 100, 77);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DrawZBelowTheTableParameter});
            this.ReportPrintOptions.DetailCountAtDesignTime = 15;
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EvenStyle,
            this.OddStyle});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter DrawZBelowTheTableParameter;
        private DevExpress.DataAccess.Sql.SqlDataSource dsOddEvenStyles1;
        private System.ComponentModel.IContainer components;
    }
}
