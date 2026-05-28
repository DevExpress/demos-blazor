using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.ReportMergingWithPdf {
    public class Report : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;
        private XRPageInfo pageInfo1;
        private DetailReportBand OrdersDetailReport;
        private DetailBand OrdersDetail;
        private ReportHeaderBand ReportHeader1;
        private XRPanel panel1;
        private XRTable xrTable3;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell6;
        private XRTableRow tableRow1;
        private XRTableCell tableCell1;
        private XRTableCell tableCell2;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableRow xrTableRow6;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell3;
        private XRPictureBox xrPictureBoxLogo;
        private XRTable xrTable4;
        private XRTableRow xrTableRow7;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell14;
        private XRTableCell xrTableCell15;
        private XRTableCell xrTableCell16;
        private XRTableCell xrTableCell17;
        private XRTableRow xrTableRow8;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell18;
        private XRTableCell xrTableCell19;
        private XRTableCell xrTableCell20;
        private XRTableCell xrTableCell21;
        private XRTableCell xrTableCell22;
        private GroupFooterBand GroupFooter2;
        private XRTable xrTable6;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell28;
        private XRTableCell xrTableCell29;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell30;
        private XRTableCell xrTableCell31;
        private XRTableRow xrTableRow12;
        private XRTableCell xrTableCell32;
        private XRTableCell xrTableCell33;
        private GroupHeaderBand GroupHeader2;
        private XRTable xrTable5;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell23;
        private XRTableCell xrTableCell24;
        private XRTableCell xrTableCell26;
        private XRTableCell xrTableCell27;
        private XRTableCell xrTableCell25;
        private DetailReportBand DetailReport;
        private DetailBand Detail;
        private XRTable xrTable2;
        private XRTableRow xrTableRow13;
        private XRTableCell xrTableCell34;
        private XRTableCell xrTableCell35;
        private XRTableCell xrTableCell36;
        private XRTableCell xrTableCell37;
        private XRTableCell xrTableCell38;
        private DevExpress.DataAccess.Sql.SqlDataSource reportSqlDataSource;
        private DetailReportBand DetailReport1;
        private DetailBand Detail1;
        private DetailReportBand DetailReport2;
        private DetailBand Detail2;
        private XRPdfContent xrPdfContent1;
        private XRControlStyle HeaderStyle;
        private XRControlStyle General;
        private XRControlStyle Comments;
        private XRControlStyle BillingShippingHeaderStyle;
        private XRControlStyle TableHeaderStyle;
        private XRControlStyle DetailTableHeaderStyle;
        private XRControlStyle TableOddStyle;
        private CalculatedField HomeOffice_StateName;
        private CalculatedField Address_StateName;
        private DevExpress.XtraReports.Parameters.Parameter paramShowHeader;
        private DevExpress.XtraReports.Parameters.Parameter paramShowFooter;
        private DevExpress.XtraReports.Parameters.Parameter paramShowStatus;
        private DevExpress.XtraReports.Parameters.Parameter paramShowComments;
        private DevExpress.XtraReports.Parameters.Parameter parameterInvoice;
        private DevExpress.DataAccess.Sql.SqlDataSource parameterSqlDataSource;
        private XRPdfSignature xrPdfSignature1;
        private System.ComponentModel.IContainer components;

        public Report() {
            InitializeComponent();
            Name = ReportNames.ReportMergingWithPdfName;
            DisplayName = ReportNames.ReportMergingWithPdf;
        }

        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression37 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column37 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression38 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column38 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression39 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column39 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression40 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column40 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression41 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column41 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression42 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column42 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression43 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column43 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression44 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column44 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression45 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column45 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression46 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column46 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression47 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column47 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression48 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column48 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression49 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column49 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression50 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column50 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression51 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column51 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression52 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column52 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression53 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column53 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression54 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column54 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression55 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column55 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression56 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column56 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression57 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column57 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression58 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column58 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression59 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column59 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression60 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column60 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression61 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column61 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression62 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column62 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression63 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column63 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression64 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column64 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression65 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column65 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression66 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Sorting sorting2 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression67 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column66 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression68 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column67 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression69 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column68 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression70 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column69 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression71 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column70 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression72 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column71 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression73 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column72 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression74 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column73 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression75 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column74 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression76 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column75 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression77 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column76 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression78 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column77 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression79 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column78 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression80 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column79 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression81 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column80 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression82 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column81 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression83 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column82 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression84 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column83 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression85 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column84 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression86 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column85 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression87 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column86 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression88 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column87 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression89 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column88 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression90 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column89 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression91 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column90 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression92 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column91 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression93 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column92 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression94 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column93 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression95 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column94 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression96 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column95 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression97 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column96 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression98 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column97 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression99 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column98 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression100 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column99 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression101 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column100 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression102 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column101 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression103 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column102 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression104 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column103 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression105 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column104 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression106 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column105 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression107 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column106 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression108 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column107 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression109 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column108 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression110 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column109 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression111 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column110 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression112 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column111 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression113 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column112 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression114 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column113 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression115 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column114 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression116 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column115 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression117 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery7 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column116 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression118 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column117 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression119 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column118 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression120 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column119 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression121 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column120 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression122 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column121 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression123 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column122 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression124 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column123 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression125 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column124 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression126 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column125 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression127 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column126 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression128 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column127 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression129 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column128 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression130 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column129 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression131 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column130 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression132 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column131 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression133 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column132 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression134 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column133 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression135 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column134 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression136 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column135 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression137 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table9 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo2 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo3 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo4 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo5 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo6 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo8 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            parameterSqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            OrdersDetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            OrdersDetail = new DevExpress.XtraReports.UI.DetailBand();
            ReportHeader1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            panel1 = new DevExpress.XtraReports.UI.XRPanel();
            xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            xrPictureBoxLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            Detail = new DevExpress.XtraReports.UI.DetailBand();
            xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            reportSqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            xrPdfContent1 = new DevExpress.XtraReports.UI.XRPdfContent();
            HeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            General = new DevExpress.XtraReports.UI.XRControlStyle();
            Comments = new DevExpress.XtraReports.UI.XRControlStyle();
            BillingShippingHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            TableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            DetailTableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            TableOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            HomeOffice_StateName = new DevExpress.XtraReports.UI.CalculatedField();
            Address_StateName = new DevExpress.XtraReports.UI.CalculatedField();
            paramShowHeader = new DevExpress.XtraReports.Parameters.Parameter();
            paramShowFooter = new DevExpress.XtraReports.Parameters.Parameter();
            paramShowStatus = new DevExpress.XtraReports.Parameters.Parameter();
            paramShowComments = new DevExpress.XtraReports.Parameters.Parameter();
            parameterInvoice = new DevExpress.XtraReports.Parameters.Parameter();
            xrPdfSignature1 = new DevExpress.XtraReports.UI.XRPdfSignature();
            ((System.ComponentModel.ISupportInitialize)(xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // parameterSqlDataSource
            // 
            parameterSqlDataSource.ConnectionName = "DevAvConnectionString";
            parameterSqlDataSource.Name = "parameterSqlDataSource";
            columnExpression1.ColumnName = "InvoiceNumber";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"419\" />";
            table1.Name = "Orders";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "OrderDate";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Id";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "Orders";
            columnExpression4.ColumnName = "OrderDate";
            columnExpression4.Table = table1;
            sorting1.Expression = columnExpression4;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table1);
            parameterSqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            parameterSqlDataSource.ResultSchemaSerializable = resources.GetString("parameterSqlDataSource.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            topMarginBand1.Dpi = 96F;
            topMarginBand1.HeightF = 46.08F;
            topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            detailBand1.Dpi = 96F;
            detailBand1.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            detailBand1.HeightF = 0F;
            detailBand1.HierarchyPrintOptions.Indent = 19.2F;
            detailBand1.Name = "detailBand1";
            detailBand1.StylePriority.UseFont = false;
            detailBand1.StylePriority.UseForeColor = false;
            // 
            // bottomMarginBand1
            // 
            bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            pageInfo1});
            bottomMarginBand1.Dpi = 96F;
            bottomMarginBand1.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            bottomMarginBand1.HeightF = 60.33794F;
            bottomMarginBand1.Name = "bottomMarginBand1";
            bottomMarginBand1.StylePriority.UseFont = false;
            // 
            // pageInfo1
            // 
            pageInfo1.Dpi = 96F;
            pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(302.5406F, 8.257084F);
            pageInfo1.Name = "pageInfo1";
            pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            pageInfo1.SizeF = new System.Drawing.SizeF(96F, 22.08F);
            pageInfo1.StyleName = "General";
            pageInfo1.StylePriority.UseTextAlignment = false;
            pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            pageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // OrdersDetailReport
            // 
            OrdersDetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            OrdersDetail,
            ReportHeader1,
            GroupFooter2,
            GroupHeader2,
            DetailReport});
            OrdersDetailReport.DataMember = "Orders";
            OrdersDetailReport.DataSource = reportSqlDataSource;
            OrdersDetailReport.Dpi = 96F;
            OrdersDetailReport.Level = 0;
            OrdersDetailReport.Name = "OrdersDetailReport";
            // 
            // OrdersDetail
            // 
            OrdersDetail.Dpi = 96F;
            OrdersDetail.HeightF = 0F;
            OrdersDetail.HierarchyPrintOptions.Indent = 19.2F;
            OrdersDetail.Name = "OrdersDetail";
            // 
            // ReportHeader1
            // 
            ReportHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            panel1,
            xrTable1,
            xrPictureBoxLogo,
            xrTable4});
            ReportHeader1.Dpi = 96F;
            ReportHeader1.HeightF = 440.8175F;
            ReportHeader1.Name = "ReportHeader1";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            panel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable3});
            panel1.Dpi = 96F;
            panel1.LocationFloat = new DevExpress.Utils.PointFloat(24.31999F, 137.5563F);
            panel1.Name = "panel1";
            panel1.SizeF = new System.Drawing.SizeF(656.6666F, 147.8788F);
            panel1.StylePriority.UseBackColor = false;
            panel1.StylePriority.UseBorders = false;
            // 
            // xrTable3
            // 
            xrTable3.Dpi = 96F;
            xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(22.93609F, 25.87239F);
            xrTable3.Name = "xrTable3";
            xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow4,
            tableRow1,
            xrTableRow5,
            xrTableRow6});
            xrTable3.SizeF = new System.Drawing.SizeF(596.2111F, 122.0064F);
            xrTable3.StylePriority.UseTextAlignment = false;
            xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow4
            // 
            xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell2,
            xrTableCell6});
            xrTableRow4.Dpi = 96F;
            xrTableRow4.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            xrTableRow4.ForeColor = System.Drawing.Color.FromArgb(166, 166, 166);
            xrTableRow4.Name = "xrTableRow4";
            xrTableRow4.StylePriority.UseFont = false;
            xrTableRow4.StylePriority.UseForeColor = false;
            xrTableRow4.Weight = 0.8269312838050884D;
            // 
            // xrTableCell2
            // 
            xrTableCell2.CanGrow = false;
            xrTableCell2.Dpi = 96F;
            xrTableCell2.Name = "xrTableCell2";
            xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTableCell2.StyleName = "BillingShippingHeaderStyle";
            xrTableCell2.StylePriority.UsePadding = false;
            xrTableCell2.Text = "Billing Address";
            xrTableCell2.Weight = 1.2560061534181426D;
            // 
            // xrTableCell6
            // 
            xrTableCell6.CanGrow = false;
            xrTableCell6.Dpi = 96F;
            xrTableCell6.Name = "xrTableCell6";
            xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTableCell6.StyleName = "BillingShippingHeaderStyle";
            xrTableCell6.StylePriority.UsePadding = false;
            xrTableCell6.Text = "Shipping Address";
            xrTableCell6.Weight = 1.7439938465818574D;
            // 
            // tableRow1
            // 
            tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            tableCell1,
            tableCell2});
            tableRow1.Dpi = 96F;
            tableRow1.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            tableRow1.ForeColor = System.Drawing.Color.FromArgb(166, 166, 166);
            tableRow1.Name = "tableRow1";
            tableRow1.StylePriority.UseFont = false;
            tableRow1.StylePriority.UseForeColor = false;
            tableRow1.Weight = 0.34950031364622997D;
            // 
            // tableCell1
            // 
            tableCell1.CanGrow = false;
            tableCell1.Dpi = 96F;
            tableCell1.Multiline = true;
            tableCell1.Name = "tableCell1";
            tableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            tableCell1.StyleName = "BillingShippingHeaderStyle";
            tableCell1.StylePriority.UsePadding = false;
            tableCell1.Weight = 1.2560061534181426D;
            // 
            // tableCell2
            // 
            tableCell2.CanGrow = false;
            tableCell2.Dpi = 96F;
            tableCell2.Multiline = true;
            tableCell2.Name = "tableCell2";
            tableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            tableCell2.StyleName = "BillingShippingHeaderStyle";
            tableCell2.StylePriority.UsePadding = false;
            tableCell2.Weight = 1.7439938465818574D;
            // 
            // xrTableRow5
            // 
            xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell7,
            xrTableCell8});
            xrTableRow5.Dpi = 96F;
            xrTableRow5.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableRow5.Name = "xrTableRow5";
            xrTableRow5.StylePriority.UseFont = false;
            xrTableRow5.Weight = 0.88845332146656031D;
            // 
            // xrTableCell7
            // 
            xrTableCell7.CanGrow = false;
            xrTableCell7.Dpi = 96F;
            xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer.Name]")});
            xrTableCell7.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell7.Name = "xrTableCell7";
            xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTableCell7.StyleName = "General";
            xrTableCell7.StylePriority.UseFont = false;
            xrTableCell7.StylePriority.UsePadding = false;
            xrTableCell7.Weight = 1.2560061534181426D;
            // 
            // xrTableCell8
            // 
            xrTableCell8.Dpi = 96F;
            xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer.Name]")});
            xrTableCell8.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            xrTableCell8.Name = "xrTableCell8";
            xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTableCell8.StyleName = "General";
            xrTableCell8.StylePriority.UseFont = false;
            xrTableCell8.StylePriority.UsePadding = false;
            xrTableCell8.Weight = 1.7439938465818574D;
            // 
            // xrTableRow6
            // 
            xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell9,
            xrTableCell10});
            xrTableRow6.Dpi = 96F;
            xrTableRow6.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            xrTableRow6.Name = "xrTableRow6";
            xrTableRow6.StylePriority.UseFont = false;
            xrTableRow6.Weight = 3.0187164242698779D;
            // 
            // xrTableCell9
            // 
            xrTableCell9.Dpi = 96F;
            xrTableCell9.Multiline = true;
            xrTableCell9.Name = "xrTableCell9";
            xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTableCell9.StyleName = "General";
            xrTableCell9.StylePriority.UsePadding = false;
            xrTableCell9.StylePriority.UseTextAlignment = false;
            xrTableCell9.Text = "Home Office\r\n[Customer.HomeOffice_Line]\r\n[Customer.HomeOffice_City], [Customer.Ho" +
    "meOffice_StateName] [Customer.HomeOffice_ZipCode]";
            xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            xrTableCell9.Weight = 1.2560061534181426D;
            // 
            // xrTableCell10
            // 
            xrTableCell10.Dpi = 96F;
            xrTableCell10.Multiline = true;
            xrTableCell10.Name = "xrTableCell10";
            xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTableCell10.StyleName = "General";
            xrTableCell10.StylePriority.UsePadding = false;
            xrTableCell10.StylePriority.UseTextAlignment = false;
            xrTableCell10.Text = "[Store.Address_City] Store\r\n[Store.Address_Line]\r\n[Store.Address_City], [Store.Ad" +
    "dress_StateName] [Store.Address_ZipCode]";
            xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            xrTableCell10.Weight = 1.7439938465818574D;
            // 
            // xrTable1
            // 
            xrTable1.Dpi = 96F;
            xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(22.9952F, 50.39841F);
            xrTable1.Name = "xrTable1";
            xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 96F);
            xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow1,
            xrTableRow3});
            xrTable1.SizeF = new System.Drawing.SizeF(430.9133F, 62.41702F);
            xrTable1.StylePriority.UseFont = false;
            xrTable1.StylePriority.UsePadding = false;
            xrTable1.StylePriority.UseTextAlignment = false;
            xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell1});
            xrTableRow1.Dpi = 96F;
            xrTableRow1.Font = new DevExpress.Drawing.DXFont("Arial", 14F);
            xrTableRow1.Name = "xrTableRow1";
            xrTableRow1.StylePriority.UseFont = false;
            xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            xrTableCell1.CanGrow = false;
            xrTableCell1.Dpi = 96F;
            xrTableCell1.Name = "xrTableCell1";
            xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            xrTableCell1.StyleName = "HeaderStyle";
            xrTableCell1.StylePriority.UseFont = false;
            xrTableCell1.StylePriority.UseForeColor = false;
            xrTableCell1.StylePriority.UsePadding = false;
            xrTableCell1.StylePriority.UseTextAlignment = false;
            xrTableCell1.Text = "Invoice # [InvoiceNumber]";
            xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell1.Weight = 0.3656307129798903D;
            // 
            // xrTableRow3
            // 
            xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell3});
            xrTableRow3.Dpi = 96F;
            xrTableRow3.Name = "xrTableRow3";
            xrTableRow3.Weight = 7.1843158466786257D;
            // 
            // xrTableCell3
            // 
            xrTableCell3.CanGrow = false;
            xrTableCell3.Dpi = 96F;
            xrTableCell3.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            xrTableCell3.Name = "xrTableCell3";
            xrTableCell3.StyleName = "General";
            xrTableCell3.StylePriority.UseFont = false;
            xrTableCell3.StylePriority.UsePadding = false;
            xrTableCell3.StylePriority.UseTextAlignment = false;
            xrTableCell3.Text = "[OrderDate!MM/dd/yy]";
            xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell3.Weight = 0.3656307129798903D;
            // 
            // xrPictureBoxLogo
            // 
            xrPictureBoxLogo.Dpi = 96F;
            xrPictureBoxLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBoxLogo.ImageSource"));
            xrPictureBoxLogo.LocationFloat = new DevExpress.Utils.PointFloat(490.6027F, 32.12367F);
            xrPictureBoxLogo.Name = "xrPictureBoxLogo";
            xrPictureBoxLogo.SizeF = new System.Drawing.SizeF(193.0292F, 57.15536F);
            xrPictureBoxLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrTable4
            // 
            xrTable4.Borders = (((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTable4.Dpi = 96F;
            xrTable4.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(22.99519F, 319.6004F);
            xrTable4.Name = "xrTable4";
            xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow7,
            xrTableRow8});
            xrTable4.SizeF = new System.Drawing.SizeF(657.9914F, 62.595F);
            xrTable4.StylePriority.UseBorders = false;
            xrTable4.StylePriority.UseFont = false;
            xrTable4.StylePriority.UseTextAlignment = false;
            xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            xrTableRow7.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell11,
            xrTableCell12,
            xrTableCell14,
            xrTableCell15,
            xrTableCell16,
            xrTableCell17});
            xrTableRow7.Dpi = 96F;
            xrTableRow7.Name = "xrTableRow7";
            xrTableRow7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 2, 0, 96F);
            xrTableRow7.StylePriority.UseBackColor = false;
            xrTableRow7.StylePriority.UsePadding = false;
            xrTableRow7.Weight = 1.3351953125D;
            // 
            // xrTableCell11
            // 
            xrTableCell11.Dpi = 96F;
            xrTableCell11.Name = "xrTableCell11";
            xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 96F);
            xrTableCell11.StyleName = "TableHeaderStyle";
            xrTableCell11.StylePriority.UsePadding = false;
            xrTableCell11.StylePriority.UseTextAlignment = false;
            xrTableCell11.Text = "Sales Rep.";
            xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell11.Weight = 0.87337124463981453D;
            // 
            // xrTableCell12
            // 
            xrTableCell12.Dpi = 96F;
            xrTableCell12.Name = "xrTableCell12";
            xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 2, 0, 96F);
            xrTableCell12.StyleName = "TableHeaderStyle";
            xrTableCell12.StylePriority.UsePadding = false;
            xrTableCell12.StylePriority.UseTextAlignment = false;
            xrTableCell12.Text = "PO #";
            xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell12.Weight = 0.542657708540922D;
            // 
            // xrTableCell14
            // 
            xrTableCell14.Dpi = 96F;
            xrTableCell14.Name = "xrTableCell14";
            xrTableCell14.StyleName = "TableHeaderStyle";
            xrTableCell14.Text = "Ship Date";
            xrTableCell14.Weight = 0.69479935035123674D;
            // 
            // xrTableCell15
            // 
            xrTableCell15.Dpi = 96F;
            xrTableCell15.Name = "xrTableCell15";
            xrTableCell15.StyleName = "TableHeaderStyle";
            xrTableCell15.Text = "Ship Via";
            xrTableCell15.Weight = 0.92323718365925511D;
            // 
            // xrTableCell16
            // 
            xrTableCell16.Dpi = 96F;
            xrTableCell16.Name = "xrTableCell16";
            xrTableCell16.StyleName = "TableHeaderStyle";
            xrTableCell16.Text = "FOB";
            xrTableCell16.Weight = 0.54709842411275023D;
            // 
            // xrTableCell17
            // 
            xrTableCell17.Dpi = 96F;
            xrTableCell17.Name = "xrTableCell17";
            xrTableCell17.StyleName = "TableHeaderStyle";
            xrTableCell17.Text = "Terms";
            xrTableCell17.Weight = 0.87980333477995443D;
            // 
            // xrTableRow8
            // 
            xrTableRow8.BorderColor = System.Drawing.Color.FromArgb(229, 229, 229);
            xrTableRow8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell13,
            xrTableCell18,
            xrTableCell19,
            xrTableCell20,
            xrTableCell21,
            xrTableCell22});
            xrTableRow8.Dpi = 96F;
            xrTableRow8.Name = "xrTableRow8";
            xrTableRow8.StylePriority.UseBorderColor = false;
            xrTableRow8.StylePriority.UseBorders = false;
            xrTableRow8.Weight = 1.272927903327012D;
            // 
            // xrTableCell13
            // 
            xrTableCell13.Dpi = 96F;
            xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Employee.FullName]")});
            xrTableCell13.Name = "xrTableCell13";
            xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F);
            xrTableCell13.StyleName = "General";
            xrTableCell13.StylePriority.UsePadding = false;
            xrTableCell13.StylePriority.UseTextAlignment = false;
            xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell13.Weight = 0.87337124463981453D;
            // 
            // xrTableCell18
            // 
            xrTableCell18.Dpi = 96F;
            xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PONumber]")});
            xrTableCell18.Name = "xrTableCell18";
            xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 96F);
            xrTableCell18.StyleName = "General";
            xrTableCell18.StylePriority.UsePadding = false;
            xrTableCell18.StylePriority.UseTextAlignment = false;
            xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell18.Weight = 0.54265752408010282D;
            // 
            // xrTableCell19
            // 
            xrTableCell19.Dpi = 96F;
            xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GetDate([ShipDate])")});
            xrTableCell19.Name = "xrTableCell19";
            xrTableCell19.StyleName = "General";
            xrTableCell19.TextFormatString = "{0:MM/dd/yyyy}";
            xrTableCell19.Weight = 0.69479976538807975D;
            // 
            // xrTableCell20
            // 
            xrTableCell20.Dpi = 96F;
            xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif([ShipMethod] = 0, \'Ground\', [ShipMethod] = 1, \'Air\', \'-\')")});
            xrTableCell20.Name = "xrTableCell20";
            xrTableCell20.StyleName = "General";
            xrTableCell20.Weight = 0.9232372439369031D;
            // 
            // xrTableCell21
            // 
            xrTableCell21.Dpi = 96F;
            xrTableCell21.Name = "xrTableCell21";
            xrTableCell21.Text = " - ";
            xrTableCell21.Weight = 0.54709823257070933D;
            // 
            // xrTableCell22
            // 
            xrTableCell22.Dpi = 96F;
            xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderTerms]")});
            xrTableCell22.Name = "xrTableCell22";
            xrTableCell22.StyleName = "General";
            xrTableCell22.Weight = 0.87980323546832329D;
            // 
            // GroupFooter2
            // 
            GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrPdfSignature1,
            xrTable6});
            GroupFooter2.Dpi = 96F;
            GroupFooter2.HeightF = 159.7737F;
            GroupFooter2.Name = "GroupFooter2";
            GroupFooter2.PrintAtBottom = true;
            // 
            // xrTable6
            // 
            xrTable6.Borders = (((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTable6.Dpi = 96F;
            xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(460.2045F, 41.94443F);
            xrTable6.Name = "xrTable6";
            xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow10,
            xrTableRow11,
            xrTableRow12});
            xrTable6.SizeF = new System.Drawing.SizeF(220.4065F, 94.40681F);
            xrTable6.StylePriority.UseBorders = false;
            // 
            // xrTableRow10
            // 
            xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell28,
            xrTableCell29});
            xrTableRow10.Dpi = 96F;
            xrTableRow10.Name = "xrTableRow10";
            xrTableRow10.Weight = 1.6445612561757967D;
            // 
            // xrTableCell28
            // 
            xrTableCell28.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            xrTableCell28.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235);
            xrTableCell28.Borders = (DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTableCell28.Dpi = 96F;
            xrTableCell28.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            xrTableCell28.Name = "xrTableCell28";
            xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 2, 0, 96F);
            xrTableCell28.StyleName = "TableOddStyle";
            xrTableCell28.StylePriority.UseBackColor = false;
            xrTableCell28.StylePriority.UseBorderColor = false;
            xrTableCell28.StylePriority.UseBorders = false;
            xrTableCell28.StylePriority.UseFont = false;
            xrTableCell28.StylePriority.UsePadding = false;
            xrTableCell28.StylePriority.UseTextAlignment = false;
            xrTableCell28.Text = "Sub Total";
            xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell28.Weight = 1.8279264198044849D;
            // 
            // xrTableCell29
            // 
            xrTableCell29.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            xrTableCell29.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235);
            xrTableCell29.Borders = (DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTableCell29.Dpi = 96F;
            xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([OrderItems].[Total])")});
            xrTableCell29.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            xrTableCell29.Name = "xrTableCell29";
            xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 2, 0, 96F);
            xrTableCell29.StyleName = "TableOddStyle";
            xrTableCell29.StylePriority.UseBackColor = false;
            xrTableCell29.StylePriority.UseBorderColor = false;
            xrTableCell29.StylePriority.UseBorders = false;
            xrTableCell29.StylePriority.UseFont = false;
            xrTableCell29.StylePriority.UsePadding = false;
            xrTableCell29.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            xrTableCell29.Summary = xrSummary1;
            xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell29.TextFormatString = "{0:$#,#}";
            xrTableCell29.Weight = 1.2142824291082539D;
            // 
            // xrTableRow11
            // 
            xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell30,
            xrTableCell31});
            xrTableRow11.Dpi = 96F;
            xrTableRow11.Name = "xrTableRow11";
            xrTableRow11.Weight = 1.5315354078890038D;
            // 
            // xrTableCell30
            // 
            xrTableCell30.BackColor = System.Drawing.Color.Transparent;
            xrTableCell30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell30.Dpi = 96F;
            xrTableCell30.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            xrTableCell30.Name = "xrTableCell30";
            xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F);
            xrTableCell30.StyleName = "TableHeaderStyle";
            xrTableCell30.StylePriority.UseBackColor = false;
            xrTableCell30.StylePriority.UseBorders = false;
            xrTableCell30.StylePriority.UseFont = false;
            xrTableCell30.StylePriority.UsePadding = false;
            xrTableCell30.StylePriority.UseTextAlignment = false;
            xrTableCell30.Text = "Shipping";
            xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell30.Weight = 1.82792864409057D;
            // 
            // xrTableCell31
            // 
            xrTableCell31.BackColor = System.Drawing.Color.Transparent;
            xrTableCell31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell31.Dpi = 96F;
            xrTableCell31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShippingAmount]")});
            xrTableCell31.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            xrTableCell31.Name = "xrTableCell31";
            xrTableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F);
            xrTableCell31.StyleName = "TableHeaderStyle";
            xrTableCell31.StylePriority.UseBackColor = false;
            xrTableCell31.StylePriority.UseBorders = false;
            xrTableCell31.StylePriority.UseFont = false;
            xrTableCell31.StylePriority.UsePadding = false;
            xrTableCell31.StylePriority.UseTextAlignment = false;
            xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell31.TextFormatString = "{0:$#,#}";
            xrTableCell31.Weight = 1.2142813010470537D;
            // 
            // xrTableRow12
            // 
            xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell32,
            xrTableCell33});
            xrTableRow12.Dpi = 96F;
            xrTableRow12.Name = "xrTableRow12";
            xrTableRow12.Weight = 1.6255815606400634D;
            // 
            // xrTableCell32
            // 
            xrTableCell32.BackColor = System.Drawing.Color.Transparent;
            xrTableCell32.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell32.Dpi = 96F;
            xrTableCell32.Name = "xrTableCell32";
            xrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F);
            xrTableCell32.StyleName = "TableHeaderStyle";
            xrTableCell32.StylePriority.UseBackColor = false;
            xrTableCell32.StylePriority.UseBorders = false;
            xrTableCell32.StylePriority.UseFont = false;
            xrTableCell32.StylePriority.UsePadding = false;
            xrTableCell32.StylePriority.UseTextAlignment = false;
            xrTableCell32.Text = "Total Due";
            xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell32.Weight = 1.82792864409057D;
            // 
            // xrTableCell33
            // 
            xrTableCell33.BackColor = System.Drawing.Color.Transparent;
            xrTableCell33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCell33.Dpi = 96F;
            xrTableCell33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")});
            xrTableCell33.Name = "xrTableCell33";
            xrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F);
            xrTableCell33.StyleName = "TableHeaderStyle";
            xrTableCell33.StylePriority.UseBackColor = false;
            xrTableCell33.StylePriority.UseBorders = false;
            xrTableCell33.StylePriority.UseFont = false;
            xrTableCell33.StylePriority.UsePadding = false;
            xrTableCell33.StylePriority.UseTextAlignment = false;
            xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell33.TextFormatString = "{0:$#,#}";
            xrTableCell33.Weight = 1.2142813010470537D;
            // 
            // GroupHeader2
            // 
            GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable5});
            GroupHeader2.Dpi = 96F;
            GroupHeader2.HeightF = 30.38236F;
            GroupHeader2.Name = "GroupHeader2";
            // 
            // xrTable5
            // 
            xrTable5.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            xrTable5.Borders = (((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom);
            xrTable5.Dpi = 96F;
            xrTable5.Font = new DevExpress.Drawing.DXFont("Arial", 13F);
            xrTable5.ForeColor = System.Drawing.Color.FromArgb(113, 112, 116);
            xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(22.99513F, 0.3823617F);
            xrTable5.Name = "xrTable5";
            xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow9});
            xrTable5.SizeF = new System.Drawing.SizeF(657.9914F, 30F);
            xrTable5.StylePriority.UseBackColor = false;
            xrTable5.StylePriority.UseBorders = false;
            xrTable5.StylePriority.UseFont = false;
            xrTable5.StylePriority.UseForeColor = false;
            // 
            // xrTableRow9
            // 
            xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell23,
            xrTableCell24,
            xrTableCell26,
            xrTableCell27,
            xrTableCell25});
            xrTableRow9.Dpi = 96F;
            xrTableRow9.Name = "xrTableRow9";
            xrTableRow9.StylePriority.UseBorders = false;
            xrTableRow9.Weight = 1.031581923608158D;
            // 
            // xrTableCell23
            // 
            xrTableCell23.Dpi = 96F;
            xrTableCell23.Name = "xrTableCell23";
            xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 96F);
            xrTableCell23.StyleName = "DetailTableHeaderStyle";
            xrTableCell23.StylePriority.UsePadding = false;
            xrTableCell23.StylePriority.UseTextAlignment = false;
            xrTableCell23.Text = "Description";
            xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell23.Weight = 0.74283632613826966D;
            // 
            // xrTableCell24
            // 
            xrTableCell24.Dpi = 96F;
            xrTableCell24.Name = "xrTableCell24";
            xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 8, 0, 0, 96F);
            xrTableCell24.StyleName = "DetailTableHeaderStyle";
            xrTableCell24.StylePriority.UsePadding = false;
            xrTableCell24.StylePriority.UseTextAlignment = false;
            xrTableCell24.Text = "Unit Price";
            xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell24.Weight = 0.69508230296883622D;
            // 
            // xrTableCell26
            // 
            xrTableCell26.Dpi = 96F;
            xrTableCell26.Name = "xrTableCell26";
            xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 96F);
            xrTableCell26.StyleName = "DetailTableHeaderStyle";
            xrTableCell26.StylePriority.UsePadding = false;
            xrTableCell26.StylePriority.UseTextAlignment = false;
            xrTableCell26.Text = "Quantity";
            xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell26.Weight = 0.52416638509731162D;
            // 
            // xrTableCell27
            // 
            xrTableCell27.Dpi = 96F;
            xrTableCell27.Name = "xrTableCell27";
            xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F);
            xrTableCell27.StyleName = "DetailTableHeaderStyle";
            xrTableCell27.StylePriority.UsePadding = false;
            xrTableCell27.StylePriority.UseTextAlignment = false;
            xrTableCell27.Text = "Discount";
            xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell27.Weight = 0.52416638509731162D;
            // 
            // xrTableCell25
            // 
            xrTableCell25.Dpi = 96F;
            xrTableCell25.Name = "xrTableCell25";
            xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 96F);
            xrTableCell25.StyleName = "DetailTableHeaderStyle";
            xrTableCell25.StylePriority.UsePadding = false;
            xrTableCell25.StylePriority.UseTextAlignment = false;
            xrTableCell25.Text = "Total";
            xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell25.Weight = 0.52416638509731162D;
            // 
            // DetailReport
            // 
            DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            Detail});
            DetailReport.DataMember = "Orders.OrderItems";
            DetailReport.DataSource = reportSqlDataSource;
            DetailReport.Dpi = 96F;
            DetailReport.Level = 0;
            DetailReport.Name = "DetailReport";
            // 
            // Detail
            // 
            Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable2});
            Detail.Dpi = 96F;
            Detail.FillEmptySpace = true;
            Detail.HeightF = 30F;
            Detail.HierarchyPrintOptions.Indent = 19.2F;
            Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            xrTable2.Borders = (DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right);
            xrTable2.Dpi = 96F;
            xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(24.31999F, 0F);
            xrTable2.Name = "xrTable2";
            xrTable2.OddStyleName = "TableOddStyle";
            xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow13});
            xrTable2.SizeF = new System.Drawing.SizeF(656.6665F, 30F);
            xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow13
            // 
            xrTableRow13.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235);
            xrTableRow13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell34,
            xrTableCell35,
            xrTableCell36,
            xrTableCell37,
            xrTableCell38});
            xrTableRow13.Dpi = 96F;
            xrTableRow13.Name = "xrTableRow13";
            xrTableRow13.StylePriority.UseBorderColor = false;
            xrTableRow13.StylePriority.UseBorders = false;
            xrTableRow13.Weight = 3.021817127268994D;
            // 
            // xrTableCell34
            // 
            xrTableCell34.Dpi = 96F;
            xrTableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Product_Name]")});
            xrTableCell34.Multiline = true;
            xrTableCell34.Name = "xrTableCell34";
            xrTableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 96F);
            xrTableCell34.StyleName = "General";
            xrTableCell34.StylePriority.UseFont = false;
            xrTableCell34.StylePriority.UsePadding = false;
            xrTableCell34.StylePriority.UseTextAlignment = false;
            xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCell34.Weight = 180.88969053070841D;
            // 
            // xrTableCell35
            // 
            xrTableCell35.Dpi = 96F;
            xrTableCell35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductPrice]")});
            xrTableCell35.Multiline = true;
            xrTableCell35.Name = "xrTableCell35";
            xrTableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 8, 0, 0, 96F);
            xrTableCell35.StyleName = "General";
            xrTableCell35.StylePriority.UseFont = false;
            xrTableCell35.StylePriority.UsePadding = false;
            xrTableCell35.StylePriority.UseTextAlignment = false;
            xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell35.TextFormatString = "{0:$#,#}";
            xrTableCell35.Weight = 168.48122563857984D;
            // 
            // xrTableCell36
            // 
            xrTableCell36.Dpi = 96F;
            xrTableCell36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductUnits]")});
            xrTableCell36.Multiline = true;
            xrTableCell36.Name = "xrTableCell36";
            xrTableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 96F);
            xrTableCell36.StyleName = "General";
            xrTableCell36.StylePriority.UseFont = false;
            xrTableCell36.StylePriority.UsePadding = false;
            xrTableCell36.StylePriority.UseTextAlignment = false;
            xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell36.Weight = 127.89576640347559D;
            // 
            // xrTableCell37
            // 
            xrTableCell37.Dpi = 96F;
            xrTableCell37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")});
            xrTableCell37.Multiline = true;
            xrTableCell37.Name = "xrTableCell37";
            xrTableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 96F);
            xrTableCell37.StyleName = "General";
            xrTableCell37.StylePriority.UseFont = false;
            xrTableCell37.StylePriority.UsePadding = false;
            xrTableCell37.StylePriority.UseTextAlignment = false;
            xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell37.TextFormatString = "{0:$#,#;$#,#;\'-\'}";
            xrTableCell37.Weight = 127.89576640347559D;
            // 
            // xrTableCell38
            // 
            xrTableCell38.Dpi = 96F;
            xrTableCell38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")});
            xrTableCell38.Multiline = true;
            xrTableCell38.Name = "xrTableCell38";
            xrTableCell38.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 96F);
            xrTableCell38.StyleName = "General";
            xrTableCell38.StylePriority.UseFont = false;
            xrTableCell38.StylePriority.UsePadding = false;
            xrTableCell38.StylePriority.UseTextAlignment = false;
            xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell38.TextFormatString = "{0:$#,#}";
            xrTableCell38.Weight = 127.89576640347559D;
            // 
            // reportSqlDataSource
            // 
            reportSqlDataSource.ConnectionName = "DevAvConnectionString";
            reportSqlDataSource.Name = "reportSqlDataSource";
            columnExpression5.ColumnName = "Id";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"419\" />";
            table2.Name = "Orders";
            columnExpression5.Table = table2;
            column4.Expression = columnExpression5;
            columnExpression6.ColumnName = "InvoiceNumber";
            columnExpression6.Table = table2;
            column5.Expression = columnExpression6;
            columnExpression7.ColumnName = "CustomerId";
            columnExpression7.Table = table2;
            column6.Expression = columnExpression7;
            columnExpression8.ColumnName = "StoreId";
            columnExpression8.Table = table2;
            column7.Expression = columnExpression8;
            columnExpression9.ColumnName = "PONumber";
            columnExpression9.Table = table2;
            column8.Expression = columnExpression9;
            columnExpression10.ColumnName = "EmployeeId";
            columnExpression10.Table = table2;
            column9.Expression = columnExpression10;
            columnExpression11.ColumnName = "OrderDate";
            columnExpression11.Table = table2;
            column10.Expression = columnExpression11;
            columnExpression12.ColumnName = "SaleAmount";
            columnExpression12.Table = table2;
            column11.Expression = columnExpression12;
            columnExpression13.ColumnName = "ShippingAmount";
            columnExpression13.Table = table2;
            column12.Expression = columnExpression13;
            columnExpression14.ColumnName = "TotalAmount";
            columnExpression14.Table = table2;
            column13.Expression = columnExpression14;
            columnExpression15.ColumnName = "ShipDate";
            columnExpression15.Table = table2;
            column14.Expression = columnExpression15;
            columnExpression16.ColumnName = "ShipMethod";
            columnExpression16.Table = table2;
            column15.Expression = columnExpression16;
            columnExpression17.ColumnName = "OrderTerms";
            columnExpression17.Table = table2;
            column16.Expression = columnExpression17;
            columnExpression18.ColumnName = "ShipmentCourier";
            columnExpression18.Table = table2;
            column17.Expression = columnExpression18;
            columnExpression19.ColumnName = "ShipmentCourierId";
            columnExpression19.Table = table2;
            column18.Expression = columnExpression19;
            columnExpression20.ColumnName = "ShipmentStatus";
            columnExpression20.Table = table2;
            column19.Expression = columnExpression20;
            columnExpression21.ColumnName = "Comments";
            columnExpression21.Table = table2;
            column20.Expression = columnExpression21;
            columnExpression22.ColumnName = "RefundTotal";
            columnExpression22.Table = table2;
            column21.Expression = columnExpression22;
            columnExpression23.ColumnName = "PaymentTotal";
            columnExpression23.Table = table2;
            column22.Expression = columnExpression23;
            selectQuery2.Columns.Add(column4);
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
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
            selectQuery2.FilterString = "[Orders.InvoiceNumber] = ?parameterInvoiceNumber";
            selectQuery2.GroupFilterString = "";
            selectQuery2.MetaSerializable = "<Meta X=\"110\" Y=\"20\" Width=\"180\" Height=\"360\" />";
            selectQuery2.Name = "Orders";
            queryParameter1.Name = "parameterInvoiceNumber";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?parameterInvoice", typeof(string));
            selectQuery2.Parameters.Add(queryParameter1);
            selectQuery2.Tables.Add(table2);
            columnExpression24.ColumnName = "Id";
            table3.Name = "Customers";
            columnExpression24.Table = table3;
            column23.Expression = columnExpression24;
            columnExpression25.ColumnName = "Name";
            columnExpression25.Table = table3;
            column24.Expression = columnExpression25;
            columnExpression26.ColumnName = "HomeOffice_Line";
            columnExpression26.Table = table3;
            column25.Expression = columnExpression26;
            columnExpression27.ColumnName = "HomeOffice_City";
            columnExpression27.Table = table3;
            column26.Expression = columnExpression27;
            columnExpression28.ColumnName = "HomeOffice_State";
            columnExpression28.Table = table3;
            column27.Expression = columnExpression28;
            columnExpression29.ColumnName = "HomeOffice_Latitude";
            columnExpression29.Table = table3;
            column28.Expression = columnExpression29;
            columnExpression30.ColumnName = "HomeOffice_Longitude";
            columnExpression30.Table = table3;
            column29.Expression = columnExpression30;
            columnExpression31.ColumnName = "HomeOffice_ZipCode";
            columnExpression31.Table = table3;
            column30.Expression = columnExpression31;
            columnExpression32.ColumnName = "BillingAddress_Line";
            columnExpression32.Table = table3;
            column31.Expression = columnExpression32;
            columnExpression33.ColumnName = "BillingAddress_City";
            columnExpression33.Table = table3;
            column32.Expression = columnExpression33;
            columnExpression34.ColumnName = "BillingAddress_State";
            columnExpression34.Table = table3;
            column33.Expression = columnExpression34;
            columnExpression35.ColumnName = "BillingAddress_Latitude";
            columnExpression35.Table = table3;
            column34.Expression = columnExpression35;
            columnExpression36.ColumnName = "BillingAddress_Longitude";
            columnExpression36.Table = table3;
            column35.Expression = columnExpression36;
            columnExpression37.ColumnName = "BillingAddress_ZipCode";
            columnExpression37.Table = table3;
            column36.Expression = columnExpression37;
            columnExpression38.ColumnName = "HomeOfficeLine";
            columnExpression38.Table = table3;
            column37.Expression = columnExpression38;
            columnExpression39.ColumnName = "HomeOfficeCity";
            columnExpression39.Table = table3;
            column38.Expression = columnExpression39;
            columnExpression40.ColumnName = "HomeOfficeZipCode";
            columnExpression40.Table = table3;
            column39.Expression = columnExpression40;
            columnExpression41.ColumnName = "BillingAddressLine";
            columnExpression41.Table = table3;
            column40.Expression = columnExpression41;
            columnExpression42.ColumnName = "BillingAddressCity";
            columnExpression42.Table = table3;
            column41.Expression = columnExpression42;
            columnExpression43.ColumnName = "BillingAddressZipCode";
            columnExpression43.Table = table3;
            column42.Expression = columnExpression43;
            columnExpression44.ColumnName = "HomeOfficeState";
            columnExpression44.Table = table3;
            column43.Expression = columnExpression44;
            columnExpression45.ColumnName = "HomeOfficeLatitude";
            columnExpression45.Table = table3;
            column44.Expression = columnExpression45;
            columnExpression46.ColumnName = "HomeOfficeLongitude";
            columnExpression46.Table = table3;
            column45.Expression = columnExpression46;
            columnExpression47.ColumnName = "BillingAddressState";
            columnExpression47.Table = table3;
            column46.Expression = columnExpression47;
            columnExpression48.ColumnName = "BillingAddressLatitude";
            columnExpression48.Table = table3;
            column47.Expression = columnExpression48;
            columnExpression49.ColumnName = "BillingAddressLongitude";
            columnExpression49.Table = table3;
            column48.Expression = columnExpression49;
            columnExpression50.ColumnName = "Phone";
            columnExpression50.Table = table3;
            column49.Expression = columnExpression50;
            columnExpression51.ColumnName = "Fax";
            columnExpression51.Table = table3;
            column50.Expression = columnExpression51;
            columnExpression52.ColumnName = "Website";
            columnExpression52.Table = table3;
            column51.Expression = columnExpression52;
            columnExpression53.ColumnName = "AnnualRevenue";
            columnExpression53.Table = table3;
            column52.Expression = columnExpression53;
            columnExpression54.ColumnName = "TotalStores";
            columnExpression54.Table = table3;
            column53.Expression = columnExpression54;
            columnExpression55.ColumnName = "TotalEmployees";
            columnExpression55.Table = table3;
            column54.Expression = columnExpression55;
            columnExpression56.ColumnName = "Status";
            columnExpression56.Table = table3;
            column55.Expression = columnExpression56;
            columnExpression57.ColumnName = "Profile";
            columnExpression57.Table = table3;
            column56.Expression = columnExpression57;
            columnExpression58.ColumnName = "Logo";
            columnExpression58.Table = table3;
            column57.Expression = columnExpression58;
            selectQuery3.Columns.Add(column23);
            selectQuery3.Columns.Add(column24);
            selectQuery3.Columns.Add(column25);
            selectQuery3.Columns.Add(column26);
            selectQuery3.Columns.Add(column27);
            selectQuery3.Columns.Add(column28);
            selectQuery3.Columns.Add(column29);
            selectQuery3.Columns.Add(column30);
            selectQuery3.Columns.Add(column31);
            selectQuery3.Columns.Add(column32);
            selectQuery3.Columns.Add(column33);
            selectQuery3.Columns.Add(column34);
            selectQuery3.Columns.Add(column35);
            selectQuery3.Columns.Add(column36);
            selectQuery3.Columns.Add(column37);
            selectQuery3.Columns.Add(column38);
            selectQuery3.Columns.Add(column39);
            selectQuery3.Columns.Add(column40);
            selectQuery3.Columns.Add(column41);
            selectQuery3.Columns.Add(column42);
            selectQuery3.Columns.Add(column43);
            selectQuery3.Columns.Add(column44);
            selectQuery3.Columns.Add(column45);
            selectQuery3.Columns.Add(column46);
            selectQuery3.Columns.Add(column47);
            selectQuery3.Columns.Add(column48);
            selectQuery3.Columns.Add(column49);
            selectQuery3.Columns.Add(column50);
            selectQuery3.Columns.Add(column51);
            selectQuery3.Columns.Add(column52);
            selectQuery3.Columns.Add(column53);
            selectQuery3.Columns.Add(column54);
            selectQuery3.Columns.Add(column55);
            selectQuery3.Columns.Add(column56);
            selectQuery3.Columns.Add(column57);
            selectQuery3.MetaSerializable = "<Meta X=\"330\" Y=\"20\" Width=\"260\" Height=\"632\" />";
            selectQuery3.Name = "Customers";
            selectQuery3.Tables.Add(table3);
            columnExpression59.ColumnName = "Id";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table4.Name = "OrderItems";
            columnExpression59.Table = table4;
            column58.Expression = columnExpression59;
            columnExpression60.ColumnName = "OrderId";
            columnExpression60.Table = table4;
            column59.Expression = columnExpression60;
            columnExpression61.ColumnName = "ProductId";
            columnExpression61.Table = table4;
            column60.Expression = columnExpression61;
            columnExpression62.ColumnName = "ProductUnits";
            columnExpression62.Table = table4;
            column61.Expression = columnExpression62;
            columnExpression63.ColumnName = "ProductPrice";
            columnExpression63.Table = table4;
            column62.Expression = columnExpression63;
            columnExpression64.ColumnName = "Discount";
            columnExpression64.Table = table4;
            column63.Expression = columnExpression64;
            columnExpression65.ColumnName = "Total";
            columnExpression65.Table = table4;
            column64.Expression = columnExpression65;
            column65.Alias = "Product_Name";
            columnExpression66.ColumnName = "Name";
            table5.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"419\" />";
            table5.Name = "Products";
            columnExpression66.Table = table5;
            column65.Expression = columnExpression66;
            selectQuery4.Columns.Add(column58);
            selectQuery4.Columns.Add(column59);
            selectQuery4.Columns.Add(column60);
            selectQuery4.Columns.Add(column61);
            selectQuery4.Columns.Add(column62);
            selectQuery4.Columns.Add(column63);
            selectQuery4.Columns.Add(column64);
            selectQuery4.Columns.Add(column65);
            selectQuery4.MetaSerializable = "<Meta X=\"-30\" Y=\"20\" Width=\"100\" Height=\"173\" />";
            selectQuery4.Name = "OrderItems";
            relationColumnInfo1.NestedKeyColumn = "Id";
            relationColumnInfo1.ParentKeyColumn = "ProductId";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table5;
            join1.Parent = table4;
            selectQuery4.Relations.Add(join1);
            columnExpression67.ColumnName = "ProductUnits";
            columnExpression67.Table = table4;
            sorting2.Expression = columnExpression67;
            selectQuery4.Sorting.Add(sorting2);
            selectQuery4.Tables.Add(table4);
            selectQuery4.Tables.Add(table5);
            columnExpression68.ColumnName = "Id";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"457\" />";
            table6.Name = "CustomerStores";
            columnExpression68.Table = table6;
            column66.Expression = columnExpression68;
            columnExpression69.ColumnName = "CustomerId";
            columnExpression69.Table = table6;
            column67.Expression = columnExpression69;
            columnExpression70.ColumnName = "Address_Line";
            columnExpression70.Table = table6;
            column68.Expression = columnExpression70;
            columnExpression71.ColumnName = "Address_City";
            columnExpression71.Table = table6;
            column69.Expression = columnExpression71;
            columnExpression72.ColumnName = "Address_State";
            columnExpression72.Table = table6;
            column70.Expression = columnExpression72;
            columnExpression73.ColumnName = "Address_Latitude";
            columnExpression73.Table = table6;
            column71.Expression = columnExpression73;
            columnExpression74.ColumnName = "Address_Longitude";
            columnExpression74.Table = table6;
            column72.Expression = columnExpression74;
            columnExpression75.ColumnName = "Address_ZipCode";
            columnExpression75.Table = table6;
            column73.Expression = columnExpression75;
            columnExpression76.ColumnName = "Address_Line1";
            columnExpression76.Table = table6;
            column74.Expression = columnExpression76;
            columnExpression77.ColumnName = "Address_City1";
            columnExpression77.Table = table6;
            column75.Expression = columnExpression77;
            columnExpression78.ColumnName = "Address_State1";
            columnExpression78.Table = table6;
            column76.Expression = columnExpression78;
            columnExpression79.ColumnName = "Address_ZipCode1";
            columnExpression79.Table = table6;
            column77.Expression = columnExpression79;
            columnExpression80.ColumnName = "Address_Latitude1";
            columnExpression80.Table = table6;
            column78.Expression = columnExpression80;
            columnExpression81.ColumnName = "Address_Longitude1";
            columnExpression81.Table = table6;
            column79.Expression = columnExpression81;
            columnExpression82.ColumnName = "Phone";
            columnExpression82.Table = table6;
            column80.Expression = columnExpression82;
            columnExpression83.ColumnName = "Fax";
            columnExpression83.Table = table6;
            column81.Expression = columnExpression83;
            columnExpression84.ColumnName = "TotalEmployees";
            columnExpression84.Table = table6;
            column82.Expression = columnExpression84;
            columnExpression85.ColumnName = "SquereFootage";
            columnExpression85.Table = table6;
            column83.Expression = columnExpression85;
            columnExpression86.ColumnName = "AnnualSales";
            columnExpression86.Table = table6;
            column84.Expression = columnExpression86;
            columnExpression87.ColumnName = "CrestId";
            columnExpression87.Table = table6;
            column85.Expression = columnExpression87;
            columnExpression88.ColumnName = "Location";
            columnExpression88.Table = table6;
            column86.Expression = columnExpression88;
            selectQuery5.Columns.Add(column66);
            selectQuery5.Columns.Add(column67);
            selectQuery5.Columns.Add(column68);
            selectQuery5.Columns.Add(column69);
            selectQuery5.Columns.Add(column70);
            selectQuery5.Columns.Add(column71);
            selectQuery5.Columns.Add(column72);
            selectQuery5.Columns.Add(column73);
            selectQuery5.Columns.Add(column74);
            selectQuery5.Columns.Add(column75);
            selectQuery5.Columns.Add(column76);
            selectQuery5.Columns.Add(column77);
            selectQuery5.Columns.Add(column78);
            selectQuery5.Columns.Add(column79);
            selectQuery5.Columns.Add(column80);
            selectQuery5.Columns.Add(column81);
            selectQuery5.Columns.Add(column82);
            selectQuery5.Columns.Add(column83);
            selectQuery5.Columns.Add(column84);
            selectQuery5.Columns.Add(column85);
            selectQuery5.Columns.Add(column86);
            selectQuery5.MetaSerializable = "<Meta X=\"0\" Y=\"410\" Width=\"141\" Height=\"394\" />";
            selectQuery5.Name = "CustomerStores";
            selectQuery5.Tables.Add(table6);
            columnExpression89.ColumnName = "Id";
            table7.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"609\" />";
            table7.Name = "Employees";
            columnExpression89.Table = table7;
            column87.Expression = columnExpression89;
            columnExpression90.ColumnName = "Department";
            columnExpression90.Table = table7;
            column88.Expression = columnExpression90;
            columnExpression91.ColumnName = "Title";
            columnExpression91.Table = table7;
            column89.Expression = columnExpression91;
            columnExpression92.ColumnName = "Status";
            columnExpression92.Table = table7;
            column90.Expression = columnExpression92;
            columnExpression93.ColumnName = "HireDate";
            columnExpression93.Table = table7;
            column91.Expression = columnExpression93;
            columnExpression94.ColumnName = "PersonalProfile";
            columnExpression94.Table = table7;
            column92.Expression = columnExpression94;
            columnExpression95.ColumnName = "ProbationReason_Id";
            columnExpression95.Table = table7;
            column93.Expression = columnExpression95;
            columnExpression96.ColumnName = "FirstName";
            columnExpression96.Table = table7;
            column94.Expression = columnExpression96;
            columnExpression97.ColumnName = "LastName";
            columnExpression97.Table = table7;
            column95.Expression = columnExpression97;
            columnExpression98.ColumnName = "FullName";
            columnExpression98.Table = table7;
            column96.Expression = columnExpression98;
            columnExpression99.ColumnName = "Prefix";
            columnExpression99.Table = table7;
            column97.Expression = columnExpression99;
            columnExpression100.ColumnName = "HomePhone";
            columnExpression100.Table = table7;
            column98.Expression = columnExpression100;
            columnExpression101.ColumnName = "MobilePhone";
            columnExpression101.Table = table7;
            column99.Expression = columnExpression101;
            columnExpression102.ColumnName = "Email";
            columnExpression102.Table = table7;
            column100.Expression = columnExpression102;
            columnExpression103.ColumnName = "Skype";
            columnExpression103.Table = table7;
            column101.Expression = columnExpression103;
            columnExpression104.ColumnName = "BirthDate";
            columnExpression104.Table = table7;
            column102.Expression = columnExpression104;
            columnExpression105.ColumnName = "PictureId";
            columnExpression105.Table = table7;
            column103.Expression = columnExpression105;
            columnExpression106.ColumnName = "Address_Line";
            columnExpression106.Table = table7;
            column104.Expression = columnExpression106;
            columnExpression107.ColumnName = "Address_City";
            columnExpression107.Table = table7;
            column105.Expression = columnExpression107;
            columnExpression108.ColumnName = "Address_State";
            columnExpression108.Table = table7;
            column106.Expression = columnExpression108;
            columnExpression109.ColumnName = "Address_Latitude";
            columnExpression109.Table = table7;
            column107.Expression = columnExpression109;
            columnExpression110.ColumnName = "Address_Longitude";
            columnExpression110.Table = table7;
            column108.Expression = columnExpression110;
            columnExpression111.ColumnName = "Address_ZipCode";
            columnExpression111.Table = table7;
            column109.Expression = columnExpression111;
            columnExpression112.ColumnName = "AddressLine";
            columnExpression112.Table = table7;
            column110.Expression = columnExpression112;
            columnExpression113.ColumnName = "AddressCity";
            columnExpression113.Table = table7;
            column111.Expression = columnExpression113;
            columnExpression114.ColumnName = "AddressZipCode";
            columnExpression114.Table = table7;
            column112.Expression = columnExpression114;
            columnExpression115.ColumnName = "AddressState";
            columnExpression115.Table = table7;
            column113.Expression = columnExpression115;
            columnExpression116.ColumnName = "AddressLatitude";
            columnExpression116.Table = table7;
            column114.Expression = columnExpression116;
            columnExpression117.ColumnName = "AddressLongitude";
            columnExpression117.Table = table7;
            column115.Expression = columnExpression117;
            selectQuery6.Columns.Add(column87);
            selectQuery6.Columns.Add(column88);
            selectQuery6.Columns.Add(column89);
            selectQuery6.Columns.Add(column90);
            selectQuery6.Columns.Add(column91);
            selectQuery6.Columns.Add(column92);
            selectQuery6.Columns.Add(column93);
            selectQuery6.Columns.Add(column94);
            selectQuery6.Columns.Add(column95);
            selectQuery6.Columns.Add(column96);
            selectQuery6.Columns.Add(column97);
            selectQuery6.Columns.Add(column98);
            selectQuery6.Columns.Add(column99);
            selectQuery6.Columns.Add(column100);
            selectQuery6.Columns.Add(column101);
            selectQuery6.Columns.Add(column102);
            selectQuery6.Columns.Add(column103);
            selectQuery6.Columns.Add(column104);
            selectQuery6.Columns.Add(column105);
            selectQuery6.Columns.Add(column106);
            selectQuery6.Columns.Add(column107);
            selectQuery6.Columns.Add(column108);
            selectQuery6.Columns.Add(column109);
            selectQuery6.Columns.Add(column110);
            selectQuery6.Columns.Add(column111);
            selectQuery6.Columns.Add(column112);
            selectQuery6.Columns.Add(column113);
            selectQuery6.Columns.Add(column114);
            selectQuery6.Columns.Add(column115);
            selectQuery6.MetaSerializable = "<Meta X=\"610\" Y=\"20\" Width=\"141\" Height=\"530\" />";
            selectQuery6.Name = "DataEmployees";
            selectQuery6.Tables.Add(table7);
            columnExpression118.ColumnName = "Id";
            table8.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"419\" />";
            table8.Name = "Products";
            columnExpression118.Table = table8;
            column116.Expression = columnExpression118;
            columnExpression119.ColumnName = "Name";
            columnExpression119.Table = table8;
            column117.Expression = columnExpression119;
            columnExpression120.ColumnName = "Description";
            columnExpression120.Table = table8;
            column118.Expression = columnExpression120;
            columnExpression121.ColumnName = "ProductionStart";
            columnExpression121.Table = table8;
            column119.Expression = columnExpression121;
            columnExpression122.ColumnName = "Available";
            columnExpression122.Table = table8;
            column120.Expression = columnExpression122;
            columnExpression123.ColumnName = "Image";
            columnExpression123.Table = table8;
            column121.Expression = columnExpression123;
            columnExpression124.ColumnName = "SupportId";
            columnExpression124.Table = table8;
            column122.Expression = columnExpression124;
            columnExpression125.ColumnName = "EngineerId";
            columnExpression125.Table = table8;
            column123.Expression = columnExpression125;
            columnExpression126.ColumnName = "CurrentInventory";
            columnExpression126.Table = table8;
            column124.Expression = columnExpression126;
            columnExpression127.ColumnName = "Backorder";
            columnExpression127.Table = table8;
            column125.Expression = columnExpression127;
            columnExpression128.ColumnName = "Manufacturing";
            columnExpression128.Table = table8;
            column126.Expression = columnExpression128;
            columnExpression129.ColumnName = "Barcode";
            columnExpression129.Table = table8;
            column127.Expression = columnExpression129;
            columnExpression130.ColumnName = "PrimaryImageId";
            columnExpression130.Table = table8;
            column128.Expression = columnExpression130;
            columnExpression131.ColumnName = "Cost";
            columnExpression131.Table = table8;
            column129.Expression = columnExpression131;
            columnExpression132.ColumnName = "SalePrice";
            columnExpression132.Table = table8;
            column130.Expression = columnExpression132;
            columnExpression133.ColumnName = "RetailPrice";
            columnExpression133.Table = table8;
            column131.Expression = columnExpression133;
            columnExpression134.ColumnName = "Weight";
            columnExpression134.Table = table8;
            column132.Expression = columnExpression134;
            columnExpression135.ColumnName = "ConsumerRating";
            columnExpression135.Table = table8;
            column133.Expression = columnExpression135;
            columnExpression136.ColumnName = "Category";
            columnExpression136.Table = table8;
            column134.Expression = columnExpression136;
            columnExpression137.ColumnName = "PDF";
            table9.MetaSerializable = "<Meta X=\"190\" Y=\"40\" Width=\"125\" Height=\"115\" />";
            table9.Name = "ProductCatalogs";
            columnExpression137.Table = table9;
            column135.Expression = columnExpression137;
            selectQuery7.Columns.Add(column116);
            selectQuery7.Columns.Add(column117);
            selectQuery7.Columns.Add(column118);
            selectQuery7.Columns.Add(column119);
            selectQuery7.Columns.Add(column120);
            selectQuery7.Columns.Add(column121);
            selectQuery7.Columns.Add(column122);
            selectQuery7.Columns.Add(column123);
            selectQuery7.Columns.Add(column124);
            selectQuery7.Columns.Add(column125);
            selectQuery7.Columns.Add(column126);
            selectQuery7.Columns.Add(column127);
            selectQuery7.Columns.Add(column128);
            selectQuery7.Columns.Add(column129);
            selectQuery7.Columns.Add(column130);
            selectQuery7.Columns.Add(column131);
            selectQuery7.Columns.Add(column132);
            selectQuery7.Columns.Add(column133);
            selectQuery7.Columns.Add(column134);
            selectQuery7.Columns.Add(column135);
            selectQuery7.MetaSerializable = "<Meta X=\"960\" Y=\"410\" Width=\"125\" Height=\"360\" />";
            selectQuery7.Name = "Products";
            relationColumnInfo2.NestedKeyColumn = "ProductId";
            relationColumnInfo2.ParentKeyColumn = "Id";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table9;
            join2.Parent = table8;
            selectQuery7.Relations.Add(join2);
            selectQuery7.Tables.Add(table8);
            selectQuery7.Tables.Add(table9);
            reportSqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2,
            selectQuery3,
            selectQuery4,
            selectQuery5,
            selectQuery6,
            selectQuery7});
            masterDetailInfo1.DetailQueryName = "Customers";
            relationColumnInfo3.NestedKeyColumn = "Id";
            relationColumnInfo3.ParentKeyColumn = "CustomerId";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3);
            masterDetailInfo1.MasterQueryName = "Orders";
            masterDetailInfo1.Name = "Customer";
            masterDetailInfo2.DetailQueryName = "OrderItems";
            relationColumnInfo4.NestedKeyColumn = "OrderId";
            relationColumnInfo4.ParentKeyColumn = "Id";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo4);
            masterDetailInfo2.MasterQueryName = "Orders";
            masterDetailInfo2.Name = "OrderItems";
            masterDetailInfo3.DetailQueryName = "CustomerStores";
            relationColumnInfo5.NestedKeyColumn = "Id";
            relationColumnInfo5.ParentKeyColumn = "StoreId";
            masterDetailInfo3.KeyColumns.Add(relationColumnInfo5);
            masterDetailInfo3.MasterQueryName = "Orders";
            masterDetailInfo3.Name = "Store";
            masterDetailInfo4.DetailQueryName = "DataEmployees";
            relationColumnInfo6.NestedKeyColumn = "Id";
            relationColumnInfo6.ParentKeyColumn = "EmployeeId";
            masterDetailInfo4.KeyColumns.Add(relationColumnInfo6);
            masterDetailInfo4.MasterQueryName = "Orders";
            masterDetailInfo4.Name = "Employee";
            masterDetailInfo5.DetailQueryName = "ProductCatalogs";
            relationColumnInfo7.NestedKeyColumn = "ProductId";
            relationColumnInfo7.ParentKeyColumn = "Id";
            masterDetailInfo5.KeyColumns.Add(relationColumnInfo7);
            masterDetailInfo5.MasterQueryName = "Products";
            masterDetailInfo5.Name = "Catalog";
            masterDetailInfo6.DetailQueryName = "Products";
            relationColumnInfo8.NestedKeyColumn = "Id";
            relationColumnInfo8.ParentKeyColumn = "ProductId";
            masterDetailInfo6.KeyColumns.Add(relationColumnInfo8);
            masterDetailInfo6.MasterQueryName = "OrderItems";
            reportSqlDataSource.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2,
            masterDetailInfo3,
            masterDetailInfo4,
            masterDetailInfo5,
            masterDetailInfo6});
            reportSqlDataSource.ResultSchemaSerializable = resources.GetString("reportSqlDataSource.ResultSchemaSerializable");
            // 
            // DetailReport1
            // 
            DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            Detail1,
            DetailReport2});
            DetailReport1.DataMember = "Orders";
            DetailReport1.DataSource = reportSqlDataSource;
            DetailReport1.Dpi = 96F;
            DetailReport1.Level = 1;
            DetailReport1.Name = "DetailReport1";
            // 
            // Detail1
            // 
            Detail1.Dpi = 96F;
            Detail1.HeightF = 0F;
            Detail1.HierarchyPrintOptions.Indent = 19.2F;
            Detail1.Name = "Detail1";
            // 
            // DetailReport2
            // 
            DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            Detail2});
            DetailReport2.DataMember = "Orders.OrderItems";
            DetailReport2.DataSource = reportSqlDataSource;
            DetailReport2.Dpi = 96F;
            DetailReport2.Level = 0;
            DetailReport2.Name = "DetailReport2";
            // 
            // Detail2
            // 
            Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrPdfContent1});
            Detail2.Dpi = 96F;
            Detail2.HeightF = 22.08F;
            Detail2.HierarchyPrintOptions.Indent = 19.2F;
            Detail2.Name = "Detail2";
            // 
            // xrPdfContent1
            // 
            xrPdfContent1.Dpi = 96F;
            xrPdfContent1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Source", "[OrderItemsProducts].[PDF]")});
            xrPdfContent1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrPdfContent1.Name = "xrPdfContent1";
            xrPdfContent1.SizeF = new System.Drawing.SizeF(717F, 22.08F);
            // 
            // HeaderStyle
            // 
            HeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 26F, DevExpress.Drawing.DXFontStyle.Bold);
            HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(67, 73, 86);
            HeaderStyle.Name = "HeaderStyle";
            HeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // General
            // 
            General.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            General.ForeColor = System.Drawing.Color.FromArgb(67, 73, 86);
            General.Name = "General";
            General.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            // 
            // Comments
            // 
            Comments.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            Comments.ForeColor = System.Drawing.Color.FromArgb(167, 174, 187);
            Comments.Name = "Comments";
            // 
            // BillingShippingHeaderStyle
            // 
            BillingShippingHeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            BillingShippingHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(167, 174, 187);
            BillingShippingHeaderStyle.Name = "BillingShippingHeaderStyle";
            // 
            // TableHeaderStyle
            // 
            TableHeaderStyle.BackColor = System.Drawing.Color.Transparent;
            TableHeaderStyle.BorderColor = System.Drawing.Color.FromArgb(92, 100, 118);
            TableHeaderStyle.Borders = (DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
            TableHeaderStyle.BorderWidth = 2F;
            TableHeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(92, 100, 118);
            TableHeaderStyle.Name = "TableHeaderStyle";
            // 
            // DetailTableHeaderStyle
            // 
            DetailTableHeaderStyle.BackColor = System.Drawing.Color.FromArgb(92, 100, 118);
            DetailTableHeaderStyle.Borders = (DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right);
            DetailTableHeaderStyle.BorderWidth = 0F;
            DetailTableHeaderStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F, DevExpress.Drawing.DXFontStyle.Bold);
            DetailTableHeaderStyle.ForeColor = System.Drawing.Color.White;
            DetailTableHeaderStyle.Name = "DetailTableHeaderStyle";
            // 
            // TableOddStyle
            // 
            TableOddStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            TableOddStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            TableOddStyle.BorderWidth = 1F;
            TableOddStyle.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            TableOddStyle.ForeColor = System.Drawing.Color.FromArgb(67, 73, 86);
            TableOddStyle.Name = "TableOddStyle";
            TableOddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            TableOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // HomeOffice_StateName
            // 
            HomeOffice_StateName.DataMember = "Orders.Customer";
            HomeOffice_StateName.Expression = resources.GetString("HomeOffice_StateName.Expression");
            HomeOffice_StateName.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            HomeOffice_StateName.Name = "HomeOffice_StateName";
            // 
            // Address_StateName
            // 
            Address_StateName.DataMember = "Orders.Store";
            Address_StateName.Expression = resources.GetString("Address_StateName.Expression");
            Address_StateName.Name = "Address_StateName";
            // 
            // paramShowHeader
            // 
            paramShowHeader.Description = "ParamShowHeader";
            paramShowHeader.Name = "paramShowHeader";
            paramShowHeader.Type = typeof(bool);
            paramShowHeader.ValueInfo = "True";
            paramShowHeader.Visible = false;
            // 
            // paramShowFooter
            // 
            paramShowFooter.Description = "Show Footer";
            paramShowFooter.Name = "paramShowFooter";
            paramShowFooter.Type = typeof(bool);
            paramShowFooter.ValueInfo = "True";
            paramShowFooter.Visible = false;
            // 
            // paramShowStatus
            // 
            paramShowStatus.Description = "Show Status";
            paramShowStatus.Name = "paramShowStatus";
            paramShowStatus.Type = typeof(bool);
            paramShowStatus.ValueInfo = "True";
            paramShowStatus.Visible = false;
            // 
            // paramShowComments
            // 
            paramShowComments.Description = "Show Comments";
            paramShowComments.Name = "paramShowComments";
            paramShowComments.Type = typeof(bool);
            paramShowComments.ValueInfo = "True";
            paramShowComments.Visible = false;
            // 
            // parameterInvoice
            // 
            parameterInvoice.Description = "Invoice Number";
            parameterInvoice.Name = "parameterInvoice";
            parameterInvoice.ValueInfo = "243817";
            dynamicListLookUpSettings1.DataMember = "Orders";
            dynamicListLookUpSettings1.DataSource = parameterSqlDataSource;
            dynamicListLookUpSettings1.DisplayMember = null;
            dynamicListLookUpSettings1.SortMember = "OrderDate";
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "InvoiceNumber";
            parameterInvoice.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // xrPdfSignature1
            // 
            xrPdfSignature1.Dpi = 96F;
            xrPdfSignature1.LocationFloat = new DevExpress.Utils.PointFloat(22.99512F, 43.75F);
            xrPdfSignature1.Name = "xrPdfSignature1";
            xrPdfSignature1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 96F);
            xrPdfSignature1.SizeF = new System.Drawing.SizeF(375.5455F, 92.60126F);
            // 
            // Report
            // 
            Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            topMarginBand1,
            detailBand1,
            bottomMarginBand1,
            OrdersDetailReport,
            DetailReport1});
            CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            HomeOffice_StateName,
            Address_StateName});
            ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            reportSqlDataSource,
            parameterSqlDataSource});
            DataSource = reportSqlDataSource;
            DisplayName = "Report Merging with PDF";
            Dpi = 96F;
            DrawWatermark = true;
            Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            Margins = new DevExpress.Drawing.DXMargins(56, 43, 46, 60);
            PageHeight = 1056;
            PageWidth = 816;
            Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            paramShowHeader,
            paramShowFooter,
            paramShowStatus,
            paramShowComments,
            parameterInvoice});
            ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            RequestParameters = false;
            SnapGridSize = 12.5F;
            StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            HeaderStyle,
            General,
            Comments,
            BillingShippingHeaderStyle,
            TableHeaderStyle,
            DetailTableHeaderStyle,
            TableOddStyle});
            Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
