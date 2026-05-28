using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.NorthwindTraders {
    partial class CatalogReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbFallCatalog;
        private DevExpress.XtraReports.UI.XRLabel lbCommitment;
        private DevExpress.XtraReports.UI.XRLabel lbCommitment1;
        private DevExpress.XtraReports.UI.XRLabel lbTourTitle;
        private DevExpress.XtraReports.UI.XRLabel lbTourParagraph;
        private DevExpress.XtraReports.UI.XRLabel lbTourParagraph1;
        private DevExpress.XtraReports.UI.XRLabel lbTourParagraph2;
        private DevExpress.XtraReports.UI.XRLabel lbTourParagraph3;
        private DevExpress.XtraReports.UI.XRLabel lbTourParagraph4;
        private DevExpress.XtraReports.UI.XRPictureBox pbLargeLogo;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel lbDesciption;
        private DevExpress.XtraReports.UI.XRPictureBox PictureBox;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lbPageNumber;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel lbOrderForm;
        private DevExpress.XtraReports.UI.XRLabel lbAddress;
        private DevExpress.XtraReports.UI.XRLabel lbInstructionsText;
        private DevExpress.XtraReports.UI.XRLabel lbBillTo;
        private DevExpress.XtraReports.UI.XRLabel lbShipTo;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
        private DevExpress.XtraReports.UI.XRLine xrLine6;
        private DevExpress.XtraReports.UI.XRLine xrLine7;
        private DevExpress.XtraReports.UI.XRLine xrLine8;
        private DevExpress.XtraReports.UI.XRLine xrLine9;
        private DevExpress.XtraReports.UI.XRLine xrLine10;
        private DevExpress.XtraReports.UI.XRLine xrLine11;
        private DevExpress.XtraReports.UI.XRLabel lbDateOfOrder;
        private DevExpress.XtraReports.UI.XRLabel lbDateRequired;
        private DevExpress.XtraReports.UI.XRLine xrLine12;
        private DevExpress.XtraReports.UI.XRLabel lbCustomerID;
        private DevExpress.XtraReports.UI.XRLine xrLine13;
        private DevExpress.XtraReports.UI.XRLabel lbShipVia;
        private DevExpress.XtraReports.UI.XRLine lnThickLeft;
        private DevExpress.XtraReports.UI.XRLine lnThinLeft;
        private DevExpress.XtraReports.UI.XRLine lnThickRight;
        private DevExpress.XtraReports.UI.XRLine lnThinRight;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRCheckBox cbSpeedyExpress;
        private DevExpress.XtraReports.UI.XRCheckBox cbUnitedPackage;
        private DevExpress.XtraReports.UI.XRCheckBox cbFederalShipping;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell30;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell33;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell35;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell36;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell37;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell38;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell39;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell40;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell41;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell42;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell43;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell44;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell45;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell46;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell47;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell48;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell49;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell50;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell51;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell52;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell53;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell54;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell55;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell56;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell57;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell58;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell59;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell60;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell61;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell62;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell63;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell64;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell65;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell67;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell69;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell70;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell66;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell68;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell71;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell72;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell73;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell74;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogReport));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
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
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTableOfContents1 = new DevExpress.XtraReports.UI.XRTableOfContents();
            this.lbTourParagraph4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTourParagraph3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTourParagraph2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTourParagraph1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTourParagraph = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTourTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.lbFallCatalog = new DevExpress.XtraReports.UI.XRLabel();
            this.pbLargeLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lnThickLeft = new DevExpress.XtraReports.UI.XRLine();
            this.lnThinLeft = new DevExpress.XtraReports.UI.XRLine();
            this.lbCommitment1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCommitment = new DevExpress.XtraReports.UI.XRLabel();
            this.lnThickRight = new DevExpress.XtraReports.UI.XRLine();
            this.lnThinRight = new DevExpress.XtraReports.UI.XRLine();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lbHighestPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.lbLowestPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTotalSales = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCount = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDesciption = new DevExpress.XtraReports.UI.XRLabel();
            this.PictureBox = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbPageNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.cbFederalShipping = new DevExpress.XtraReports.UI.XRCheckBox();
            this.lbShipVia = new DevExpress.XtraReports.UI.XRLabel();
            this.cbSpeedyExpress = new DevExpress.XtraReports.UI.XRCheckBox();
            this.cbUnitedPackage = new DevExpress.XtraReports.UI.XRCheckBox();
            this.lbInstructionsText = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.lbCustomerID = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.lbDateRequired = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDateOfOrder = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.lbShipTo = new DevExpress.XtraReports.UI.XRLabel();
            this.lbBillTo = new DevExpress.XtraReports.UI.XRLabel();
            this.lbAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.lbOrderForm = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.parameterSortGroupsType = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterSortGroupsOrder = new DevExpress.XtraReports.Parameters.Parameter();
            this.ProductSales = new DevExpress.XtraReports.UI.CalculatedField();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 24F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.BookmarkParent = this.lbCategoryName;
            this.xrTable2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "ProductName")});
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(33F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable2.SizeF = new System.Drawing.SizeF(572F, 24F);
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbCategoryName.BorderColor = System.Drawing.Color.White;
            this.lbCategoryName.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.lbCategoryName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "CategoryName"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CategoryName")});
            this.lbCategoryName.Font = new DevExpress.Drawing.DXFont("Tahoma", 21F);
            this.lbCategoryName.ForeColor = System.Drawing.Color.DimGray;
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(34F, 33.00006F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(391F, 44.00002F);
            this.lbCategoryName.Text = "xrLabel1";
            this.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrTableRow3.BorderColor = System.Drawing.Color.White;
            this.xrTableRow3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell9,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow3.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 0.42832167832167833D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductID")});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 0, 0, 0, 100F);
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 0.16433566433566432D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "QuantityPerUnit")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.23426573426573427D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UnitPrice")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 7, 0, 0, 100F);
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell6.TextFormatString = "{0:C}";
            this.xrTableCell6.Weight = 0.17307692307692307D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.BorderColor = System.Drawing.Color.Black;
            this.ReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableOfContents1,
            this.lbTourParagraph4,
            this.lbTourParagraph3,
            this.lbTourParagraph2,
            this.lbTourParagraph1,
            this.lbTourParagraph,
            this.lbTourTitle,
            this.lbFallCatalog,
            this.pbLargeLogo,
            this.lnThickLeft,
            this.lnThinLeft,
            this.lbCommitment1,
            this.lbCommitment,
            this.lnThickRight,
            this.lnThinRight});
            this.ReportHeader.HeightF = 1848F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableOfContents1
            // 
            this.xrTableOfContents1.LevelDefault.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F);
            this.xrTableOfContents1.LevelDefault.Padding = new DevExpress.XtraPrinting.PaddingInfo(50, 50, 0, 0, 100F);
            this.xrTableOfContents1.LevelTitle.Font = new DevExpress.Drawing.DXFont("Segoe UI", 14.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableOfContents1.LevelTitle.Height = 325F;
            this.xrTableOfContents1.LevelTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(50, 0, 250, 0, 100F);
            this.xrTableOfContents1.LevelTitle.Text = "Table of Contents";
            this.xrTableOfContents1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1500F);
            this.xrTableOfContents1.MaxNestingLevel = 1;
            this.xrTableOfContents1.Name = "xrTableOfContents1";
            this.xrTableOfContents1.StylePriority.UsePadding = false;
            // 
            // lbTourParagraph4
            // 
            this.lbTourParagraph4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbTourParagraph4.ForeColor = System.Drawing.Color.Black;
            this.lbTourParagraph4.LocationFloat = new DevExpress.Utils.PointFloat(125F, 1366F);
            this.lbTourParagraph4.Name = "lbTourParagraph4";
            this.lbTourParagraph4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTourParagraph4.SizeF = new System.Drawing.SizeF(400F, 66F);
            this.lbTourParagraph4.Text = "Our sales representatives are ready to take your orders now. For your convenience" +
    ", we\'ve included details on ordering on the last page of this catalog.";
            this.lbTourParagraph4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTourParagraph3
            // 
            this.lbTourParagraph3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbTourParagraph3.ForeColor = System.Drawing.Color.Black;
            this.lbTourParagraph3.LocationFloat = new DevExpress.Utils.PointFloat(125F, 1266F);
            this.lbTourParagraph3.Name = "lbTourParagraph3";
            this.lbTourParagraph3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTourParagraph3.SizeF = new System.Drawing.SizeF(400F, 91F);
            this.lbTourParagraph3.Text = resources.GetString("lbTourParagraph3.Text");
            this.lbTourParagraph3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTourParagraph2
            // 
            this.lbTourParagraph2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbTourParagraph2.ForeColor = System.Drawing.Color.Black;
            this.lbTourParagraph2.LocationFloat = new DevExpress.Utils.PointFloat(125F, 1200F);
            this.lbTourParagraph2.Name = "lbTourParagraph2";
            this.lbTourParagraph2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTourParagraph2.SizeF = new System.Drawing.SizeF(400F, 58F);
            this.lbTourParagraph2.Text = "For thirst quenchers, try exotic Chang, hearty Laughing Lumberjack Lager, robust " +
    "Rhnbru Klosterbier, and refreshing Lakkalikri.";
            this.lbTourParagraph2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTourParagraph1
            // 
            this.lbTourParagraph1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbTourParagraph1.ForeColor = System.Drawing.Color.Black;
            this.lbTourParagraph1.LocationFloat = new DevExpress.Utils.PointFloat(125F, 1141F);
            this.lbTourParagraph1.Name = "lbTourParagraph1";
            this.lbTourParagraph1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTourParagraph1.SizeF = new System.Drawing.SizeF(400F, 41F);
            this.lbTourParagraph1.Text = "The beverages and confections we\'re featuring this fall are sure to please even t" +
    "he most discerning palates.";
            this.lbTourParagraph1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTourParagraph
            // 
            this.lbTourParagraph.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbTourParagraph.ForeColor = System.Drawing.Color.Black;
            this.lbTourParagraph.LocationFloat = new DevExpress.Utils.PointFloat(125F, 1050F);
            this.lbTourParagraph.Name = "lbTourParagraph";
            this.lbTourParagraph.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTourParagraph.SizeF = new System.Drawing.SizeF(400F, 75F);
            this.lbTourParagraph.Text = "When Northwind Traders buyers set out to search for the Wonders of the Gastronomi" +
    "c World they found a lot more than seven of them. And here they are--tastefully " +
    "presented in our Fall Catalog.";
            this.lbTourParagraph.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTourTitle
            // 
            this.lbTourTitle.Font = new DevExpress.Drawing.DXFont("Times New Roman", 18F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbTourTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTourTitle.LocationFloat = new DevExpress.Utils.PointFloat(150F, 966F);
            this.lbTourTitle.Multiline = true;
            this.lbTourTitle.Name = "lbTourTitle";
            this.lbTourTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTourTitle.SizeF = new System.Drawing.SizeF(350F, 58F);
            this.lbTourTitle.Text = "Tour the Gastronomic World with Northwind Traders!";
            this.lbTourTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbFallCatalog
            // 
            this.lbFallCatalog.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbFallCatalog.ForeColor = System.Drawing.Color.Maroon;
            this.lbFallCatalog.LocationFloat = new DevExpress.Utils.PointFloat(267F, 442F);
            this.lbFallCatalog.Name = "lbFallCatalog";
            this.lbFallCatalog.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbFallCatalog.SizeF = new System.Drawing.SizeF(116F, 25F);
            this.lbFallCatalog.Text = "Fall Catalog";
            this.lbFallCatalog.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pbLargeLogo
            // 
            this.pbLargeLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pbLargeLogo.ImageSource"));
            this.pbLargeLogo.LocationFloat = new DevExpress.Utils.PointFloat(180F, 50F);
            this.pbLargeLogo.Name = "pbLargeLogo";
            this.pbLargeLogo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.pbLargeLogo.SizeF = new System.Drawing.SizeF(290.625F, 320.8333F);
            this.pbLargeLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.pbLargeLogo.UseImageResolution = false;
            // 
            // lnThickLeft
            // 
            this.lnThickLeft.LineWidth = 4F;
            this.lnThickLeft.LocationFloat = new DevExpress.Utils.PointFloat(0F, 175F);
            this.lnThickLeft.Name = "lnThickLeft";
            this.lnThickLeft.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.lnThickLeft.SizeF = new System.Drawing.SizeF(180F, 8F);
            // 
            // lnThinLeft
            // 
            this.lnThinLeft.LocationFloat = new DevExpress.Utils.PointFloat(0F, 167F);
            this.lnThinLeft.Name = "lnThinLeft";
            this.lnThinLeft.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.lnThinLeft.SizeF = new System.Drawing.SizeF(180F, 8F);
            // 
            // lbCommitment1
            // 
            this.lbCommitment1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbCommitment1.ForeColor = System.Drawing.Color.Maroon;
            this.lbCommitment1.LocationFloat = new DevExpress.Utils.PointFloat(171F, 695F);
            this.lbCommitment1.Name = "lbCommitment1";
            this.lbCommitment1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCommitment1.SizeF = new System.Drawing.SizeF(308F, 100F);
            this.lbCommitment1.Text = resources.GetString("lbCommitment1.Text");
            this.lbCommitment1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCommitment
            // 
            this.lbCommitment.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14.25F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lbCommitment.ForeColor = System.Drawing.Color.Maroon;
            this.lbCommitment.LocationFloat = new DevExpress.Utils.PointFloat(221F, 658F);
            this.lbCommitment.Name = "lbCommitment";
            this.lbCommitment.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCommitment.SizeF = new System.Drawing.SizeF(208F, 23F);
            this.lbCommitment.Text = "Commitment to Quality";
            this.lbCommitment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lnThickRight
            // 
            this.lnThickRight.LineWidth = 4F;
            this.lnThickRight.LocationFloat = new DevExpress.Utils.PointFloat(471F, 175F);
            this.lnThickRight.Name = "lnThickRight";
            this.lnThickRight.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.lnThickRight.SizeF = new System.Drawing.SizeF(179F, 8F);
            // 
            // lnThinRight
            // 
            this.lnThinRight.LocationFloat = new DevExpress.Utils.PointFloat(471F, 167F);
            this.lnThinRight.Name = "lnThinRight";
            this.lnThinRight.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.lnThinRight.SizeF = new System.Drawing.SizeF(179F, 8F);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHighestPrice,
            this.lbLowestPrice,
            this.lbTotalSales,
            this.lbCount,
            this.lbCategoryName,
            this.lbDesciption,
            this.PictureBox,
            this.xrTable1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeader1.HeightF = 178F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbHighestPrice
            // 
            this.lbHighestPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbHighestPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumMax(UnitPrice)")});
            this.lbHighestPrice.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.lbHighestPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbHighestPrice.LocationFloat = new DevExpress.Utils.PointFloat(226F, 127F);
            this.lbHighestPrice.Name = "lbHighestPrice";
            this.lbHighestPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 12, 0, 0, 100F);
            this.lbHighestPrice.SizeF = new System.Drawing.SizeF(198F, 22.99995F);
            this.lbHighestPrice.StylePriority.UseBackColor = false;
            this.lbHighestPrice.StylePriority.UseFont = false;
            this.lbHighestPrice.StylePriority.UseForeColor = false;
            this.lbHighestPrice.StylePriority.UsePadding = false;
            this.lbHighestPrice.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.lbHighestPrice.Summary = xrSummary1;
            this.lbHighestPrice.Text = "lbHighestPrice";
            this.lbHighestPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbHighestPrice.TextFormatString = "Highest Price: {0:C}";
            // 
            // lbLowestPrice
            // 
            this.lbLowestPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbLowestPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumMin(UnitPrice)")});
            this.lbLowestPrice.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.lbLowestPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbLowestPrice.LocationFloat = new DevExpress.Utils.PointFloat(226F, 104.0001F);
            this.lbLowestPrice.Name = "lbLowestPrice";
            this.lbLowestPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 12, 0, 0, 100F);
            this.lbLowestPrice.SizeF = new System.Drawing.SizeF(198F, 22.99995F);
            this.lbLowestPrice.StylePriority.UseBackColor = false;
            this.lbLowestPrice.StylePriority.UseFont = false;
            this.lbLowestPrice.StylePriority.UseForeColor = false;
            this.lbLowestPrice.StylePriority.UsePadding = false;
            this.lbLowestPrice.StylePriority.UseTextAlignment = false;
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.lbLowestPrice.Summary = xrSummary2;
            this.lbLowestPrice.Text = "lbLowestPrice";
            this.lbLowestPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbLowestPrice.TextFormatString = "Lowest Price: {0:C}";
            // 
            // lbTotalSales
            // 
            this.lbTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbTotalSales.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(ProductSales)")});
            this.lbTotalSales.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.lbTotalSales.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotalSales.LocationFloat = new DevExpress.Utils.PointFloat(34F, 127F);
            this.lbTotalSales.Name = "lbTotalSales";
            this.lbTotalSales.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 12, 0, 0, 100F);
            this.lbTotalSales.SizeF = new System.Drawing.SizeF(192F, 22.99995F);
            this.lbTotalSales.StylePriority.UseBackColor = false;
            this.lbTotalSales.StylePriority.UseFont = false;
            this.lbTotalSales.StylePriority.UseForeColor = false;
            this.lbTotalSales.StylePriority.UsePadding = false;
            this.lbTotalSales.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.lbTotalSales.Summary = xrSummary3;
            this.lbTotalSales.Text = "lbTotalSales";
            this.lbTotalSales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbTotalSales.TextFormatString = "Total Sales: {0:C}";
            // 
            // lbCount
            // 
            this.lbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbCount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([ProductID])")});
            this.lbCount.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F);
            this.lbCount.ForeColor = System.Drawing.Color.DimGray;
            this.lbCount.LocationFloat = new DevExpress.Utils.PointFloat(34F, 104.0001F);
            this.lbCount.Name = "lbCount";
            this.lbCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 12, 0, 0, 100F);
            this.lbCount.SizeF = new System.Drawing.SizeF(192F, 22.99995F);
            this.lbCount.StylePriority.UseBackColor = false;
            this.lbCount.StylePriority.UseFont = false;
            this.lbCount.StylePriority.UseForeColor = false;
            this.lbCount.StylePriority.UsePadding = false;
            this.lbCount.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.lbCount.Summary = xrSummary4;
            this.lbCount.Text = "lbCount";
            this.lbCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbCount.TextFormatString = "Items Count: {0}";
            // 
            // lbDesciption
            // 
            this.lbDesciption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbDesciption.BorderColor = System.Drawing.Color.White;
            this.lbDesciption.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.lbDesciption.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Description")});
            this.lbDesciption.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.lbDesciption.ForeColor = System.Drawing.Color.DarkGray;
            this.lbDesciption.LocationFloat = new DevExpress.Utils.PointFloat(33.99998F, 77.00008F);
            this.lbDesciption.Name = "lbDesciption";
            this.lbDesciption.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 12, 0, 0, 100F);
            this.lbDesciption.SizeF = new System.Drawing.SizeF(391F, 27F);
            this.lbDesciption.Text = "xrLabel1";
            this.lbDesciption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PictureBox
            // 
            this.PictureBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.PictureBox.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PictureBox.BorderWidth = 5F;
            this.PictureBox.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "Picture")});
            this.PictureBox.LocationFloat = new DevExpress.Utils.PointFloat(425F, 33F);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PictureBox.SizeF = new System.Drawing.SizeF(180F, 117F);
            this.PictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderColor = System.Drawing.Color.White;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(33F, 152F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(572F, 26F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(73)))));
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableRow1.ForeColor = System.Drawing.Color.White;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.Text = "Product Name:";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.42832167832167833D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.Text = "Product ID:";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.16433566433566432D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.Text = "Quantity Per Unit:";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.23426573426573427D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.Text = "Unit Price: ";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.17307692307692307D;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable4.ForeColor = System.Drawing.Color.Black;
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(34F, 425F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow19});
            this.xrTable4.SizeF = new System.Drawing.SizeF(582F, 258F);
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell13,
            this.xrTableCell11,
            this.xrTableCell14,
            this.xrTableCell12});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow4.Weight = 0.16279069767441862D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell10.Text = "Product ID:";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 0.1872852233676976D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell13.Text = "Product Name:";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 0.3127147766323024D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell11.Text = "Unit Price:";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 0.16666666666666666D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell14.Text = "Quantity:";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell14.Weight = 0.16838487972508592D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell12.Text = "Extended Price:";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell12.Weight = 0.16494845360824742D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow5.Weight = 0.069767441860465115D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell15.Weight = 0.1872852233676976D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell22.Weight = 0.3127147766323024D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 0.16666666666666666D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell24.Weight = 0.16838487972508592D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell25.Weight = 0.16494845360824742D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow9.Weight = 0.069767441860465115D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell26.Weight = 0.1872852233676976D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell27.Weight = 0.3127147766323024D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell28.Weight = 0.16666666666666666D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell29.Weight = 0.16838487972508592D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell30.Weight = 0.16494845360824742D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow10.Weight = 0.069767441860465115D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell31.Weight = 0.1872852233676976D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell32.Weight = 0.3127147766323024D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell33.Weight = 0.16666666666666666D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell34.Weight = 0.16838487972508592D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell35.Weight = 0.16494845360824742D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow11.Weight = 0.069767441860465115D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell36.Weight = 0.1872852233676976D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell37.Weight = 0.3127147766323024D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell38.Weight = 0.16666666666666666D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell39.Weight = 0.16838487972508592D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell40.Weight = 0.16494845360824742D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow12.Weight = 0.069767441860465115D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell41.Weight = 0.1872852233676976D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell42.Weight = 0.3127147766323024D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell43.Weight = 0.16666666666666666D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell44.Weight = 0.16838487972508592D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell45.Weight = 0.16494845360824742D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell50});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow13.Weight = 0.069767441860465115D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell46.Weight = 0.1872852233676976D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell47.Weight = 0.3127147766323024D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell48.Weight = 0.16666666666666666D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell49.Weight = 0.16838487972508592D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell50.Weight = 0.16494845360824742D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow14.Weight = 0.069767441860465115D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell51.Weight = 0.1872852233676976D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell52.Weight = 0.3127147766323024D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell53.Weight = 0.16666666666666666D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell54.Weight = 0.16838487972508592D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell55.Weight = 0.16494845360824742D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow15.Weight = 0.069767441860465115D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell56.Weight = 0.1872852233676976D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell57.Weight = 0.3127147766323024D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell58.Weight = 0.16666666666666666D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell59.Weight = 0.16838487972508592D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell60.Weight = 0.16494845360824742D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow16.Weight = 0.069767441860465115D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell61.Weight = 0.1872852233676976D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell62.Weight = 0.3127147766323024D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell63.Weight = 0.16666666666666666D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell64.Weight = 0.16838487972508592D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell65.Weight = 0.16494845360824742D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell69,
            this.xrTableCell70});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow17.Weight = 0.069767441860465115D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell67.Weight = 0.5D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell69.Text = "Subtotal:";
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell69.Weight = 0.33505154639175255D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell70.Weight = 0.16494845360824742D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell66,
            this.xrTableCell68,
            this.xrTableCell71});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow18.Weight = 0.069767441860465115D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell66.Weight = 0.5D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell68.Text = "Freight (estimated):";
            this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell68.Weight = 0.33505154639175255D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell71.Weight = 0.16494845360824742D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell74});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow19.Weight = 0.069767441860465115D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell72.Weight = 0.5D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell73.Text = "Total:";
            this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell73.Weight = 0.33505154639175255D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell74.Weight = 0.16494845360824742D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel1,
            this.lbPageNumber});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.BorderColor = System.Drawing.Color.Black;
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrPageInfo1.ForeColor = System.Drawing.Color.Black;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(367F, 25F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(82F, 25F);
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650F, 20F);
            this.xrLabel1.Text = "Northwind Traders  - Fall Catalog";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.lbPageNumber.ForeColor = System.Drawing.Color.Black;
            this.lbPageNumber.LocationFloat = new DevExpress.Utils.PointFloat(258F, 25F);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbPageNumber.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.lbPageNumber.Text = "Page Number";
            this.lbPageNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.xrTable4,
            this.lbInstructionsText,
            this.xrLine13,
            this.lbCustomerID,
            this.xrLine12,
            this.lbDateRequired,
            this.lbDateOfOrder,
            this.xrLine11,
            this.xrLine10,
            this.xrLine9,
            this.xrLine8,
            this.xrLine7,
            this.xrLine6,
            this.xrLine5,
            this.xrLine4,
            this.xrLine3,
            this.lbShipTo,
            this.lbBillTo,
            this.lbAddress,
            this.lbOrderForm,
            this.xrPictureBox2,
            this.xrPictureBox1,
            this.xrLine2});
            this.ReportFooter.HeightF = 836F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            this.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cbFederalShipping,
            this.lbShipVia,
            this.cbSpeedyExpress,
            this.cbUnitedPackage});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(33F, 700F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPanel1.SizeF = new System.Drawing.SizeF(192F, 125F);
            // 
            // cbFederalShipping
            // 
            this.cbFederalShipping.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cbFederalShipping.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.cbFederalShipping.ForeColor = System.Drawing.Color.Black;
            this.cbFederalShipping.LocationFloat = new DevExpress.Utils.PointFloat(8F, 92F);
            this.cbFederalShipping.Name = "cbFederalShipping";
            this.cbFederalShipping.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.cbFederalShipping.SizeF = new System.Drawing.SizeF(146F, 20F);
            this.cbFederalShipping.Text = "Federal Shipping";
            // 
            // lbShipVia
            // 
            this.lbShipVia.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbShipVia.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbShipVia.ForeColor = System.Drawing.Color.Black;
            this.lbShipVia.LocationFloat = new DevExpress.Utils.PointFloat(9F, 9F);
            this.lbShipVia.Name = "lbShipVia";
            this.lbShipVia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbShipVia.SizeF = new System.Drawing.SizeF(150F, 21F);
            this.lbShipVia.Text = "Ship Via (check one):";
            this.lbShipVia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // cbSpeedyExpress
            // 
            this.cbSpeedyExpress.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cbSpeedyExpress.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.cbSpeedyExpress.ForeColor = System.Drawing.Color.Black;
            this.cbSpeedyExpress.LocationFloat = new DevExpress.Utils.PointFloat(8F, 42F);
            this.cbSpeedyExpress.Name = "cbSpeedyExpress";
            this.cbSpeedyExpress.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.cbSpeedyExpress.SizeF = new System.Drawing.SizeF(146F, 20F);
            this.cbSpeedyExpress.Text = "Speedy Express";
            // 
            // cbUnitedPackage
            // 
            this.cbUnitedPackage.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cbUnitedPackage.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.cbUnitedPackage.ForeColor = System.Drawing.Color.Black;
            this.cbUnitedPackage.LocationFloat = new DevExpress.Utils.PointFloat(8F, 67F);
            this.cbUnitedPackage.Name = "cbUnitedPackage";
            this.cbUnitedPackage.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.cbUnitedPackage.SizeF = new System.Drawing.SizeF(146F, 20F);
            this.cbUnitedPackage.Text = "United Package";
            // 
            // lbInstructionsText
            // 
            this.lbInstructionsText.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lbInstructionsText.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Italic);
            this.lbInstructionsText.ForeColor = System.Drawing.Color.Black;
            this.lbInstructionsText.LocationFloat = new DevExpress.Utils.PointFloat(42F, 166F);
            this.lbInstructionsText.Multiline = true;
            this.lbInstructionsText.Name = "lbInstructionsText";
            this.lbInstructionsText.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbInstructionsText.SizeF = new System.Drawing.SizeF(566F, 75F);
            this.lbInstructionsText.Text = resources.GetString("lbInstructionsText.Text");
            this.lbInstructionsText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine13
            // 
            this.xrLine13.ForeColor = System.Drawing.Color.Black;
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(441F, 400F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine13.SizeF = new System.Drawing.SizeF(173F, 8F);
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbCustomerID.ForeColor = System.Drawing.Color.Black;
            this.lbCustomerID.LocationFloat = new DevExpress.Utils.PointFloat(333F, 391F);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCustomerID.SizeF = new System.Drawing.SizeF(108F, 22F);
            this.lbCustomerID.Text = "Customer ID:";
            this.lbCustomerID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine12
            // 
            this.xrLine12.ForeColor = System.Drawing.Color.Black;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(150F, 400F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine12.SizeF = new System.Drawing.SizeF(167F, 8F);
            // 
            // lbDateRequired
            // 
            this.lbDateRequired.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbDateRequired.ForeColor = System.Drawing.Color.Black;
            this.lbDateRequired.LocationFloat = new DevExpress.Utils.PointFloat(33F, 391F);
            this.lbDateRequired.Name = "lbDateRequired";
            this.lbDateRequired.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDateRequired.SizeF = new System.Drawing.SizeF(116F, 22F);
            this.lbDateRequired.Text = "Date Required:";
            this.lbDateRequired.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDateOfOrder
            // 
            this.lbDateOfOrder.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbDateOfOrder.ForeColor = System.Drawing.Color.Black;
            this.lbDateOfOrder.LocationFloat = new DevExpress.Utils.PointFloat(33F, 366F);
            this.lbDateOfOrder.Name = "lbDateOfOrder";
            this.lbDateOfOrder.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDateOfOrder.SizeF = new System.Drawing.SizeF(115F, 22F);
            this.lbDateOfOrder.Text = "Date of Order:";
            this.lbDateOfOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine11
            // 
            this.xrLine11.ForeColor = System.Drawing.Color.Black;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(150F, 375F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine11.SizeF = new System.Drawing.SizeF(159F, 8F);
            // 
            // xrLine10
            // 
            this.xrLine10.ForeColor = System.Drawing.Color.Black;
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(341F, 325F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine10.SizeF = new System.Drawing.SizeF(275F, 8F);
            // 
            // xrLine9
            // 
            this.xrLine9.ForeColor = System.Drawing.Color.Black;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(33F, 325F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine9.SizeF = new System.Drawing.SizeF(266F, 8F);
            // 
            // xrLine8
            // 
            this.xrLine8.ForeColor = System.Drawing.Color.Black;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(341F, 341F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine8.SizeF = new System.Drawing.SizeF(275F, 8F);
            // 
            // xrLine7
            // 
            this.xrLine7.ForeColor = System.Drawing.Color.Black;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(33F, 341F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine7.SizeF = new System.Drawing.SizeF(266F, 8F);
            // 
            // xrLine6
            // 
            this.xrLine6.ForeColor = System.Drawing.Color.Black;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(341F, 308F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine6.SizeF = new System.Drawing.SizeF(275F, 8F);
            // 
            // xrLine5
            // 
            this.xrLine5.ForeColor = System.Drawing.Color.Black;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(33F, 308F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine5.SizeF = new System.Drawing.SizeF(266F, 8F);
            // 
            // xrLine4
            // 
            this.xrLine4.ForeColor = System.Drawing.Color.Black;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(408F, 291F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine4.SizeF = new System.Drawing.SizeF(207F, 8F);
            // 
            // xrLine3
            // 
            this.xrLine3.ForeColor = System.Drawing.Color.Black;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(99F, 291F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine3.SizeF = new System.Drawing.SizeF(200F, 8F);
            // 
            // lbShipTo
            // 
            this.lbShipTo.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbShipTo.ForeColor = System.Drawing.Color.Black;
            this.lbShipTo.LocationFloat = new DevExpress.Utils.PointFloat(339F, 278F);
            this.lbShipTo.Name = "lbShipTo";
            this.lbShipTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbShipTo.SizeF = new System.Drawing.SizeF(67F, 20F);
            this.lbShipTo.Text = "Ship To:";
            this.lbShipTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbBillTo
            // 
            this.lbBillTo.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbBillTo.ForeColor = System.Drawing.Color.Black;
            this.lbBillTo.LocationFloat = new DevExpress.Utils.PointFloat(33F, 278F);
            this.lbBillTo.Name = "lbBillTo";
            this.lbBillTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbBillTo.SizeF = new System.Drawing.SizeF(66F, 20F);
            this.lbBillTo.Text = "Bill To:";
            this.lbBillTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8.25F, DevExpress.Drawing.DXFontStyle.Italic);
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.LocationFloat = new DevExpress.Utils.PointFloat(33F, 116F);
            this.lbAddress.Multiline = true;
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbAddress.SizeF = new System.Drawing.SizeF(258F, 33F);
            this.lbAddress.Text = "One Portals Way, Twin Points WA  98156\r\nPhone: 1-206-555-1417   Fax: 1-206-555-59" +
    "38";
            this.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbOrderForm
            // 
            this.lbOrderForm.Font = new DevExpress.Drawing.DXFont("Times New Roman", 20.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbOrderForm.ForeColor = System.Drawing.Color.Black;
            this.lbOrderForm.LocationFloat = new DevExpress.Utils.PointFloat(425F, 0F);
            this.lbOrderForm.Name = "lbOrderForm";
            this.lbOrderForm.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbOrderForm.SizeF = new System.Drawing.SizeF(220F, 33F);
            this.lbOrderForm.Text = "ORDER FORM";
            this.lbOrderForm.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(118F, 21F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(162F, 38F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(30F, 1F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(87.5F, 87.5F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xrPictureBox1.UseImageResolution = false;
            // 
            // xrLine2
            // 
            this.xrLine2.LineWidth = 3F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 91F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine2.SizeF = new System.Drawing.SizeF(650F, 16F);
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // parameterSortGroupsType
            // 
            this.parameterSortGroupsType.Description = "Sort Categories By";
            this.parameterSortGroupsType.Name = "parameterSortGroupsType";
            // 
            // parameterSortGroupsOrder
            // 
            this.parameterSortGroupsOrder.Description = "Sort Order";
            this.parameterSortGroupsOrder.Name = "parameterSortGroupsOrder";
            // 
            // ProductSales
            // 
            this.ProductSales.DataMember = "Products";
            this.ProductSales.Expression = "[ProductsOrderDetails].Sum([UnitPrice] * (1 - [Discount]) * [Quantity])";
            this.ProductSales.Name = "ProductSales";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NWindConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ProductID";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "QuantityPerUnit";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "CategoryID";
            table2.Name = "Categories";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "CategoryName";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Description";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Picture";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "CategoryID";
            relationColumnInfo1.ParentKeyColumn = "CategoryID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            columnExpression9.ColumnName = "OrderID";
            table3.Name = "OrderDetails";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "ProductID";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "UnitPrice";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Quantity";
            columnExpression12.Table = table3;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Discount";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Columns.Add(column12);
            selectQuery2.Columns.Add(column13);
            selectQuery2.Name = "OrderDetails";
            selectQuery2.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            masterDetailInfo1.DetailQueryName = "OrderDetails";
            relationColumnInfo2.NestedKeyColumn = "ProductID";
            relationColumnInfo2.ParentKeyColumn = "ProductID";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo1.MasterQueryName = "Products";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // CatalogReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.ReportFooter,
            this.BottomMargin,
            this.topMarginBand1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.ProductSales});
            this.DataMember = "Products";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new DevExpress.Drawing.DXMargins(100, 100, 100, 75);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parameterSortGroupsType,
            this.parameterSortGroupsOrder});
            this.ReportPrintOptions.DetailCountAtDesignTime = 6;
            this.RequestParameters = false;
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel lbTotalSales;
        private DevExpress.XtraReports.UI.XRLabel lbCount;
        private DevExpress.XtraReports.UI.XRLabel lbHighestPrice;
        private DevExpress.XtraReports.UI.XRLabel lbLowestPrice;
        private DevExpress.XtraReports.Parameters.Parameter parameterSortGroupsType;
        private DevExpress.XtraReports.Parameters.Parameter parameterSortGroupsOrder;
        private DevExpress.XtraReports.UI.XRTableOfContents xrTableOfContents1;
        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.CalculatedField ProductSales;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.ComponentModel.IContainer components;
    }
}
