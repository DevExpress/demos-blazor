using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.DataAccess;

namespace XtraReportsDemos.CrossBandContent {
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.Table table10 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.line2 = new DevExpress.XtraReports.UI.XRLine();
            this.table7 = new DevExpress.XtraReports.UI.XRTable();
            this.barCode2 = new DevExpress.XtraReports.UI.XRBarCode();
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
            this.tableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.InvoiceDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GreyTextStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.HeaderBoldTextStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailTableCellStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TotalCellStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.InvoiceHeaderBoldStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.InvoiceHeaderDetailStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.NetPrice = new DevExpress.XtraReports.UI.CalculatedField();
            this.SubTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField3 = new DevExpress.XtraReports.UI.CalculatedField();
            this.paramCompany = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.FillEmptySpace = true;
            this.Detail.HeightF = 31.25F;
            this.Detail.Name = "Detail";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ContactName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 1100F;
            this.GroupHeader1.Level = 2;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PrintAcrossBands = true;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader2.HeightF = 33.33333F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1,
            this.xrLabel17});
            this.GroupHeader3.HeightF = 200F;
            this.GroupHeader3.Level = 1;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.line2,
            this.table7,
            this.barCode2,
            this.pictureBox3,
            this.table9});
            this.GroupFooter1.HeightF = 429F;
            this.GroupFooter1.Level = 2;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.PrintAtBottom = true;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.BorderWidth = 1F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(309.9536F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(458.4579F, 31.25F);
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
            this.xrTableCell5});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UsePadding = false;
            this.xrTableRow1.Weight = 13.895833333333334D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber([ProductName])")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StyleName = "DetailTableCellStyle";
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell11.Summary = xrSummary1;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.TextFormatString = "{0:00}";
            this.xrTableCell11.Weight = 0.30743619581260517D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 1, 100F);
            this.xrTableCell1.StyleName = "DetailTableCellStyle";
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 1.159824794670725D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanGrow = false;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StyleName = "DetailTableCellStyle";
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.TextFormatString = "{0:$0.00}";
            this.xrTableCell2.Weight = 0.46119086934664449D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.CanGrow = false;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StyleName = "DetailTableCellStyle";
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.56358944254168175D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "NetPrice")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StyleName = "DetailTableCellStyle";
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.TextFormatString = "{0:$0.00}";
            this.xrTableCell5.Weight = 0.65701634470818915D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table5,
            this.table4,
            this.table3,
            this.table2,
            this.pictureBox1});
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(247.4327F, 1099.157F);
            this.panel1.StylePriority.UseBackColor = false;
            // 
            // table5
            // 
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(51.07282F, 664.0108F);
            this.table5.Name = "table5";
            this.table5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow23,
            this.tableRow13,
            this.tableRow16,
            this.tableRow17,
            this.tableRow18,
            this.tableRow19,
            this.tableRow20,
            this.tableRow21,
            this.tableRow22});
            this.table5.SizeF = new System.Drawing.SizeF(144.9713F, 234.1133F);
            // 
            // table4
            // 
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(51.07282F, 267.5371F);
            this.table4.Name = "table4";
            this.table4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow7,
            this.tableRow8,
            this.tableRow9,
            this.tableRow10,
            this.tableRow11,
            this.tableRow12});
            this.table4.SizeF = new System.Drawing.SizeF(144.9713F, 155.4726F);
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(51.07282F, 464.3613F);
            this.table3.Name = "table3";
            this.table3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5,
            this.tableRow6,
            this.tableRow27,
            this.tableRow28,
            this.tableRow29,
            this.tableRow30});
            this.table3.SizeF = new System.Drawing.SizeF(144.9713F, 186.8392F);
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(51.07282F, 205.2573F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4,
            this.tableRow3});
            this.table2.SizeF = new System.Drawing.SizeF(115.2778F, 62.27972F);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"));
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(44.27083F, 54.6875F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(16, 0, 5, 0, 100F);
            this.pictureBox1.SizeF = new System.Drawing.SizeF(148.3669F, 103.9839F);
            this.pictureBox1.StylePriority.UsePadding = false;
            // 
            // tableRow23
            // 
            this.tableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell23});
            this.tableRow23.Name = "tableRow23";
            this.tableRow23.Weight = 1.8689700161975629D;
            // 
            // tableRow13
            // 
            this.tableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15});
            this.tableRow13.Name = "tableRow13";
            this.tableRow13.Weight = 0.89875136663655553D;
            // 
            // tableRow16
            // 
            this.tableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell16});
            this.tableRow16.Name = "tableRow16";
            this.tableRow16.Weight = 0.72504107601208811D;
            // 
            // tableRow17
            // 
            this.tableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell17});
            this.tableRow17.Name = "tableRow17";
            this.tableRow17.Weight = 1.2749583375551774D;
            // 
            // tableRow18
            // 
            this.tableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell18});
            this.tableRow18.Name = "tableRow18";
            this.tableRow18.Weight = 0.7969649414013D;
            // 
            // tableRow19
            // 
            this.tableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell19});
            this.tableRow19.Name = "tableRow19";
            this.tableRow19.Weight = 1.2685576984647813D;
            // 
            // tableRow20
            // 
            this.tableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell20});
            this.tableRow20.Name = "tableRow20";
            this.tableRow20.Weight = 1.0751197621124016D;
            // 
            // tableRow21
            // 
            this.tableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell21});
            this.tableRow21.Name = "tableRow21";
            this.tableRow21.Weight = 0.99135397592214081D;
            // 
            // tableRow22
            // 
            this.tableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell22});
            this.tableRow22.Name = "tableRow22";
            this.tableRow22.Weight = 1.4467637043944475D;
            // 
            // tableCell23
            // 
            this.tableCell23.Multiline = true;
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell23.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell23.StylePriority.UsePadding = false;
            this.tableCell23.Text = "PAYMENT METHOD:";
            this.tableCell23.Weight = 3D;
            // 
            // tableCell15
            // 
            this.tableCell15.Multiline = true;
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell15.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell15.StylePriority.UsePadding = false;
            this.tableCell15.Text = "Account №:";
            this.tableCell15.Weight = 3D;
            // 
            // tableCell16
            // 
            this.tableCell16.Multiline = true;
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell16.StylePriority.UseTextAlignment = false;
            this.tableCell16.Text = "123-45-6789";
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell16.Weight = 3D;
            // 
            // tableCell17
            // 
            this.tableCell17.Multiline = true;
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell17.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell17.StylePriority.UsePadding = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            this.tableCell17.Text = "Bank:";
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell17.Weight = 3D;
            // 
            // tableCell18
            // 
            this.tableCell18.Multiline = true;
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 1, 0, 100F);
            this.tableCell18.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell18.StylePriority.UsePadding = false;
            this.tableCell18.StylePriority.UseTextAlignment = false;
            this.tableCell18.Text = "1st Enterprise Bank";
            this.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell18.Weight = 3D;
            // 
            // tableCell19
            // 
            this.tableCell19.Multiline = true;
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell19.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell19.StylePriority.UsePadding = false;
            this.tableCell19.StylePriority.UseTextAlignment = false;
            this.tableCell19.Text = "Swift Code:";
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell19.Weight = 3D;
            // 
            // tableCell20
            // 
            this.tableCell20.Multiline = true;
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell20.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell20.StylePriority.UsePadding = false;
            this.tableCell20.StylePriority.UseTextAlignment = false;
            this.tableCell20.Text = "SWFTKUS6LXXX";
            this.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell20.Weight = 3D;
            // 
            // tableCell21
            // 
            this.tableCell21.Multiline = true;
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell21.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell21.StylePriority.UsePadding = false;
            this.tableCell21.StylePriority.UseTextAlignment = false;
            this.tableCell21.Text = "Card Payment:";
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell21.Weight = 3D;
            // 
            // tableCell22
            // 
            this.tableCell22.Multiline = true;
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell22.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell22.StylePriority.UsePadding = false;
            this.tableCell22.StylePriority.UseTextAlignment = false;
            this.tableCell22.Text = "Visa, MasterCard, American Express";
            this.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell22.Weight = 3D;
            // 
            // tableRow7
            // 
            this.tableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9});
            this.tableRow7.Name = "tableRow7";
            this.tableRow7.Weight = 0.89875136663655553D;
            // 
            // tableRow8
            // 
            this.tableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell10});
            this.tableRow8.Name = "tableRow8";
            this.tableRow8.Weight = 1.8536609350924906D;
            // 
            // tableRow9
            // 
            this.tableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell11});
            this.tableRow9.Name = "tableRow9";
            this.tableRow9.Weight = 0.89875277153706556D;
            // 
            // tableRow10
            // 
            this.tableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell12});
            this.tableRow10.Name = "tableRow10";
            this.tableRow10.Weight = 0.752798909588049D;
            // 
            // tableRow11
            // 
            this.tableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell13});
            this.tableRow11.Name = "tableRow11";
            this.tableRow11.Weight = 1.1969302526990893D;
            // 
            // tableRow12
            // 
            this.tableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell14});
            this.tableRow12.Name = "tableRow12";
            this.tableRow12.Weight = 1.2701143281899576D;
            // 
            // tableCell9
            // 
            this.tableCell9.Multiline = true;
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell9.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell9.StylePriority.UsePadding = false;
            this.tableCell9.Text = "Address:";
            this.tableCell9.Weight = 3D;
            // 
            // tableCell10
            // 
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.Text = "One Portals Way, Twin Points WA, 98156";
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell10.Weight = 3D;
            // 
            // tableCell11
            // 
            this.tableCell11.Multiline = true;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell11.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell11.StylePriority.UsePadding = false;
            this.tableCell11.Text = "Phone:";
            this.tableCell11.Weight = 3D;
            // 
            // tableCell12
            // 
            this.tableCell12.CanGrow = false;
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.Text = "1-206-555-1417";
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell12.Weight = 3D;
            // 
            // tableCell13
            // 
            this.tableCell13.CanGrow = false;
            this.tableCell13.Multiline = true;
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell13.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell13.StylePriority.UsePadding = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            this.tableCell13.Text = "Web:";
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell13.Weight = 3D;
            // 
            // tableCell14
            // 
            this.tableCell14.Multiline = true;
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell14.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell14.StylePriority.UsePadding = false;
            this.tableCell14.StylePriority.UseTextAlignment = false;
            this.tableCell14.Text = "www.northwind.com";
            this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell14.Weight = 3D;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6});
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 1D;
            // 
            // tableRow6
            // 
            this.tableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7});
            this.tableRow6.Name = "tableRow6";
            this.tableRow6.Weight = 1.7524123017290458D;
            // 
            // tableRow27
            // 
            this.tableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell24});
            this.tableRow27.Name = "tableRow27";
            this.tableRow27.Weight = 0.782195135743229D;
            // 
            // tableRow28
            // 
            this.tableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell25});
            this.tableRow28.Name = "tableRow28";
            this.tableRow28.Weight = 1.9702171659858165D;
            // 
            // tableRow29
            // 
            this.tableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell26});
            this.tableRow29.Name = "tableRow29";
            this.tableRow29.Weight = 0.82179092401249076D;
            // 
            // tableRow30
            // 
            this.tableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell27});
            this.tableRow30.Name = "tableRow30";
            this.tableRow30.Weight = 1.9306213777165553D;
            // 
            // tableCell6
            // 
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell6.Text = "TO:";
            this.tableCell6.Weight = 3D;
            // 
            // tableCell7
            // 
            this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")});
            this.tableCell7.Multiline = true;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell7.StylePriority.UseForeColor = false;
            this.tableCell7.Weight = 3D;
            // 
            // tableCell24
            // 
            this.tableCell24.Multiline = true;
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell24.StylePriority.UseTextAlignment = false;
            this.tableCell24.Text = "Address:";
            this.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell24.Weight = 3D;
            // 
            // tableCell25
            // 
            this.tableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0}, {1}, {2}\', [Address], [City], [Country])")});
            this.tableCell25.Multiline = true;
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 100F);
            this.tableCell25.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell25.StylePriority.UseForeColor = false;
            this.tableCell25.StylePriority.UsePadding = false;
            this.tableCell25.StylePriority.UseTextAlignment = false;
            this.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell25.Weight = 3D;
            // 
            // tableCell26
            // 
            this.tableCell26.Multiline = true;
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell26.StylePriority.UseTextAlignment = false;
            this.tableCell26.Text = "Phone:";
            this.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell26.Weight = 3D;
            // 
            // tableCell27
            // 
            this.tableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            this.tableCell27.Multiline = true;
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.tableCell27.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell27.StylePriority.UseForeColor = false;
            this.tableCell27.StylePriority.UsePadding = false;
            this.tableCell27.StylePriority.UseTextAlignment = false;
            this.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell27.Weight = 3D;
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell8});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 1D;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 1.7524123017290458D;
            // 
            // tableCell8
            // 
            this.tableCell8.Multiline = true;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "InvoiceHeaderBoldStyle";
            this.tableCell8.Text = "FROM:";
            this.tableCell8.Weight = 3D;
            // 
            // tableCell5
            // 
            this.tableCell5.Multiline = true;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "InvoiceHeaderDetailStyle";
            this.tableCell5.Text = "Northwind Traders";
            this.tableCell5.Weight = 3D;
            // 
            // xrTable2
            // 
            this.xrTable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(309.9538F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(458.4583F, 33.33333F);
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
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell10});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UsePadding = false;
            this.xrTableRow2.Weight = 11.236641221374043D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "Pos.";
            this.xrTableCell12.Weight = 0.30522042045810632D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.Text = "Product Name";
            this.xrTableCell6.Weight = 1.1514660692383285D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Unit Price";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.Weight = 0.45786681207803032D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Quantity";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell8.Weight = 0.5595259129897151D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Total";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.Weight = 0.652284177027956D;
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(644.8574F, 75.69452F);
            this.table1.Name = "table1";
            this.table1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1,
            this.tableRow2,
            this.tableRow14,
            this.tableRow15});
            this.table1.SizeF = new System.Drawing.SizeF(123.5574F, 89.82597F);
            this.table1.StylePriority.UsePadding = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(306.25F, 73.95834F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.SizeF = new System.Drawing.SizeF(211.6745F, 53.20831F);
            this.xrLabel17.StyleName = "TitleStyle";
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "INVOICE";
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 0.91397862588205647D;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell2});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1.3612903225806452D;
            // 
            // tableRow14
            // 
            this.tableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3});
            this.tableRow14.Name = "tableRow14";
            this.tableRow14.Weight = 0.81391444052419359D;
            // 
            // tableRow15
            // 
            this.tableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell4});
            this.tableRow15.Name = "tableRow15";
            this.tableRow15.Weight = 1.3615483437815019D;
            // 
            // tableCell1
            // 
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "GreyTextStyle";
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.Text = "Order №:";
            this.tableCell1.Weight = 1D;
            // 
            // tableCell2
            // 
            this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")});
            this.tableCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell2.Multiline = true;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "HeaderBoldTextStyle";
            this.tableCell2.StylePriority.UseFont = false;
            this.tableCell2.StylePriority.UseForeColor = false;
            this.tableCell2.StylePriority.UsePadding = false;
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Multiline = true;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "GreyTextStyle";
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "Order Date:";
            this.tableCell3.Weight = 1D;
            // 
            // tableCell4
            // 
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")});
            this.tableCell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "HeaderBoldTextStyle";
            this.tableCell4.StylePriority.UseFont = false;
            this.tableCell4.StylePriority.UseForeColor = false;
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.tableCell4.TextFormatString = "{0:MMMM d, yyyy}";
            this.tableCell4.Weight = 1D;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(118)))));
            this.line2.BorderWidth = 1F;
            this.line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.line2.LineWidth = 2F;
            this.line2.LocationFloat = new DevExpress.Utils.PointFloat(309.9538F, 0F);
            this.line2.Name = "line2";
            this.line2.SizeF = new System.Drawing.SizeF(460.0484F, 2.083333F);
            this.line2.StylePriority.UseBorderColor = false;
            this.line2.StylePriority.UseBorderWidth = false;
            this.line2.StylePriority.UseForeColor = false;
            // 
            // table7
            // 
            this.table7.LocationFloat = new DevExpress.Utils.PointFloat(555.926F, 2.083333F);
            this.table7.Name = "table7";
            this.table7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow24,
            this.tableRow25,
            this.tableRow26});
            this.table7.SizeF = new System.Drawing.SizeF(214.0729F, 94.14556F);
            // 
            // barCode2
            // 
            this.barCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.barCode2.AutoModule = true;
            this.barCode2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "OrderID")});
            this.barCode2.LocationFloat = new DevExpress.Utils.PointFloat(555F, 113.5417F);
            this.barCode2.Name = "barCode2";
            this.barCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 12, 12, 100F);
            this.barCode2.ShowText = false;
            this.barCode2.SizeF = new System.Drawing.SizeF(215F, 62F);
            this.barCode2.StyleName = "TitleStyle";
            this.barCode2.StylePriority.UsePadding = false;
            this.barCode2.Symbology = code128Generator1;
            this.barCode2.Text = "10634";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox3.ImageSource"));
            this.pictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(553F, 206F);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.SizeF = new System.Drawing.SizeF(120F, 95F);
            // 
            // table9
            // 
            this.table9.LocationFloat = new DevExpress.Utils.PointFloat(650F, 301F);
            this.table9.Name = "table9";
            this.table9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow32,
            this.tableRow33});
            this.table9.SizeF = new System.Drawing.SizeF(118F, 44F);
            // 
            // tableRow24
            // 
            this.tableRow24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableRow24.BorderWidth = 2.5F;
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
            this.tableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell40,
            this.tableCell41});
            this.tableRow25.Name = "tableRow25";
            this.tableRow25.Weight = 0.334263861744661D;
            // 
            // tableRow26
            // 
            this.tableRow26.BorderWidth = 2.5F;
            this.tableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell42,
            this.tableCell43});
            this.tableRow26.Name = "tableRow26";
            this.tableRow26.StylePriority.UseBorderWidth = false;
            this.tableRow26.Weight = 0.32430194900068893D;
            // 
            // tableCell37
            // 
            this.tableCell37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.tableCell37.BorderWidth = 1F;
            this.tableCell37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell37.Multiline = true;
            this.tableCell37.Name = "tableCell37";
            this.tableCell37.StyleName = "TotalCellStyle";
            this.tableCell37.StylePriority.UseBorderColor = false;
            this.tableCell37.StylePriority.UseBorderWidth = false;
            this.tableCell37.StylePriority.UseForeColor = false;
            this.tableCell37.StylePriority.UseTextAlignment = false;
            this.tableCell37.Text = "Sub Total:";
            this.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell37.Weight = 1.5D;
            // 
            // tableCell39
            // 
            this.tableCell39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.tableCell39.BorderWidth = 1F;
            this.tableCell39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubTotal]")});
            this.tableCell39.Multiline = true;
            this.tableCell39.Name = "tableCell39";
            this.tableCell39.StyleName = "TotalCellStyle";
            this.tableCell39.StylePriority.UseBorderColor = false;
            this.tableCell39.StylePriority.UseBorderWidth = false;
            this.tableCell39.StylePriority.UseTextAlignment = false;
            this.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell39.TextFormatString = "{0:$0.00}";
            this.tableCell39.Weight = 1.5D;
            // 
            // tableCell40
            // 
            this.tableCell40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell40.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.tableCell40.Multiline = true;
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.StyleName = "TotalCellStyle";
            this.tableCell40.StylePriority.UseBorderColor = false;
            this.tableCell40.StylePriority.UseBorders = false;
            this.tableCell40.StylePriority.UseBorderWidth = false;
            this.tableCell40.StylePriority.UseFont = false;
            this.tableCell40.StylePriority.UseForeColor = false;
            this.tableCell40.StylePriority.UseTextAlignment = false;
            this.tableCell40.Text = "Discount Total:";
            this.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell40.Weight = 1.5D;
            // 
            // tableCell41
            // 
            this.tableCell41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell41.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField1]")});
            this.tableCell41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.tableCell41.Multiline = true;
            this.tableCell41.Name = "tableCell41";
            this.tableCell41.StyleName = "TotalCellStyle";
            this.tableCell41.StylePriority.UseBorderColor = false;
            this.tableCell41.StylePriority.UseBorders = false;
            this.tableCell41.StylePriority.UseBorderWidth = false;
            this.tableCell41.StylePriority.UseFont = false;
            this.tableCell41.StylePriority.UseForeColor = false;
            this.tableCell41.StylePriority.UseTextAlignment = false;
            this.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell41.TextFormatString = "{0:$0.00}";
            this.tableCell41.Weight = 1.5D;
            // 
            // tableCell42
            // 
            this.tableCell42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell42.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell42.Multiline = true;
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.StyleName = "TotalCellStyle";
            this.tableCell42.StylePriority.UseBorderColor = false;
            this.tableCell42.StylePriority.UseBorders = false;
            this.tableCell42.StylePriority.UseBorderWidth = false;
            this.tableCell42.StylePriority.UseForeColor = false;
            this.tableCell42.StylePriority.UseTextAlignment = false;
            this.tableCell42.Text = "Grand Total:";
            this.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell42.Weight = 1.5D;
            // 
            // tableCell43
            // 
            this.tableCell43.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell43.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField2]")});
            this.tableCell43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.tableCell43.Multiline = true;
            this.tableCell43.Name = "tableCell43";
            this.tableCell43.StyleName = "TotalCellStyle";
            this.tableCell43.StylePriority.UseBorderColor = false;
            this.tableCell43.StylePriority.UseBorders = false;
            this.tableCell43.StylePriority.UseBorderWidth = false;
            this.tableCell43.StylePriority.UseFont = false;
            this.tableCell43.StylePriority.UseForeColor = false;
            this.tableCell43.StylePriority.UseTextAlignment = false;
            this.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell43.TextFormatString = "{0:$0.00}";
            this.tableCell43.Weight = 1.5D;
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
            this.tableCell53.StyleName = "HeaderBoldTextStyle";
            this.tableCell53.StylePriority.UsePadding = false;
            this.tableCell53.StylePriority.UseTextAlignment = false;
            this.tableCell53.Text = "Andrew Jacobson";
            this.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.tableCell53.Weight = 2D;
            // 
            // tableCell54
            // 
            this.tableCell54.Font = new DevExpress.Drawing.DXFont("Arial", 7.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell54.Multiline = true;
            this.tableCell54.Name = "tableCell54";
            this.tableCell54.StyleName = "GreyTextStyle";
            this.tableCell54.StylePriority.UseFont = false;
            this.tableCell54.StylePriority.UsePadding = false;
            this.tableCell54.Text = "Account Manager";
            this.tableCell54.Weight = 2D;
            // 
            // InvoiceDataSource
            // 
            this.InvoiceDataSource.ConnectionName = "NWindConnectionString";
            this.InvoiceDataSource.Name = "InvoiceDataSource";
            columnExpression1.ColumnName = "OrderID";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"474\" />";
            table6.Name = "Orders";
            columnExpression1.Table = table6;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "OrderDate";
            columnExpression2.Table = table6;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ProductName";
            table8.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"312\" />";
            table8.Name = "OrderDetailsExtended";
            columnExpression3.Table = table8;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table8;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Discount";
            columnExpression5.Table = table8;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Quantity";
            columnExpression6.Table = table8;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ExtendedPrice";
            columnExpression7.Table = table8;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "CompanyName";
            table10.MetaSerializable = "<Meta X=\"270\" Y=\"370\" Width=\"240\" Height=\"393\" />";
            table10.Name = "Customers";
            columnExpression8.Table = table10;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "ContactName";
            columnExpression9.Table = table10;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Address";
            columnExpression10.Table = table10;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "City";
            columnExpression11.Table = table10;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Region";
            columnExpression12.Table = table10;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Phone";
            columnExpression13.Table = table10;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Country";
            columnExpression14.Table = table10;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "CustomerID";
            columnExpression15.Table = table6;
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
            selectQuery1.Name = "Order_Details_Invoice";
            relationColumnInfo1.NestedKeyColumn = "OrderID";
            relationColumnInfo1.ParentKeyColumn = "OrderID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table8;
            join1.Parent = table6;
            relationColumnInfo2.NestedKeyColumn = "CustomerID";
            relationColumnInfo2.ParentKeyColumn = "CustomerID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table10;
            join2.Parent = table6;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table6);
            selectQuery1.Tables.Add(table8);
            selectQuery1.Tables.Add(table10);
            this.InvoiceDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            masterDetailInfo1.DetailQueryName = "OrderDetails";
            relationColumnInfo3.NestedKeyColumn = "OrderID";
            relationColumnInfo3.ParentKeyColumn = "OrderID";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3);
            masterDetailInfo1.MasterQueryName = "Orders";
            this.InvoiceDataSource.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1});
            this.InvoiceDataSource.ResultSchemaSerializable = resources.GetString("InvoiceDataSource.ResultSchemaSerializable");
            // 
            // GreyTextStyle
            // 
            this.GreyTextStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GreyTextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.GreyTextStyle.Name = "GreyTextStyle";
            this.GreyTextStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // HeaderBoldTextStyle
            // 
            this.HeaderBoldTextStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HeaderBoldTextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(86)))));
            this.HeaderBoldTextStyle.Name = "HeaderBoldTextStyle";
            this.HeaderBoldTextStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // TableHeaderStyle
            // 
            this.TableHeaderStyle.BorderWidth = 2F;
            this.TableHeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.TableHeaderStyle.Name = "TableHeaderStyle";
            this.TableHeaderStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailTableCellStyle
            // 
            this.DetailTableCellStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F);
            this.DetailTableCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(86)))));
            this.DetailTableCellStyle.Name = "DetailTableCellStyle";
            this.DetailTableCellStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 1, 100F);
            this.DetailTableCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TotalCellStyle
            // 
            this.TotalCellStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.TotalCellStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TotalCellStyle.BorderWidth = 2F;
            this.TotalCellStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TotalCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.TotalCellStyle.Name = "TotalCellStyle";
            this.TotalCellStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            // 
            // InvoiceHeaderBoldStyle
            // 
            this.InvoiceHeaderBoldStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F, DevExpress.Drawing.DXFontStyle.Bold);
            this.InvoiceHeaderBoldStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvoiceHeaderBoldStyle.Name = "InvoiceHeaderBoldStyle";
            this.InvoiceHeaderBoldStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.InvoiceHeaderBoldStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // InvoiceHeaderDetailStyle
            // 
            this.InvoiceHeaderDetailStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.5F);
            this.InvoiceHeaderDetailStyle.ForeColor = System.Drawing.Color.White;
            this.InvoiceHeaderDetailStyle.Name = "InvoiceHeaderDetailStyle";
            this.InvoiceHeaderDetailStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.InvoiceHeaderDetailStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new DevExpress.Drawing.DXFont("Arial", 36F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TitleStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.TitleStyle.Name = "TitleStyle";
            // 
            // NetPrice
            // 
            this.NetPrice.DataMember = "Order_Details_Invoice";
            this.NetPrice.Expression = "[UnitPrice] * [Quantity]";
            this.NetPrice.Name = "NetPrice";
            // 
            // SubTotal
            // 
            this.SubTotal.DataMember = "Order_Details_Invoice";
            this.SubTotal.DisplayName = "SubTotal";
            this.SubTotal.Expression = "[][[OrderID] == [^.OrderID]].Sum([UnitPrice]*[Quantity])";
            this.SubTotal.Name = "SubTotal";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "Order_Details_Invoice";
            this.calculatedField1.DisplayName = "DiscountTotal";
            this.calculatedField1.Expression = "[][[ContactName] == [^.ContactName] AND [OrderID] == [^.OrderID]].Sum([calculated" +
    "Field3])";
            this.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calculatedField1.Name = "calculatedField1";
            // 
            // calculatedField2
            // 
            this.calculatedField2.DataMember = "Order_Details_Invoice";
            this.calculatedField2.DisplayName = "GrandTotal";
            this.calculatedField2.Expression = "[SubTotal] - [calculatedField1]";
            this.calculatedField2.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calculatedField2.Name = "calculatedField2";
            // 
            // calculatedField3
            // 
            this.calculatedField3.DataMember = "Order_Details_Invoice";
            this.calculatedField3.DisplayName = "PosDiscount";
            this.calculatedField3.Expression = "[Quantity]* [Discount]";
            this.calculatedField3.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calculatedField3.Name = "calculatedField3";
            // 
            // paramCompany
            // 
            this.paramCompany.Description = "Company";
            this.paramCompany.MultiValue = true;
            this.paramCompany.Name = "paramCompany";
            this.paramCompany.ValueInfo = "ALFKI";
            dynamicListLookUpSettings1.DataMember = "Order_Details_Invoice";
            dynamicListLookUpSettings1.DataSource = this.InvoiceDataSource;
            dynamicListLookUpSettings1.DisplayMember = "CompanyName";
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "CustomerID";
            this.paramCompany.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupHeader3,
            this.GroupFooter1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.NetPrice,
            this.SubTotal,
            this.calculatedField1,
            this.calculatedField2,
            this.calculatedField3});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.InvoiceDataSource});
            this.DataMember = "Order_Details_Invoice";
            this.DataSource = this.InvoiceDataSource;
            this.DisplayName = "Cross-Band Content";
            this.FilterString = "[CustomerID] In (?paramCompany)";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramCompany});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.GreyTextStyle,
            this.HeaderBoldTextStyle,
            this.TableHeaderStyle,
            this.DetailTableCellStyle,
            this.TotalCellStyle,
            this.InvoiceHeaderBoldStyle,
            this.InvoiceHeaderDetailStyle,
            this.TitleStyle});
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableRow tableRow13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableRow tableRow16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableRow tableRow17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableRow tableRow18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableRow tableRow19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableRow tableRow20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableRow tableRow21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableRow tableRow22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableRow tableRow9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableRow tableRow10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableRow tableRow11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableRow tableRow12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableRow tableRow6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableRow tableRow27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.XRTableRow tableRow28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableRow tableRow29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell26;
        private DevExpress.XtraReports.UI.XRTableRow tableRow30;
        private DevExpress.XtraReports.UI.XRTableCell tableCell27;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
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
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox3;
        private DevExpress.XtraReports.UI.XRTable table9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow32;
        private DevExpress.XtraReports.UI.XRTableCell tableCell53;
        private DevExpress.XtraReports.UI.XRTableRow tableRow33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell54;
        private DevExpress.DataAccess.Sql.SqlDataSource InvoiceDataSource;
        private DevExpress.XtraReports.UI.XRControlStyle GreyTextStyle;
        private DevExpress.XtraReports.UI.XRControlStyle HeaderBoldTextStyle;
        private DevExpress.XtraReports.UI.XRControlStyle TableHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle DetailTableCellStyle;
        private DevExpress.XtraReports.UI.XRControlStyle TotalCellStyle;
        private DevExpress.XtraReports.UI.XRControlStyle InvoiceHeaderBoldStyle;
        private DevExpress.XtraReports.UI.XRControlStyle InvoiceHeaderDetailStyle;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraReports.UI.CalculatedField NetPrice;
        private DevExpress.XtraReports.UI.CalculatedField SubTotal;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField2;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField3;
        private DevExpress.XtraReports.Parameters.Parameter paramCompany;
    }
}
