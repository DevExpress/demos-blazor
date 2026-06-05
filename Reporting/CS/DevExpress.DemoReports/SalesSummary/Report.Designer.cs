using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.SalesSummary {
    public partial class Report {
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("Salesperson filter", true);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("Category filter", true);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.crossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell10 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell11 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell12 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell13 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell14 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell15 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell16 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell17 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell18 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabCell19 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.country = new DevExpress.XtraReports.Parameters.Parameter();
            this.salespeople = new DevExpress.XtraReports.Parameters.Parameter();
            this.enableFilter = new DevExpress.XtraReports.Parameters.Parameter();
            this.categories = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTab1});
            this.Detail.HeightF = 113F;
            this.Detail.Name = "Detail";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 94F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // crossTab1
            // 
            this.crossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabCell1,
            this.crossTabCell2,
            this.crossTabCell3,
            this.crossTabCell4,
            this.crossTabCell5,
            this.crossTabCell6,
            this.crossTabCell7,
            this.crossTabCell8,
            this.crossTabCell9,
            this.crossTabCell10,
            this.crossTabCell11,
            this.crossTabCell12,
            this.crossTabCell13,
            this.crossTabCell14,
            this.crossTabCell15,
            this.crossTabCell16,
            this.crossTabCell17,
            this.crossTabCell18,
            this.crossTabCell19});
            this.crossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(127.5552F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(118.1822F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(130F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(133F)});
            crossTabColumnField1.FieldName = "Country";
            crossTabColumnField2.FieldName = "FullName";
            this.crossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1,
            crossTabColumnField2});
            this.crossTab1.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "ExtendedPrice";
            this.crossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.crossTab1.DataMember = "SalesPerson";
            this.crossTab1.DataSource = this.sqlDataSource1;
            this.crossTab1.FilterString = "[FullName] In (?salespeople) And Iif(?enableFilter, [CategoryName] In (?categorie" +
    "s), True)";
            this.crossTab1.GeneralStyleName = "crossTabGeneralStyle1";
            this.crossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.crossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.crossTab1.Name = "crossTab1";
            this.crossTab1.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("enableFilter", this.enableFilter),
            new DevExpress.XtraReports.UI.XRControlParameter("categories", this.categories),
            new DevExpress.XtraReports.UI.XRControlParameter("salespeople", this.salespeople)});
            this.crossTab1.PrintOptions.PrintTotalsForSingleValues = false;
            this.crossTab1.PrintOptions.RepeatColumnHeaders = false;
            this.crossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(22.6F)});
            crossTabRowField1.FieldName = "OrderDate";
            crossTabRowField1.GroupInterval = DevExpress.XtraReports.UI.CrossTab.GroupInterval.DateQuarter;
            crossTabRowField2.FieldName = "CategoryName";
            this.crossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1,
            crossTabRowField2});
            this.crossTab1.SizeF = new System.Drawing.SizeF(641.7374F, 113F);
            this.crossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabCell1
            // 
            this.crossTabCell1.ColumnIndex = 0;
            this.crossTabCell1.Name = "crossTabCell1";
            this.crossTabCell1.RowIndex = 0;
            this.crossTabCell1.RowSpan = 2;
            this.crossTabCell1.Text = "Order Date";
            this.crossTabCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell2
            // 
            this.crossTabCell2.ColumnIndex = 2;
            this.crossTabCell2.Name = "crossTabCell2";
            this.crossTabCell2.RowIndex = 2;
            this.crossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell2.TextFormatString = "{0:c}";
            // 
            // crossTabCell3
            // 
            this.crossTabCell3.ColumnIndex = 2;
            this.crossTabCell3.Name = "crossTabCell3";
            this.crossTabCell3.RowIndex = 0;
            this.crossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell4
            // 
            this.crossTabCell4.ColumnIndex = 4;
            this.crossTabCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ColumnVisible", "not ?enableFilter")});
            this.crossTabCell4.Name = "crossTabCell4";
            this.crossTabCell4.RowIndex = 0;
            this.crossTabCell4.RowSpan = 2;
            this.crossTabCell4.Text = "Grand Total";
            this.crossTabCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell5
            // 
            this.crossTabCell5.ColumnIndex = 4;
            this.crossTabCell5.Name = "crossTabCell5";
            this.crossTabCell5.RowIndex = 2;
            this.crossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell5.TextFormatString = "{0:c}";
            // 
            // crossTabCell6
            // 
            this.crossTabCell6.ColumnIndex = 0;
            this.crossTabCell6.Name = "crossTabCell6";
            this.crossTabCell6.RowIndex = 2;
            this.crossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.crossTabCell6.TextFormatString = "Quarter {0}";
            // 
            // crossTabCell7
            // 
            this.crossTabCell7.ColumnIndex = 0;
            this.crossTabCell7.ColumnSpan = 2;
            this.crossTabCell7.Name = "crossTabCell7";
            this.crossTabCell7.RowIndex = 4;
            this.crossTabCell7.Text = "Grand Total";
            this.crossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell8
            // 
            this.crossTabCell8.ColumnIndex = 2;
            this.crossTabCell8.Name = "crossTabCell8";
            this.crossTabCell8.RowIndex = 4;
            this.crossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell8.TextFormatString = "{0:c}";
            // 
            // crossTabCell9
            // 
            this.crossTabCell9.ColumnIndex = 4;
            this.crossTabCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "RowVisible", "not ?enableFilter")});
            this.crossTabCell9.Name = "crossTabCell9";
            this.crossTabCell9.RowIndex = 4;
            this.crossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell9.TextFormatString = "{0:c}";
            // 
            // crossTabCell10
            // 
            this.crossTabCell10.ColumnIndex = 2;
            this.crossTabCell10.Name = "crossTabCell10";
            this.crossTabCell10.RowIndex = 1;
            this.crossTabCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell11
            // 
            this.crossTabCell11.ColumnIndex = 3;
            this.crossTabCell11.Name = "crossTabCell11";
            this.crossTabCell11.RowIndex = 0;
            this.crossTabCell11.RowSpan = 2;
            this.crossTabCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.crossTabCell11.TextFormatString = "Total {0}";
            // 
            // crossTabCell12
            // 
            this.crossTabCell12.BackColor = System.Drawing.Color.White;
            this.crossTabCell12.ColumnIndex = 3;
            this.crossTabCell12.Font = new DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabCell12.Name = "crossTabCell12";
            this.crossTabCell12.RowIndex = 2;
            this.crossTabCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell12.TextFormatString = "{0:c}";
            // 
            // crossTabCell13
            // 
            this.crossTabCell13.ColumnIndex = 3;
            this.crossTabCell13.Name = "crossTabCell13";
            this.crossTabCell13.RowIndex = 4;
            this.crossTabCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell13.TextFormatString = "{0:c}";
            // 
            // crossTabCell14
            // 
            this.crossTabCell14.ColumnIndex = 1;
            this.crossTabCell14.Name = "crossTabCell14";
            this.crossTabCell14.RowIndex = 0;
            this.crossTabCell14.RowSpan = 2;
            this.crossTabCell14.Text = "Category Name";
            this.crossTabCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell15
            // 
            this.crossTabCell15.ColumnIndex = 1;
            this.crossTabCell15.Name = "crossTabCell15";
            this.crossTabCell15.RowIndex = 2;
            this.crossTabCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabCell16
            // 
            this.crossTabCell16.ColumnIndex = 0;
            this.crossTabCell16.ColumnSpan = 2;
            this.crossTabCell16.Name = "crossTabCell16";
            this.crossTabCell16.RowIndex = 3;
            this.crossTabCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.crossTabCell16.TextFormatString = "Total {0}";
            // 
            // crossTabCell17
            // 
            this.crossTabCell17.BackColor = System.Drawing.Color.White;
            this.crossTabCell17.ColumnIndex = 2;
            this.crossTabCell17.Font = new DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabCell17.Name = "crossTabCell17";
            this.crossTabCell17.RowIndex = 3;
            this.crossTabCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell17.TextFormatString = "{0:c}";
            // 
            // crossTabCell18
            // 
            this.crossTabCell18.BackColor = System.Drawing.Color.White;
            this.crossTabCell18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabCell18.BorderWidth = 1F;
            this.crossTabCell18.ColumnIndex = 3;
            this.crossTabCell18.Font = new DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabCell18.Name = "crossTabCell18";
            this.crossTabCell18.RowIndex = 3;
            this.crossTabCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell18.TextFormatString = "{0:c}";
            // 
            // crossTabCell19
            // 
            this.crossTabCell19.ColumnIndex = 4;
            this.crossTabCell19.Name = "crossTabCell19";
            this.crossTabCell19.RowIndex = 3;
            this.crossTabCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.crossTabCell19.TextFormatString = "{0:c}";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NWindConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "OrderID";
            table1.Name = "SalesPerson";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Country";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "FirstName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "LastName";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "ProductName";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "CategoryName";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "OrderDate";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "UnitPrice";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Quantity";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Discount";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "ExtendedPrice";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "FullName";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
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
            selectQuery1.Name = "SalesPerson";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(382.3333F, 38.3333F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(156.25F, 31.25F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xrPictureBox1.UseImageResolution = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(771.861F, 10.00002F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(118.1389F, 24.63888F);
            this.xrPageInfo1.StylePriority.UseBorders = false;
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            this.xrPageInfo1.StylePriority.UsePadding = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo1.TextFormatString = "Page : {0 } / {1}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Calibri", 21.75F);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(280.1805F, 36.47224F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(324F, 42F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "Sales Summary by Year";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.Font = new DevExpress.Drawing.DXFont("Calibri", 9F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.crossTabHeaderStyle1.Font = new DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.crossTabTotalStyle1.Font = new DevExpress.Drawing.DXFont("Calibri", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // country
            // 
            this.country.Description = "Country";
            this.country.MultiValue = true;
            this.country.Name = "country";
            this.country.SelectAllValues = true;
            this.country.ValueInfo = "USA|UK";
            dynamicListLookUpSettings3.DataMember = "SalesPerson";
            dynamicListLookUpSettings3.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings3.DisplayMember = "Country";
            dynamicListLookUpSettings3.ValueMember = "Country";
            this.country.ValueSourceSettings = dynamicListLookUpSettings3;
            // 
            // salespeople
            // 
            this.salespeople.Description = "Salespeople";
            this.salespeople.MultiValue = true;
            this.salespeople.Name = "salespeople";
            this.salespeople.SelectAllValues = true;
            this.salespeople.ValueInfo = "Nancy Davolio|Andrew Fuller|Janet Leverling|Margaret Peacock|Steven Buchanan|Mich" +
    "ael Suyama|Robert King|Laura Callahan|Anne Dodsworth";
            dynamicListLookUpSettings2.DataMember = "SalesPerson";
            dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings2.DisplayMember = "FullName";
            dynamicListLookUpSettings2.FilterString = "[Country] In (?country)";
            dynamicListLookUpSettings2.ValueMember = "FullName";
            this.salespeople.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // enableFilter
            // 
            this.enableFilter.Description = "Enable filter";
            this.enableFilter.Name = "enableFilter";
            this.enableFilter.Type = typeof(bool);
            this.enableFilter.ValueInfo = "False";
            // 
            // categories
            // 
            this.categories.Description = "Categories";
            this.categories.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Enabled", "?enableFilter")});
            this.categories.MultiValue = true;
            this.categories.Name = "categories";
            this.categories.SelectAllValues = true;
            this.categories.ValueInfo = "Beverages|Condiments|Confections|Dairy Products|Grains/Cereals|Meat/Poultry|Produ" +
    "ce|Seafood";
            dynamicListLookUpSettings1.DataMember = "SalesPerson";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "CategoryName";
            dynamicListLookUpSettings1.ValueMember = "CategoryName";
            this.categories.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DisplayName = "Sales Summary";
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 100F, 94F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            groupLayoutItem1.Items.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.country, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.salespeople, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            groupLayoutItem1.Title = "Salesperson filter";
            groupLayoutItem2.Items.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.enableFilter, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.categories, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            groupLayoutItem2.Orientation = DevExpress.XtraReports.Parameters.Orientation.Horizontal;
            groupLayoutItem2.Title = "Category filter";
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            groupLayoutItem1,
            groupLayoutItem2});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.country,
            this.salespeople,
            this.enableFilter,
            this.categories});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.Version = "25.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.crossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab crossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell9;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell10;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell11;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell12;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell13;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell14;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell15;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell16;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell17;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell18;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabCell19;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter enableFilter;
        private DevExpress.XtraReports.Parameters.Parameter categories;
        private DevExpress.XtraReports.Parameters.Parameter salespeople;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.Parameters.Parameter country;
    }
}
