using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.PollingReport {
    public partial class PollingReport {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PollingReport));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ResultingLink = new DevExpress.XtraReports.UI.XRLabel();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ghLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.QuestionStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.AnswerOptionStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TextAnswerStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.DescriptionStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.detailBand1.HeightF = 79F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.detailBand1_BeforePrint);
            this.detailBand1.AfterPrint += new System.EventHandler(this.detailBand1_AfterPrint);
            // 
            // xrTable1
            // 
            this.xrTable1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(25.00007F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(599.9999F, 79F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(Contains([AnswerType], \'Check\') Or Contains([AnswerType], \'Radio\'), \'True\', ?" +
                    ")")});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Visible = false;
            this.xrTableRow1.Weight = 0.45569621745500388D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox1});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrCheckBox1.EditOptions.Enabled = true;
            this.xrCheckBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Answer"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Tag", "AnswerType")});
            this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.SizeF = new System.Drawing.SizeF(599.9999F, 22F);
            this.xrCheckBox1.StyleName = "AnswerOptionStyle";
            this.xrCheckBox1.StylePriority.UseBackColor = false;
            this.xrCheckBox1.StylePriority.UseFont = false;
            this.xrCheckBox1.StylePriority.UsePadding = false;
            this.xrCheckBox1.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2});
            this.xrTableRow2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([AnswerType]  == \'RadioText\', \'True\', ?)")});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Visible = false;
            this.xrTableRow2.Weight = 0.49215191445344164D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrLabel2
            // 
            this.xrLabel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.EditOptions.Enabled = true;
            this.xrLabel2.EditOptions.ReadOnly = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(30F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.SizeF = new System.Drawing.SizeF(569.9998F, 22F);
            this.xrLabel2.StyleName = "TextAnswerStyle";
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3});
            this.xrTableRow3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([AnswerType]  == \'Text\' Or [AnswerType]  == \'Number\', \'True\', ?)")});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Visible = false;
            this.xrTableRow3.Weight = 0.49215191259313812D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 1D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.EditOptions.Enabled = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.919209E-05F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.SizeF = new System.Drawing.SizeF(599.9999F, 22.00001F);
            this.xrLabel3.StyleName = "TextAnswerStyle";
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ResultingLink
            // 
            this.ResultingLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ResultingLink.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.ResultingLink.ForeColor = System.Drawing.Color.White;
            this.ResultingLink.LocationFloat = new DevExpress.Utils.PointFloat(475F, 12.50002F);
            this.ResultingLink.Name = "ResultingLink";
            this.ResultingLink.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ResultingLink.SizeF = new System.Drawing.SizeF(150.0006F, 32.50003F);
            this.ResultingLink.StylePriority.UseBackColor = false;
            this.ResultingLink.StylePriority.UseFont = false;
            this.ResultingLink.StylePriority.UseForeColor = false;
            this.ResultingLink.StylePriority.UseTextAlignment = false;
            this.ResultingLink.Text = "Show Results";
            this.ResultingLink.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "|DataDirectory|\\Questions.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "QuestionID";
            fieldInfo1.Type = typeof(int);
            fieldInfo2.Name = "Question";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "Answer";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "AnswerType";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "AnswerID";
            fieldInfo5.Type = typeof(int);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Answers";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ghLabel,
            this.xrLine3});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeader1.HeightF = 57.49673F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // ghLabel
            // 
            this.ghLabel.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.ghLabel.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Question")});
            this.ghLabel.LocationFloat = new DevExpress.Utils.PointFloat(25.00052F, 25.00001F);
            this.ghLabel.Name = "ghLabel";
            this.ghLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ghLabel.SizeF = new System.Drawing.SizeF(600.0001F, 27F);
            this.ghLabel.StyleName = "QuestionStyle";
            this.ghLabel.StylePriority.UseFont = false;
            this.ghLabel.Text = "ghLabel";
            // 
            // xrLine3
            // 
            this.xrLine3.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(650F, 12.49997F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // QuestionStyle
            // 
            this.QuestionStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.QuestionStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.QuestionStyle.Name = "QuestionStyle";
            // 
            // AnswerOptionStyle
            // 
            this.AnswerOptionStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 9F);
            this.AnswerOptionStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.AnswerOptionStyle.Name = "AnswerOptionStyle";
            this.AnswerOptionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TextAnswerStyle
            // 
            this.TextAnswerStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.TextAnswerStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TextAnswerStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 9F);
            this.TextAnswerStyle.ForeColor = System.Drawing.Color.Black;
            this.TextAnswerStyle.Name = "TextAnswerStyle";
            this.TextAnswerStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.TextAnswerStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel4,
            this.xrLabel1});
            this.ReportHeader.HeightF = 96.78207F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLine1
            // 
            this.xrLine1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 2F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(24.99975F, 58F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(600.0002F, 24.99998F);
            this.xrLabel4.StyleName = "DescriptionStyle";
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Please take some time to fill in the following questionnaire. ";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25.00052F, 25.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(600F, 33F);
            this.xrLabel1.StyleName = "TitleStyle";
            this.xrLabel1.Text = "An analysis of the use of multimedia";
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 18F);
            this.TitleStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.TitleStyle.Name = "TitleStyle";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ResultingLink});
            this.ReportFooter.HeightF = 45.00005F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // DescriptionStyle
            // 
            this.DescriptionStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            this.DescriptionStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.DescriptionStyle.Name = "DescriptionStyle";
            this.DescriptionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PollingReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.GroupHeader1,
            this.ReportHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.excelDataSource1});
            this.DataSource = this.excelDataSource1;
            this.SnappingMode = ((DevExpress.XtraReports.UI.SnappingMode)((DevExpress.XtraReports.UI.SnappingMode.SnapLines | DevExpress.XtraReports.UI.SnappingMode.SnapToGrid)));
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.QuestionStyle,
            this.AnswerOptionStyle,
            this.TextAnswerStyle,
            this.TitleStyle,
            this.DescriptionStyle});
            this.Version = "17.2";
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.PollingReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel ghLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel ResultingLink;
        private DevExpress.XtraReports.UI.XRControlStyle QuestionStyle;
        private DevExpress.XtraReports.UI.XRControlStyle AnswerOptionStyle;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRControlStyle TextAnswerStyle;
        private DevExpress.XtraReports.UI.XRControlStyle DescriptionStyle;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
    }
}
