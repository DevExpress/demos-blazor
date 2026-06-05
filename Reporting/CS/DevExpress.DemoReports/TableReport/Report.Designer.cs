using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.DataAccess;

namespace XtraReportsDemos.TableReport {
    public partial class Report {
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
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lbOrderID = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.dsOrderDetails1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.HeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.OrderIdParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.Dpi = 96F;
            this.Detail.HeightF = 90F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2,
            this.pictureBox1});
            this.ReportFooter.Dpi = 96F;
            this.ReportFooter.HeightF = 77.95918F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.ReportFooter.PrintAtBottom = true;
            this.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.lbOrderID,
            this.xrPageInfo1,
            this.xrTable1});
            this.PageHeader.Dpi = 96F;
            this.PageHeader.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageHeader.HeightF = 115.4961F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 96F;
            this.BottomMargin.HeightF = 72F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Dpi = 96F;
            this.topMarginBand1.HeightF = 72F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // table3
            // 
            this.table3.Dpi = 96F;
            this.table3.EvenStyleName = "EvenStyle";
            this.table3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table3.Name = "table3";
            this.table3.OddStyleName = "OddStyle";
            this.table3.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 5, 0, 0, 96F);
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3,
            this.tableRow4});
            this.table3.SizeF = new System.Drawing.SizeF(672F, 90F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9});
            this.tableRow3.Dpi = 96F;
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 8.9444444444444446D;
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14});
            this.tableRow4.Dpi = 96F;
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 14.055555555555555D;
            // 
            // tableCell5
            // 
            this.tableCell5.Dpi = 96F;
            this.tableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.tableCell5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 2, 96F);
            this.tableCell5.StylePriority.UseFont = false;
            this.tableCell5.StylePriority.UsePadding = false;
            this.tableCell5.Text = "tableCell5";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell5.Weight = 1.6108408606389968D;
            // 
            // tableCell6
            // 
            this.tableCell6.Dpi = 96F;
            this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
            this.tableCell6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F);
            this.tableCell6.RowSpan = 2;
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.StylePriority.UsePadding = false;
            this.tableCell6.Text = "tableCell6";
            this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell6.TextFormatString = "{0:$#,##.00}";
            this.tableCell6.Weight = 0.40897809652856248D;
            // 
            // tableCell7
            // 
            this.tableCell7.Dpi = 96F;
            this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.tableCell7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F);
            this.tableCell7.RowSpan = 2;
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.StylePriority.UsePadding = false;
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "tableCell7";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell7.Weight = 0.40897809652856248D;
            // 
            // tableCell8
            // 
            this.tableCell8.Dpi = 96F;
            this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")});
            this.tableCell8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F);
            this.tableCell8.RowSpan = 2;
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.StylePriority.UsePadding = false;
            this.tableCell8.StylePriority.UseTextAlignment = false;
            this.tableCell8.Text = "tableCell8";
            this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell8.TextFormatString = "{0:0%}";
            this.tableCell8.Weight = 0.40897809652856248D;
            // 
            // tableCell9
            // 
            this.tableCell9.Dpi = 96F;
            this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubTotal]")});
            this.tableCell9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 15, 15, 0, 96F);
            this.tableCell9.RowSpan = 2;
            this.tableCell9.StylePriority.UseFont = false;
            this.tableCell9.StylePriority.UsePadding = false;
            this.tableCell9.StylePriority.UseTextAlignment = false;
            this.tableCell9.Text = "tableCell9";
            this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell9.TextFormatString = "{0:$#,##.00}";
            this.tableCell9.Weight = 0.40897809652856248D;
            // 
            // tableCell10
            // 
            this.tableCell10.CanGrow = false;
            this.tableCell10.Dpi = 96F;
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Supplier]")});
            this.tableCell10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.tableCell10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 10, 96F);
            this.tableCell10.StylePriority.UseFont = false;
            this.tableCell10.StylePriority.UseForeColor = false;
            this.tableCell10.StylePriority.UsePadding = false;
            this.tableCell10.Text = "tableCell10";
            this.tableCell10.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly;
            this.tableCell10.Weight = 1.610841087893689D;
            // 
            // tableCell11
            // 
            this.tableCell11.Dpi = 96F;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.tableCell11.StylePriority.UsePadding = false;
            this.tableCell11.Text = "tableCell11";
            this.tableCell11.Weight = 0.40897769883285096D;
            // 
            // tableCell12
            // 
            this.tableCell12.Dpi = 96F;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.Text = "tableCell12";
            this.tableCell12.Weight = 0.40897815334223553D;
            // 
            // tableCell13
            // 
            this.tableCell13.Dpi = 96F;
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.tableCell13.StylePriority.UsePadding = false;
            this.tableCell13.Text = "tableCell13";
            this.tableCell13.Weight = 0.40897843741060114D;
            // 
            // tableCell14
            // 
            this.tableCell14.Dpi = 96F;
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.tableCell14.StylePriority.UsePadding = false;
            this.tableCell14.Text = "tableCell14";
            this.tableCell14.Weight = 0.40897786927387009D;
            // 
            // table2
            // 
            this.table2.Dpi = 96F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(288F, 0F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 96F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5,
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(384F, 77.95918F);
            this.table2.StylePriority.UsePadding = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dpi = 96F;
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"));
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/";
            this.pictureBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.pictureBox1.SizeF = new System.Drawing.SizeF(149.9592F, 37.66764F);
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15});
            this.tableRow5.Dpi = 96F;
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 1D;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell4});
            this.tableRow2.Dpi = 96F;
            this.tableRow2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 18F);
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.StylePriority.UseFont = false;
            this.tableRow2.Weight = 1.5986393230031763D;
            // 
            // tableCell15
            // 
            this.tableCell15.Dpi = 96F;
            this.tableCell15.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 96F);
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.StylePriority.UseForeColor = false;
            this.tableCell15.StylePriority.UsePadding = false;
            this.tableCell15.StylePriority.UseTextAlignment = false;
            this.tableCell15.Text = "TOTAL ORDER COST";
            this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell15.Weight = 2D;
            // 
            // tableCell4
            // 
            this.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell4.Dpi = 96F;
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:$0.00 }\', sumSum([SubTotal]))")});
            this.tableCell4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 16F);
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 96F);
            this.tableCell4.StylePriority.UseBorders = false;
            this.tableCell4.StylePriority.UseFont = false;
            this.tableCell4.StylePriority.UsePadding = false;
            this.tableCell4.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tableCell4.Summary = xrSummary1;
            this.tableCell4.Text = "tableCell2";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell4.Weight = 2D;
            // 
            // pageInfo1
            // 
            this.pageInfo1.Dpi = 96F;
            this.pageInfo1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.pageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(576F, 62.26726F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.pageInfo1.SizeF = new System.Drawing.SizeF(95.99999F, 15.35999F);
            this.pageInfo1.StylePriority.UseFont = false;
            this.pageInfo1.StylePriority.UseForeColor = false;
            this.pageInfo1.TextFormatString = "Page {0} of {1} pages";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoWidth = true;
            this.lbOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lbOrderID.BorderWidth = 0F;
            this.lbOrderID.CanGrow = false;
            this.lbOrderID.Dpi = 96F;
            this.lbOrderID.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")});
            this.lbOrderID.Font = new DevExpress.Drawing.DXFont("Segoe UI", 18F);
            this.lbOrderID.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.lbOrderID.SizeF = new System.Drawing.SizeF(474.5528F, 31.68F);
            this.lbOrderID.StylePriority.UseBackColor = false;
            this.lbOrderID.StylePriority.UseBorderWidth = false;
            this.lbOrderID.StylePriority.UseFont = false;
            this.lbOrderID.StylePriority.UsePadding = false;
            this.lbOrderID.StylePriority.UseTextAlignment = false;
            this.lbOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbOrderID.TextFormatString = "Details for Customer Order # {0}";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 96F;
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 31.68001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(239.04F, 15.36F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            this.xrPageInfo1.StylePriority.UsePadding = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(177)))), ((int)(((byte)(183)))));
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.BorderWidth = 2F;
            this.xrTable1.Dpi = 96F;
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 85.49609F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(672F, 30F);
            this.xrTable1.StyleName = "HeaderStyle";
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UsePadding = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell2,
            this.xrTableCell13,
            this.xrTableCell3});
            this.xrTableRow1.Dpi = 96F;
            this.xrTableRow1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BorderWidth = 1F;
            this.xrTableCell1.Dpi = 96F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 96F);
            this.xrTableCell1.StyleName = "HeaderStyle";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "PRODUCT/SUPPLIER";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.3396643824140988D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BorderWidth = 1F;
            this.xrTableCell7.Dpi = 96F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F);
            this.xrTableCell7.StyleName = "HeaderStyle";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "UNIT PRICE";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.Weight = 0.086237750550321443D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BorderWidth = 1F;
            this.xrTableCell2.Dpi = 96F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F);
            this.xrTableCell2.StyleName = "HeaderStyle";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "QUANTITY";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 0.086237750550321443D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BorderWidth = 1F;
            this.xrTableCell13.Dpi = 96F;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F);
            this.xrTableCell13.StyleName = "HeaderStyle";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "DISCOUNT";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell13.Weight = 0.086237750550321443D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderWidth = 1F;
            this.xrTableCell3.Dpi = 96F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 15, 0, 0, 96F);
            this.xrTableCell3.StyleName = "HeaderStyle";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "SUBTOTAL";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.086237750550321443D;
            // 
            // dsOrderDetails1
            // 
            this.dsOrderDetails1.ConnectionName = "NWindConnectionString";
            this.dsOrderDetails1.Name = "dsOrderDetails1";
            columnExpression1.ColumnName = "OrderID";
            table1.Name = "OrderDetailsExtended";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductID";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ProductName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Quantity";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Discount";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Supplier";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            column8.Alias = "SubTotal";
            customExpression1.Expression = "ToDouble([OrderDetailsExtended].[Quantity] * [OrderDetailsExtended].[UnitPrice])";
            column8.Expression = customExpression1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.FilterString = "[OrderDetailsExtended.OrderID] = ?OrderIdParameter";
            selectQuery1.Name = "OrderDetails";
            queryParameter1.Name = "OrderIdParameter";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.OrderIdParameter]", typeof(int));
            selectQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending;
            columnExpression8.ColumnName = "ExtendedPrice";
            columnExpression8.Table = table1;
            sorting1.Expression = columnExpression8;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table1);
            this.dsOrderDetails1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsOrderDetails1.ResultSchemaSerializable = resources.GetString("dsOrderDetails1.ResultSchemaSerializable");
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.White;
            this.EvenStyle.BorderColor = System.Drawing.Color.Transparent;
            this.EvenStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.EvenStyle.BorderWidth = 1F;
            this.EvenStyle.Font = new DevExpress.Drawing.DXFont("Segoe UI", 12F);
            this.EvenStyle.ForeColor = System.Drawing.Color.Black;
            this.EvenStyle.Name = "EvenStyle";
            this.EvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 96F);
            // 
            // OddStyle
            // 
            this.OddStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.OddStyle.BorderColor = System.Drawing.Color.Transparent;
            this.OddStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OddStyle.BorderWidth = 1F;
            this.OddStyle.Font = new DevExpress.Drawing.DXFont("Segoe UI", 12F);
            this.OddStyle.ForeColor = System.Drawing.Color.Black;
            this.OddStyle.Name = "OddStyle";
            this.OddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 96F);
            // 
            // HeaderStyle
            // 
            this.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.HeaderStyle.BorderColor = System.Drawing.Color.Gray;
            this.HeaderStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.HeaderStyle.BorderWidth = 1F;
            this.HeaderStyle.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HeaderStyle.Name = "HeaderStyle";
            this.HeaderStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 96F);
            // 
            // OrderIdParameter
            // 
            this.OrderIdParameter.Description = "Order Id";
            this.OrderIdParameter.Name = "OrderIdParameter";
            this.OrderIdParameter.Type = typeof(int);
            this.OrderIdParameter.ValueInfo = "11077";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportFooter,
            this.PageHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsOrderDetails1});
            this.DataMember = "OrderDetails";
            this.DataSource = this.dsOrderDetails1;
            this.DisplayName = "Table Report";
            this.Dpi = 96F;
            this.Extensions.Add("DataSerializationExtension", "Table Report");
            this.Extensions.Add("DataEditorExtension", "Table Report");
            this.Extensions.Add("ParameterEditorExtension", "Table Report");
            this.Margins = new DevExpress.Drawing.DXMargins(72F, 72F, 72F, 72F);
            this.PageHeight = 1056;
            this.PageWidth = 816;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.OrderIdParameter});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            this.RequestParameters = false;
            this.SnapGridSize = 12F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EvenStyle,
            this.OddStyle,
            this.HeaderStyle});
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRLabel lbOrderID;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource dsOrderDetails1;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle HeaderStyle;
        private DevExpress.XtraReports.Parameters.Parameter OrderIdParameter;
    }
}
