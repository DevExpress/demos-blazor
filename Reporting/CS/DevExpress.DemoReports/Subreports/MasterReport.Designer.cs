using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.Subreports {
    partial class MasterReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterReport));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.subreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.dateRangeParameter_Start = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.dateRangeParameter_End = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.dsCust1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.DetailText = new DevExpress.XtraReports.UI.XRControlStyle();
            this.HeaderText = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dateRangeParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDate,
            this.lbTitle});
            this.ReportHeader.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.ReportHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.ReportHeader.HeightF = 80.04163F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.StylePriority.UseFont = false;
            this.ReportHeader.StylePriority.UseForeColor = false;
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDate
            // 
            this.lbDate.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(77)))), ((int)(((byte)(107)))));
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 43.00001F);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(650F, 16F);
            this.lbDate.Text = "Order Date: [?dateRangeParameter_Start!d] to [?dateRangeParameter_End!d]";
            this.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lbTitle
            // 
            this.lbTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbTitle.BorderWidth = 2F;
            this.lbTitle.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 15F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(650F, 28F);
            this.lbTitle.StylePriority.UseBorderColor = false;
            this.lbTitle.StylePriority.UseFont = false;
            this.lbTitle.Text = "Customer List (with Order information)";
            this.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1,
            this.subreport1});
            this.Detail.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.Detail.HeightF = 107.0419F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3,
            this.xrTable1,
            this.xrTable2});
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(650F, 46F);
            this.panel1.StylePriority.UseBackColor = false;
            // 
            // xrTable3
            // 
            this.xrTable3.Font = new DevExpress.Drawing.DXFont("Tahoma", 14.25F);
            this.xrTable3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(431.1094F, 1.999996F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable3.SizeF = new System.Drawing.SizeF(173.8905F, 40F);
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseForeColor = false;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.4D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StyleName = "DetailText";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Occupation";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell5.Weight = 1.9500944627357002D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 0.39999999999999997D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Occupation]")});
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StyleName = "DetailText";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "tableCell2";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell6.Weight = 1.9500944627357002D;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Tahoma", 14.25F);
            this.xrTable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(227.875F, 1.999973F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(173.8905F, 40F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseForeColor = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.4D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StyleName = "DetailText";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Company";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell2.Weight = 1.9500944627357002D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.40000000000000008D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Company]")});
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StyleName = "DetailText";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "tableCell2";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell3.Weight = 1.9500944627357002D;
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Tahoma", 14.25F);
            this.xrTable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(23F, 1.999996F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow4});
            this.xrTable2.SizeF = new System.Drawing.SizeF(173.8905F, 40F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.4D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StyleName = "DetailText";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Customer";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell1.Weight = 1.9500944627357002D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.39999999999999997D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PersonName]")});
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StyleName = "DetailText";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "tableCell2";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell4.Weight = 1.9500944627357002D;
            // 
            // subreport1
            // 
            this.subreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46F);
            this.subreport1.Name = "subreport1";
            this.subreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("customerIDParameter", null, "Customers.ID"));
            this.subreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("dateRangeParameter_Start", this.dateRangeParameter_Start));
            this.subreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("dateRangeParameter_End", this.dateRangeParameter_End));
            this.subreport1.ReportSource = new XtraReportsDemos.Subreports.DetailReport();
            this.subreport1.SizeF = new System.Drawing.SizeF(650F, 52F);
            // 
            // dateRangeParameter_Start
            // 
            this.dateRangeParameter_Start.Name = "dateRangeParameter_Start";
            this.dateRangeParameter_Start.ValueInfo = "2016-11-20";
            // 
            // dateRangeParameter_End
            // 
            this.dateRangeParameter_End.Name = "dateRangeParameter_End";
            this.dateRangeParameter_End.ValueInfo = "2016-12-20";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1});
            this.BottomMargin.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageInfo1
            // 
            this.pageInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(268.5F, 26F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo1.SizeF = new System.Drawing.SizeF(113F, 23F);
            this.pageInfo1.StyleName = "DetailText";
            this.pageInfo1.StylePriority.UseBackColor = false;
            this.pageInfo1.StylePriority.UseTextAlignment = false;
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pageInfo1.TextFormatString = "Page {0} of {1} Pages";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.topMarginBand1.HeightF = 65.58334F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(217.875F, 15.58335F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(212F, 50F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox4.UseImageResolution = false;
            // 
            // dsCust1
            // 
            this.dsCust1.ConnectionName = "HomesConnectionString";
            this.dsCust1.Name = "dsCust1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "Customers";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Company";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Occupation";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "PersonName";
            customExpression1.Expression = "Concat([Customers].[FirstName], \' \', [Customers].[LastName])";
            column4.Expression = customExpression1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "Customers";
            selectQuery1.Tables.Add(table1);
            this.dsCust1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsCust1.ResultSchemaSerializable = resources.GetString("dsCust1.ResultSchemaSerializable");
            // 
            // DetailText
            // 
            this.DetailText.BackColor = System.Drawing.Color.Transparent;
            this.DetailText.BorderColor = System.Drawing.Color.Black;
            this.DetailText.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailText.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.DetailText.Name = "DetailText";
            this.DetailText.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.DetailText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // HeaderText
            // 
            this.HeaderText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.HeaderText.BorderColor = System.Drawing.Color.Black;
            this.HeaderText.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.HeaderText.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HeaderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.HeaderText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // dateRangeParameter
            // 
            this.dateRangeParameter.Description = "Date Range";
            this.dateRangeParameter.Name = "dateRangeParameter";
            this.dateRangeParameter.Type = typeof(System.DateTime);
            this.dateRangeParameter.ValueSourceSettings = new DevExpress.XtraReports.Parameters.RangeParametersSettings(this.dateRangeParameter_Start, this.dateRangeParameter_End);
            // 
            // MasterReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsCust1});
            this.DataMember = "Customers";
            this.DataSource = this.dsCust1;
            this.DisplayName = "Subreport-Based Report";
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 65.58334F, 75F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.dateRangeParameter});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.DetailText,
            this.HeaderText});
            this.Version = "25.1";
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.MasterReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        public DetailReport detailReport1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.XRSubreport subreport1;
        private DevExpress.XtraReports.Parameters.RangeStartParameter dateRangeParameter_Start;
        private DevExpress.XtraReports.Parameters.RangeEndParameter dateRangeParameter_End;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.DataAccess.Sql.SqlDataSource dsCust1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailText;
        private DevExpress.XtraReports.UI.XRControlStyle HeaderText;
        private DevExpress.XtraReports.Parameters.Parameter dateRangeParameter;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
    }
}
