namespace XtraReportsDemos.SideBySideReports {
    partial class EmployeeComparisonReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeComparisonReport));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.lbCaption = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.leftSideParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsEmployee1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.rightSideParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2,
            this.xrSubreport1});
            this.Detail.HeightF = 375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbCaption});
            this.ReportHeader.HeightF = 75F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(332F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", this.rightSideParameter));
            this.xrSubreport2.ReportSource = new XtraReportsDemos.SideBySideReports.EmployeeOrdersReport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(318F, 375F);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", this.leftSideParameter));
            this.xrSubreport1.ReportSource = new XtraReportsDemos.SideBySideReports.EmployeeOrdersReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(318F, 375F);
            // 
            // lbCaption
            // 
            this.lbCaption.BackColor = System.Drawing.Color.Transparent;
            this.lbCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCaption.BorderWidth = 2F;
            this.lbCaption.Font = new DevExpress.Drawing.DXFont("Tahoma", 20.25F);
            this.lbCaption.ForeColor = System.Drawing.Color.Black;
            this.lbCaption.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCaption.SizeF = new System.Drawing.SizeF(650F, 50F);
            this.lbCaption.Text = "Employee Comparison";
            this.lbCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(249F, 22F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(156.25F, 31.25F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xrPictureBox4.UseImageResolution = false;
            // 
            // leftSideParameter
            // 
            this.leftSideParameter.Description = "Left Side";
            this.leftSideParameter.Name = "leftSideParameter";
            this.leftSideParameter.Type = typeof(long);
            this.leftSideParameter.ValueInfo = "5";
            dynamicListLookUpSettings2.DataMember = "SimpleEmployees";
            dynamicListLookUpSettings2.DataSource = this.dsEmployee1;
            dynamicListLookUpSettings2.DisplayMember = "FullName";
            dynamicListLookUpSettings2.ValueMember = "EmployeeID";
            this.leftSideParameter.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // dsEmployee1
            // 
            this.dsEmployee1.ConnectionName = "NWindConnectionString";
            this.dsEmployee1.Name = "dsEmployee1";
            columnExpression1.ColumnName = "EmployeeID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"400\" />";
            table1.Name = "Employees";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "FullName";
            customExpression1.Expression = "CONCAT([Employees.FirstName], \' \', [Employees.LastName])";
            column2.Expression = customExpression1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "SimpleEmployees";
            selectQuery1.Tables.Add(table1);
            this.dsEmployee1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsEmployee1.ResultSchemaSerializable = resources.GetString("dsEmployee1.ResultSchemaSerializable");
            // 
            // rightSideParameter
            // 
            this.rightSideParameter.Description = "Right Side";
            this.rightSideParameter.Name = "rightSideParameter";
            this.rightSideParameter.Type = typeof(long);
            this.rightSideParameter.ValueInfo = "9";
            dynamicListLookUpSettings1.DataMember = "SimpleEmployees";
            dynamicListLookUpSettings1.DataSource = this.dsEmployee1;
            dynamicListLookUpSettings1.DisplayMember = "FullName";
            dynamicListLookUpSettings1.FilterString = "[EmployeeID] <> ?leftSideParameter";
            dynamicListLookUpSettings1.ValueMember = "EmployeeID";
            this.rightSideParameter.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // EmployeeComparisonReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsEmployee1});
            this.DisplayName = "Side-by-Side Report";
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 100F, 75F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.leftSideParameter,
            this.rightSideParameter});
            this.RequestParameters = false;
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.Parameters.Parameter rightSideParameter;
        private DevExpress.DataAccess.Sql.SqlDataSource dsEmployee1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.Parameters.Parameter leftSideParameter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbCaption;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
    }
}
