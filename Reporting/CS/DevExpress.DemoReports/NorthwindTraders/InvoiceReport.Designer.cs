using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.NorthwindTraders {
    partial class InvoiceReport {
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReport));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table10 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.line2 = new DevExpress.XtraReports.UI.XRLine();
            this.table7 = new DevExpress.XtraReports.UI.XRTable();
            this.barCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.table8 = new DevExpress.XtraReports.UI.XRTable();
            this.pictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.table9 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Foreground = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ForegroundDisabled = new DevExpress.XtraReports.UI.XRControlStyle();
            this.SimpleTextStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.NetPrice = new DevExpress.XtraReports.UI.CalculatedField();
            this.SumUnitPrice = new DevExpress.XtraReports.UI.CalculatedField();
            this.DiscountTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.AmountPaid = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.paramCompany = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.HeightF = 205.2083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 59.375F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1,
            this.GroupFooter1});
            this.DetailReport.DataMember = "Orders.OrdersOrderDetails";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            this.DetailReport.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1});
            this.PageHeader.HeightF = 207.2917F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseBackColor = false;
            // 
            // table3
            // 
            this.table3.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(65.625F, 23.36403F);
            this.table3.Name = "table3";
            this.table3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow13,
            this.tableRow8,
            this.tableRow9,
            this.tableRow10,
            this.tableRow11,
            this.tableRow12});
            this.table3.SizeF = new System.Drawing.SizeF(396.92F, 145.0015F);
            this.table3.StylePriority.UseFont = false;
            // 
            // tableRow13
            // 
            this.tableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell10,
            this.xrTableCell13});
            this.tableRow13.Name = "tableRow13";
            this.tableRow13.Weight = 1.97230270460737D;
            // 
            // tableRow8
            // 
            this.tableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15,
            this.tableCell16});
            this.tableRow8.Name = "tableRow8";
            this.tableRow8.Weight = 1D;
            // 
            // tableRow9
            // 
            this.tableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell17,
            this.tableCell18});
            this.tableRow9.Name = "tableRow9";
            this.tableRow9.Weight = 1D;
            // 
            // tableRow10
            // 
            this.tableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell19,
            this.tableCell20});
            this.tableRow10.Name = "tableRow10";
            this.tableRow10.Weight = 1D;
            // 
            // tableRow11
            // 
            this.tableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell21,
            this.tableCell22});
            this.tableRow11.Name = "tableRow11";
            this.tableRow11.Weight = 1D;
            // 
            // tableRow12
            // 
            this.tableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell23,
            this.tableCell24});
            this.tableRow12.Name = "tableRow12";
            this.tableRow12.Weight = 1D;
            // 
            // tableCell10
            // 
            this.tableCell10.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell10.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell10.StyleName = "SimpleTextStyle";
            this.tableCell10.StylePriority.UseFont = false;
            this.tableCell10.StylePriority.UsePadding = false;
            this.tableCell10.Text = "Bill to:";
            this.tableCell10.Weight = 0.60336829956185767D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.xrTableCell13.StyleName = "SimpleTextStyle";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.Weight = 1.0426587834128349D;
            // 
            // tableCell15
            // 
            this.tableCell15.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell15.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell15.Multiline = true;
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell15.StyleName = "ForegroundDisabled";
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.StylePriority.UsePadding = false;
            this.tableCell15.StylePriority.UseTextAlignment = false;
            this.tableCell15.Text = "Company:";
            this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell15.Weight = 0.60336805972201224D;
            // 
            // tableCell16
            // 
            this.tableCell16.CanGrow = false;
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")});
            this.tableCell16.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell16.Multiline = true;
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "SimpleTextStyle";
            this.tableCell16.StylePriority.UseFont = false;
            this.tableCell16.Weight = 1.0426590232526805D;
            // 
            // tableCell17
            // 
            this.tableCell17.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell17.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell17.Multiline = true;
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell17.StyleName = "ForegroundDisabled";
            this.tableCell17.StylePriority.UseFont = false;
            this.tableCell17.StylePriority.UsePadding = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            this.tableCell17.Text = "Contact Name:";
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell17.Weight = 0.60336805972201224D;
            // 
            // tableCell18
            // 
            this.tableCell18.CanGrow = false;
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")});
            this.tableCell18.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F);
            this.tableCell18.Multiline = true;
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.StyleName = "SimpleTextStyle";
            this.tableCell18.StylePriority.UseFont = false;
            this.tableCell18.Weight = 1.0426590232526805D;
            // 
            // tableCell19
            // 
            this.tableCell19.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell19.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell19.Multiline = true;
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell19.StyleName = "ForegroundDisabled";
            this.tableCell19.StylePriority.UseFont = false;
            this.tableCell19.StylePriority.UsePadding = false;
            this.tableCell19.StylePriority.UseTextAlignment = false;
            this.tableCell19.Text = "Address:";
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell19.Weight = 0.60336805972201224D;
            // 
            // tableCell20
            // 
            this.tableCell20.CanGrow = false;
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0}, {1}, {2}, {3}\', [Address], [City], [Country], [PostalCode])")});
            this.tableCell20.Multiline = true;
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.StyleName = "SimpleTextStyle";
            this.tableCell20.Weight = 1.0426590232526805D;
            // 
            // tableCell21
            // 
            this.tableCell21.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell21.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell21.Multiline = true;
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell21.StyleName = "ForegroundDisabled";
            this.tableCell21.StylePriority.UseFont = false;
            this.tableCell21.StylePriority.UsePadding = false;
            this.tableCell21.StylePriority.UseTextAlignment = false;
            this.tableCell21.Text = "Phone:\t";
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell21.Weight = 0.60336805972201224D;
            // 
            // tableCell22
            // 
            this.tableCell22.CanGrow = false;
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            this.tableCell22.Multiline = true;
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.StyleName = "SimpleTextStyle";
            this.tableCell22.Weight = 1.0426590232526805D;
            // 
            // tableCell23
            // 
            this.tableCell23.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell23.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell23.Multiline = true;
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell23.StyleName = "ForegroundDisabled";
            this.tableCell23.StylePriority.UseFont = false;
            this.tableCell23.StylePriority.UsePadding = false;
            this.tableCell23.StylePriority.UseTextAlignment = false;
            this.tableCell23.Text = "Mail:";
            this.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell23.Weight = 0.60336805972201224D;
            // 
            // tableCell24
            // 
            this.tableCell24.CanGrow = false;
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat(Lower(Replace([CompanyName],\' \',\'\')), \'@mail.com\')")});
            this.tableCell24.Multiline = true;
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "SimpleTextStyle";
            this.tableCell24.Weight = 1.0426590232526805D;
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail1.FillEmptySpace = true;
            this.Detail1.HeightF = 31.25F;
            this.Detail1.Name = "Detail1";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader1.HeightF = 32.29167F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.line2,
            this.table7,
            this.barCode2,
            this.table8,
            this.pictureBox3,
            this.table9});
            this.GroupFooter1.HeightF = 283.5869F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.PrintAtBottom = true;
            // 
            // xrTable1
            // 
            this.xrTable1.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.BorderWidth = 1F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(80.64301F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(689.3542F, 31.25F);
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseBorderWidth = false;
            this.xrTable1.StylePriority.UsePadding = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableRow1.StylePriority.UsePadding = false;
            this.xrTableRow1.Weight = 13.895833333333334D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber([ProductName])")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 5, 5, 100F);
            this.xrTableCell11.StyleName = "SimpleTextStyle";
            this.xrTableCell11.StylePriority.UsePadding = false;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell11.Summary = xrSummary1;
            this.xrTableCell11.TextFormatString = "{0:00}";
            this.xrTableCell11.Weight = 0.34866643084144D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 5, 5, 5, 100F);
            this.xrTableCell1.StyleName = "SimpleTextStyle";
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Weight = 1.3214647037089855D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanGrow = false;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 7, 5, 5, 100F);
            this.xrTableCell2.StyleName = "SimpleTextStyle";
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.TextFormatString = "{0:$0.00}";
            this.xrTableCell2.Weight = 0.467105020016339D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.CanGrow = false;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 8, 5, 5, 100F);
            this.xrTableCell3.StyleName = "SimpleTextStyle";
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.478822428844348D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField1]")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 7, 5, 5, 100F);
            this.xrTableCell4.StyleName = "SimpleTextStyle";
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.TextFormatString = "{0:$0.00}";
            this.xrTableCell4.Weight = 0.55713882978313467D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "NetPrice")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 5, 5, 100F);
            this.xrTableCell5.StyleName = "SimpleTextStyle";
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.TextFormatString = "{0:$0.00}";
            this.xrTableCell5.Weight = 0.5329990636687334D;
            // 
            // xrTable2
            // 
            this.xrTable2.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.xrTable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.BorderWidth = 2F;
            this.xrTable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(80.64301F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(689.3542F, 32.29167F);
            this.xrTable2.StyleName = "TableHeaderStyle";
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseBorderWidth = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            this.xrTable2.StylePriority.UsePadding = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderRow;
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 3, 5, 100F);
            this.xrTableRow2.StylePriority.UsePadding = false;
            this.xrTableRow2.Weight = 11.236641221374043D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 3, 5, 100F);
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "#";
            this.xrTableCell12.Weight = 0.34615376790364583D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 5, 3, 5, 100F);
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.Text = "Product Name";
            this.xrTableCell6.Weight = 1.3119414381547954D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Unit Price";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.Weight = 0.46373906965959022D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 8, 3, 5, 100F);
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Quantity";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell8.Weight = 0.47537141956127937D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 7, 3, 5, 100F);
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Discount";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell9.Weight = 0.55312370944484268D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 5, 100F);
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Total";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.Weight = 0.52915769651282552D;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.line2.BorderWidth = 1F;
            this.line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.line2.LineWidth = 2F;
            this.line2.LocationFloat = new DevExpress.Utils.PointFloat(80.64301F, 0F);
            this.line2.Name = "line2";
            this.line2.SizeF = new System.Drawing.SizeF(689.36F, 2.083334F);
            this.line2.StyleName = "SimpleTextStyle";
            this.line2.StylePriority.UseBorderColor = false;
            this.line2.StylePriority.UseBorderWidth = false;
            this.line2.StylePriority.UseForeColor = false;
            // 
            // table7
            // 
            this.table7.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.table7.LocationFloat = new DevExpress.Utils.PointFloat(557.9952F, 2.083333F);
            this.table7.Name = "table7";
            this.table7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow24,
            this.tableRow25,
            this.tableRow26});
            this.table7.SizeF = new System.Drawing.SizeF(212.002F, 94.14556F);
            // 
            // barCode2
            // 
            this.barCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.barCode2.AutoModule = true;
            this.barCode2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "OrderID")});
            this.barCode2.LocationFloat = new DevExpress.Utils.PointFloat(554.9952F, 113.5417F);
            this.barCode2.Name = "barCode2";
            this.barCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 12, 12, 100F);
            this.barCode2.ShowText = false;
            this.barCode2.SizeF = new System.Drawing.SizeF(215.002F, 61.99999F);
            this.barCode2.StyleName = "Foreground";
            this.barCode2.StylePriority.UsePadding = false;
            this.barCode2.Symbology = code128Generator1;
            this.barCode2.Text = "10634";
            // 
            // table8
            // 
            this.table8.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.table8.LocationFloat = new DevExpress.Utils.PointFloat(65.62503F, 29.16667F);
            this.table8.Name = "table8";
            this.table8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow27,
            this.tableRow28,
            this.tableRow29,
            this.tableRow30,
            this.tableRow31});
            this.table8.SizeF = new System.Drawing.SizeF(396.92F, 125.6415F);
            this.table8.StylePriority.UseFont = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox3.ImageSource"));
            this.pictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(532.9813F, 180.8091F);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.SizeF = new System.Drawing.SizeF(119.4445F, 102.7778F);
            // 
            // table9
            // 
            this.table9.LocationFloat = new DevExpress.Utils.PointFloat(652.4258F, 218.1934F);
            this.table9.Name = "table9";
            this.table9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow32,
            this.tableRow33});
            this.table9.SizeF = new System.Drawing.SizeF(117.5714F, 43.69209F);
            // 
            // tableRow24
            // 
            this.tableRow24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell37,
            this.tableCell39});
            this.tableRow24.Name = "tableRow24";
            this.tableRow24.StylePriority.UseBorders = false;
            this.tableRow24.StylePriority.UseBorderWidth = false;
            this.tableRow24.Weight = 0.31844500653974622D;
            // 
            // tableRow25
            // 
            this.tableRow25.BorderWidth = 2F;
            this.tableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell40,
            this.tableCell41});
            this.tableRow25.Name = "tableRow25";
            this.tableRow25.StylePriority.UseBorderWidth = false;
            this.tableRow25.Weight = 0.334263861744661D;
            // 
            // tableRow26
            // 
            this.tableRow26.BorderWidth = 2F;
            this.tableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell42,
            this.tableCell43});
            this.tableRow26.Name = "tableRow26";
            this.tableRow26.StylePriority.UseBorderWidth = false;
            this.tableRow26.Weight = 0.32430194900068893D;
            // 
            // tableCell37
            // 
            this.tableCell37.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.tableCell37.Multiline = true;
            this.tableCell37.Name = "tableCell37";
            this.tableCell37.StyleName = "Foreground";
            this.tableCell37.StylePriority.UseBorderColor = false;
            this.tableCell37.StylePriority.UseTextAlignment = false;
            this.tableCell37.Text = "Sub Total:";
            this.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell37.Weight = 1.5971166912340502D;
            // 
            // tableCell39
            // 
            this.tableCell39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.tableCell39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumUnitPrice]")});
            this.tableCell39.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.tableCell39.Multiline = true;
            this.tableCell39.Name = "tableCell39";
            this.tableCell39.StylePriority.UseBorderColor = false;
            this.tableCell39.StylePriority.UseFont = false;
            this.tableCell39.StylePriority.UseForeColor = false;
            this.tableCell39.StylePriority.UseTextAlignment = false;
            this.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell39.TextFormatString = "{0:$0.00}";
            this.tableCell39.Weight = 1.4028833087659496D;
            // 
            // tableCell40
            // 
            this.tableCell40.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(116)))));
            this.tableCell40.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell40.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell40.Multiline = true;
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.StyleName = "ForegroundDisabled";
            this.tableCell40.StylePriority.UseBorderColor = false;
            this.tableCell40.StylePriority.UseBorders = false;
            this.tableCell40.StylePriority.UseBorderWidth = false;
            this.tableCell40.StylePriority.UseFont = false;
            this.tableCell40.StylePriority.UseTextAlignment = false;
            this.tableCell40.Text = "Discount Total:";
            this.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell40.Weight = 1.5971166912340502D;
            // 
            // tableCell41
            // 
            this.tableCell41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(116)))));
            this.tableCell41.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiscountTotal]")});
            this.tableCell41.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            this.tableCell41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.tableCell41.Multiline = true;
            this.tableCell41.Name = "tableCell41";
            this.tableCell41.StylePriority.UseBorderColor = false;
            this.tableCell41.StylePriority.UseBorders = false;
            this.tableCell41.StylePriority.UseBorderWidth = false;
            this.tableCell41.StylePriority.UseFont = false;
            this.tableCell41.StylePriority.UseForeColor = false;
            this.tableCell41.StylePriority.UseTextAlignment = false;
            this.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell41.TextFormatString = "{0:$0.00}";
            this.tableCell41.Weight = 1.4028833087659496D;
            // 
            // tableCell42
            // 
            this.tableCell42.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.tableCell42.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell42.Multiline = true;
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.StyleName = "Foreground";
            this.tableCell42.StylePriority.UseBorderColor = false;
            this.tableCell42.StylePriority.UseBorders = false;
            this.tableCell42.StylePriority.UseBorderWidth = false;
            this.tableCell42.StylePriority.UseTextAlignment = false;
            this.tableCell42.Text = "Grand Total:";
            this.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell42.Weight = 1.5971166912340502D;
            // 
            // tableCell43
            // 
            this.tableCell43.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.tableCell43.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AmountPaid]")});
            this.tableCell43.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.tableCell43.Multiline = true;
            this.tableCell43.Name = "tableCell43";
            this.tableCell43.StylePriority.UseBorderColor = false;
            this.tableCell43.StylePriority.UseBorders = false;
            this.tableCell43.StylePriority.UseBorderWidth = false;
            this.tableCell43.StylePriority.UseFont = false;
            this.tableCell43.StylePriority.UseForeColor = false;
            this.tableCell43.StylePriority.UseTextAlignment = false;
            this.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell43.TextFormatString = "{0:$0.00}";
            this.tableCell43.Weight = 1.4028833087659496D;
            // 
            // tableRow27
            // 
            this.tableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell44,
            this.xrTableCell14});
            this.tableRow27.Name = "tableRow27";
            this.tableRow27.Weight = 0.31800607361714839D;
            // 
            // tableRow28
            // 
            this.tableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell45,
            this.tableCell46});
            this.tableRow28.Name = "tableRow28";
            this.tableRow28.Weight = 0.17049848950242141D;
            // 
            // tableRow29
            // 
            this.tableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell47,
            this.tableCell48});
            this.tableRow29.Name = "tableRow29";
            this.tableRow29.Weight = 0.17049848950242141D;
            // 
            // tableRow30
            // 
            this.tableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell49,
            this.tableCell50});
            this.tableRow30.Name = "tableRow30";
            this.tableRow30.Weight = 0.17049848950242141D;
            // 
            // tableRow31
            // 
            this.tableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell51,
            this.tableCell52});
            this.tableRow31.Name = "tableRow31";
            this.tableRow31.Weight = 0.17049848950242141D;
            // 
            // tableCell44
            // 
            this.tableCell44.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell44.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell44.Multiline = true;
            this.tableCell44.Name = "tableCell44";
            this.tableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell44.StyleName = "SimpleTextStyle";
            this.tableCell44.StylePriority.UseFont = false;
            this.tableCell44.StylePriority.UsePadding = false;
            this.tableCell44.Text = "Payment method:";
            this.tableCell44.Weight = 0.60336810972728738D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.xrTableCell14.StyleName = "SimpleTextStyle";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.Weight = 1.0426589732474052D;
            // 
            // tableCell45
            // 
            this.tableCell45.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell45.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell45.Multiline = true;
            this.tableCell45.Name = "tableCell45";
            this.tableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell45.StyleName = "ForegroundDisabled";
            this.tableCell45.StylePriority.UseFont = false;
            this.tableCell45.StylePriority.UsePadding = false;
            this.tableCell45.StylePriority.UseTextAlignment = false;
            this.tableCell45.Text = "Account №:";
            this.tableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell45.Weight = 0.60336802027461378D;
            // 
            // tableCell46
            // 
            this.tableCell46.CanGrow = false;
            this.tableCell46.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F);
            this.tableCell46.Multiline = true;
            this.tableCell46.Name = "tableCell46";
            this.tableCell46.StyleName = "SimpleTextStyle";
            this.tableCell46.StylePriority.UseFont = false;
            this.tableCell46.Text = "123-45-6789";
            this.tableCell46.Weight = 1.0426590627000789D;
            // 
            // tableCell47
            // 
            this.tableCell47.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell47.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell47.Multiline = true;
            this.tableCell47.Name = "tableCell47";
            this.tableCell47.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell47.StyleName = "ForegroundDisabled";
            this.tableCell47.StylePriority.UseFont = false;
            this.tableCell47.StylePriority.UsePadding = false;
            this.tableCell47.StylePriority.UseTextAlignment = false;
            this.tableCell47.Text = "Bank:";
            this.tableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell47.Weight = 0.60336802027461378D;
            // 
            // tableCell48
            // 
            this.tableCell48.CanGrow = false;
            this.tableCell48.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F);
            this.tableCell48.Multiline = true;
            this.tableCell48.Name = "tableCell48";
            this.tableCell48.StyleName = "SimpleTextStyle";
            this.tableCell48.StylePriority.UseFont = false;
            this.tableCell48.Text = "1st Enterprise Bank";
            this.tableCell48.Weight = 1.0426590627000789D;
            // 
            // tableCell49
            // 
            this.tableCell49.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell49.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell49.Multiline = true;
            this.tableCell49.Name = "tableCell49";
            this.tableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.tableCell49.StyleName = "ForegroundDisabled";
            this.tableCell49.StylePriority.UseFont = false;
            this.tableCell49.StylePriority.UsePadding = false;
            this.tableCell49.StylePriority.UseTextAlignment = false;
            this.tableCell49.Text = "Swift Code:";
            this.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell49.Weight = 0.60336802027461378D;
            // 
            // tableCell50
            // 
            this.tableCell50.CanGrow = false;
            this.tableCell50.Multiline = true;
            this.tableCell50.Name = "tableCell50";
            this.tableCell50.StyleName = "SimpleTextStyle";
            this.tableCell50.Text = "SWFTKUS6LXXX";
            this.tableCell50.Weight = 1.0426590627000789D;
            // 
            // tableCell51
            // 
            this.tableCell51.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell51.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell51.Multiline = true;
            this.tableCell51.Name = "tableCell51";
            this.tableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 2, 100F);
            this.tableCell51.StyleName = "ForegroundDisabled";
            this.tableCell51.StylePriority.UseFont = false;
            this.tableCell51.StylePriority.UsePadding = false;
            this.tableCell51.StylePriority.UseTextAlignment = false;
            this.tableCell51.Text = "Payment Options:";
            this.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell51.Weight = 0.60336802027461378D;
            // 
            // tableCell52
            // 
            this.tableCell52.CanGrow = false;
            this.tableCell52.Multiline = true;
            this.tableCell52.Name = "tableCell52";
            this.tableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 2, 100F);
            this.tableCell52.StyleName = "SimpleTextStyle";
            this.tableCell52.StylePriority.UsePadding = false;
            this.tableCell52.Text = "Visa, MasterCard, American Express";
            this.tableCell52.Weight = 1.0426590627000789D;
            // 
            // tableRow32
            // 
            this.tableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell53});
            this.tableRow32.Name = "tableRow32";
            this.tableRow32.Weight = 0.808849536872746D;
            // 
            // tableRow33
            // 
            this.tableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell54});
            this.tableRow33.Name = "tableRow33";
            this.tableRow33.Weight = 0.52743325318822309D;
            // 
            // tableCell53
            // 
            this.tableCell53.Multiline = true;
            this.tableCell53.Name = "tableCell53";
            this.tableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableCell53.StyleName = "Foreground";
            this.tableCell53.StylePriority.UsePadding = false;
            this.tableCell53.StylePriority.UseTextAlignment = false;
            this.tableCell53.Text = "Andrew Jacobson";
            this.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.tableCell53.Weight = 2D;
            // 
            // tableCell54
            // 
            this.tableCell54.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell54.Multiline = true;
            this.tableCell54.Name = "tableCell54";
            this.tableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            this.tableCell54.StyleName = "ForegroundDisabled";
            this.tableCell54.StylePriority.UseFont = false;
            this.tableCell54.StylePriority.UsePadding = false;
            this.tableCell54.Text = "Account Manager";
            this.tableCell54.Weight = 2D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NWindConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "OrderID";
            table4.Name = "OrderDetailsExtended";
            columnExpression1.Table = table4;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductID";
            columnExpression2.Table = table4;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ProductName";
            columnExpression3.Table = table4;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table4;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Quantity";
            columnExpression5.Table = table4;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Discount";
            columnExpression6.Table = table4;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ExtendedPrice";
            columnExpression7.Table = table4;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Supplier";
            columnExpression8.Table = table4;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "OrderDetails";
            selectQuery1.Tables.Add(table4);
            columnExpression9.ColumnName = "OrderID";
            table5.Name = "Orders";
            columnExpression9.Table = table5;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "CustomerID";
            columnExpression10.Table = table5;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "EmployeeID";
            columnExpression11.Table = table5;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "OrderDate";
            columnExpression12.Table = table5;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "RequiredDate";
            columnExpression13.Table = table5;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "ShippedDate";
            columnExpression14.Table = table5;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "ShipVia";
            columnExpression15.Table = table5;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Freight";
            columnExpression16.Table = table5;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "ShipName";
            columnExpression17.Table = table5;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "ShipAddress";
            columnExpression18.Table = table5;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "ShipCity";
            columnExpression19.Table = table5;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "ShipRegion";
            columnExpression20.Table = table5;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "ShipPostalCode";
            columnExpression21.Table = table5;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "ShipCountry";
            columnExpression22.Table = table5;
            column22.Expression = columnExpression22;
            column23.Alias = "Customers_CustomerID";
            columnExpression23.ColumnName = "CustomerID";
            table6.Name = "Customers";
            columnExpression23.Table = table6;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "CompanyName";
            columnExpression24.Table = table6;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "ContactName";
            columnExpression25.Table = table6;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "ContactTitle";
            columnExpression26.Table = table6;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "Address";
            columnExpression27.Table = table6;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "City";
            columnExpression28.Table = table6;
            column28.Expression = columnExpression28;
            columnExpression29.ColumnName = "Region";
            columnExpression29.Table = table6;
            column29.Expression = columnExpression29;
            columnExpression30.ColumnName = "PostalCode";
            columnExpression30.Table = table6;
            column30.Expression = columnExpression30;
            columnExpression31.ColumnName = "Country";
            columnExpression31.Table = table6;
            column31.Expression = columnExpression31;
            columnExpression32.ColumnName = "Phone";
            columnExpression32.Table = table6;
            column32.Expression = columnExpression32;
            columnExpression33.ColumnName = "Fax";
            columnExpression33.Table = table6;
            column33.Expression = columnExpression33;
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Columns.Add(column12);
            selectQuery2.Columns.Add(column13);
            selectQuery2.Columns.Add(column14);
            selectQuery2.Columns.Add(column15);
            selectQuery2.Columns.Add(column16);
            selectQuery2.Columns.Add(column17);
            selectQuery2.Columns.Add(column18);
            selectQuery2.Columns.Add(column19);
            selectQuery2.Columns.Add(column20);
            selectQuery2.Columns.Add(column21);
            selectQuery2.Columns.Add(column22);
            selectQuery2.Columns.Add(column23);
            selectQuery2.Columns.Add(column24);
            selectQuery2.Columns.Add(column25);
            selectQuery2.Columns.Add(column26);
            selectQuery2.Columns.Add(column27);
            selectQuery2.Columns.Add(column28);
            selectQuery2.Columns.Add(column29);
            selectQuery2.Columns.Add(column30);
            selectQuery2.Columns.Add(column31);
            selectQuery2.Columns.Add(column32);
            selectQuery2.Columns.Add(column33);
            selectQuery2.Name = "Orders";
            relationColumnInfo1.NestedKeyColumn = "CustomerID";
            relationColumnInfo1.ParentKeyColumn = "CustomerID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table5;
            join1.Parent = table6;
            selectQuery2.Relations.Add(join1);
            selectQuery2.Tables.Add(table6);
            selectQuery2.Tables.Add(table5);
            columnExpression34.ColumnName = "CustomerID";
            table10.Name = "Customers";
            columnExpression34.Table = table10;
            column34.Expression = columnExpression34;
            columnExpression35.ColumnName = "CompanyName";
            columnExpression35.Table = table10;
            column35.Expression = columnExpression35;
            columnExpression36.ColumnName = "ContactName";
            columnExpression36.Table = table10;
            column36.Expression = columnExpression36;
            selectQuery3.Columns.Add(column34);
            selectQuery3.Columns.Add(column35);
            selectQuery3.Columns.Add(column36);
            selectQuery3.Name = "Customers";
            selectQuery3.Tables.Add(table10);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2,
            selectQuery3});
            masterDetailInfo1.DetailQueryName = "OrderDetails";
            relationColumnInfo2.NestedKeyColumn = "OrderID";
            relationColumnInfo2.ParentKeyColumn = "OrderID";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo1.MasterQueryName = "Orders";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox1,
            this.table2,
            this.table1,
            this.xrLabel17});
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(850F, 207.2917F);
            this.panel1.StylePriority.UseBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"));
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(65.625F, 75F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(16, 0, 5, 0, 100F);
            this.pictureBox1.SizeF = new System.Drawing.SizeF(145.4951F, 103.9839F);
            this.pictureBox1.StylePriority.UsePadding = false;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(211.1201F, 75F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3,
            this.tableRow4,
            this.tableRow6,
            this.tableRow7,
            this.tableRow5});
            this.table2.SizeF = new System.Drawing.SizeF(304F, 103.9839F);
            // 
            // table1
            // 
            this.table1.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(557.9952F, 137.3173F);
            this.table1.Name = "table1";
            this.table1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1,
            this.tableRow2});
            this.table1.SizeF = new System.Drawing.SizeF(218.0077F, 41.66667F);
            this.table1.StylePriority.UseFont = false;
            this.table1.StylePriority.UsePadding = false;
            this.table1.StylePriority.UseTextAlignment = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Heading1;
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Arial", 37.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(515.1201F, 75F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(260.8827F, 53.2083F);
            this.xrLabel17.StyleName = "Foreground";
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "INVOICE";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 1D;
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 1D;
            // 
            // tableRow6
            // 
            this.tableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell8});
            this.tableRow6.Name = "tableRow6";
            this.tableRow6.Weight = 1D;
            // 
            // tableRow7
            // 
            this.tableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9});
            this.tableRow7.Name = "tableRow7";
            this.tableRow7.Weight = 1D;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7});
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 1D;
            // 
            // tableCell5
            // 
            this.tableCell5.CanGrow = false;
            this.tableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell5.Multiline = true;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "SimpleTextStyle";
            this.tableCell5.StylePriority.UseFont = false;
            this.tableCell5.Text = "Northwind Traders";
            this.tableCell5.Weight = 1.0198401485769693D;
            // 
            // tableCell6
            // 
            this.tableCell6.CanGrow = false;
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "SimpleTextStyle";
            this.tableCell6.Text = "One Portals Way, Twin Points WA, 98156";
            this.tableCell6.Weight = 1.0198401485769693D;
            // 
            // tableCell8
            // 
            this.tableCell8.CanGrow = false;
            this.tableCell8.Multiline = true;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "SimpleTextStyle";
            this.tableCell8.Text = "1-206-555-1417";
            this.tableCell8.Weight = 1.0198401485769693D;
            // 
            // tableCell9
            // 
            this.tableCell9.CanGrow = false;
            this.tableCell9.Multiline = true;
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "SimpleTextStyle";
            this.tableCell9.Text = "northwind@mail.com";
            this.tableCell9.Weight = 1.0198401485769693D;
            // 
            // tableCell7
            // 
            this.tableCell7.CanGrow = false;
            this.tableCell7.Multiline = true;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "SimpleTextStyle";
            this.tableCell7.Text = "www.northwind.com";
            this.tableCell7.Weight = 1.0198401485769693D;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 0.481148248077382D;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 0.48114824807738177D;
            // 
            // tableCell1
            // 
            this.tableCell1.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell1.CanGrow = false;
            this.tableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "ForegroundDisabled";
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.StylePriority.UsePadding = false;
            this.tableCell1.StylePriority.UseTextAlignment = false;
            this.tableCell1.Text = "Invoice №:";
            this.tableCell1.Weight = 1.194199883360656D;
            // 
            // tableCell2
            // 
            this.tableCell2.CanGrow = false;
            this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")});
            this.tableCell2.Multiline = true;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "Foreground";
            this.tableCell2.Weight = 1.1125145374308747D;
            // 
            // tableCell3
            // 
            this.tableCell3.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.TableHeaderCell;
            this.tableCell3.CanGrow = false;
            this.tableCell3.Multiline = true;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "ForegroundDisabled";
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.StylePriority.UsePadding = false;
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "Invoice Date:";
            this.tableCell3.Weight = 1.194199883360656D;
            // 
            // tableCell4
            // 
            this.tableCell4.CanGrow = false;
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")});
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "Foreground";
            this.tableCell4.TextFormatString = "{0:MM/dd/yy}";
            this.tableCell4.Weight = 1.1125145374308745D;
            // 
            // Foreground
            // 
            this.Foreground.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Foreground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(82)))));
            this.Foreground.Name = "Foreground";
            this.Foreground.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ForegroundDisabled
            // 
            this.ForegroundDisabled.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ForegroundDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.ForegroundDisabled.Name = "ForegroundDisabled";
            this.ForegroundDisabled.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // SimpleTextStyle
            // 
            this.SimpleTextStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F);
            this.SimpleTextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(86)))));
            this.SimpleTextStyle.Name = "SimpleTextStyle";
            this.SimpleTextStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TableHeaderStyle
            // 
            this.TableHeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(86)))));
            this.TableHeaderStyle.Name = "TableHeaderStyle";
            this.TableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // NetPrice
            // 
            this.NetPrice.DataMember = "Orders.OrdersOrderDetails";
            this.NetPrice.Expression = "[UnitPrice] * [Quantity] - [Discount]";
            this.NetPrice.Name = "NetPrice";
            // 
            // SumUnitPrice
            // 
            this.SumUnitPrice.DataMember = "Orders.OrdersOrderDetails";
            this.SumUnitPrice.Expression = "[][[OrderID] == [^.OrderID]].Sum([UnitPrice]*[Quantity])";
            this.SumUnitPrice.Name = "SumUnitPrice";
            // 
            // DiscountTotal
            // 
            this.DiscountTotal.DataMember = "Orders.OrdersOrderDetails";
            this.DiscountTotal.Expression = "[][[OrderID] == [^.OrderID]].Sum([calculatedField1])";
            this.DiscountTotal.Name = "DiscountTotal";
            // 
            // AmountPaid
            // 
            this.AmountPaid.DataMember = "Orders.OrdersOrderDetails";
            this.AmountPaid.Expression = "[SumUnitPrice] - [DiscountTotal]";
            this.AmountPaid.Name = "AmountPaid";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "Orders.OrdersOrderDetails";
            this.calculatedField1.DisplayName = "PosDiscount";
            this.calculatedField1.Expression = "[Quantity]* [Discount]";
            this.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calculatedField1.Name = "calculatedField1";
            // 
            // paramCompany
            // 
            this.paramCompany.Description = "Company";
            this.paramCompany.MultiValue = true;
            this.paramCompany.Name = "paramCompany";
            this.paramCompany.ValueInfo = "ALFKI";
            dynamicListLookUpSettings1.DataMember = "Customers";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "CompanyName";
            dynamicListLookUpSettings1.ValueMember = "CustomerID";
            this.paramCompany.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // InvoiceReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.NetPrice,
            this.SumUnitPrice,
            this.DiscountTotal,
            this.AmountPaid,
            this.calculatedField1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Orders";
            this.DataSource = this.sqlDataSource1;
            this.DisplayName = "Invoice";
            this.FilterString = "[CustomerID] In (?paramCompany)";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 59.375F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.paramCompany, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramCompany});
            this.RequestParameters = false;
            this.SnapGridSize = 13.02083F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Foreground,
            this.ForegroundDisabled,
            this.SimpleTextStyle,
            this.TableHeaderStyle});
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableRow tableRow8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableRow tableRow9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableRow tableRow10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableRow tableRow11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTableRow tableRow12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLine line2;
        private DevExpress.XtraReports.UI.XRTable table7;
        private DevExpress.XtraReports.UI.XRTableRow tableRow24;
        private DevExpress.XtraReports.UI.XRTableCell tableCell37;
        private DevExpress.XtraReports.UI.XRTableCell tableCell39;
        private DevExpress.XtraReports.UI.XRTableRow tableRow25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell40;
        private DevExpress.XtraReports.UI.XRTableCell tableCell41;
        private DevExpress.XtraReports.UI.XRTableRow tableRow26;
        private DevExpress.XtraReports.UI.XRTableCell tableCell42;
        private DevExpress.XtraReports.UI.XRTableCell tableCell43;
        private DevExpress.XtraReports.UI.XRBarCode barCode2;
        private DevExpress.XtraReports.UI.XRTable table8;
        private DevExpress.XtraReports.UI.XRTableRow tableRow27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell44;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableRow tableRow28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell45;
        private DevExpress.XtraReports.UI.XRTableCell tableCell46;
        private DevExpress.XtraReports.UI.XRTableRow tableRow29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell47;
        private DevExpress.XtraReports.UI.XRTableCell tableCell48;
        private DevExpress.XtraReports.UI.XRTableRow tableRow30;
        private DevExpress.XtraReports.UI.XRTableCell tableCell49;
        private DevExpress.XtraReports.UI.XRTableCell tableCell50;
        private DevExpress.XtraReports.UI.XRTableRow tableRow31;
        private DevExpress.XtraReports.UI.XRTableCell tableCell51;
        private DevExpress.XtraReports.UI.XRTableCell tableCell52;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox3;
        private DevExpress.XtraReports.UI.XRTable table9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow32;
        private DevExpress.XtraReports.UI.XRTableCell tableCell53;
        private DevExpress.XtraReports.UI.XRTableRow tableRow33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell54;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableRow tableRow6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableRow tableRow7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRControlStyle Foreground;
        private DevExpress.XtraReports.UI.XRControlStyle ForegroundDisabled;
        private DevExpress.XtraReports.UI.XRControlStyle SimpleTextStyle;
        private DevExpress.XtraReports.UI.XRControlStyle TableHeaderStyle;
        private DevExpress.XtraReports.UI.CalculatedField NetPrice;
        private DevExpress.XtraReports.UI.CalculatedField SumUnitPrice;
        private DevExpress.XtraReports.UI.CalculatedField DiscountTotal;
        private DevExpress.XtraReports.UI.CalculatedField AmountPaid;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.Parameters.Parameter paramCompany;
    }
}
