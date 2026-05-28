namespace XtraReportsDemos.Charts {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Group group1 = new DevExpress.DataAccess.Sql.Group();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Group group2 = new DevExpress.DataAccess.Sql.Group();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table9 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join6 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.DataAccess.Json.CustomJsonSource customJsonSource1 = new DevExpress.DataAccess.Json.CustomJsonSource();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode1 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode2 = new DevExpress.DataAccess.Json.JsonSchemaNode("CategoryId", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode3 = new DevExpress.DataAccess.Json.JsonSchemaNode("CategoryName", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.DataFederation.SelectNode selectNode1 = new DevExpress.DataAccess.DataFederation.SelectNode();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode1 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.Source source1 = new DevExpress.DataAccess.DataFederation.Source();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode2 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.Source source2 = new DevExpress.DataAccess.DataFederation.Source();
            DevExpress.DataAccess.DataFederation.JoinElement joinElement1 = new DevExpress.DataAccess.DataFederation.JoinElement();
            DevExpress.DataAccess.DataFederation.SelectNode selectNode2 = new DevExpress.DataAccess.DataFederation.SelectNode();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode3 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode4 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.Source source3 = new DevExpress.DataAccess.DataFederation.Source();
            DevExpress.DataAccess.DataFederation.JoinElement joinElement2 = new DevExpress.DataAccess.DataFederation.JoinElement();
            DevExpress.DataAccess.DataFederation.SelectNode selectNode3 = new DevExpress.DataAccess.DataFederation.SelectNode();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode5 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.Source source4 = new DevExpress.DataAccess.DataFederation.Source();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel1 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel2 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel3 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel4 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel5 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel6 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel7 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel8 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel9 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel10 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel11 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel12 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel13 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel14 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel15 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel16 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel17 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel18 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel19 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel20 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView2 = new DevExpress.XtraCharts.DoughnutSeriesView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.federationDataSource1 = new DevExpress.DataAccess.DataFederation.FederationDataSource();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.CurrentYear = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrChart3 = new DevExpress.XtraReports.UI.XRChart();
            this.xrChart2 = new DevExpress.XtraReports.UI.XRChart();
            this.xrChart4 = new DevExpress.XtraReports.UI.XRChart();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Year = new DevExpress.XtraReports.UI.CalculatedField();
            this.Month = new DevExpress.XtraReports.UI.CalculatedField();
            this.Quarter = new DevExpress.XtraReports.UI.CalculatedField();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.VerticalDetail = new DevExpress.XtraReports.UI.VerticalDetailBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrChart6 = new DevExpress.XtraReports.UI.XRChart();
            this.ReportHeader1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Totals = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.federationDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DevAvConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            column1.Alias = "ProductName";
            columnExpression1.ColumnName = "Name";
            table1.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"443\" />";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "CategoryId";
            columnExpression2.ColumnName = "Category";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "OrderDate";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"443\" />";
            table2.Name = "Orders";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "ProductUnits";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"203\" />";
            table3.Name = "OrderItems";
            columnExpression4.Table = table3;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Total";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "Orders";
            relationColumnInfo1.NestedKeyColumn = "Id";
            relationColumnInfo1.ParentKeyColumn = "OrderId";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table3;
            relationColumnInfo2.NestedKeyColumn = "Id";
            relationColumnInfo2.ParentKeyColumn = "ProductId";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table1;
            join2.Parent = table3;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table1);
            column6.Alias = "CategoryId";
            columnExpression6.ColumnName = "Category";
            table4.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"443\" />";
            table4.Name = "Products";
            columnExpression6.Table = table4;
            column6.Expression = columnExpression6;
            column7.Alias = "Sales";
            columnExpression7.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression7.ColumnName = "Total";
            table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"203\" />";
            table5.Name = "OrderItems";
            columnExpression7.Table = table5;
            column7.Expression = columnExpression7;
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.FilterString = "GetDate([Orders.OrderDate]) >= ?Start And GetDate([OrderItems.Id]) < ?End";
            selectQuery2.GroupFilterString = "";
            columnExpression8.ColumnName = "Category";
            columnExpression8.Table = table4;
            group1.Expression = columnExpression8;
            selectQuery2.Groups.Add(group1);
            selectQuery2.Name = "SalesByCategory";
            queryParameter1.Name = "Start";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?CurrentYear", typeof(System.DateTime));
            queryParameter2.Name = "End";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("AddYears(?CurrentYear, 1)", typeof(System.DateTime));
            selectQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            relationColumnInfo3.NestedKeyColumn = "Id";
            relationColumnInfo3.ParentKeyColumn = "OrderId";
            join3.KeyColumns.Add(relationColumnInfo3);
            table6.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"443\" />";
            table6.Name = "Orders";
            join3.Nested = table6;
            join3.Parent = table5;
            relationColumnInfo4.NestedKeyColumn = "Id";
            relationColumnInfo4.ParentKeyColumn = "ProductId";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table4;
            join4.Parent = table5;
            selectQuery2.Relations.Add(join3);
            selectQuery2.Relations.Add(join4);
            selectQuery2.Tables.Add(table5);
            selectQuery2.Tables.Add(table6);
            selectQuery2.Tables.Add(table4);
            column8.Alias = "ProductName";
            columnExpression9.ColumnName = "Name";
            table7.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"443\" />";
            table7.Name = "Products";
            columnExpression9.Table = table7;
            column8.Expression = columnExpression9;
            column9.Alias = "SalesCount";
            columnExpression10.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression10.ColumnName = "ProductUnits";
            table8.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"203\" />";
            table8.Name = "OrderItems";
            columnExpression10.Table = table8;
            column9.Expression = columnExpression10;
            column10.Alias = "SalesTotal";
            columnExpression11.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression11.ColumnName = "Total";
            columnExpression11.Table = table8;
            column10.Expression = columnExpression11;
            selectQuery3.Columns.Add(column8);
            selectQuery3.Columns.Add(column9);
            selectQuery3.Columns.Add(column10);
            selectQuery3.FilterString = "GetDate([Orders.OrderDate]) >= ?Start And GetDate([Orders.OrderDate]) < ?End";
            selectQuery3.GroupFilterString = "";
            columnExpression12.ColumnName = "Name";
            columnExpression12.Table = table7;
            group2.Expression = columnExpression12;
            selectQuery3.Groups.Add(group2);
            selectQuery3.Name = "BestSellingProducts";
            queryParameter3.Name = "Start";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?CurrentYear", typeof(System.DateTime));
            queryParameter4.Name = "End";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("AddYears(?CurrentYear, 1)", typeof(System.DateTime));
            selectQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter3,
            queryParameter4});
            relationColumnInfo5.NestedKeyColumn = "Id";
            relationColumnInfo5.ParentKeyColumn = "OrderId";
            join5.KeyColumns.Add(relationColumnInfo5);
            table9.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"443\" />";
            table9.Name = "Orders";
            join5.Nested = table9;
            join5.Parent = table8;
            relationColumnInfo6.NestedKeyColumn = "Id";
            relationColumnInfo6.ParentKeyColumn = "ProductId";
            join6.KeyColumns.Add(relationColumnInfo6);
            join6.Nested = table7;
            join6.Parent = table8;
            selectQuery3.Relations.Add(join5);
            selectQuery3.Relations.Add(join6);
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending;
            columnExpression13.Aggregate = DevExpress.DataAccess.Sql.AggregationType.Sum;
            columnExpression13.ColumnName = "Total";
            columnExpression13.Table = table8;
            sorting1.Expression = columnExpression13;
            selectQuery3.Sorting.Add(sorting1);
            selectQuery3.Tables.Add(table8);
            selectQuery3.Tables.Add(table9);
            selectQuery3.Tables.Add(table7);
            selectQuery3.Top = 10;
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2,
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.ConnectionName = null;
            customJsonSource1.Json = resources.GetString("customJsonSource1.Json");
            this.jsonDataSource1.JsonSource = customJsonSource1;
            this.jsonDataSource1.Name = "jsonDataSource1";
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode2);
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode3);
            this.jsonDataSource1.Schema = jsonSchemaNode1;
            // 
            // federationDataSource1
            // 
            this.federationDataSource1.Name = "federationDataSource1";
            selectNode1.Alias = "Orders";
            sourceNode1.Alias = "Orders";
            source1.DataMember = "Orders";
            source1.DataSource = this.sqlDataSource1;
            source1.Name = "sqlDataSource1_Orders";
            sourceNode1.Source = source1;
            sourceNode2.Alias = "jsonDataSource1";
            source2.DataMember = "";
            source2.DataSource = this.jsonDataSource1;
            source2.Name = "jsonDataSource1";
            sourceNode2.Source = source2;
            selectNode1.Expressions.AddRange(new DevExpress.DataAccess.DataFederation.ISelectExpression[] {
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "ProductName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "CategoryName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "OrderDate"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "ProductUnits"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "Total")});
            selectNode1.Root = sourceNode1;
            joinElement1.Condition = "[[jsonDataSource1\\].[CategoryId\\]] = [[Orders\\].[CategoryId\\]]";
            joinElement1.Node = sourceNode2;
            selectNode1.SubNodes.AddRange(new DevExpress.DataAccess.DataFederation.JoinElement[] {
            joinElement1});
            selectNode2.Alias = "SalesByCategory";
            sourceNode3.Alias = "jsonDataSource1";
            sourceNode3.Source = source2;
            sourceNode4.Alias = "SalesByCategory";
            source3.DataMember = "SalesByCategory";
            source3.DataSource = this.sqlDataSource1;
            source3.Name = "sqlDataSource1_SalesByCategory";
            sourceNode4.Source = source3;
            selectNode2.Expressions.AddRange(new DevExpress.DataAccess.DataFederation.ISelectExpression[] {
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "CategoryName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode4, "Sales")});
            selectNode2.Root = sourceNode4;
            joinElement2.Condition = "[[jsonDataSource1\\].[CategoryId\\]] = [[SalesByCategory\\].[CategoryId\\]]";
            joinElement2.Node = sourceNode3;
            selectNode2.SubNodes.AddRange(new DevExpress.DataAccess.DataFederation.JoinElement[] {
            joinElement2});
            selectNode3.Alias = "BestSellingProducts";
            sourceNode5.Alias = "BestSellingProducts";
            source4.DataMember = "BestSellingProducts";
            source4.DataSource = this.sqlDataSource1;
            source4.Name = "sqlDataSource1_BestSellingProducts";
            sourceNode5.Source = source4;
            selectNode3.Expressions.AddRange(new DevExpress.DataAccess.DataFederation.ISelectExpression[] {
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode5, "ProductName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode5, "SalesCount"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode5, "SalesTotal")});
            selectNode3.Root = sourceNode5;
            this.federationDataSource1.Queries.AddRange(new DevExpress.DataAccess.DataFederation.QueryNode[] {
            selectNode1,
            selectNode2,
            selectNode3});
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.Transparent;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1,
            this.xrChart3,
            this.xrChart2});
            this.Detail.Font = new DevExpress.Drawing.DXFont("Verdana", 9.75F);
            this.Detail.HeightF = 645F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrChart1
            // 
            this.xrChart1.BackColor = System.Drawing.Color.Transparent;
            this.xrChart1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrChart1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrChart1.DataSource = this.federationDataSource1;
            xyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            customAxisLabel1.AxisValueSerializable = "1";
            customAxisLabel1.Name = "JAN";
            customAxisLabel2.AxisValueSerializable = "2";
            customAxisLabel2.Name = "FEB";
            customAxisLabel3.AxisValueSerializable = "3";
            customAxisLabel3.Name = "MAR";
            customAxisLabel4.AxisValueSerializable = "4";
            customAxisLabel4.Name = "APR";
            customAxisLabel5.AxisValueSerializable = "5";
            customAxisLabel5.Name = "MAY";
            customAxisLabel6.AxisValueSerializable = "6";
            customAxisLabel6.Name = "JUN";
            customAxisLabel7.AxisValueSerializable = "7";
            customAxisLabel7.Name = "JUL";
            customAxisLabel8.AxisValueSerializable = "8";
            customAxisLabel8.Name = "AUG";
            customAxisLabel9.AxisValueSerializable = "9";
            customAxisLabel9.Name = "SEP";
            customAxisLabel10.AxisValueSerializable = "10";
            customAxisLabel10.Name = "OCT";
            customAxisLabel11.AxisValueSerializable = "11";
            customAxisLabel11.Name = "NOV";
            customAxisLabel12.AxisValueSerializable = "12";
            customAxisLabel12.Name = "DEC";
            xyDiagram1.AxisX.CustomLabels.AddRange(new DevExpress.XtraCharts.CustomAxisLabel[] {
            customAxisLabel1,
            customAxisLabel2,
            customAxisLabel3,
            customAxisLabel4,
            customAxisLabel5,
            customAxisLabel6,
            customAxisLabel7,
            customAxisLabel8,
            customAxisLabel9,
            customAxisLabel10,
            customAxisLabel11,
            customAxisLabel12});
            xyDiagram1.AxisX.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            xyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            xyDiagram1.AxisY.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            xyDiagram1.AxisY.Label.TextPattern = "{V:n0}";
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram1.DefaultPane.BorderVisible = false;
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.xrChart1.Legend.BackColor = System.Drawing.Color.Transparent;
            this.xrChart1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.xrChart1.Legend.DockTargetName = "Default Pane";
            this.xrChart1.Legend.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 9F);
            this.xrChart1.Legend.HorizontalIndent = 20;
            this.xrChart1.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.Legend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.xrChart1.Legend.TextOffset = 5;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 22, 96F);
            this.xrChart1.PaletteName = "Palette 1";
            this.xrChart1.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230))))), System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(133))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(133))))))}));
            this.xrChart1.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", this.CurrentYear)});
            this.xrChart1.SeriesDataMember = "Orders.Year";
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.xrChart1.SeriesTemplate.ArgumentDataMember = "Orders.Month";
            this.xrChart1.SeriesTemplate.FilterString = "[Orders.OrderDate] >= AddYears(?CurrentYear, -1) And [Orders.OrderDate] < AddYear" +
    "s(?CurrentYear, 1)";
            this.xrChart1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.SeriesTemplate.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])";
            this.xrChart1.SeriesTemplate.SeriesDataMember = "Orders.Year";
            this.xrChart1.SeriesTemplate.ValueDataMembersSerializable = "Orders.Total";
            this.xrChart1.SideBySideBarDistanceFixed = 2;
            this.xrChart1.SizeF = new System.Drawing.SizeF(980F, 365F);
            this.xrChart1.StylePriority.UseBackColor = false;
            this.xrChart1.StylePriority.UseBorderColor = false;
            this.xrChart1.StylePriority.UseBorders = false;
            this.xrChart1.StylePriority.UsePadding = false;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle1.Indent = 0;
            chartTitle1.Text = "Annual Sales Comparison, $";
            chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            chartTitle1.WordWrap = true;
            this.xrChart1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.xrChart1.CustomDrawSeries += new DevExpress.XtraCharts.CustomDrawSeriesEventHandler(this.xrChart_CustomDrawLegendMarker);
            // 
            // CurrentYear
            // 
            this.CurrentYear.Description = "CurrentYear";
            this.CurrentYear.Name = "CurrentYear";
            this.CurrentYear.Type = typeof(System.DateTime);
            this.CurrentYear.Visible = false;
            // 
            // xrChart3
            // 
            this.xrChart3.BackColor = System.Drawing.Color.Transparent;
            this.xrChart3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrChart3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrChart3.DataSource = this.federationDataSource1;
            this.xrChart3.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.xrChart3.Legend.BackColor = System.Drawing.Color.Transparent;
            this.xrChart3.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart3.Legend.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 9F);
            this.xrChart3.Legend.HorizontalIndent = 0;
            this.xrChart3.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            this.xrChart3.Legend.Name = "Default Legend";
            this.xrChart3.Legend.Padding.Bottom = 0;
            this.xrChart3.Legend.Padding.Left = 20;
            this.xrChart3.Legend.Padding.Right = 30;
            this.xrChart3.Legend.Padding.Top = 0;
            this.xrChart3.Legend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.xrChart3.Legend.TextOffset = 5;
            this.xrChart3.Legend.VerticalIndent = 10;
            this.xrChart3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.xrChart3.LocationFloat = new DevExpress.Utils.PointFloat(600F, 395F);
            this.xrChart3.Name = "xrChart3";
            this.xrChart3.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 15, 96F);
            this.xrChart3.PaletteName = "Palette 1";
            this.xrChart3.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197))))), System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(107)))), ((int)(((byte)(132))))), System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(163)))), ((int)(((byte)(140))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(144))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(162)))), ((int)(((byte)(161))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(162)))), ((int)(((byte)(161))))))}));
            this.xrChart3.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", this.CurrentYear)});
            series1.ArgumentDataMember = "Orders.CategoryName";
            series1.FilterString = "[Orders.OrderDate] >= ?CurrentYear And [Orders.OrderDate] < AddYears(?CurrentYear" +
    ", 1)";
            doughnutSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel1.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            doughnutSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            doughnutSeriesLabel1.TextPattern = "{VP:0%}";
            series1.Label = doughnutSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])";
            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([Orders.Total])";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.ValueDataMembersSerializable = "Orders.Total";
            doughnutSeriesView1.HoleRadiusPercent = 45;
            doughnutSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise;
            series1.View = doughnutSeriesView1;
            this.xrChart3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart3.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart3.SeriesTemplate.View = stackedBarSeriesView1;
            this.xrChart3.SizeF = new System.Drawing.SizeF(390F, 240F);
            this.xrChart3.StylePriority.UseBackColor = false;
            this.xrChart3.StylePriority.UseBorderColor = false;
            this.xrChart3.StylePriority.UseBorders = false;
            this.xrChart3.StylePriority.UsePadding = false;
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle2.Indent = 15;
            chartTitle2.Text = "Product Categories";
            chartTitle2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            chartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.xrChart3.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            this.xrChart3.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.xrChart_CustomDrawLegendMarker);
            // 
            // xrChart2
            // 
            this.xrChart2.BackColor = System.Drawing.Color.Transparent;
            this.xrChart2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrChart2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrChart2.DataSource = this.federationDataSource1;
            xyDiagram2.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            customAxisLabel13.AxisValueSerializable = "1";
            customAxisLabel13.Name = "Q1";
            customAxisLabel14.AxisValueSerializable = "2";
            customAxisLabel14.Name = "Q2";
            customAxisLabel15.AxisValueSerializable = "3";
            customAxisLabel15.Name = "Q3";
            customAxisLabel16.AxisValueSerializable = "4";
            customAxisLabel16.Name = "Q4";
            xyDiagram2.AxisX.CustomLabels.AddRange(new DevExpress.XtraCharts.CustomAxisLabel[] {
            customAxisLabel13,
            customAxisLabel14,
            customAxisLabel15,
            customAxisLabel16});
            xyDiagram2.AxisX.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xyDiagram2.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            xyDiagram2.AxisX.Reverse = true;
            xyDiagram2.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisX.Tickmarks.Visible = false;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            xyDiagram2.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            xyDiagram2.AxisY.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xyDiagram2.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            xyDiagram2.AxisY.Label.TextPattern = "{V:n0}";
            xyDiagram2.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram2.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Millions;
            xyDiagram2.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisY.Tickmarks.Visible = false;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram2.DefaultPane.BorderVisible = false;
            xyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram2.DefaultPane.LayoutOptions.Column = 0;
            xyDiagram2.DefaultPane.LayoutOptions.Row = 0;
            xyDiagram2.PaneLayout.Direction = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal;
            xyDiagram2.Rotated = true;
            this.xrChart2.Diagram = xyDiagram2;
            this.xrChart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.xrChart2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.xrChart2.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.xrChart2.Legend.Name = "Default Legend";
            this.xrChart2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 395F);
            this.xrChart2.Name = "xrChart2";
            this.xrChart2.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 22, 96F);
            this.xrChart2.PaletteName = "Palette 1";
            this.xrChart2.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197))))), System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(107)))), ((int)(((byte)(132))))), System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(163)))), ((int)(((byte)(140))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(144))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(162)))), ((int)(((byte)(161))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(162)))), ((int)(((byte)(161))))))}));
            this.xrChart2.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", this.CurrentYear)});
            this.xrChart2.SeriesDataMember = "Orders.CategoryName";
            this.xrChart2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.xrChart2.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.xrChart2.SeriesTemplate.ArgumentDataMember = "Orders.Quarter";
            this.xrChart2.SeriesTemplate.FilterString = "[Orders.OrderDate] >= ?CurrentYear And [Orders.OrderDate] < AddYears(?CurrentYear" +
    ", 1)";
            this.xrChart2.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart2.SeriesTemplate.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])";
            this.xrChart2.SeriesTemplate.SeriesDataMember = "Orders.CategoryName";
            this.xrChart2.SeriesTemplate.ValueDataMembersSerializable = "Orders.Total";
            this.xrChart2.SeriesTemplate.View = stackedBarSeriesView2;
            this.xrChart2.SizeF = new System.Drawing.SizeF(570F, 240F);
            this.xrChart2.StylePriority.UseBackColor = false;
            this.xrChart2.StylePriority.UseBorderColor = false;
            this.xrChart2.StylePriority.UseBorders = false;
            this.xrChart2.StylePriority.UsePadding = false;
            chartTitle3.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle3.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle3.Indent = 15;
            chartTitle3.Text = "Quarterly Sales Distribution, $";
            chartTitle3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.xrChart2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // xrChart4
            // 
            this.xrChart4.BackColor = System.Drawing.Color.Transparent;
            this.xrChart4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrChart4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrChart4.DataSource = this.federationDataSource1;
            xyDiagram3.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            customAxisLabel17.AxisValueSerializable = "1";
            customAxisLabel17.Name = "Q1";
            customAxisLabel18.AxisValueSerializable = "2";
            customAxisLabel18.Name = "Q2";
            customAxisLabel19.AxisValueSerializable = "3";
            customAxisLabel19.Name = "Q3";
            customAxisLabel20.AxisValueSerializable = "4";
            customAxisLabel20.Name = "Q4";
            xyDiagram3.AxisX.CustomLabels.AddRange(new DevExpress.XtraCharts.CustomAxisLabel[] {
            customAxisLabel17,
            customAxisLabel18,
            customAxisLabel19,
            customAxisLabel20});
            xyDiagram3.AxisX.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xyDiagram3.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            xyDiagram3.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram3.AxisX.Tickmarks.Visible = false;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            xyDiagram3.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            xyDiagram3.AxisY.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xyDiagram3.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            xyDiagram3.AxisY.Label.TextPattern = "{V:n0}";
            xyDiagram3.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram3.AxisY.Tickmarks.Visible = false;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram3.DefaultPane.BorderVisible = false;
            xyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram3.DefaultPane.LayoutOptions.Column = 0;
            xyDiagram3.DefaultPane.LayoutOptions.Row = 0;
            xyDiagram3.PaneLayout.Direction = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal;
            this.xrChart4.Diagram = xyDiagram3;
            this.xrChart4.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.xrChart4.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.xrChart4.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart4.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.xrChart4.Legend.Name = "Default Legend";
            this.xrChart4.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart4.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.xrChart4.Name = "xrChart4";
            this.xrChart4.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 32, 96F);
            this.xrChart4.PaletteName = "Palette 1";
            this.xrChart4.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197))))), System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(107)))), ((int)(((byte)(132))))), System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(107)))), ((int)(((byte)(132)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(163)))), ((int)(((byte)(140))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(144))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(162)))), ((int)(((byte)(161))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(162)))), ((int)(((byte)(161))))))}));
            this.xrChart4.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("CurrentYear", this.CurrentYear)});
            this.xrChart4.SeriesDataMember = "Orders.CategoryName";
            this.xrChart4.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.xrChart4.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.xrChart4.SeriesTemplate.ArgumentDataMember = "Orders.Quarter";
            this.xrChart4.SeriesTemplate.FilterString = "[Orders.OrderDate] >= ?CurrentYear And [Orders.OrderDate] < AddYears(?CurrentYear" +
    ", 1)";
            this.xrChart4.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart4.SeriesTemplate.NumericSummaryOptions.SummaryFunction = "SUM([Orders.Total])";
            this.xrChart4.SeriesTemplate.SeriesDataMember = "Orders.CategoryName";
            this.xrChart4.SeriesTemplate.ValueDataMembersSerializable = "Orders.Total";
            this.xrChart4.SeriesTemplate.View = lineSeriesView1;
            this.xrChart4.SizeF = new System.Drawing.SizeF(570F, 405.0001F);
            this.xrChart4.StylePriority.UseBackColor = false;
            this.xrChart4.StylePriority.UseBorderColor = false;
            this.xrChart4.StylePriority.UseBorders = false;
            this.xrChart4.StylePriority.UsePadding = false;
            chartTitle4.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle4.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle4.Indent = 25;
            chartTitle4.Text = "Sales by Product Category, $";
            chartTitle4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.xrChart4.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 55F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.lbTitle});
            this.ReportHeader.HeightF = 98F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:d} - {1:d}\', ?CurrentYear, AddDays(AddMonths(?CurrentYear, 11), " +
                    "30))")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10F, 63F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(570F, 25F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesByCategory].[Totals]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Tahoma", 22F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(600F, 22.99999F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(390.0001F, 40F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel2.TextFormatString = "{0:$#,##0}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(600F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(390F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Total Sales";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // lbTitle
            // 
            this.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GetYear(?CurrentYear)")});
            this.lbTitle.Font = new DevExpress.Drawing.DXFont("Tahoma", 28F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(9.999992F, 0F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(570F, 63F);
            this.lbTitle.StylePriority.UseFont = false;
            this.lbTitle.StylePriority.UseForeColor = false;
            this.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.lbTitle.TextFormatString = "Sales Analysis {0}";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 55F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // Year
            // 
            this.Year.DataMember = "Orders";
            this.Year.Expression = "GetYear([OrderDate])";
            this.Year.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.Year.Name = "Year";
            // 
            // Month
            // 
            this.Month.DataMember = "Orders";
            this.Month.Expression = "GetMonth([OrderDate])";
            this.Month.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.Month.Name = "Month";
            // 
            // Quarter
            // 
            this.Quarter.DataMember = "Orders";
            this.Quarter.Expression = "[Month] / 4 + 1";
            this.Quarter.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.Quarter.Name = "Quarter";
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.VerticalDetail,
            this.ReportHeader1,
            this.ReportFooter});
            this.DetailReport2.DataMember = "SalesByCategory";
            this.DetailReport2.DataSource = this.federationDataSource1;
            this.DetailReport2.Level = 1;
            this.DetailReport2.Name = "DetailReport2";
            // 
            // VerticalDetail
            // 
            this.VerticalDetail.BandLayout = DevExpress.XtraReports.UI.VerticalBandLayout.AcrossThenDown;
            this.VerticalDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrChart6});
            this.VerticalDetail.HeightF = 215F;
            this.VerticalDetail.Name = "VerticalDetail";
            this.VerticalDetail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.VerticalDetail.WidthF = 195F;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Tahoma", 9F);
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(20F, 185F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 12, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(175F, 30F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrChart6
            // 
            this.xrChart6.BackColor = System.Drawing.Color.Transparent;
            this.xrChart6.BorderColor = System.Drawing.Color.Black;
            this.xrChart6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart6.Legend.Name = "Default Legend";
            this.xrChart6.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart6.LocationFloat = new DevExpress.Utils.PointFloat(20F, 0F);
            this.xrChart6.Name = "xrChart6";
            this.xrChart6.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 20, 20, 96F);
            this.xrChart6.PaletteName = "Palette 1";
            this.xrChart6.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197))))), System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240))))), System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240))))))}));
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Series 1";
            doughnutSeriesView2.HoleRadiusPercent = 45;
            doughnutSeriesView2.TotalLabel.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            doughnutSeriesView2.TotalLabel.Visible = true;
            series2.View = doughnutSeriesView2;
            this.xrChart6.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.xrChart6.SizeF = new System.Drawing.SizeF(175F, 185F);
            this.xrChart6.StylePriority.UseBackColor = false;
            this.xrChart6.StylePriority.UsePadding = false;
            this.xrChart6.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrChart6_BeforePrint);
            // 
            // ReportHeader1
            // 
            this.ReportHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
            this.ReportHeader1.HeightF = 75F;
            this.ReportHeader1.Name = "ReportHeader1";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(20F, 35.99999F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(17, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(559.9999F, 26F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Sales by Product Category";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 20F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // Totals
            // 
            this.Totals.DataMember = "SalesByCategory";
            this.Totals.Expression = "Sum([Sales])";
            this.Totals.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.Totals.Name = "Totals";
            // 
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrCrossBandBox1.BorderWidth = 1F;
            this.xrCrossBandBox1.EndBand = this.ReportFooter;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(10F, 19.99997F);
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.ReportHeader1;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(10F, 20F);
            this.xrCrossBandBox1.WidthF = 980F;
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1,
            this.GroupHeader2});
            this.DetailReport1.DataMember = "BestSellingProducts";
            this.DetailReport1.DataSource = this.federationDataSource1;
            this.DetailReport1.Level = 0;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail1.HeightF = 32F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable1
            // 
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Tahoma", 9F);
            this.xrTable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(600.0001F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(390F, 32F);
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseForeColor = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell7});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 11.5D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 2, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 1.4364278092423868D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", ""),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesCount]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 12, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.89468944643182358D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", ""),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesTotal]")});
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 22, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.TextFormatString = "{0:c0}";
            this.xrTableCell7.Weight = 0.89468944643182358D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart4});
            this.GroupHeader1.HeightF = 415.0001F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PrintAcrossBands = true;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrTable2});
            this.GroupHeader2.HeightF = 95F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrLine1.LineWidth = 2F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(600F, 93F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(390F, 2.1F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrTable2
            // 
            this.xrTable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(600F, 10F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(390F, 82.99995F);
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 20.316647656758626D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 22, 15, 8, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Best Selling Products";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 3.2258067021060342D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 11.5D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(22, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "PRODUCT NAME";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 1.4364278092423868D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 12, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "SALES COUNT";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.Weight = 0.89468944643182358D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 22, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "TOTAL";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell6.Weight = 0.89468944643182358D;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.BottomMargin,
            this.ReportHeader,
            this.topMarginBand1,
            this.DetailReport2,
            this.DetailReport1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Year,
            this.Month,
            this.Quarter,
            this.Totals});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.jsonDataSource1,
            this.federationDataSource1});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox1});
            this.DataSource = this.federationDataSource1;
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(50, 50, 55, 55);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CurrentYear});
            this.RequestParameters = false;
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.federationDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.CalculatedField Year;
        private DevExpress.XtraReports.UI.CalculatedField Month;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.DataFederation.FederationDataSource federationDataSource1;
        private DevExpress.XtraReports.UI.XRChart xrChart2;
        private DevExpress.XtraReports.UI.CalculatedField Quarter;
        private DevExpress.XtraReports.UI.XRChart xrChart3;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRChart xrChart4;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.VerticalDetailBand VerticalDetail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRChart xrChart6;
        private DevExpress.XtraReports.UI.CalculatedField Totals;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox1;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.Parameters.Parameter CurrentYear;
    }
}
