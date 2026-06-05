using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.PivotGridAndChart {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        private System.ComponentModel.IContainer components = null;
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedSplineAreaSeriesView stackedSplineAreaSeriesView1 = new DevExpress.XtraCharts.StackedSplineAreaSeriesView();
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrChart = new DevExpress.XtraReports.UI.XRChart();
            this.xrPivotGrid = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pgfSalesPerson = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgfSalesTotal = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgfYear = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgfQuarter = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xpiPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xpbDevExpress = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrlTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader = new DevExpress.XtraReports.UI.XRControlStyle();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.CategoryStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.parameterViewType = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterShowLabels = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterGenerateSeriesFromColumns = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterShowRowGrandTotals = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterShowColumnGrandTotals = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.Transparent;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart,
            this.xrPivotGrid});
            this.Detail.Font = new DevExpress.Drawing.DXFont("Verdana", 9.75F);
            this.Detail.HeightF = 592F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xpiPageCount});
            this.BottomMargin.HeightF = 87F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xpbDevExpress});
            this.topMarginBand1.HeightF = 119F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlTitle});
            this.ReportHeader.HeightF = 48.95833F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrChart
            // 
            this.xrChart.BorderColor = System.Drawing.Color.Black;
            this.xrChart.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart.DataSource = this.xrPivotGrid;
            xyDiagram1.AxisLabelsResolveOverlappingMinIndent = 0;
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.ScaleBreakOptions.SizeInPixels = -1;
            xyDiagram1.AxisX.ScaleBreakOptions.Style = DevExpress.XtraCharts.ScaleBreakStyle.Straight;
            xyDiagram1.AxisX.Title.Text = "Year Quarter";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.Title.Text = "Sales Total";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.xrChart.Diagram = xyDiagram1;
            this.xrChart.ImageType = DevExpress.XtraReports.UI.ChartImageType.Svg;
            this.xrChart.Legend.MaxHorizontalPercentage = 30D;
            this.xrChart.Legend.Name = "Default Legend";
            this.xrChart.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-05F, 217F);
            this.xrChart.Name = "xrChart";
            this.xrChart.SeriesDataMember = "Series";
            this.xrChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.xrChart.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.xrChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.xrChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart.SeriesTemplate.SeriesDataMember = "Series";
            this.xrChart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            stackedSplineAreaSeriesView1.EmptyPointOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            stackedSplineAreaSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            stackedSplineAreaSeriesView1.Transparency = ((byte)(100));
            this.xrChart.SeriesTemplate.View = stackedSplineAreaSeriesView1;
            this.xrChart.SizeF = new System.Drawing.SizeF(919.9999F, 295F);
            // 
            // xrPivotGrid
            // 
            this.xrPivotGrid.Appearance.Cell.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.CustomTotalCell.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.FieldHeader.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.FieldValue.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.FieldValueGrandTotal.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.FieldValueTotal.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.GrandTotalCell.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.Lines.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.Appearance.TotalCell.Font = new DevExpress.Drawing.DXFont("Tahoma", 7.875F);
            this.xrPivotGrid.DataMember = "SalesPerson";
            this.xrPivotGrid.DataSource = this.sqlDataSource1;
            this.xrPivotGrid.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.pgfSalesPerson,
            this.pgfSalesTotal,
            this.pgfYear,
            this.pgfQuarter});
            this.xrPivotGrid.HeaderGroupLineStyleName = "GroupHeader";
            this.xrPivotGrid.LocationFloat = new DevExpress.Utils.PointFloat(1F, 0F);
            this.xrPivotGrid.Name = "xrPivotGrid";
            this.xrPivotGrid.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings;
            this.xrPivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value;
            this.xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = false;
            this.xrPivotGrid.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid.OptionsView.ShowColumnTotals = false;
            this.xrPivotGrid.OptionsView.ShowRowTotals = false;
            this.xrPivotGrid.SizeF = new System.Drawing.SizeF(920F, 215.625F);
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
            selectQuery1.MetaSerializable = "<Meta X=\"380\" Y=\"20\" Width=\"100\" Height=\"280\" />";
            selectQuery1.Name = "SalesPerson";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // pgfSalesPerson
            // 
            this.pgfSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pgfSalesPerson.AreaIndex = 0;
            this.pgfSalesPerson.Caption = "Sales Person";
            this.pgfSalesPerson.FieldName = "FullName";
            this.pgfSalesPerson.Name = "pgfSalesPerson";
            // 
            // pgfSalesTotal
            // 
            this.pgfSalesTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfSalesTotal.AreaIndex = 0;
            this.pgfSalesTotal.Caption = "Sales Total";
            this.pgfSalesTotal.FieldName = "ExtendedPrice";
            this.pgfSalesTotal.Name = "pgfSalesTotal";
            // 
            // pgfYear
            // 
            this.pgfYear.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pgfYear.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pgfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pgfYear.AreaIndex = 0;
            this.pgfYear.Caption = "Year";
            this.pgfYear.FieldName = "OrderDate";
            this.pgfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pgfYear.Name = "pgfYear";
            this.pgfYear.UnboundFieldName = "pgfYear";
            // 
            // pgfQuarter
            // 
            this.pgfQuarter.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pgfQuarter.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pgfQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pgfQuarter.AreaIndex = 1;
            this.pgfQuarter.Caption = "Quarter";
            this.pgfQuarter.FieldName = "OrderDate";
            this.pgfQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.pgfQuarter.Name = "pgfQuarter";
            this.pgfQuarter.UnboundFieldName = "pgfQuarter";
            this.pgfQuarter.Width = 87;
            // 
            // xpiPageCount
            // 
            this.xpiPageCount.Font = new DevExpress.Drawing.DXFont("Arial", 10.25F);
            this.xpiPageCount.LocationFloat = new DevExpress.Utils.PointFloat(412F, 35F);
            this.xpiPageCount.Name = "xpiPageCount";
            this.xpiPageCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xpiPageCount.SizeF = new System.Drawing.SizeF(98F, 17F);
            this.xpiPageCount.StylePriority.UseFont = false;
            this.xpiPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xpiPageCount.TextFormatString = "Page : {0 } / {1}";
            // 
            // xpbDevExpress
            // 
            this.xpbDevExpress.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xpbDevExpress.ImageSource"));
            this.xpbDevExpress.LocationFloat = new DevExpress.Utils.PointFloat(382.875F, 43.875F);
            this.xpbDevExpress.Name = "xpbDevExpress";
            this.xpbDevExpress.NavigateUrl = "https://www.devexpress.com/Products/NET/Reporting/";
            this.xpbDevExpress.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xpbDevExpress.SizeF = new System.Drawing.SizeF(156.25F, 31.25F);
            this.xpbDevExpress.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xpbDevExpress.UseImageResolution = false;
            // 
            // xrlTitle
            // 
            this.xrlTitle.Font = new DevExpress.Drawing.DXFont("Arial", 21.75F);
            this.xrlTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrlTitle.Name = "xrlTitle";
            this.xrlTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlTitle.SizeF = new System.Drawing.SizeF(920F, 48.95833F);
            this.xrlTitle.StylePriority.UseFont = false;
            this.xrlTitle.StylePriority.UseTextAlignment = false;
            this.xrlTitle.Text = "Sales by Person";
            this.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // OddStyle
            // 
            this.OddStyle.BackColor = System.Drawing.Color.Transparent;
            this.OddStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.OddStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.OddStyle.BorderWidth = 1F;
            this.OddStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.OddStyle.ForeColor = System.Drawing.Color.Black;
            this.OddStyle.Name = "OddStyle";
            // 
            // GroupHeader
            // 
            this.GroupHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.GroupHeader.BorderColor = System.Drawing.Color.White;
            this.GroupHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeader.BorderWidth = 1F;
            this.GroupHeader.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.GroupHeader.Name = "GroupHeader";
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.EvenStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.EvenStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.EvenStyle.BorderWidth = 1F;
            this.EvenStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.EvenStyle.ForeColor = System.Drawing.Color.Black;
            this.EvenStyle.Name = "EvenStyle";
            // 
            // CategoryStyle
            // 
            this.CategoryStyle.BackColor = System.Drawing.Color.Transparent;
            this.CategoryStyle.BorderColor = System.Drawing.Color.Black;
            this.CategoryStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CategoryStyle.BorderWidth = 1F;
            this.CategoryStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 14.25F);
            this.CategoryStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.CategoryStyle.Name = "CategoryStyle";
            // 
            // parameterViewType
            // 
            this.parameterViewType.Description = "View Type";
            this.parameterViewType.Name = "parameterViewType";
            this.parameterViewType.Type = typeof(XtraReportsDemos.PivotGridAndChart.ViewTypeFiltered);
            this.parameterViewType.ValueInfo = "StackedSplineArea";
            // 
            // parameterShowLabels
            // 
            this.parameterShowLabels.Description = "Show Labels";
            this.parameterShowLabels.Name = "parameterShowLabels";
            this.parameterShowLabels.Type = typeof(bool);
            this.parameterShowLabels.ValueInfo = "False";
            // 
            // parameterGenerateSeriesFromColumns
            // 
            this.parameterGenerateSeriesFromColumns.Description = "Generate Series from Columns";
            this.parameterGenerateSeriesFromColumns.Name = "parameterGenerateSeriesFromColumns";
            this.parameterGenerateSeriesFromColumns.Type = typeof(bool);
            this.parameterGenerateSeriesFromColumns.ValueInfo = "False";
            // 
            // parameterShowRowGrandTotals
            // 
            this.parameterShowRowGrandTotals.Description = "Show Row Grand Totals";
            this.parameterShowRowGrandTotals.Name = "parameterShowRowGrandTotals";
            this.parameterShowRowGrandTotals.Type = typeof(bool);
            this.parameterShowRowGrandTotals.ValueInfo = "False";
            // 
            // parameterShowColumnGrandTotals
            // 
            this.parameterShowColumnGrandTotals.Description = "Show Column Grand Totals";
            this.parameterShowColumnGrandTotals.Name = "parameterShowColumnGrandTotals";
            this.parameterShowColumnGrandTotals.Type = typeof(bool);
            this.parameterShowColumnGrandTotals.ValueInfo = "False";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DisplayName = "PivotGrid and Chart";
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 78F, 119F, 87F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parameterViewType,
            this.parameterShowLabels,
            this.parameterGenerateSeriesFromColumns,
            this.parameterShowRowGrandTotals,
            this.parameterShowColumnGrandTotals});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.OddStyle,
            this.GroupHeader,
            this.EvenStyle,
            this.CategoryStyle});
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRChart xrChart;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfSalesPerson;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfSalesTotal;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfYear;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfQuarter;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo xpiPageCount;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRPictureBox xpbDevExpress;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrlTitle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle GroupHeader;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle CategoryStyle;
        private DevExpress.XtraReports.Parameters.Parameter parameterViewType;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowLabels;
        private DevExpress.XtraReports.Parameters.Parameter parameterGenerateSeriesFromColumns;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowRowGrandTotals;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowColumnGrandTotals;
    }
}
