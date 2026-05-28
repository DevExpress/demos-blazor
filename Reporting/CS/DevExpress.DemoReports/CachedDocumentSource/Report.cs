using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CachedDocumentSourceReport {
    public class Report : XtraReport {
        private TopMarginBand topMarginBand1;
        private XRPageInfo xrPageInfo4;
        private XRPageInfo xrPageInfo3;
        private BottomMarginBand bottomMarginBand1;
        private DetailBand detailBand1;
        private XRLabel xrLabel1;
        private XRBarCode xrBarCode1;
        private XRLabel xrLabel4;
        private XRLabel xrLabel5;
        private XRLabel xrLabel6;
        private XRLabel xrLabel7;
        private XRLabel xrLabel8;
        private XRLabel xrLabel9;
        private XRLabel xrLabel10;
        private XRLabel xrLabel11;
        private XRLabel xrLabel12;
        private XRLabel xrLabel13;
        private SubBand SubBand1;
        private XRTable xrTable5;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell18;
        private XRTableCell xrTableCell20;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell24;
        private XRTableCell xrTableCell25;
        private XRTableRow xrTableRow12;
        private XRTableCell xrTableCell26;
        private XRTableCell xrTableCell27;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell21;
        private XRTableCell xrTableCell23;
        private XRTableRow xrTableRow13;
        private XRTableCell xrTableCell28;
        private XRTableCell xrTableCell29;
        private XRLabel xrLabel2;
        private DetailReportBand detailReportBand1;
        private GroupHeaderBand groupHeaderBand1;
        private XRTable xrTable2;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell11;
        private DetailBand detailBand2;
        private XRTable xrTable3;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell15;
        private XRTableCell xrTableCell16;
        private ReportHeaderBand ReportHeader;
        private XRLabel xrLabel3;
        private ReportFooterBand ReportFooter;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell4;
        private XRTableCell xrTableCell5;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private XRControlStyle Title;
        private XRControlStyle ReportTitleCaption;
        private XRControlStyle DetailData3;
        private XRControlStyle DetailData3_Odd;
        private XRControlStyle PageInfo;
        private XRControlStyle Headers;
        private XRControlStyle SummaryTitles;
        private XRControlStyle SummaryValues;
        protected DevExpress.XtraReports.Parameters.Parameter RowCountParameter;
        private System.ComponentModel.IContainer components;

        public Report() {
            InitializeComponent();
            Name = ReportNames.LargeDatasetName;
            DisplayName = ReportNames.LargeDataset;
        }

        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            DevExpress.DataAccess.ObjectBinding.Parameter parameter1 = new DevExpress.DataAccess.ObjectBinding.Parameter();
            topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            detailReportBand1 = new DevExpress.XtraReports.UI.DetailReportBand();
            xrPageInfo4 = new DevExpress.XtraReports.UI.XRPageInfo();
            xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            detailBand2 = new DevExpress.XtraReports.UI.DetailBand();
            ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(components);
            Title = new DevExpress.XtraReports.UI.XRControlStyle();
            ReportTitleCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            Headers = new DevExpress.XtraReports.UI.XRControlStyle();
            SummaryTitles = new DevExpress.XtraReports.UI.XRControlStyle();
            SummaryValues = new DevExpress.XtraReports.UI.XRControlStyle();
            RowCountParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrPageInfo4,
            xrPageInfo3});
            topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrLabel1,
            xrBarCode1,
            xrLabel4,
            xrLabel5,
            xrLabel6,
            xrLabel7,
            xrLabel8,
            xrLabel9,
            xrLabel10,
            xrLabel11,
            xrLabel12,
            xrLabel13});
            detailBand1.HeightF = 197.9167F;
            detailBand1.KeepTogether = true;
            detailBand1.Name = "detailBand1";
            detailBand1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            SubBand1});
            // 
            // detailReportBand1
            // 
            detailReportBand1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            groupHeaderBand1,
            detailBand2,
            ReportHeader,
            ReportFooter});
            detailReportBand1.DataMember = "Adjustments";
            detailReportBand1.DataSource = objectDataSource1;
            detailReportBand1.Level = 0;
            detailReportBand1.Name = "detailReportBand1";
            detailReportBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrPageInfo4
            // 
            xrPageInfo4.LocationFloat = new DevExpress.Utils.PointFloat(461.75F, 38.73147F);
            xrPageInfo4.Name = "xrPageInfo4";
            xrPageInfo4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            xrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            xrPageInfo4.SizeF = new System.Drawing.SizeF(178.875F, 23F);
            xrPageInfo4.StyleName = "PageInfo";
            xrPageInfo4.StylePriority.UseForeColor = false;
            xrPageInfo4.StylePriority.UsePadding = false;
            xrPageInfo4.StylePriority.UseTextAlignment = false;
            xrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrPageInfo4.TextFormatString = "Issued: {0}";
            // 
            // xrPageInfo3
            // 
            xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.73146F);
            xrPageInfo3.Name = "xrPageInfo3";
            xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrPageInfo3.SizeF = new System.Drawing.SizeF(300.2737F, 23F);
            xrPageInfo3.StyleName = "PageInfo";
            xrPageInfo3.StylePriority.UseForeColor = false;
            xrPageInfo3.StylePriority.UsePadding = false;
            xrPageInfo3.StylePriority.UseTextAlignment = false;
            xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrPageInfo3.TextFormatString = "Page {0} of {1} Pages";
            // 
            // xrLabel1
            // 
            xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")});
            xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrLabel1.Name = "xrLabel1";
            xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrLabel1.SizeF = new System.Drawing.SizeF(650F, 50F);
            xrLabel1.StyleName = "ReportTitleCaption";
            xrLabel1.StylePriority.UseFont = false;
            xrLabel1.StylePriority.UseForeColor = false;
            xrLabel1.StylePriority.UsePadding = false;
            xrLabel1.Text = "Paris spécialités";
            // 
            // xrBarCode1
            // 
            xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrBarCode1.AutoModule = true;
            xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address] + NewLine() + [City] + \' , \' + [PostalCode] + NewLine() + [Phone]")});
            xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(514.9792F, 50.18913F);
            xrBarCode1.Module = 4.7F;
            xrBarCode1.Name = "xrBarCode1";
            xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            xrBarCode1.ShowText = false;
            xrBarCode1.SizeF = new System.Drawing.SizeF(135.021F, 124.9819F);
            xrBarCode1.StylePriority.UsePadding = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            xrBarCode1.Symbology = qrCodeGenerator1;
            xrBarCode1.Text = "12, rue des Bouchers\r\nMarseille , 13008\r\n91.24.45.40";
            // 
            // xrLabel4
            // 
            xrLabel4.BackColor = System.Drawing.Color.Transparent;
            xrLabel4.BorderColor = System.Drawing.Color.Transparent;
            xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel4.BorderWidth = 1F;
            xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.41667F);
            xrLabel4.Name = "xrLabel4";
            xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            xrLabel4.SizeF = new System.Drawing.SizeF(163.3871F, 25F);
            xrLabel4.StyleName = "Headers";
            xrLabel4.StylePriority.UseBackColor = false;
            xrLabel4.StylePriority.UseBorderColor = false;
            xrLabel4.StylePriority.UseBorders = false;
            xrLabel4.StylePriority.UseBorderWidth = false;
            xrLabel4.StylePriority.UseFont = false;
            xrLabel4.StylePriority.UseForeColor = false;
            xrLabel4.StylePriority.UsePadding = false;
            xrLabel4.StylePriority.UseTextAlignment = false;
            xrLabel4.Text = "CUSTOMER ACCOUNT:";
            xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            xrLabel5.BackColor = System.Drawing.Color.Transparent;
            xrLabel5.BorderColor = System.Drawing.Color.Transparent;
            xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerAccount]")});
            xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(163.3871F, 60.41667F);
            xrLabel5.Name = "xrLabel5";
            xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrLabel5.SizeF = new System.Drawing.SizeF(127.8075F, 25F);
            xrLabel5.StyleName = "DetailData3";
            xrLabel5.StylePriority.UseBackColor = false;
            xrLabel5.StylePriority.UseBorderColor = false;
            xrLabel5.StylePriority.UseBorders = false;
            xrLabel5.StylePriority.UseFont = false;
            xrLabel5.StylePriority.UseForeColor = false;
            xrLabel5.StylePriority.UsePadding = false;
            xrLabel5.StylePriority.UseTextAlignment = false;
            xrLabel5.Text = "Energy";
            xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            xrLabel6.BackColor = System.Drawing.Color.Transparent;
            xrLabel6.BorderColor = System.Drawing.Color.Transparent;
            xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel6.BorderWidth = 1F;
            xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 89.58334F);
            xrLabel6.Name = "xrLabel6";
            xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            xrLabel6.SizeF = new System.Drawing.SizeF(163.3871F, 25F);
            xrLabel6.StyleName = "Headers";
            xrLabel6.StylePriority.UseBackColor = false;
            xrLabel6.StylePriority.UseBorderColor = false;
            xrLabel6.StylePriority.UseBorders = false;
            xrLabel6.StylePriority.UseBorderWidth = false;
            xrLabel6.StylePriority.UseFont = false;
            xrLabel6.StylePriority.UseForeColor = false;
            xrLabel6.StylePriority.UsePadding = false;
            xrLabel6.StylePriority.UseTextAlignment = false;
            xrLabel6.Text = "CUSTOMER IDENTIFIERS:";
            xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            xrLabel7.BackColor = System.Drawing.Color.Transparent;
            xrLabel7.BorderColor = System.Drawing.Color.Transparent;
            xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerIdentifiers]")});
            xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(163.3871F, 89.58334F);
            xrLabel7.Name = "xrLabel7";
            xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrLabel7.SizeF = new System.Drawing.SizeF(127.8075F, 25F);
            xrLabel7.StyleName = "DetailData3";
            xrLabel7.StylePriority.UseBackColor = false;
            xrLabel7.StylePriority.UseBorderColor = false;
            xrLabel7.StylePriority.UseBorders = false;
            xrLabel7.StylePriority.UseFont = false;
            xrLabel7.StylePriority.UseForeColor = false;
            xrLabel7.StylePriority.UsePadding = false;
            xrLabel7.StylePriority.UseTextAlignment = false;
            xrLabel7.Text = "1273-86";
            xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            xrLabel8.BackColor = System.Drawing.Color.Transparent;
            xrLabel8.BorderColor = System.Drawing.Color.Transparent;
            xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel8.BorderWidth = 1F;
            xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 118.75F);
            xrLabel8.Name = "xrLabel8";
            xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            xrLabel8.SizeF = new System.Drawing.SizeF(163.3871F, 24.99999F);
            xrLabel8.StyleName = "Headers";
            xrLabel8.StylePriority.UseBackColor = false;
            xrLabel8.StylePriority.UseBorderColor = false;
            xrLabel8.StylePriority.UseBorders = false;
            xrLabel8.StylePriority.UseBorderWidth = false;
            xrLabel8.StylePriority.UseFont = false;
            xrLabel8.StylePriority.UseForeColor = false;
            xrLabel8.StylePriority.UsePadding = false;
            xrLabel8.StylePriority.UseTextAlignment = false;
            xrLabel8.Text = "EMAIL:";
            xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            xrLabel9.AutoWidth = true;
            xrLabel9.BackColor = System.Drawing.Color.Transparent;
            xrLabel9.BorderColor = System.Drawing.Color.Transparent;
            xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(163.3871F, 118.75F);
            xrLabel9.Name = "xrLabel9";
            xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrLabel9.SizeF = new System.Drawing.SizeF(127.8075F, 24.99997F);
            xrLabel9.StyleName = "DetailData3";
            xrLabel9.StylePriority.UseBackColor = false;
            xrLabel9.StylePriority.UseBorderColor = false;
            xrLabel9.StylePriority.UseBorders = false;
            xrLabel9.StylePriority.UseFont = false;
            xrLabel9.StylePriority.UseForeColor = false;
            xrLabel9.StylePriority.UsePadding = false;
            xrLabel9.StylePriority.UseTextAlignment = false;
            xrLabel9.Text = "laurence@bon.com";
            xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrLabel9.WordWrap = false;
            // 
            // xrLabel10
            // 
            xrLabel10.BackColor = System.Drawing.Color.Transparent;
            xrLabel10.BorderColor = System.Drawing.Color.Transparent;
            xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel10.CanGrow = false;
            xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")});
            xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(370.0327F, 60.41668F);
            xrLabel10.Name = "xrLabel10";
            xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel10.SizeF = new System.Drawing.SizeF(144.7905F, 25F);
            xrLabel10.StyleName = "DetailData3";
            xrLabel10.StylePriority.UseBackColor = false;
            xrLabel10.StylePriority.UseBorderColor = false;
            xrLabel10.StylePriority.UseBorders = false;
            xrLabel10.StylePriority.UseFont = false;
            xrLabel10.StylePriority.UseForeColor = false;
            xrLabel10.StylePriority.UsePadding = false;
            xrLabel10.StylePriority.UseTextAlignment = false;
            xrLabel10.Text = "12, rue des Bouchers";
            xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrLabel10.WordWrap = false;
            // 
            // xrLabel11
            // 
            xrLabel11.BackColor = System.Drawing.Color.Transparent;
            xrLabel11.BorderColor = System.Drawing.Color.Transparent;
            xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City] + \', \' + [Region] + \' \' + [PostalCode]")});
            xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(302.2708F, 89.58334F);
            xrLabel11.Name = "xrLabel11";
            xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel11.SizeF = new System.Drawing.SizeF(212.5539F, 25F);
            xrLabel11.StyleName = "DetailData3";
            xrLabel11.StylePriority.UseBackColor = false;
            xrLabel11.StylePriority.UseBorderColor = false;
            xrLabel11.StylePriority.UseBorders = false;
            xrLabel11.StylePriority.UseFont = false;
            xrLabel11.StylePriority.UseForeColor = false;
            xrLabel11.StylePriority.UsePadding = false;
            xrLabel11.StylePriority.UseTextAlignment = false;
            xrLabel11.Text = "Marseille,  13008";
            xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel12
            // 
            xrLabel12.BorderColor = System.Drawing.Color.Transparent;
            xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")});
            xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(370.0327F, 118.75F);
            xrLabel12.Name = "xrLabel12";
            xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel12.SizeF = new System.Drawing.SizeF(144.792F, 25.00002F);
            xrLabel12.StyleName = "DetailData3";
            xrLabel12.StylePriority.UseBorderColor = false;
            xrLabel12.StylePriority.UseBorders = false;
            xrLabel12.StylePriority.UseFont = false;
            xrLabel12.StylePriority.UseForeColor = false;
            xrLabel12.StylePriority.UsePadding = false;
            xrLabel12.StylePriority.UseTextAlignment = false;
            xrLabel12.Text = "France";
            xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel13
            // 
            xrLabel13.BackColor = System.Drawing.Color.Transparent;
            xrLabel13.BorderColor = System.Drawing.Color.Transparent;
            xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(370.034F, 147.9167F);
            xrLabel13.Name = "xrLabel13";
            xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLabel13.SizeF = new System.Drawing.SizeF(144.792F, 25F);
            xrLabel13.StyleName = "DetailData3";
            xrLabel13.StylePriority.UseBackColor = false;
            xrLabel13.StylePriority.UseBorderColor = false;
            xrLabel13.StylePriority.UseBorders = false;
            xrLabel13.StylePriority.UseFont = false;
            xrLabel13.StylePriority.UseForeColor = false;
            xrLabel13.StylePriority.UsePadding = false;
            xrLabel13.StylePriority.UseTextAlignment = false;
            xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // SubBand1
            // 
            SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable5,
            xrLabel2});
            SubBand1.HeightF = 226.7708F;
            SubBand1.Name = "SubBand1";
            // 
            // xrTable5
            // 
            xrTable5.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTable5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 48.95833F);
            xrTable5.Name = "xrTable5";
            xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow9,
            xrTableRow11,
            xrTableRow12,
            xrTableRow10,
            xrTableRow13});
            xrTable5.SizeF = new System.Drawing.SizeF(640.625F, 145.8333F);
            xrTable5.StylePriority.UseBorderColor = false;
            xrTable5.StylePriority.UseBorders = false;
            // 
            // xrLabel2
            // 
            xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.083345F);
            xrLabel2.Name = "xrLabel2";
            xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrLabel2.SizeF = new System.Drawing.SizeF(640.625F, 35F);
            xrLabel2.StyleName = "Title";
            xrLabel2.StylePriority.UseBorderColor = false;
            xrLabel2.StylePriority.UseBorders = false;
            xrLabel2.StylePriority.UseFont = false;
            xrLabel2.StylePriority.UseForeColor = false;
            xrLabel2.StylePriority.UsePadding = false;
            xrLabel2.StylePriority.UseTextAlignment = false;
            xrLabel2.Text = "Monthly Billing Invoice Statement";
            xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow9
            // 
            xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell18,
            xrTableCell20});
            xrTableRow9.Name = "xrTableRow9";
            xrTableRow9.Weight = 10.208333833436589D;
            // 
            // xrTableRow11
            // 
            xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell24,
            xrTableCell25});
            xrTableRow11.Name = "xrTableRow11";
            xrTableRow11.Weight = 10.208333401633816D;
            // 
            // xrTableRow12
            // 
            xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell26,
            xrTableCell27});
            xrTableRow12.Name = "xrTableRow12";
            xrTableRow12.Weight = 10.208334312922753D;
            // 
            // xrTableRow10
            // 
            xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell21,
            xrTableCell23});
            xrTableRow10.Name = "xrTableRow10";
            xrTableRow10.Weight = 10.208334312922753D;
            // 
            // xrTableRow13
            // 
            xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell28,
            xrTableCell29});
            xrTableRow13.Name = "xrTableRow13";
            xrTableRow13.Weight = 10.208332922147653D;
            // 
            // xrTableCell18
            // 
            xrTableCell18.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell18.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell18.Multiline = true;
            xrTableCell18.Name = "xrTableCell18";
            xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            xrTableCell18.StyleName = "DetailData3_Odd";
            xrTableCell18.StylePriority.UseFont = false;
            xrTableCell18.StylePriority.UseForeColor = false;
            xrTableCell18.StylePriority.UsePadding = false;
            xrTableCell18.Text = "CONTACT NAME";
            xrTableCell18.Weight = 0.13177048207687855D;
            // 
            // xrTableCell20
            // 
            xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactName]")});
            xrTableCell20.Name = "xrTableCell20";
            xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            xrTableCell20.StyleName = "DetailData3_Odd";
            xrTableCell20.StylePriority.UsePadding = false;
            xrTableCell20.Text = "Laurence Lebihan";
            xrTableCell20.Weight = 0.31267396236756584D;
            // 
            // xrTableCell24
            // 
            xrTableCell24.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTableCell24.Name = "xrTableCell24";
            xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            xrTableCell24.StyleName = "Headers";
            xrTableCell24.StylePriority.UseBackColor = false;
            xrTableCell24.StylePriority.UseBorderColor = false;
            xrTableCell24.StylePriority.UseBorders = false;
            xrTableCell24.StylePriority.UseFont = false;
            xrTableCell24.StylePriority.UseForeColor = false;
            xrTableCell24.StylePriority.UsePadding = false;
            xrTableCell24.Text = "CONTACT TITLE";
            xrTableCell24.Weight = 0.13177048207687855D;
            // 
            // xrTableCell25
            // 
            xrTableCell25.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContactTitle]")});
            xrTableCell25.Name = "xrTableCell25";
            xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            xrTableCell25.StyleName = "DetailData3";
            xrTableCell25.StylePriority.UseBorderColor = false;
            xrTableCell25.StylePriority.UseBorders = false;
            xrTableCell25.StylePriority.UsePadding = false;
            xrTableCell25.Text = "Owner";
            xrTableCell25.Weight = 0.31267396236756584D;
            // 
            // xrTableCell26
            // 
            xrTableCell26.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell26.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell26.Name = "xrTableCell26";
            xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            xrTableCell26.StyleName = "DetailData3_Odd";
            xrTableCell26.StylePriority.UseFont = false;
            xrTableCell26.StylePriority.UseForeColor = false;
            xrTableCell26.StylePriority.UsePadding = false;
            xrTableCell26.Text = "BILLING STATEMENT DATE";
            xrTableCell26.Weight = 0.13177048207687855D;
            // 
            // xrTableCell27
            // 
            xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillingDate]")});
            xrTableCell27.Name = "xrTableCell27";
            xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            xrTableCell27.StyleName = "DetailData3_Odd";
            xrTableCell27.StylePriority.UsePadding = false;
            xrTableCell27.Text = "9/5/2018";
            xrTableCell27.TextFormatString = "{0:M/d/yyyy}";
            xrTableCell27.Weight = 0.31267396236756584D;
            // 
            // xrTableCell21
            // 
            xrTableCell21.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTableCell21.Name = "xrTableCell21";
            xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            xrTableCell21.StyleName = "Headers";
            xrTableCell21.StylePriority.UseBackColor = false;
            xrTableCell21.StylePriority.UseBorderColor = false;
            xrTableCell21.StylePriority.UseBorders = false;
            xrTableCell21.StylePriority.UseFont = false;
            xrTableCell21.StylePriority.UseForeColor = false;
            xrTableCell21.StylePriority.UsePadding = false;
            xrTableCell21.Text = "BILLING PERIOD";
            xrTableCell21.Weight = 0.13177048207687855D;
            // 
            // xrTableCell23
            // 
            xrTableCell23.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:M/d/yyyy}\',[BillingPeriodStart] ) + \' To \' + FormatString(\'{0:M/" +
                    "d/yyyy}\',[BillingPeriodEnd])")});
            xrTableCell23.Name = "xrTableCell23";
            xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            xrTableCell23.StyleName = "DetailData3";
            xrTableCell23.StylePriority.UseBorderColor = false;
            xrTableCell23.StylePriority.UseBorders = false;
            xrTableCell23.StylePriority.UsePadding = false;
            xrTableCell23.Text = "8/4/2018 To 8/17/2018";
            xrTableCell23.Weight = 0.31267396236756584D;
            // 
            // xrTableCell28
            // 
            xrTableCell28.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTableCell28.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell28.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell28.Name = "xrTableCell28";
            xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 1, 100F);
            xrTableCell28.StyleName = "DetailData3_Odd";
            xrTableCell28.StylePriority.UseBorderColor = false;
            xrTableCell28.StylePriority.UseBorders = false;
            xrTableCell28.StylePriority.UseFont = false;
            xrTableCell28.StylePriority.UseForeColor = false;
            xrTableCell28.StylePriority.UsePadding = false;
            xrTableCell28.Text = "TERMS";
            xrTableCell28.Weight = 0.13177048207687855D;
            // 
            // xrTableCell29
            // 
            xrTableCell29.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Terms]")});
            xrTableCell29.Name = "xrTableCell29";
            xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 1, 100F);
            xrTableCell29.StyleName = "DetailData3_Odd";
            xrTableCell29.StylePriority.UseBorderColor = false;
            xrTableCell29.StylePriority.UseBorders = false;
            xrTableCell29.StylePriority.UsePadding = false;
            xrTableCell29.Text = "End of month";
            xrTableCell29.Weight = 0.31267396236756584D;
            // 
            // groupHeaderBand1
            // 
            groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable2});
            groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            groupHeaderBand1.HeightF = 29.16667F;
            groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // detailBand2
            // 
            detailBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable3});
            detailBand2.EvenStyleName = "DetailData3";
            detailBand2.HeightF = 29.16667F;
            detailBand2.Name = "detailBand2";
            // 
            // ReportHeader
            // 
            ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrLabel3});
            ReportHeader.HeightF = 46.875F;
            ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter
            // 
            ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable1});
            ReportFooter.HeightF = 98.95834F;
            ReportFooter.Name = "ReportFooter";
            ReportFooter.PrintAtBottom = true;
            // 
            // xrTable2
            // 
            xrTable2.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTable2.Borders = (((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTable2.BorderWidth = 1.2F;
            xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(4.238557E-05F, 0F);
            xrTable2.Name = "xrTable2";
            xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow3});
            xrTable2.SizeF = new System.Drawing.SizeF(640.625F, 29.16667F);
            xrTable2.StyleName = "Headers";
            xrTable2.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow3
            // 
            xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell7,
            xrTableCell8,
            xrTableCell9,
            xrTableCell11});
            xrTableRow3.Name = "xrTableRow3";
            xrTableRow3.StyleName = "Headers";
            xrTableRow3.Weight = 1.0416666991890433D;
            // 
            // xrTableCell7
            // 
            xrTableCell7.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell7.BorderWidth = 2F;
            xrTableCell7.Name = "xrTableCell7";
            xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            xrTableCell7.StyleName = "Headers";
            xrTableCell7.StylePriority.UseBorderColor = false;
            xrTableCell7.StylePriority.UseBorders = false;
            xrTableCell7.StylePriority.UseBorderWidth = false;
            xrTableCell7.StylePriority.UsePadding = false;
            xrTableCell7.Text = "DATE";
            xrTableCell7.Weight = 0.26282052324906857D;
            // 
            // xrTableCell8
            // 
            xrTableCell8.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell8.BorderWidth = 2F;
            xrTableCell8.Name = "xrTableCell8";
            xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrTableCell8.StyleName = "Headers";
            xrTableCell8.StylePriority.UseBorderColor = false;
            xrTableCell8.StylePriority.UseBorders = false;
            xrTableCell8.StylePriority.UseBorderWidth = false;
            xrTableCell8.Text = "DESCRIPTION";
            xrTableCell8.Weight = 0.2264102459817007D;
            // 
            // xrTableCell9
            // 
            xrTableCell9.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell9.BorderWidth = 2F;
            xrTableCell9.Name = "xrTableCell9";
            xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrTableCell9.StyleName = "Headers";
            xrTableCell9.StylePriority.UseBorderColor = false;
            xrTableCell9.StylePriority.UseBorders = false;
            xrTableCell9.StylePriority.UseBorderWidth = false;
            xrTableCell9.StylePriority.UseTextAlignment = false;
            xrTableCell9.Text = "AMOUNT";
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell9.Weight = 0.24679486710782655D;
            // 
            // xrTableCell11
            // 
            xrTableCell11.BorderColor = System.Drawing.Color.FromArgb(46, 94, 168);
            xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell11.BorderWidth = 2F;
            xrTableCell11.Name = "xrTableCell11";
            xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            xrTableCell11.StyleName = "Headers";
            xrTableCell11.StylePriority.UseBorderColor = false;
            xrTableCell11.StylePriority.UseBorders = false;
            xrTableCell11.StylePriority.UseBorderWidth = false;
            xrTableCell11.StylePriority.UsePadding = false;
            xrTableCell11.StylePriority.UseTextAlignment = false;
            xrTableCell11.Text = "BALANCE";
            xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell11.Weight = 0.26397427885888147D;
            // 
            // xrTable3
            // 
            xrTable3.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrTable3.BorderWidth = 0.8F;
            xrTable3.EvenStyleName = "DetailData3_Odd";
            xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(5.298196E-05F, 0F);
            xrTable3.Name = "xrTable3";
            xrTable3.OddStyleName = "DetailData3";
            xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow4});
            xrTable3.SizeF = new System.Drawing.SizeF(640.6249F, 29.16667F);
            xrTable3.StylePriority.UseBorderColor = false;
            xrTable3.StylePriority.UseBorders = false;
            xrTable3.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow4
            // 
            xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell12,
            xrTableCell13,
            xrTableCell15,
            xrTableCell16});
            xrTableRow4.Name = "xrTableRow4";
            xrTableRow4.Weight = 13.416666666666666D;
            // 
            // xrTableCell12
            // 
            xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Date]")});
            xrTableCell12.Name = "xrTableCell12";
            xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            xrTableCell12.StyleName = "DetailData3";
            xrTableCell12.StylePriority.UsePadding = false;
            xrTableCell12.Text = "9/9/2018";
            xrTableCell12.TextFormatString = "{0:M/d/yyyy}";
            xrTableCell12.Weight = 0.22071864610205361D;
            // 
            // xrTableCell13
            // 
            xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            xrTableCell13.Name = "xrTableCell13";
            xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrTableCell13.StyleName = "DetailData3";
            xrTableCell13.StylePriority.UsePadding = false;
            xrTableCell13.Text = "Bill - Rent";
            xrTableCell13.Weight = 0.190140978530862D;
            // 
            // xrTableCell15
            // 
            xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(Contains([Description], \'Balance\'), \'\', [Amount])")});
            xrTableCell15.Name = "xrTableCell15";
            xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            xrTableCell15.StyleName = "DetailData3";
            xrTableCell15.StylePriority.UsePadding = false;
            xrTableCell15.StylePriority.UseTextAlignment = false;
            xrTableCell15.Text = "$210.00";
            xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell15.TextFormatString = "{0:$#,##.00}";
            xrTableCell15.Weight = 0.20726019714891966D;
            // 
            // xrTableCell16
            // 
            xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRunningSum([Amount])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Name", "\'Arial\'"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Size", "8"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "[DataSource.CurrentRowIndex] == [DataSource.RowCount] -1")});
            xrTableCell16.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell16.Name = "xrTableCell16";
            xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 10, 0, 0, 100F);
            xrTableCell16.StyleName = "DetailData3";
            xrTableCell16.StylePriority.UseFont = false;
            xrTableCell16.StylePriority.UsePadding = false;
            xrTableCell16.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            xrTableCell16.Summary = xrSummary1;
            xrTableCell16.Text = "xrTableCell16";
            xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell16.TextFormatString = "{0:$#,##.00}";
            xrTableCell16.Weight = 0.22168754127396906D;
            // 
            // xrLabel3
            // 
            xrLabel3.BorderColor = System.Drawing.Color.FromArgb(75, 75, 75);
            xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.083306F);
            xrLabel3.Name = "xrLabel3";
            xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            xrLabel3.SizeF = new System.Drawing.SizeF(640.625F, 27.94597F);
            xrLabel3.StyleName = "Title";
            xrLabel3.StylePriority.UseBorderColor = false;
            xrLabel3.StylePriority.UseBorders = false;
            xrLabel3.StylePriority.UseFont = false;
            xrLabel3.StylePriority.UseForeColor = false;
            xrLabel3.StylePriority.UsePadding = false;
            xrLabel3.StylePriority.UseTextAlignment = false;
            xrLabel3.Text = "Payments and Adjustments";
            xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable1
            // 
            xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrTable1.Name = "xrTable1";
            xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow1,
            xrTableRow2});
            xrTable1.SizeF = new System.Drawing.SizeF(650F, 98.95834F);
            // 
            // xrTableRow1
            // 
            xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell3,
            xrTableCell1,
            xrTableCell2});
            xrTableRow1.KeepTogether = false;
            xrTableRow1.Name = "xrTableRow1";
            xrTableRow1.Weight = 0.299592056274414D;
            // 
            // xrTableRow2
            // 
            xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell6,
            xrTableCell4,
            xrTableCell5});
            xrTableRow2.KeepTogether = false;
            xrTableRow2.Name = "xrTableRow2";
            xrTableRow2.Weight = 0.70040771484374975D;
            // 
            // xrTableCell3
            // 
            xrTableCell3.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246);
            xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            xrTableCell3.BorderWidth = 2F;
            xrTableCell3.Multiline = true;
            xrTableCell3.Name = "xrTableCell3";
            xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrTableCell3.StyleName = "SummaryTitles";
            xrTableCell3.StylePriority.UseBorderColor = false;
            xrTableCell3.StylePriority.UseBorders = false;
            xrTableCell3.StylePriority.UseBorderWidth = false;
            xrTableCell3.StylePriority.UseTextAlignment = false;
            xrTableCell3.Text = "NEW CHARGES\r\n";
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            xrTableCell3.Weight = 0.9903846153846152D;
            // 
            // xrTableCell1
            // 
            xrTableCell1.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246);
            xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            xrTableCell1.BorderWidth = 2F;
            xrTableCell1.Multiline = true;
            xrTableCell1.Name = "xrTableCell1";
            xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrTableCell1.StyleName = "SummaryTitles";
            xrTableCell1.StylePriority.UseBorderColor = false;
            xrTableCell1.StylePriority.UseBorders = false;
            xrTableCell1.StylePriority.UseBorderWidth = false;
            xrTableCell1.StylePriority.UseTextAlignment = false;
            xrTableCell1.Text = "PAYMENTS";
            xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            xrTableCell2.Multiline = true;
            xrTableCell2.Name = "xrTableCell2";
            xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrTableCell2.StyleName = "SummaryTitles";
            xrTableCell2.StylePriority.UseBorderColor = false;
            xrTableCell2.StylePriority.UseBorders = false;
            xrTableCell2.StylePriority.UseBorderWidth = false;
            xrTableCell2.StylePriority.UsePadding = false;
            xrTableCell2.StylePriority.UseTextAlignment = false;
            xrTableCell2.Text = "CURRENT BALANCE";
            xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            xrTableCell2.Weight = 1.0096153846153846D;
            // 
            // xrTableCell6
            // 
            xrTableCell6.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246);
            xrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            xrTableCell6.BorderWidth = 2F;
            xrTableCell6.CanGrow = false;
            xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[][[Amount] > 0 And !Contains([Description], \'Balance\')].Sum([Amount])")});
            xrTableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 23F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell6.Multiline = true;
            xrTableCell6.Name = "xrTableCell6";
            xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            xrTableCell6.StyleName = "SummaryValues";
            xrTableCell6.StylePriority.UseBorderColor = false;
            xrTableCell6.StylePriority.UseBorders = false;
            xrTableCell6.StylePriority.UseBorderWidth = false;
            xrTableCell6.StylePriority.UseFont = false;
            xrTableCell6.StylePriority.UsePadding = false;
            xrTableCell6.Text = "+$210.00";
            xrTableCell6.TextFormatString = "+{0:$#,##.00}";
            xrTableCell6.Weight = 0.9903846153846152D;
            // 
            // xrTableCell4
            // 
            xrTableCell4.BorderColor = System.Drawing.Color.FromArgb(238, 241, 246);
            xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            xrTableCell4.BorderWidth = 2F;
            xrTableCell4.CanGrow = false;
            xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[][[Amount] < 0].Sum([Amount])")});
            xrTableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 23F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell4.Multiline = true;
            xrTableCell4.Name = "xrTableCell4";
            xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            xrTableCell4.StyleName = "SummaryValues";
            xrTableCell4.StylePriority.UseBorderColor = false;
            xrTableCell4.StylePriority.UseBorders = false;
            xrTableCell4.StylePriority.UseBorderWidth = false;
            xrTableCell4.StylePriority.UseFont = false;
            xrTableCell4.StylePriority.UsePadding = false;
            xrTableCell4.Text = "-$280.00";
            xrTableCell4.TextFormatString = "{0:$#,##.00}";
            xrTableCell4.Weight = 1D;
            // 
            // xrTableCell5
            // 
            xrTableCell5.CanGrow = false;
            xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([Amount])")});
            xrTableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 23F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell5.Multiline = true;
            xrTableCell5.Name = "xrTableCell5";
            xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 100F);
            xrTableCell5.StyleName = "SummaryValues";
            xrTableCell5.StylePriority.UseBorderColor = false;
            xrTableCell5.StylePriority.UseBorders = false;
            xrTableCell5.StylePriority.UseBorderWidth = false;
            xrTableCell5.StylePriority.UseFont = false;
            xrTableCell5.StylePriority.UsePadding = false;
            xrTableCell5.Text = "$1,480.00";
            xrTableCell5.TextFormatString = "{0:$#,##.00}";
            xrTableCell5.Weight = 1.0096153846153846D;
            // 
            // objectDataSource1
            // 
            parameter1.Name = "rowCount";
            parameter1.Type = typeof(DevExpress.DataAccess.Expression);
            parameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.RowCountParameter]", typeof(int));
            objectConstructorInfo1.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter1});
            objectDataSource1.Constructor = objectConstructorInfo1;
            objectDataSource1.DataSource = typeof(XtraReportsDemos.CachedDocumentSourceReport.DataItemList);
            objectDataSource1.Name = "objectDataSource1";
            // 
            // Title
            // 
            Title.BackColor = System.Drawing.Color.Transparent;
            Title.BorderColor = System.Drawing.Color.Black;
            Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            Title.BorderWidth = 1F;
            Title.Font = new DevExpress.Drawing.DXFont("Arial", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            Title.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            Title.Name = "Title";
            // 
            // ReportTitleCaption
            // 
            ReportTitleCaption.BackColor = System.Drawing.Color.Transparent;
            ReportTitleCaption.BorderColor = System.Drawing.Color.Transparent;
            ReportTitleCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            ReportTitleCaption.Font = new DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            ReportTitleCaption.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            ReportTitleCaption.Name = "ReportTitleCaption";
            ReportTitleCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            ReportTitleCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            DetailData3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            DetailData3.ForeColor = System.Drawing.Color.Black;
            DetailData3.Name = "DetailData3";
            DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            DetailData3_Odd.BorderWidth = 1F;
            DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            DetailData3_Odd.Name = "DetailData3_Odd";
            DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            PageInfo.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            PageInfo.Name = "PageInfo";
            PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // Headers
            // 
            Headers.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            Headers.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168);
            Headers.Name = "Headers";
            Headers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SummaryTitles
            // 
            SummaryTitles.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            SummaryTitles.ForeColor = System.Drawing.Color.FromArgb(171, 185, 214);
            SummaryTitles.Name = "SummaryTitles";
            SummaryTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SummaryValues
            // 
            SummaryValues.Font = new DevExpress.Drawing.DXFont("Arial", 23F);
            SummaryValues.ForeColor = System.Drawing.Color.FromArgb(46, 94, 168);
            SummaryValues.Name = "SummaryValues";
            SummaryValues.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 16, 0, 100F);
            SummaryValues.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // RowCountParameter
            // 
            RowCountParameter.Description = "Row Count";
            RowCountParameter.Name = "RowCountParameter";
            RowCountParameter.Type = typeof(int);
            RowCountParameter.ValueInfo = "100000";
            // 
            // Report
            // 
            Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            topMarginBand1,
            bottomMarginBand1,
            detailBand1,
            detailReportBand1});
            ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            objectDataSource1});
            DataSource = objectDataSource1;
            DisplayName = "Large Dataset";
            Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            RowCountParameter});
            RequestParameters = false;
            StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            Title,
            ReportTitleCaption,
            DetailData3,
            DetailData3_Odd,
            PageInfo,
            Headers,
            SummaryTitles,
            SummaryValues});
            Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
