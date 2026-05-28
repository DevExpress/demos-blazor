using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.MailMerge {
    public partial class Report {
        
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.richText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.richText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.pictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.richText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.pictureBox6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.pictureBox5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.richText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.pictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.dsEmployees1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.AddressWithoutLineBreaks = new DevExpress.XtraReports.UI.CalculatedField();
            this.DateTimeNow = new DevExpress.XtraReports.UI.CalculatedField();
            this.DateTimeNowPlus = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.Detail.HeightF = 482.3591F;
            this.Detail.HierarchyPrintOptions.Indent = 20.83333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1});
            this.topMarginBand1.HeightF = 312F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.bottomMarginBand1.HeightF = 185.4167F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(80.21F, 80F);
            this.table1.Name = "table1";
            this.table1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2,
            this.tableRow3,
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(686.926F, 401.8591F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 3.44011334402534D;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5,
            this.tableCell6});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 0.80199558555344563D;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 0.8216862566823222D;
            // 
            // tableCell3
            // 
            this.tableCell3.CanGrow = false;
            this.tableCell3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.richText1});
            this.tableCell3.Multiline = true;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.Weight = 2.3493453229186718D;
            // 
            // tableCell4
            // 
            this.tableCell4.CanGrow = false;
            this.tableCell4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.Text = "tableCell4";
            this.tableCell4.Weight = 4.3289421831848438D;
            // 
            // richText1
            // 
            this.richText1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.richText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.richText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.richText1.Name = "richText1";
            this.richText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 16, 0, 0, 100F);
            this.richText1.SerializableRtfString = resources.GetString("richText1.SerializableRtfString");
            this.richText1.SizeF = new System.Drawing.SizeF(241.6527F, 273.0049F);
            this.richText1.StylePriority.UseFont = false;
            this.richText1.StylePriority.UseForeColor = false;
            this.richText1.StylePriority.UsePadding = false;
            // 
            // xrRichText1
            // 
            this.xrRichText1.BackColor = System.Drawing.Color.Transparent;
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.xrRichText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.xrRichText1.KeepTogether = true;
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(445.2733F, 273.0049F);
            this.xrRichText1.StylePriority.UseFont = false;
            this.xrRichText1.StylePriority.UseForeColor = false;
            // 
            // tableCell5
            // 
            this.tableCell5.Multiline = true;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.Weight = 2.3493453229186718D;
            // 
            // tableCell6
            // 
            this.tableCell6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox1});
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.Text = "tableCell6";
            this.tableCell6.Weight = 4.3289421831848438D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft;
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"));
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(445.2733F, 63.64579F);
            // 
            // tableCell1
            // 
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.Weight = 2.3493453229186718D;
            // 
            // tableCell2
            // 
            this.tableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.richText4});
            this.tableCell2.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.tableCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.tableCell2.Multiline = true;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StylePriority.UseFont = false;
            this.tableCell2.StylePriority.UseForeColor = false;
            this.tableCell2.Weight = 4.3289421831848438D;
            // 
            // richText4
            // 
            this.richText4.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.richText4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.richText4.Name = "richText4";
            this.richText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.richText4.SerializableRtfString = resources.GetString("richText4.SerializableRtfString");
            this.richText4.SizeF = new System.Drawing.SizeF(445.2733F, 65.20844F);
            this.richText4.StylePriority.UseFont = false;
            this.richText4.StylePriority.UseForeColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox3});
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(850F, 312F);
            this.panel1.StylePriority.UseBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox3.ImageSource"));
            this.pictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(316.7177F, 56.34468F);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.SizeF = new System.Drawing.SizeF(216.5647F, 199.8106F);
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(78.869F, 0F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4,
            this.tableRow5});
            this.table2.SizeF = new System.Drawing.SizeF(688.2651F, 172.3993F);
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 0.58711817383566267D;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell10,
            this.tableCell8,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13});
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 1.4128818261643372D;
            // 
            // tableCell7
            // 
            this.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.tableCell7.BorderWidth = 2F;
            this.tableCell7.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.tableCell7.Multiline = true;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 8, 100F);
            this.tableCell7.StylePriority.UseBorders = false;
            this.tableCell7.StylePriority.UseBorderWidth = false;
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.StylePriority.UseForeColor = false;
            this.tableCell7.StylePriority.UsePadding = false;
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "Contact us:";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.tableCell7.Weight = 3.8431752877294705D;
            // 
            // tableCell10
            // 
            this.tableCell10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox4});
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableCell10.StylePriority.UsePadding = false;
            this.tableCell10.Weight = 0.14259635080564151D;
            // 
            // tableCell8
            // 
            this.tableCell8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.richText2});
            this.tableCell8.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.tableCell8.Multiline = true;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 16, 0, 100F);
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.StylePriority.UsePadding = false;
            this.tableCell8.Weight = 1.091435821473528D;
            // 
            // tableCell11
            // 
            this.tableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox6,
            this.pictureBox5});
            this.tableCell11.Multiline = true;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Weight = 0.17198881521666767D;
            // 
            // tableCell12
            // 
            this.tableCell12.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.richText3});
            this.tableCell12.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 16, 0, 100F);
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.Weight = 1.1560958709904765D;
            // 
            // tableCell13
            // 
            this.tableCell13.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox2});
            this.tableCell13.Multiline = true;
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.Weight = 1.1560958709904765D;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.pictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox4.ImageSource"));
            this.pictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(0.5790551F, 14.22786F);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.SizeF = new System.Drawing.SizeF(25F, 25F);
            // 
            // richText2
            // 
            this.richText2.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.richText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.richText2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.richText2.Name = "richText2";
            this.richText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 19, 0, 100F);
            this.richText2.SerializableRtfString = resources.GetString("richText2.SerializableRtfString");
            this.richText2.SizeF = new System.Drawing.SizeF(202.0318F, 121.7899F);
            this.richText2.StylePriority.UseForeColor = false;
            this.richText2.StylePriority.UsePadding = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.pictureBox6.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox6.ImageSource"));
            this.pictureBox6.LocationFloat = new DevExpress.Utils.PointFloat(2.473895F, 49.39859F);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.SizeF = new System.Drawing.SizeF(25F, 25F);
            this.pictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.pictureBox5.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox5.ImageSource"));
            this.pictureBox5.LocationFloat = new DevExpress.Utils.PointFloat(2.473895F, 14.22786F);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.SizeF = new System.Drawing.SizeF(25F, 25F);
            this.pictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // richText3
            // 
            this.richText3.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.richText3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.richText3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.richText3.Name = "richText3";
            this.richText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 2, 17, 0, 100F);
            this.richText3.SerializableRtfString = resources.GetString("richText3.SerializableRtfString");
            this.richText3.SizeF = new System.Drawing.SizeF(214.0008F, 121.7899F);
            this.richText3.StylePriority.UseForeColor = false;
            this.richText3.StylePriority.UsePadding = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopRight;
            this.pictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox2.ImageSource"));
            this.pictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 14, 0, 100F);
            this.pictureBox2.SizeF = new System.Drawing.SizeF(214.0008F, 121.7899F);
            this.pictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.pictureBox2.StylePriority.UsePadding = false;
            // 
            // dsEmployees1
            // 
            this.dsEmployees1.ConnectionName = "NWindConnectionString";
            this.dsEmployees1.Name = "dsEmployees1";
            columnExpression1.ColumnName = "Address";
            table3.Alias = "e";
            table3.Name = "Employees";
            columnExpression1.Table = table3;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "BirthDate";
            columnExpression2.Table = table3;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "City";
            columnExpression3.Table = table3;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Country";
            columnExpression4.Table = table3;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "EmployeeID";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "LastName";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "FirstName";
            columnExpression7.Table = table3;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "HireDate";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "HomePhone";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Notes";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "Photo";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "PostalCode";
            columnExpression12.Table = table3;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Extension";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Region";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "ReportsTo";
            columnExpression15.Table = table3;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Title";
            columnExpression16.Table = table3;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "TitleOfCourtesy";
            columnExpression17.Table = table3;
            column17.Expression = columnExpression17;
            column18.Alias = "ReportsToInfo";
            customExpression1.Expression = "Concat([r].[FirstName], \' \', [r].[LastName])";
            column18.Expression = customExpression1;
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
            selectQuery1.Columns.Add(column16);
            selectQuery1.Columns.Add(column17);
            selectQuery1.Columns.Add(column18);
            selectQuery1.Name = "Employees";
            relationColumnInfo1.NestedKeyColumn = "EmployeeID";
            relationColumnInfo1.ParentKeyColumn = "ReportsTo";
            join1.KeyColumns.Add(relationColumnInfo1);
            table4.Alias = "r";
            table4.Name = "Employees";
            join1.Nested = table4;
            join1.Parent = table3;
            join1.SqlJoinType = ((DevExpress.DataAccess.Sql.SqlJoinType)(DevExpress.DataAccess.Sql.SqlJoinType.LeftOuter));
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table4);
            this.dsEmployees1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsEmployees1.ResultSchemaSerializable = resources.GetString("dsEmployees1.ResultSchemaSerializable");
            // 
            // AddressWithoutLineBreaks
            // 
            this.AddressWithoutLineBreaks.DataMember = "Employees";
            this.AddressWithoutLineBreaks.Expression = "Replace([Address], Concat(Char(13), Char(10)), \' \')";
            this.AddressWithoutLineBreaks.Name = "AddressWithoutLineBreaks";
            // 
            // DateTimeNow
            // 
            this.DateTimeNow.DataMember = "Employees";
            this.DateTimeNow.Expression = "Now()";
            this.DateTimeNow.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime;
            this.DateTimeNow.Name = "DateTimeNow";
            // 
            // DateTimeNowPlus
            // 
            this.DateTimeNowPlus.DataMember = "Employees";
            this.DateTimeNowPlus.Expression = "GetYear(AddYears(Now(), 4))";
            this.DateTimeNowPlus.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.DateTimeNowPlus.Name = "DateTimeNowPlus";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.AddressWithoutLineBreaks,
            this.DateTimeNow,
            this.DateTimeNowPlus});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsEmployees1});
            this.DataMember = "Employees";
            this.DataSource = this.dsEmployees1;
            this.DisplayName = "Mail Merge";
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 312F, 185.4167F);
            this.SnapGridSize = 13.02083F;
            this.Version = "25.1";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRRichText richText1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRRichText richText4;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox3;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRRichText richText2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox6;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRRichText richText3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox2;
        private DevExpress.DataAccess.Sql.SqlDataSource dsEmployees1;
        private DevExpress.XtraReports.UI.CalculatedField AddressWithoutLineBreaks;
        private DevExpress.XtraReports.UI.CalculatedField DateTimeNow;
        private DevExpress.XtraReports.UI.CalculatedField DateTimeNowPlus;
    }
}
