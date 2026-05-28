using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.BarCodes {
    public partial class BarCodeTypesReport : DevExpress.XtraReports.UI.XtraReport {
        private System.ComponentModel.Container components = null;
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell27;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell30;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell33;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell35;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell36;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell37;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell38;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell39;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell20;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell40;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell41;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell42;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell43;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell44;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell45;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell46;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell47;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell48;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell49;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell50;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell51;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell52;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell53;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell54;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell55;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell56;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell57;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode3;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode4;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode5;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode6;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode7;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode8;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode9;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode10;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode11;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode12;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode13;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode14;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode15;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode16;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode17;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode18;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode19;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode20;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRControlStyle TextPaddingStyle;
        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPrinting.BarCode.AztecCodeGenerator aztecCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.AztecCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodeTypesReport));
            DevExpress.XtraPrinting.BarCode.MicroQRCodeGenerator microQRCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.MicroQRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.QRCodeGS1Generator qrCodeGS1Generator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGS1Generator();
            DevExpress.XtraPrinting.BarCode.QRCodeEPCGenerator qrCodeEPCGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeEPCGenerator();
            DevExpress.XtraPrinting.BarCode.PaymentServicesAustriaQRFrameOptions paymentServicesAustriaQRFrameOptions1 = new DevExpress.XtraPrinting.BarCode.PaymentServicesAustriaQRFrameOptions();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.RectangleQRFrameOptions rectangleQRFrameOptions1 = new DevExpress.XtraPrinting.BarCode.RectangleQRFrameOptions();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.SSCCGenerator ssccGenerator1 = new DevExpress.XtraPrinting.BarCode.SSCCGenerator();
            DevExpress.XtraPrinting.BarCode.DeutschePostIdentcodeGenerator deutschePostIdentcodeGenerator1 = new DevExpress.XtraPrinting.BarCode.DeutschePostIdentcodeGenerator();
            DevExpress.XtraPrinting.BarCode.DeutschePostLeitcodeGenerator deutschePostLeitcodeGenerator1 = new DevExpress.XtraPrinting.BarCode.DeutschePostLeitcodeGenerator();
            DevExpress.XtraPrinting.BarCode.PharmacodeGenerator pharmacodeGenerator1 = new DevExpress.XtraPrinting.BarCode.PharmacodeGenerator();
            DevExpress.XtraPrinting.BarCode.PharmacodeGenerator pharmacodeGenerator2 = new DevExpress.XtraPrinting.BarCode.PharmacodeGenerator();
            DevExpress.XtraPrinting.BarCode.DataBarGenerator dataBarGenerator1 = new DevExpress.XtraPrinting.BarCode.DataBarGenerator();
            DevExpress.XtraPrinting.BarCode.DataBarGenerator dataBarGenerator2 = new DevExpress.XtraPrinting.BarCode.DataBarGenerator();
            DevExpress.XtraPrinting.BarCode.ITF14Generator itF14Generator1 = new DevExpress.XtraPrinting.BarCode.ITF14Generator();
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator intelligentMailGenerator1 = new DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator();
            DevExpress.XtraPrinting.BarCode.IntelligentMailPackageGenerator intelligentMailPackageGenerator1 = new DevExpress.XtraPrinting.BarCode.IntelligentMailPackageGenerator();
            DevExpress.XtraPrinting.BarCode.DataMatrixGenerator dataMatrixGenerator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGenerator();
            DevExpress.XtraPrinting.BarCode.PDF417Generator pdF417Generator1 = new DevExpress.XtraPrinting.BarCode.PDF417Generator();
            DevExpress.XtraPrinting.BarCode.CodabarGenerator codabarGenerator1 = new DevExpress.XtraPrinting.BarCode.CodabarGenerator();
            DevExpress.XtraPrinting.BarCode.Code11Generator code11Generator1 = new DevExpress.XtraPrinting.BarCode.Code11Generator();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.XtraPrinting.BarCode.EAN128Generator eaN128Generator1 = new DevExpress.XtraPrinting.BarCode.EAN128Generator();
            DevExpress.XtraPrinting.BarCode.Code39Generator code39Generator1 = new DevExpress.XtraPrinting.BarCode.Code39Generator();
            DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator code39ExtendedGenerator1 = new DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator();
            DevExpress.XtraPrinting.BarCode.Code93Generator code93Generator1 = new DevExpress.XtraPrinting.BarCode.Code93Generator();
            DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator code93ExtendedGenerator1 = new DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator();
            DevExpress.XtraPrinting.BarCode.Industrial2of5Generator industrial2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Industrial2of5Generator();
            DevExpress.XtraPrinting.BarCode.Matrix2of5Generator matrix2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Matrix2of5Generator();
            DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator interleaved2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.EAN8Generator eaN8Generator1 = new DevExpress.XtraPrinting.BarCode.EAN8Generator();
            DevExpress.XtraPrinting.BarCode.CodeMSIGenerator codeMSIGenerator1 = new DevExpress.XtraPrinting.BarCode.CodeMSIGenerator();
            DevExpress.XtraPrinting.BarCode.UPCAGenerator upcaGenerator1 = new DevExpress.XtraPrinting.BarCode.UPCAGenerator();
            DevExpress.XtraPrinting.BarCode.UPCE0Generator upcE0Generator1 = new DevExpress.XtraPrinting.BarCode.UPCE0Generator();
            DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator upcSupplemental2Generator1 = new DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator2 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator3 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator upcSupplemental5Generator1 = new DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator();
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode37 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode38 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode35 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode39 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode23 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode36 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode34 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode32 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode33 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode30 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode31 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode28 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode27 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode26 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode25 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode24 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode29 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode22 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode21 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode3 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode4 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode5 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode6 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode7 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode8 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode9 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode10 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode11 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode12 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode13 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode14 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode15 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode16 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode19 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode17 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode18 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode20 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.TextPaddingStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.AutoModuleParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 4108.133F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.BorderColor = System.Drawing.Color.White;
            this.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow36,
            this.xrTableRow22,
            this.xrTableRow34,
            this.xrTableRow33,
            this.xrTableRow35,
            this.xrTableRow32,
            this.xrTableRow31,
            this.xrTableRow30,
            this.xrTableRow28,
            this.xrTableRow29,
            this.xrTableRow26,
            this.xrTableRow25,
            this.xrTableRow24,
            this.xrTableRow23,
            this.xrTableRow27,
            this.xrTableRow21,
            this.xrTableRow20,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow19});
            this.xrTable2.SizeF = new System.Drawing.SizeF(670F, 4108.133F);
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow36
            // 
            this.xrTableRow36.BackColor = System.Drawing.Color.White;
            this.xrTableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108});
            this.xrTableRow36.Name = "xrTableRow36";
            this.xrTableRow36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow36.StylePriority.UseBackColor = false;
            this.xrTableRow36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow36.Weight = 0.11324286715924584D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell106.BorderWidth = 0F;
            this.xrTableCell106.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell106.Multiline = true;
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell106.StyleName = "TextPaddingStyle";
            this.xrTableCell106.StylePriority.UseBackColor = false;
            this.xrTableCell106.StylePriority.UseBorderWidth = false;
            this.xrTableCell106.Text = "Aztec Code";
            this.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell106.Weight = 0.14936854190585536D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell107.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell107.BorderWidth = 1F;
            this.xrTableCell107.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode37});
            this.xrTableCell107.Multiline = true;
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell107.StylePriority.UseBackColor = false;
            this.xrTableCell107.StylePriority.UseBorders = false;
            this.xrTableCell107.StylePriority.UseBorderWidth = false;
            this.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell107.Weight = 0.3773823191733639D;
            // 
            // xrBarCode37
            // 
            this.xrBarCode37.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode37.LocationFloat = new DevExpress.Utils.PointFloat(1.041664F, 0F);
            this.xrBarCode37.Module = 5F;
            this.xrBarCode37.Name = "xrBarCode37";
            this.xrBarCode37.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrBarCode37.ShowText = false;
            this.xrBarCode37.SizeF = new System.Drawing.SizeF(250.7628F, 130.1645F);
            this.xrBarCode37.StylePriority.UsePadding = false;
            this.xrBarCode37.Symbology = aztecCodeGenerator1;
            this.xrBarCode37.Text = " \nhttps://devexpress.com";
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell108.BorderWidth = 0F;
            this.xrTableCell108.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell108.Multiline = true;
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell108.StyleName = "TextPaddingStyle";
            this.xrTableCell108.StylePriority.UseBackColor = false;
            this.xrTableCell108.StylePriority.UseBorderWidth = false;
            this.xrTableCell108.Text = resources.GetString("xrTableCell108.Text");
            this.xrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell108.Weight = 0.47324913892078074D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.BackColor = System.Drawing.Color.White;
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66});
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow22.StylePriority.UseBackColor = false;
            this.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow22.Weight = 0.11324286715924584D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.BackColor = System.Drawing.Color.White;
            this.xrTableCell64.BorderWidth = 0F;
            this.xrTableCell64.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell64.Multiline = true;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell64.StyleName = "TextPaddingStyle";
            this.xrTableCell64.StylePriority.UseBackColor = false;
            this.xrTableCell64.StylePriority.UseBorderWidth = false;
            this.xrTableCell64.Text = "Micro QR Code";
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell64.Weight = 0.14936854190585536D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell65.BorderWidth = 1F;
            this.xrTableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode38});
            this.xrTableCell65.Multiline = true;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell65.StylePriority.UseBackColor = false;
            this.xrTableCell65.StylePriority.UseBorders = false;
            this.xrTableCell65.StylePriority.UseBorderWidth = false;
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell65.Weight = 0.3773823191733639D;
            // 
            // xrBarCode38
            // 
            this.xrBarCode38.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode38.BackColor = System.Drawing.Color.White;
            this.xrBarCode38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode38.LocationFloat = new DevExpress.Utils.PointFloat(1.041664F, 0F);
            this.xrBarCode38.Module = 4F;
            this.xrBarCode38.Name = "xrBarCode38";
            this.xrBarCode38.Padding = new DevExpress.XtraPrinting.PaddingInfo(25, 25, 25, 25, 100F);
            this.xrBarCode38.ShowText = false;
            this.xrBarCode38.SizeF = new System.Drawing.SizeF(250.7628F, 130.1645F);
            this.xrBarCode38.StylePriority.UseBackColor = false;
            this.xrBarCode38.StylePriority.UsePadding = false;
            microQRCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.MicroQRCodeCompactionMode.Byte;
            microQRCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.MicroQRCodeVersion.AutoVersion;
            this.xrBarCode38.Symbology = microQRCodeGenerator1;
            this.xrBarCode38.Text = "devexpress.com";
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.BackColor = System.Drawing.Color.White;
            this.xrTableCell66.BorderWidth = 0F;
            this.xrTableCell66.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell66.Multiline = true;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell66.StyleName = "TextPaddingStyle";
            this.xrTableCell66.StylePriority.UseBackColor = false;
            this.xrTableCell66.StylePriority.UseBorderWidth = false;
            this.xrTableCell66.Text = resources.GetString("xrTableCell66.Text");
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell66.Weight = 0.47324913892078074D;
            // 
            // xrTableRow34
            // 
            this.xrTableRow34.BackColor = System.Drawing.Color.White;
            this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow34.StylePriority.UseBackColor = false;
            this.xrTableRow34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow34.Weight = 0.11324286715924584D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell100.BorderWidth = 0F;
            this.xrTableCell100.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell100.Multiline = true;
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell100.StyleName = "TextPaddingStyle";
            this.xrTableCell100.StylePriority.UseBackColor = false;
            this.xrTableCell100.StylePriority.UseBorderWidth = false;
            this.xrTableCell100.Text = "GS1 QR Code";
            this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell100.Weight = 0.14936854190585536D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell101.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell101.BorderWidth = 1F;
            this.xrTableCell101.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode35});
            this.xrTableCell101.Multiline = true;
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell101.StylePriority.UseBackColor = false;
            this.xrTableCell101.StylePriority.UseBorders = false;
            this.xrTableCell101.StylePriority.UseBorderWidth = false;
            this.xrTableCell101.Text = "xrTableCell101";
            this.xrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell101.Weight = 0.3773823191733639D;
            // 
            // xrBarCode35
            // 
            this.xrBarCode35.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode35.BorderWidth = 0F;
            this.xrBarCode35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode35.LocationFloat = new DevExpress.Utils.PointFloat(1.041664F, 0F);
            this.xrBarCode35.Module = 3F;
            this.xrBarCode35.Name = "xrBarCode35";
            this.xrBarCode35.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrBarCode35.ShowText = false;
            this.xrBarCode35.SizeF = new System.Drawing.SizeF(250.7628F, 130.1645F);
            this.xrBarCode35.StylePriority.UseBorderWidth = false;
            this.xrBarCode35.StylePriority.UsePadding = false;
            this.xrBarCode35.Symbology = qrCodeGS1Generator1;
            this.xrBarCode35.Text = "010123456789012890DEVEXPRESS";
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell102.BorderWidth = 0F;
            this.xrTableCell102.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell102.Multiline = true;
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell102.StyleName = "TextPaddingStyle";
            this.xrTableCell102.StylePriority.UseBackColor = false;
            this.xrTableCell102.StylePriority.UseBorderWidth = false;
            this.xrTableCell102.Text = resources.GetString("xrTableCell102.Text");
            this.xrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell102.Weight = 0.47324913892078074D;
            // 
            // xrTableRow33
            // 
            this.xrTableRow33.BackColor = System.Drawing.Color.White;
            this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell97,
            this.xrTableCell98,
            this.xrTableCell99});
            this.xrTableRow33.Name = "xrTableRow33";
            this.xrTableRow33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow33.StylePriority.UseBackColor = false;
            this.xrTableRow33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow33.Weight = 0.14259301930216561D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.BackColor = System.Drawing.Color.White;
            this.xrTableCell97.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell97.Multiline = true;
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell97.StyleName = "TextPaddingStyle";
            this.xrTableCell97.StylePriority.UseBackColor = false;
            this.xrTableCell97.Text = "\r\nEPC QR Code";
            this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell97.Weight = 0.14936854190585536D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.BackColor = System.Drawing.Color.White;
            this.xrTableCell98.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode39});
            this.xrTableCell98.Multiline = true;
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell98.StylePriority.UseBackColor = false;
            this.xrTableCell98.Text = "xrTableCell98";
            this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell98.Weight = 0.3773823191733639D;
            // 
            // xrBarCode39
            // 
            this.xrBarCode39.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode39.AutoModule = true;
            this.xrBarCode39.BorderWidth = 0F;
            this.xrBarCode39.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrBarCode39.LocationFloat = new DevExpress.Utils.PointFloat(1.041664F, 0F);
            this.xrBarCode39.Module = 3F;
            this.xrBarCode39.Name = "xrBarCode39";
            this.xrBarCode39.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 20, 20, 100F);
            this.xrBarCode39.ShowText = false;
            this.xrBarCode39.SizeF = new System.Drawing.SizeF(251.8045F, 163.9004F);
            this.xrBarCode39.StylePriority.UseBorderWidth = false;
            this.xrBarCode39.StylePriority.UseFont = false;
            this.xrBarCode39.StylePriority.UsePadding = false;
            qrCodeEPCGenerator1.FrameOptions = paymentServicesAustriaQRFrameOptions1;
            this.xrBarCode39.Symbology = qrCodeEPCGenerator1;
            this.xrBarCode39.Text = "BCD\r\n002\r\n1\r\nSCT\r\n\r\nFrançois D\'Alsace S.A.\r\nFR1420041010050500013M02606\r\nEUR100.0" +
    "0\r\n\r\nClient:Marie Louise La Lune";
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.BackColor = System.Drawing.Color.White;
            this.xrTableCell99.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell99.Multiline = true;
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell99.StyleName = "TextPaddingStyle";
            this.xrTableCell99.StylePriority.UseBackColor = false;
            this.xrTableCell99.Text = resources.GetString("xrTableCell99.Text");
            this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell99.Weight = 0.47324913892078074D;
            // 
            // xrTableRow35
            // 
            this.xrTableRow35.BackColor = System.Drawing.Color.White;
            this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell103,
            this.xrTableCell104,
            this.xrTableCell105});
            this.xrTableRow35.Name = "xrTableRow35";
            this.xrTableRow35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow35.StylePriority.UseBackColor = false;
            this.xrTableRow35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow35.Weight = 0.202767668776585D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell103.BorderWidth = 0F;
            this.xrTableCell103.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell103.Multiline = true;
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell103.StyleName = "TextPaddingStyle";
            this.xrTableCell103.StylePriority.UseBackColor = false;
            this.xrTableCell103.StylePriority.UseBorderWidth = false;
            this.xrTableCell103.Text = "QR Code";
            this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell103.Weight = 0.14936854190585536D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell104.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell104.BorderWidth = 1F;
            this.xrTableCell104.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode23,
            this.xrBarCode36});
            this.xrTableCell104.Multiline = true;
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell104.StylePriority.UseBackColor = false;
            this.xrTableCell104.StylePriority.UseBorders = false;
            this.xrTableCell104.StylePriority.UseBorderWidth = false;
            this.xrTableCell104.Text = "xrTableCell104";
            this.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell104.Weight = 0.3773823191733639D;
            // 
            // xrBarCode23
            // 
            this.xrBarCode23.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode23.AutoModule = true;
            this.xrBarCode23.BorderWidth = 0F;
            this.xrBarCode23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode23.LocationFloat = new DevExpress.Utils.PointFloat(9.999985F, 114.248F);
            this.xrBarCode23.Module = 3F;
            this.xrBarCode23.Name = "xrBarCode23";
            this.xrBarCode23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrBarCode23.ShowText = false;
            this.xrBarCode23.SizeF = new System.Drawing.SizeF(237.0375F, 118.6522F);
            this.xrBarCode23.StylePriority.UseBorderWidth = false;
            this.xrBarCode23.StylePriority.UsePadding = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            rectangleQRFrameOptions1.Text = "SCAN ME";
            rectangleQRFrameOptions1.TextPosition = DevExpress.XtraPrinting.BarCode.QRFrameTextPosition.Top;
            qrCodeGenerator1.FrameOptions = rectangleQRFrameOptions1;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version2;
            this.xrBarCode23.Symbology = qrCodeGenerator1;
            this.xrBarCode23.Text = "URL:http://www.devexpress.com";
            // 
            // xrBarCode36
            // 
            this.xrBarCode36.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrBarCode36.BorderWidth = 0F;
            this.xrBarCode36.LocationFloat = new DevExpress.Utils.PointFloat(9.999985F, 0F);
            this.xrBarCode36.Module = 3.2F;
            this.xrBarCode36.Name = "xrBarCode36";
            this.xrBarCode36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode36.ShowText = false;
            this.xrBarCode36.SizeF = new System.Drawing.SizeF(237.0374F, 114.248F);
            this.xrBarCode36.StylePriority.UseBorderWidth = false;
            this.xrBarCode36.StylePriority.UsePadding = false;
            qrCodeGenerator2.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator2.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.H;
            qrCodeGenerator2.Logo = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("qrCodeGenerator2.Logo"));
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBarCode36.Symbology = qrCodeGenerator2;
            this.xrBarCode36.Text = "URL:http://www.devexpress.com";
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell105.BorderWidth = 0F;
            this.xrTableCell105.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell105.Multiline = true;
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell105.StyleName = "TextPaddingStyle";
            this.xrTableCell105.StylePriority.UseBackColor = false;
            this.xrTableCell105.StylePriority.UseBorderWidth = false;
            this.xrTableCell105.Text = resources.GetString("xrTableCell105.Text");
            this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell105.Weight = 0.47324913892078074D;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.BackColor = System.Drawing.Color.White;
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell96});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow32.StylePriority.UseBackColor = false;
            this.xrTableRow32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow32.Weight = 0.10288096147870091D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.BackColor = System.Drawing.Color.White;
            this.xrTableCell94.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell94.Multiline = true;
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell94.StyleName = "TextPaddingStyle";
            this.xrTableCell94.StylePriority.UseBackColor = false;
            this.xrTableCell94.Text = "GS1-128 SSCC";
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell94.Weight = 0.14936854190585536D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.BackColor = System.Drawing.Color.White;
            this.xrTableCell95.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode34});
            this.xrTableCell95.Multiline = true;
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell95.StylePriority.UseBackColor = false;
            this.xrTableCell95.Text = "xrTableCell95";
            this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell95.Weight = 0.3773823191733639D;
            // 
            // xrBarCode34
            // 
            this.xrBarCode34.BorderWidth = 0F;
            this.xrBarCode34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode34.LocationFloat = new DevExpress.Utils.PointFloat(1.100014F, 23F);
            this.xrBarCode34.Module = 1.45F;
            this.xrBarCode34.Name = "xrBarCode34";
            this.xrBarCode34.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode34.SizeF = new System.Drawing.SizeF(251.7462F, 75F);
            this.xrBarCode34.StylePriority.UseBorderWidth = false;
            this.xrBarCode34.StylePriority.UseTextAlignment = false;
            this.xrBarCode34.Symbology = ssccGenerator1;
            this.xrBarCode34.Text = "00614141234567890";
            this.xrBarCode34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.BackColor = System.Drawing.Color.White;
            this.xrTableCell96.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell96.Multiline = true;
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell96.StyleName = "TextPaddingStyle";
            this.xrTableCell96.StylePriority.UseBackColor = false;
            this.xrTableCell96.Text = resources.GetString("xrTableCell96.Text");
            this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell96.Weight = 0.47324913892078074D;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.BackColor = System.Drawing.Color.White;
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow31.StylePriority.UseBackColor = false;
            this.xrTableRow31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow31.Weight = 0.10177710951000171D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell91.BorderWidth = 0F;
            this.xrTableCell91.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell91.Multiline = true;
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell91.StyleName = "TextPaddingStyle";
            this.xrTableCell91.StylePriority.UseBackColor = false;
            this.xrTableCell91.StylePriority.UseBorderWidth = false;
            this.xrTableCell91.Text = "Deutsche Post Identcode";
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell91.Weight = 0.14936854190585536D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell92.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell92.BorderWidth = 1F;
            this.xrTableCell92.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode32});
            this.xrTableCell92.Multiline = true;
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell92.StylePriority.UseBackColor = false;
            this.xrTableCell92.StylePriority.UseBorders = false;
            this.xrTableCell92.StylePriority.UseBorderWidth = false;
            this.xrTableCell92.Text = "xrTableCell92";
            this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell92.Weight = 0.3773823191733639D;
            // 
            // xrBarCode32
            // 
            this.xrBarCode32.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode32.BorderWidth = 0F;
            this.xrBarCode32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode32.LocationFloat = new DevExpress.Utils.PointFloat(4.149498F, 36.98541F);
            this.xrBarCode32.Module = 1.5F;
            this.xrBarCode32.Name = "xrBarCode32";
            this.xrBarCode32.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode32.SizeF = new System.Drawing.SizeF(246.9505F, 70F);
            this.xrBarCode32.StylePriority.UseBackColor = false;
            this.xrBarCode32.StylePriority.UseBorderWidth = false;
            this.xrBarCode32.StylePriority.UsePadding = false;
            deutschePostIdentcodeGenerator1.WideNarrowRatio = 3F;
            this.xrBarCode32.Symbology = deutschePostIdentcodeGenerator1;
            this.xrBarCode32.Text = "12345678901";
            this.xrBarCode32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell93.BorderWidth = 0F;
            this.xrTableCell93.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell93.Multiline = true;
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell93.StyleName = "TextPaddingStyle";
            this.xrTableCell93.StylePriority.UseBackColor = false;
            this.xrTableCell93.StylePriority.UseBorderWidth = false;
            this.xrTableCell93.Text = resources.GetString("xrTableCell93.Text");
            this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell93.Weight = 0.47324913892078074D;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow30.StylePriority.UseBackColor = false;
            this.xrTableRow30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow30.Weight = 0.090177202136186976D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.BackColor = System.Drawing.Color.White;
            this.xrTableCell88.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell88.Multiline = true;
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell88.StyleName = "TextPaddingStyle";
            this.xrTableCell88.StylePriority.UseBackColor = false;
            this.xrTableCell88.Text = "Deutsche Post Leitcode";
            this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell88.Weight = 0.14936854190585536D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.BackColor = System.Drawing.Color.White;
            this.xrTableCell89.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode33});
            this.xrTableCell89.Multiline = true;
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell89.StylePriority.UseBackColor = false;
            this.xrTableCell89.Text = "xrTableCell89";
            this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell89.Weight = 0.3773823191733639D;
            // 
            // xrBarCode33
            // 
            this.xrBarCode33.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode33.LocationFloat = new DevExpress.Utils.PointFloat(1.85F, 18F);
            this.xrBarCode33.Module = 1.25F;
            this.xrBarCode33.Name = "xrBarCode33";
            this.xrBarCode33.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode33.SizeF = new System.Drawing.SizeF(250.9938F, 70.00003F);
            this.xrBarCode33.StylePriority.UseBackColor = false;
            this.xrBarCode33.StylePriority.UsePadding = false;
            deutschePostLeitcodeGenerator1.WideNarrowRatio = 3F;
            this.xrBarCode33.Symbology = deutschePostLeitcodeGenerator1;
            this.xrBarCode33.Text = "1234567890123";
            this.xrBarCode33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.BackColor = System.Drawing.Color.White;
            this.xrTableCell90.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell90.Multiline = true;
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell90.StyleName = "TextPaddingStyle";
            this.xrTableCell90.StylePriority.UseBackColor = false;
            this.xrTableCell90.Text = resources.GetString("xrTableCell90.Text");
            this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell90.Weight = 0.47324913892078074D;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.BackColor = System.Drawing.Color.White;
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell84});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow28.StylePriority.UseBackColor = false;
            this.xrTableRow28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow28.Weight = 0.0752236289479637D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell82.BorderWidth = 0F;
            this.xrTableCell82.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell82.Multiline = true;
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell82.StyleName = "TextPaddingStyle";
            this.xrTableCell82.StylePriority.UseBackColor = false;
            this.xrTableCell82.StylePriority.UseBorderWidth = false;
            this.xrTableCell82.Text = "Pharmacode\r\nOne-Track";
            this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell82.Weight = 0.14936854190585536D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell83.BorderWidth = 1F;
            this.xrTableCell83.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode30});
            this.xrTableCell83.Multiline = true;
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell83.StylePriority.UseBackColor = false;
            this.xrTableCell83.StylePriority.UseBorders = false;
            this.xrTableCell83.StylePriority.UseBorderWidth = false;
            this.xrTableCell83.Text = "xrTableCell83";
            this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell83.Weight = 0.3773823191733639D;
            // 
            // xrBarCode30
            // 
            this.xrBarCode30.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode30.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode30.BorderWidth = 0F;
            this.xrBarCode30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode30.LocationFloat = new DevExpress.Utils.PointFloat(4.344994F, 10F);
            this.xrBarCode30.Name = "xrBarCode30";
            this.xrBarCode30.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode30.SizeF = new System.Drawing.SizeF(241.8044F, 70F);
            this.xrBarCode30.StylePriority.UseBackColor = false;
            this.xrBarCode30.StylePriority.UseBorderWidth = false;
            this.xrBarCode30.StylePriority.UsePadding = false;
            this.xrBarCode30.Symbology = pharmacodeGenerator1;
            this.xrBarCode30.Text = "101070";
            this.xrBarCode30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell84.BorderWidth = 0F;
            this.xrTableCell84.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell84.Multiline = true;
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell84.StyleName = "TextPaddingStyle";
            this.xrTableCell84.StylePriority.UseBackColor = false;
            this.xrTableCell84.StylePriority.UseBorderWidth = false;
            this.xrTableCell84.Text = resources.GetString("xrTableCell84.Text");
            this.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell84.Weight = 0.47324913892078074D;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.xrTableCell86,
            this.xrTableCell87});
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow29.StylePriority.UseBackColor = false;
            this.xrTableRow29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow29.Weight = 0.091261359178677309D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.BackColor = System.Drawing.Color.White;
            this.xrTableCell85.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell85.Multiline = true;
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell85.StyleName = "TextPaddingStyle";
            this.xrTableCell85.StylePriority.UseBackColor = false;
            this.xrTableCell85.Text = "Pharmacode\r\nTwo-Track";
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell85.Weight = 0.14936854190585536D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.BackColor = System.Drawing.Color.White;
            this.xrTableCell86.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode31});
            this.xrTableCell86.Multiline = true;
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell86.StylePriority.UseBackColor = false;
            this.xrTableCell86.Text = "xrTableCell86";
            this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell86.Weight = 0.3773823191733639D;
            // 
            // xrBarCode31
            // 
            this.xrBarCode31.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode31.BorderWidth = 0F;
            this.xrBarCode31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode31.LocationFloat = new DevExpress.Utils.PointFloat(1.846199F, 19F);
            this.xrBarCode31.Module = 4F;
            this.xrBarCode31.Name = "xrBarCode31";
            this.xrBarCode31.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode31.SizeF = new System.Drawing.SizeF(250.25F, 65F);
            this.xrBarCode31.StylePriority.UseBackColor = false;
            this.xrBarCode31.StylePriority.UseBorderWidth = false;
            this.xrBarCode31.StylePriority.UsePadding = false;
            pharmacodeGenerator2.PharmacodeType = DevExpress.XtraPrinting.BarCode.PharmacodeType.TwoTrack;
            this.xrBarCode31.Symbology = pharmacodeGenerator2;
            this.xrBarCode31.Text = "32598755";
            this.xrBarCode31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.BackColor = System.Drawing.Color.White;
            this.xrTableCell87.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell87.Multiline = true;
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell87.StyleName = "TextPaddingStyle";
            this.xrTableCell87.StylePriority.UseBackColor = false;
            this.xrTableCell87.Text = resources.GetString("xrTableCell87.Text");
            this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell87.Weight = 0.47324913892078074D;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.BackColor = System.Drawing.Color.White;
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.StylePriority.UseBackColor = false;
            this.xrTableRow26.Weight = 0.18413069809413266D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell76.BorderColor = System.Drawing.Color.White;
            this.xrTableCell76.BorderWidth = 0F;
            this.xrTableCell76.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseBackColor = false;
            this.xrTableCell76.StylePriority.UseBorderColor = false;
            this.xrTableCell76.StylePriority.UseBorderWidth = false;
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.StylePriority.UseTextAlignment = false;
            this.xrTableCell76.Text = "DataBar";
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell76.Weight = 0.14936854190585536D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell77.BorderColor = System.Drawing.Color.White;
            this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell77.BorderWidth = 1F;
            this.xrTableCell77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode28,
            this.xrBarCode27});
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseBackColor = false;
            this.xrTableCell77.StylePriority.UseBorderColor = false;
            this.xrTableCell77.StylePriority.UseBorders = false;
            this.xrTableCell77.StylePriority.UseBorderWidth = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = "xrTableCell77";
            this.xrTableCell77.Weight = 0.3773823191733639D;
            // 
            // xrBarCode28
            // 
            this.xrBarCode28.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode28.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode28.BorderWidth = 0F;
            this.xrBarCode28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode28.LocationFloat = new DevExpress.Utils.PointFloat(4.149467F, 164.6449F);
            this.xrBarCode28.Module = 1.75F;
            this.xrBarCode28.Name = "xrBarCode28";
            this.xrBarCode28.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F);
            this.xrBarCode28.SizeF = new System.Drawing.SizeF(246.9467F, 47F);
            this.xrBarCode28.StylePriority.UseBackColor = false;
            this.xrBarCode28.StylePriority.UseBorderWidth = false;
            this.xrBarCode28.StylePriority.UsePadding = false;
            this.xrBarCode28.StylePriority.UseTextAlignment = false;
            dataBarGenerator1.SegmentsInRow = 4;
            dataBarGenerator1.Type = DevExpress.XtraPrinting.BarCode.DataBarType.Truncated;
            this.xrBarCode28.Symbology = dataBarGenerator1;
            this.xrBarCode28.Text = "123456789";
            this.xrBarCode28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode27
            // 
            this.xrBarCode27.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode27.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode27.BorderWidth = 0F;
            this.xrBarCode27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode27.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8.75F);
            this.xrBarCode27.LocationFloat = new DevExpress.Utils.PointFloat(3.149467F, 1F);
            this.xrBarCode27.Module = 1.75F;
            this.xrBarCode27.Name = "xrBarCode27";
            this.xrBarCode27.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F);
            this.xrBarCode27.SizeF = new System.Drawing.SizeF(247.6923F, 160.4833F);
            this.xrBarCode27.StylePriority.UseBackColor = false;
            this.xrBarCode27.StylePriority.UseBorderWidth = false;
            this.xrBarCode27.StylePriority.UseFont = false;
            this.xrBarCode27.StylePriority.UsePadding = false;
            this.xrBarCode27.StylePriority.UseTextAlignment = false;
            dataBarGenerator2.SegmentsInRow = 4;
            dataBarGenerator2.Type = DevExpress.XtraPrinting.BarCode.DataBarType.ExpandedStacked;
            this.xrBarCode27.Symbology = dataBarGenerator2;
            this.xrBarCode27.Text = "01906141410000153202000150";
            this.xrBarCode27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell78.BorderWidth = 0F;
            this.xrTableCell78.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell78.Multiline = true;
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell78.StylePriority.UseBackColor = false;
            this.xrTableCell78.StylePriority.UseBorderColor = false;
            this.xrTableCell78.StylePriority.UseBorderWidth = false;
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.StylePriority.UsePadding = false;
            this.xrTableCell78.StylePriority.UseTextAlignment = false;
            this.xrTableCell78.Text = resources.GetString("xrTableCell78.Text");
            this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell78.Weight = 0.47324913892078074D;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 0.12569404028090733D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.BackColor = System.Drawing.Color.White;
            this.xrTableCell73.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseBackColor = false;
            this.xrTableCell73.StylePriority.UseFont = false;
            this.xrTableCell73.StylePriority.UseTextAlignment = false;
            this.xrTableCell73.Text = "UPC Shipping Container Symbol (ITF-14)";
            this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell73.Weight = 0.14936854190585536D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.BackColor = System.Drawing.Color.White;
            this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode26});
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseBackColor = false;
            this.xrTableCell74.Text = "xrTableCell74";
            this.xrTableCell74.Weight = 0.3773823191733639D;
            // 
            // xrBarCode26
            // 
            this.xrBarCode26.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode26.BorderWidth = 0F;
            this.xrBarCode26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode26.LocationFloat = new DevExpress.Utils.PointFloat(1.846186F, 21F);
            this.xrBarCode26.Module = 1.2F;
            this.xrBarCode26.Name = "xrBarCode26";
            this.xrBarCode26.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 2, 100F);
            this.xrBarCode26.SizeF = new System.Drawing.SizeF(251F, 100F);
            this.xrBarCode26.StylePriority.UseBorderWidth = false;
            this.xrBarCode26.StylePriority.UsePadding = false;
            this.xrBarCode26.StylePriority.UseTextAlignment = false;
            itF14Generator1.WideNarrowRatio = 3F;
            this.xrBarCode26.Symbology = itF14Generator1;
            this.xrBarCode26.Text = "1234567890123";
            this.xrBarCode26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.BackColor = System.Drawing.Color.White;
            this.xrTableCell75.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell75.Multiline = true;
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell75.StylePriority.UseBackColor = false;
            this.xrTableCell75.StylePriority.UseFont = false;
            this.xrTableCell75.StylePriority.UsePadding = false;
            this.xrTableCell75.StylePriority.UseTextAlignment = false;
            this.xrTableCell75.Text = resources.GetString("xrTableCell75.Text");
            this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell75.Weight = 0.47324913892078074D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.BackColor = System.Drawing.Color.White;
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.StyleName = "TextPaddingStyle";
            this.xrTableRow24.StylePriority.UseBackColor = false;
            this.xrTableRow24.Weight = 0.084533517554900531D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell70.BorderWidth = 0F;
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseBackColor = false;
            this.xrTableCell70.StylePriority.UseBorderWidth = false;
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.Text = "Data Matrix GS1";
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell70.Weight = 0.14936854190585536D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell71.BorderWidth = 1F;
            this.xrTableCell71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode25});
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBackColor = false;
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.StylePriority.UseBorderWidth = false;
            this.xrTableCell71.Text = "xrTableCell71";
            this.xrTableCell71.Weight = 0.3773823191733639D;
            // 
            // xrBarCode25
            // 
            this.xrBarCode25.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode25.BorderWidth = 0F;
            this.xrBarCode25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode25.LocationFloat = new DevExpress.Utils.PointFloat(9.999985F, 11.28455F);
            this.xrBarCode25.Name = "xrBarCode25";
            this.xrBarCode25.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F);
            this.xrBarCode25.ShowText = false;
            this.xrBarCode25.SizeF = new System.Drawing.SizeF(237.0375F, 75.88062F);
            this.xrBarCode25.StylePriority.UseBackColor = false;
            this.xrBarCode25.StylePriority.UseBorderWidth = false;
            this.xrBarCode25.StylePriority.UsePadding = false;
            this.xrBarCode25.Symbology = dataMatrixGS1Generator1;
            this.xrBarCode25.Text = "010031234567890621123456789012#300144";
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell72.BorderWidth = 0F;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell72.StylePriority.UseBackColor = false;
            this.xrTableCell72.StylePriority.UseBorderWidth = false;
            this.xrTableCell72.StylePriority.UsePadding = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.Text = resources.GetString("xrTableCell72.Text");
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell72.Weight = 0.47324913892078074D;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 0.094268648395414073D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.BackColor = System.Drawing.Color.White;
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StyleName = "TextPaddingStyle";
            this.xrTableCell67.StylePriority.UseBackColor = false;
            this.xrTableCell67.StylePriority.UseTextAlignment = false;
            this.xrTableCell67.Text = "Intelligent Mail";
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell67.Weight = 0.14936854190585536D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode24});
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Text = "xrTableCell68";
            this.xrTableCell68.Weight = 0.3773823191733639D;
            // 
            // xrBarCode24
            // 
            this.xrBarCode24.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode24.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode24.BackColor = System.Drawing.Color.White;
            this.xrBarCode24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode24.LocationFloat = new DevExpress.Utils.PointFloat(1.846218F, 3.178914E-05F);
            this.xrBarCode24.Module = 1.75F;
            this.xrBarCode24.Name = "xrBarCode24";
            this.xrBarCode24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBarCode24.ShowText = false;
            this.xrBarCode24.SizeF = new System.Drawing.SizeF(251F, 108.3549F);
            this.xrBarCode24.StylePriority.UseBackColor = false;
            this.xrBarCode24.StylePriority.UsePadding = false;
            this.xrBarCode24.Symbology = intelligentMailGenerator1;
            this.xrBarCode24.Text = "4408200000012345678991203";
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.BackColor = System.Drawing.Color.White;
            this.xrTableCell69.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell69.StylePriority.UseBackColor = false;
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.StylePriority.UsePadding = false;
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.Text = resources.GetString("xrTableCell69.Text");
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell69.Weight = 0.47324913892078074D;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 0.13272603021968232D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell79.BorderWidth = 0F;
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StyleName = "TextPaddingStyle";
            this.xrTableCell79.StylePriority.UseBackColor = false;
            this.xrTableCell79.StylePriority.UseBorderWidth = false;
            this.xrTableCell79.StylePriority.UseTextAlignment = false;
            this.xrTableCell79.Text = "Intelligent Mail Package";
            this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell79.Weight = 0.14936854190585536D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode29});
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseBackColor = false;
            this.xrTableCell80.Text = "xrTableCell80";
            this.xrTableCell80.Weight = 0.3773823191733639D;
            // 
            // xrBarCode29
            // 
            this.xrBarCode29.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode29.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode29.BorderWidth = 0F;
            this.xrBarCode29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode29.LocationFloat = new DevExpress.Utils.PointFloat(1.850037F, 0F);
            this.xrBarCode29.Module = 0.65F;
            this.xrBarCode29.Name = "xrBarCode29";
            this.xrBarCode29.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrBarCode29.ShowText = false;
            this.xrBarCode29.SizeF = new System.Drawing.SizeF(250.9962F, 152.559F);
            this.xrBarCode29.StylePriority.UseBorderWidth = false;
            this.xrBarCode29.StylePriority.UsePadding = false;
            this.xrBarCode29.Symbology = intelligentMailPackageGenerator1;
            this.xrBarCode29.Text = "9212391234567812345671";
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell81.BorderWidth = 0F;
            this.xrTableCell81.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell81.StyleName = "TextPaddingStyle";
            this.xrTableCell81.StylePriority.UseBackColor = false;
            this.xrTableCell81.StylePriority.UseBorderWidth = false;
            this.xrTableCell81.StylePriority.UseFont = false;
            this.xrTableCell81.StylePriority.UsePadding = false;
            this.xrTableCell81.StylePriority.UseTextAlignment = false;
            this.xrTableCell81.Text = resources.GetString("xrTableCell81.Text");
            this.xrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell81.Weight = 0.47324913892078074D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.BackColor = System.Drawing.Color.White;
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.StylePriority.UseBackColor = false;
            this.xrTableRow21.Weight = 0.16560617116237181D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StyleName = "TextPaddingStyle";
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.Text = "Data Matrix";
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell61.Weight = 0.14936854190585536D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode22});
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.Text = "xrTableCell62";
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell62.Weight = 0.3773823191733639D;
            // 
            // xrBarCode22
            // 
            this.xrBarCode22.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode22.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode22.LocationFloat = new DevExpress.Utils.PointFloat(1.100014F, 0F);
            this.xrBarCode22.Module = 1F;
            this.xrBarCode22.Name = "xrBarCode22";
            this.xrBarCode22.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F);
            this.xrBarCode22.ShowText = false;
            this.xrBarCode22.SizeF = new System.Drawing.SizeF(251.7462F, 190.3522F);
            this.xrBarCode22.StylePriority.UsePadding = false;
            this.xrBarCode22.StylePriority.UseTextAlignment = false;
            this.xrBarCode22.Symbology = dataMatrixGenerator1;
            this.xrBarCode22.Text = resources.GetString("xrBarCode22.Text");
            this.xrBarCode22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell63.Multiline = true;
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UsePadding = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.Text = resources.GetString("xrTableCell63.Text");
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell63.Weight = 0.47324913892078074D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.StylePriority.UseBackColor = false;
            this.xrTableRow20.Weight = 0.1436397802694781D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.BorderWidth = 0F;
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StyleName = "TextPaddingStyle";
            this.xrTableCell58.StylePriority.UseBackColor = false;
            this.xrTableCell58.StylePriority.UseBorderWidth = false;
            this.xrTableCell58.StylePriority.UseTextAlignment = false;
            this.xrTableCell58.Text = "PDF417";
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell58.Weight = 0.14936854190585536D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell59.BorderWidth = 1F;
            this.xrTableCell59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode21});
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.StylePriority.UseBackColor = false;
            this.xrTableCell59.StylePriority.UseBorders = false;
            this.xrTableCell59.StylePriority.UseBorderWidth = false;
            this.xrTableCell59.Text = "xrTableCell59";
            this.xrTableCell59.Weight = 0.3773823191733639D;
            // 
            // xrBarCode21
            // 
            this.xrBarCode21.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrBarCode21.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode21.BorderWidth = 0F;
            this.xrBarCode21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode21.LocationFloat = new DevExpress.Utils.PointFloat(2.345001F, 2.000244F);
            this.xrBarCode21.Module = 1F;
            this.xrBarCode21.Name = "xrBarCode21";
            this.xrBarCode21.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode21.ShowText = false;
            this.xrBarCode21.SizeF = new System.Drawing.SizeF(248.5011F, 162.1217F);
            this.xrBarCode21.StylePriority.UseBorderWidth = false;
            this.xrBarCode21.StylePriority.UsePadding = false;
            pdF417Generator1.Columns = 9;
            pdF417Generator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.ErrorCorrectionLevel.Level0;
            pdF417Generator1.Rows = 36;
            this.xrBarCode21.Symbology = pdF417Generator1;
            this.xrBarCode21.Text = resources.GetString("xrBarCode21.Text");
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.BorderWidth = 0F;
            this.xrTableCell60.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell60.Multiline = true;
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell60.StylePriority.UseBackColor = false;
            this.xrTableCell60.StylePriority.UseBorderWidth = false;
            this.xrTableCell60.StylePriority.UsePadding = false;
            this.xrTableCell60.StylePriority.UseTextAlignment = false;
            this.xrTableCell60.Text = resources.GetString("xrTableCell60.Text");
            this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell60.Weight = 0.47324913892078074D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.BackColor = System.Drawing.Color.White;
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow2.StylePriority.UseBackColor = false;
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow2.Weight = 0.062805762830391229D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell4.StyleName = "TextPaddingStyle";
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.Text = "Codabar";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.14936854190585536D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.3773823191733639D;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 12F);
            this.xrBarCode1.Module = 1F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode1.StylePriority.UseBackColor = false;
            codabarGenerator1.WideNarrowRatio = 2F;
            this.xrBarCode1.Symbology = codabarGenerator1;
            this.xrBarCode1.Text = "0123456789+-/:.$";
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell6.StyleName = "TextPaddingStyle";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.Text = resources.GetString("xrTableCell6.Text");
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell6.Weight = 0.47324913892078074D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow3.StylePriority.UseBackColor = false;
            this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow3.Weight = 0.080640303642661892D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BorderWidth = 0F;
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.StyleName = "TextPaddingStyle";
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorderWidth = false;
            this.xrTableCell7.Text = "Code 11";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.14936854190585536D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell8.BorderWidth = 1F;
            this.xrTableCell8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode2});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell8.Weight = 0.3773823191733639D;
            // 
            // xrBarCode2
            // 
            this.xrBarCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode2.BorderWidth = 0F;
            this.xrBarCode2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 18F);
            this.xrBarCode2.Name = "xrBarCode2";
            this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode2.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode2.StylePriority.UseBackColor = false;
            this.xrBarCode2.StylePriority.UseBorderWidth = false;
            this.xrBarCode2.Symbology = code11Generator1;
            this.xrBarCode2.Text = "0123456";
            this.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BorderWidth = 0F;
            this.xrTableCell9.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell9.StyleName = "TextPaddingStyle";
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseBorderWidth = false;
            this.xrTableCell9.Text = resources.GetString("xrTableCell9.Text");
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell9.Weight = 0.47324913892078074D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.BackColor = System.Drawing.Color.White;
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow4.StylePriority.UseBackColor = false;
            this.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow4.Weight = 0.12950549263905303D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell10.StyleName = "TextPaddingStyle";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.Text = "Code 128";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 0.14936854190585536D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode3});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.Text = "xrTableCell11";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell11.Weight = 0.3773823191733639D;
            // 
            // xrBarCode3
            // 
            this.xrBarCode3.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode3.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 42F);
            this.xrBarCode3.Module = 1F;
            this.xrBarCode3.Name = "xrBarCode3";
            this.xrBarCode3.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode3.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode3.StylePriority.UseBackColor = false;
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.xrBarCode3.Symbology = code128Generator1;
            this.xrBarCode3.Text = "XRBarCode 0123456";
            this.xrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell12.StyleName = "TextPaddingStyle";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.Text = resources.GetString("xrTableCell12.Text");
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell12.Weight = 0.47324913892078074D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow5.StylePriority.UseBackColor = false;
            this.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow5.Weight = 0.090355568115820725D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BorderWidth = 0F;
            this.xrTableCell13.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell13.StyleName = "TextPaddingStyle";
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.StylePriority.UseBorderWidth = false;
            this.xrTableCell13.Text = "EAN128";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 0.14936854190585536D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell14.BorderWidth = 1F;
            this.xrTableCell14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode4});
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell14.StylePriority.UseBackColor = false;
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseBorderWidth = false;
            this.xrTableCell14.Text = "xrTableCell14";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell14.Weight = 0.3773823191733639D;
            // 
            // xrBarCode4
            // 
            this.xrBarCode4.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode4.BorderWidth = 0F;
            this.xrBarCode4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode4.LocationFloat = new DevExpress.Utils.PointFloat(4.149467F, 23.8335F);
            this.xrBarCode4.Module = 0.8F;
            this.xrBarCode4.Name = "xrBarCode4";
            this.xrBarCode4.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode4.SizeF = new System.Drawing.SizeF(242.8879F, 59F);
            this.xrBarCode4.StylePriority.UseBackColor = false;
            this.xrBarCode4.StylePriority.UseBorderWidth = false;
            eaN128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.xrBarCode4.Symbology = eaN128Generator1;
            this.xrBarCode4.Text = "XRBarCode 0123456";
            this.xrBarCode4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BorderWidth = 0F;
            this.xrTableCell15.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell15.StyleName = "TextPaddingStyle";
            this.xrTableCell15.StylePriority.UseBackColor = false;
            this.xrTableCell15.StylePriority.UseBorderWidth = false;
            this.xrTableCell15.Text = resources.GetString("xrTableCell15.Text");
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell15.Weight = 0.47324913892078074D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.BackColor = System.Drawing.Color.White;
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow8.StylePriority.UseBackColor = false;
            this.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow8.Weight = 0.0881799351031717D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell22.StyleName = "TextPaddingStyle";
            this.xrTableCell22.StylePriority.UseBackColor = false;
            this.xrTableCell22.Text = "Code 39";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell22.Weight = 0.14936854190585536D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode5});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell23.StylePriority.UseBackColor = false;
            this.xrTableCell23.Text = "xrTableCell23";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 0.3773823191733639D;
            // 
            // xrBarCode5
            // 
            this.xrBarCode5.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode5.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 20F);
            this.xrBarCode5.Module = 1F;
            this.xrBarCode5.Name = "xrBarCode5";
            this.xrBarCode5.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode5.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode5.StylePriority.UseBackColor = false;
            code39Generator1.WideNarrowRatio = 3F;
            this.xrBarCode5.Symbology = code39Generator1;
            this.xrBarCode5.Text = "XRBARCODE";
            this.xrBarCode5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell24.StyleName = "TextPaddingStyle";
            this.xrTableCell24.StylePriority.UseBackColor = false;
            this.xrTableCell24.Text = resources.GetString("xrTableCell24.Text");
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell24.Weight = 0.47324913892078074D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow9.StylePriority.UseBackColor = false;
            this.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow9.Weight = 0.083830793097216263D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.BorderWidth = 0F;
            this.xrTableCell25.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell25.StyleName = "TextPaddingStyle";
            this.xrTableCell25.StylePriority.UseBackColor = false;
            this.xrTableCell25.StylePriority.UseBorderWidth = false;
            this.xrTableCell25.Text = "Code 39 Extended";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell25.Weight = 0.14936854190585536D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell26.BorderWidth = 1F;
            this.xrTableCell26.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode6});
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell26.StylePriority.UseBackColor = false;
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.StylePriority.UseBorderWidth = false;
            this.xrTableCell26.Text = "xrTableCell26";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell26.Weight = 0.3773823191733639D;
            // 
            // xrBarCode6
            // 
            this.xrBarCode6.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode6.BorderWidth = 0F;
            this.xrBarCode6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode6.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 18F);
            this.xrBarCode6.Module = 1F;
            this.xrBarCode6.Name = "xrBarCode6";
            this.xrBarCode6.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode6.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode6.StylePriority.UseBackColor = false;
            this.xrBarCode6.StylePriority.UseBorderWidth = false;
            code39ExtendedGenerator1.WideNarrowRatio = 3F;
            this.xrBarCode6.Symbology = code39ExtendedGenerator1;
            this.xrBarCode6.Text = "BarCODE";
            this.xrBarCode6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.BorderWidth = 0F;
            this.xrTableCell27.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell27.StyleName = "TextPaddingStyle";
            this.xrTableCell27.StylePriority.UseBackColor = false;
            this.xrTableCell27.StylePriority.UseBorderWidth = false;
            this.xrTableCell27.Text = resources.GetString("xrTableCell27.Text");
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell27.Weight = 0.47324913892078074D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.BackColor = System.Drawing.Color.White;
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow10.StylePriority.UseBackColor = false;
            this.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow10.Weight = 0.092530570560227524D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell28.StyleName = "TextPaddingStyle";
            this.xrTableCell28.StylePriority.UseBackColor = false;
            this.xrTableCell28.Text = "Code 93";
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell28.Weight = 0.14936854190585536D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode7});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell29.StylePriority.UseBackColor = false;
            this.xrTableCell29.Text = "xrTableCell29";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell29.Weight = 0.3773823191733639D;
            // 
            // xrBarCode7
            // 
            this.xrBarCode7.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode7.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 21F);
            this.xrBarCode7.Module = 1F;
            this.xrBarCode7.Name = "xrBarCode7";
            this.xrBarCode7.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode7.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode7.StylePriority.UseBackColor = false;
            this.xrBarCode7.Symbology = code93Generator1;
            this.xrBarCode7.Text = "XRBARCODE";
            this.xrBarCode7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell30.StyleName = "TextPaddingStyle";
            this.xrTableCell30.StylePriority.UseBackColor = false;
            this.xrTableCell30.Text = resources.GetString("xrTableCell30.Text");
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell30.Weight = 0.47324913892078074D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow11.StylePriority.UseBackColor = false;
            this.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow11.Weight = 0.0686058224492926D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.BorderWidth = 0F;
            this.xrTableCell31.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell31.Multiline = true;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell31.StyleName = "TextPaddingStyle";
            this.xrTableCell31.StylePriority.UseBackColor = false;
            this.xrTableCell31.StylePriority.UseBorderWidth = false;
            this.xrTableCell31.Text = "Code 93 Extended";
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell31.Weight = 0.14936854190585536D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell32.BorderWidth = 1F;
            this.xrTableCell32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode8});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell32.StylePriority.UseBackColor = false;
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.StylePriority.UseBorderWidth = false;
            this.xrTableCell32.Text = "xrTableCell32";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell32.Weight = 0.3773823191733639D;
            // 
            // xrBarCode8
            // 
            this.xrBarCode8.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode8.BorderWidth = 0F;
            this.xrBarCode8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode8.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 9F);
            this.xrBarCode8.Module = 1F;
            this.xrBarCode8.Name = "xrBarCode8";
            this.xrBarCode8.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode8.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode8.StylePriority.UseBackColor = false;
            this.xrBarCode8.StylePriority.UseBorderWidth = false;
            this.xrBarCode8.Symbology = code93ExtendedGenerator1;
            this.xrBarCode8.Text = "XRBarCode";
            this.xrBarCode8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.BorderWidth = 0F;
            this.xrTableCell33.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell33.StyleName = "TextPaddingStyle";
            this.xrTableCell33.StylePriority.UseBackColor = false;
            this.xrTableCell33.StylePriority.UseBorderWidth = false;
            this.xrTableCell33.Text = resources.GetString("xrTableCell33.Text");
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell33.Weight = 0.47324913892078074D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.BackColor = System.Drawing.Color.White;
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow12.StylePriority.UseBackColor = false;
            this.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow12.Weight = 0.063530478230094292D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell34.Multiline = true;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell34.StyleName = "TextPaddingStyle";
            this.xrTableCell34.StylePriority.UseBackColor = false;
            this.xrTableCell34.Text = "Industrial\r\n2 of 5";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell34.Weight = 0.14936854190585536D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode9});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell35.StylePriority.UseBackColor = false;
            this.xrTableCell35.Text = "xrTableCell35";
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell35.Weight = 0.3773823191733639D;
            // 
            // xrBarCode9
            // 
            this.xrBarCode9.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode9.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 7F);
            this.xrBarCode9.Module = 1F;
            this.xrBarCode9.Name = "xrBarCode9";
            this.xrBarCode9.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode9.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode9.StylePriority.UseBackColor = false;
            this.xrBarCode9.Symbology = industrial2of5Generator1;
            this.xrBarCode9.Text = "0123456789";
            this.xrBarCode9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell36.StyleName = "TextPaddingStyle";
            this.xrTableCell36.StylePriority.UseBackColor = false;
            this.xrTableCell36.Text = resources.GetString("xrTableCell36.Text");
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell36.Weight = 0.47324913892078074D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow13.StylePriority.UseBackColor = false;
            this.xrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow13.Weight = 0.087455435424183117D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.BorderWidth = 0F;
            this.xrTableCell37.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell37.Multiline = true;
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell37.StyleName = "TextPaddingStyle";
            this.xrTableCell37.StylePriority.UseBackColor = false;
            this.xrTableCell37.StylePriority.UseBorderWidth = false;
            this.xrTableCell37.Text = "Matrix\r\n2 of 5";
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell37.Weight = 0.14936854190585536D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell38.BorderWidth = 1F;
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode10});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell38.StylePriority.UseBackColor = false;
            this.xrTableCell38.StylePriority.UseBorders = false;
            this.xrTableCell38.StylePriority.UseBorderWidth = false;
            this.xrTableCell38.Text = "xrTableCell38";
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell38.Weight = 0.3773823191733639D;
            // 
            // xrBarCode10
            // 
            this.xrBarCode10.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode10.BorderWidth = 0F;
            this.xrBarCode10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode10.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 21F);
            this.xrBarCode10.Module = 1F;
            this.xrBarCode10.Name = "xrBarCode10";
            this.xrBarCode10.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode10.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode10.StylePriority.UseBackColor = false;
            this.xrBarCode10.StylePriority.UseBorderWidth = false;
            this.xrBarCode10.Symbology = matrix2of5Generator1;
            this.xrBarCode10.Text = "00123456789";
            this.xrBarCode10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.BorderWidth = 0F;
            this.xrTableCell39.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell39.StyleName = "TextPaddingStyle";
            this.xrTableCell39.StylePriority.UseBackColor = false;
            this.xrTableCell39.StylePriority.UseBorderWidth = false;
            this.xrTableCell39.Text = resources.GetString("xrTableCell39.Text");
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell39.Weight = 0.47324913892078074D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.BackColor = System.Drawing.Color.White;
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow6.StylePriority.UseBackColor = false;
            this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow6.Weight = 0.059905205334885074D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell16.StyleName = "TextPaddingStyle";
            this.xrTableCell16.StylePriority.UseBackColor = false;
            this.xrTableCell16.Text = "Interleaved\r\n2 of 5";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell16.Weight = 0.14936854190585536D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode11});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell17.StylePriority.UseBackColor = false;
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell17.Weight = 0.3773823191733639D;
            // 
            // xrBarCode11
            // 
            this.xrBarCode11.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode11.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 6F);
            this.xrBarCode11.Module = 1F;
            this.xrBarCode11.Name = "xrBarCode11";
            this.xrBarCode11.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode11.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode11.StylePriority.UseBackColor = false;
            interleaved2of5Generator1.WideNarrowRatio = 3F;
            this.xrBarCode11.Symbology = interleaved2of5Generator1;
            this.xrBarCode11.Text = "0123456789";
            this.xrBarCode11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell18.StyleName = "TextPaddingStyle";
            this.xrTableCell18.StylePriority.UseBackColor = false;
            this.xrTableCell18.Text = "Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard " +
    "2 of 5 symbology. It is used primarily in the distribution and warehouse industr" +
    "y.";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell18.Weight = 0.47324913892078074D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow7.StylePriority.UseBackColor = false;
            this.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow7.Weight = 0.066431042363160886D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.BorderWidth = 0F;
            this.xrTableCell19.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell19.StyleName = "TextPaddingStyle";
            this.xrTableCell19.StylePriority.UseBackColor = false;
            this.xrTableCell19.StylePriority.UseBorderWidth = false;
            this.xrTableCell19.Text = "EAN13";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell19.Weight = 0.14936854190585536D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.BorderWidth = 0F;
            this.xrTableCell20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode12});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell20.StylePriority.UseBackColor = false;
            this.xrTableCell20.StylePriority.UseBorderWidth = false;
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell20.Weight = 0.3773823191733639D;
            // 
            // xrBarCode12
            // 
            this.xrBarCode12.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode12.BorderWidth = 0F;
            this.xrBarCode12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode12.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 12F);
            this.xrBarCode12.Module = 1F;
            this.xrBarCode12.Name = "xrBarCode12";
            this.xrBarCode12.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode12.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode12.StylePriority.UseBackColor = false;
            this.xrBarCode12.StylePriority.UseBorderWidth = false;
            this.xrBarCode12.Symbology = eaN13Generator1;
            this.xrBarCode12.Text = "978531800111";
            this.xrBarCode12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.BorderWidth = 0F;
            this.xrTableCell21.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell21.StyleName = "TextPaddingStyle";
            this.xrTableCell21.StylePriority.UseBackColor = false;
            this.xrTableCell21.StylePriority.UseBorderWidth = false;
            this.xrTableCell21.Text = "EAN-13, based upon the UPC-A standard, was implemented by the International Artic" +
    "le Numbering Association (EAN) in Europe.";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell21.Weight = 0.47324913892078074D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.BackColor = System.Drawing.Color.White;
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow14.StylePriority.UseBackColor = false;
            this.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow14.Weight = 0.0555552137211925D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell40.Multiline = true;
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell40.StyleName = "TextPaddingStyle";
            this.xrTableCell40.StylePriority.UseBackColor = false;
            this.xrTableCell40.Text = "EAN8";
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell40.Weight = 0.14936854190585536D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode13});
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell41.StylePriority.UseBackColor = false;
            this.xrTableCell41.Text = "xrTableCell41";
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell41.Weight = 0.3773823191733639D;
            // 
            // xrBarCode13
            // 
            this.xrBarCode13.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode13.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 2F);
            this.xrBarCode13.Module = 1F;
            this.xrBarCode13.Name = "xrBarCode13";
            this.xrBarCode13.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode13.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode13.StylePriority.UseBackColor = false;
            this.xrBarCode13.Symbology = eaN8Generator1;
            this.xrBarCode13.Text = "0123456";
            this.xrBarCode13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell42.StyleName = "TextPaddingStyle";
            this.xrTableCell42.StylePriority.UseBackColor = false;
            this.xrTableCell42.Text = "EAN-8 is the EAN equivalent of UPC-E in the sense that it provides a \"short\" barc" +
    "ode for small packages.";
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell42.Weight = 0.47324913892078074D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow15.StylePriority.UseBackColor = false;
            this.xrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow15.Weight = 0.096155415332787889D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.BorderWidth = 0F;
            this.xrTableCell43.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell43.Multiline = true;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell43.StyleName = "TextPaddingStyle";
            this.xrTableCell43.StylePriority.UseBackColor = false;
            this.xrTableCell43.StylePriority.UseBorderWidth = false;
            this.xrTableCell43.Text = "MSI/Plessey";
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell43.Weight = 0.14936854190585536D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell44.BorderWidth = 1F;
            this.xrTableCell44.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode14});
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell44.StylePriority.UseBackColor = false;
            this.xrTableCell44.StylePriority.UseBorders = false;
            this.xrTableCell44.StylePriority.UseBorderWidth = false;
            this.xrTableCell44.Text = "xrTableCell44";
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell44.Weight = 0.3773823191733639D;
            // 
            // xrBarCode14
            // 
            this.xrBarCode14.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode14.BorderWidth = 0F;
            this.xrBarCode14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode14.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 25F);
            this.xrBarCode14.Module = 1F;
            this.xrBarCode14.Name = "xrBarCode14";
            this.xrBarCode14.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode14.SizeF = new System.Drawing.SizeF(250F, 62.11206F);
            this.xrBarCode14.StylePriority.UseBackColor = false;
            this.xrBarCode14.StylePriority.UseBorderWidth = false;
            this.xrBarCode14.Symbology = codeMSIGenerator1;
            this.xrBarCode14.Text = "0123456789";
            this.xrBarCode14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.BorderWidth = 0F;
            this.xrTableCell45.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell45.StyleName = "TextPaddingStyle";
            this.xrTableCell45.StylePriority.UseBackColor = false;
            this.xrTableCell45.StylePriority.UseBorderWidth = false;
            this.xrTableCell45.Text = resources.GetString("xrTableCell45.Text");
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell45.Weight = 0.47324913892078074D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.BackColor = System.Drawing.Color.White;
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow16.StylePriority.UseBackColor = false;
            this.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow16.Weight = 0.085280652019271208D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell46.Multiline = true;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell46.StyleName = "TextPaddingStyle";
            this.xrTableCell46.StylePriority.UseBackColor = false;
            this.xrTableCell46.Text = "UPC-A";
            this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell46.Weight = 0.14936854190585536D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode15});
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell47.StylePriority.UseBackColor = false;
            this.xrTableCell47.Text = "xrTableCell47";
            this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell47.Weight = 0.3773823191733639D;
            // 
            // xrBarCode15
            // 
            this.xrBarCode15.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode15.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 19F);
            this.xrBarCode15.Module = 1F;
            this.xrBarCode15.Name = "xrBarCode15";
            this.xrBarCode15.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode15.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode15.StylePriority.UseBackColor = false;
            this.xrBarCode15.Symbology = upcaGenerator1;
            this.xrBarCode15.Text = "78534235463";
            this.xrBarCode15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell48.StyleName = "TextPaddingStyle";
            this.xrTableCell48.StylePriority.UseBackColor = false;
            this.xrTableCell48.Text = resources.GetString("xrTableCell48.Text");
            this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell48.Weight = 0.47324913892078074D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow17.StylePriority.UseBackColor = false;
            this.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow17.Weight = 0.088449476476530772D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.BorderWidth = 0F;
            this.xrTableCell49.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell49.Multiline = true;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell49.StyleName = "TextPaddingStyle";
            this.xrTableCell49.StylePriority.UseBackColor = false;
            this.xrTableCell49.StylePriority.UseBorderWidth = false;
            this.xrTableCell49.Text = "UPC-E";
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell49.Weight = 0.14936854190585536D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell50.BorderWidth = 1F;
            this.xrTableCell50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode16});
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell50.StylePriority.UseBackColor = false;
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.StylePriority.UseBorderWidth = false;
            this.xrTableCell50.Text = "xrTableCell50";
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell50.Weight = 0.3773823191733639D;
            // 
            // xrBarCode16
            // 
            this.xrBarCode16.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode16.BorderWidth = 0F;
            this.xrBarCode16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode16.LocationFloat = new DevExpress.Utils.PointFloat(1.04174F, 20F);
            this.xrBarCode16.Module = 1F;
            this.xrBarCode16.Name = "xrBarCode16";
            this.xrBarCode16.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode16.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode16.StylePriority.UseBackColor = false;
            this.xrBarCode16.StylePriority.UseBorderWidth = false;
            this.xrBarCode16.Symbology = upcE0Generator1;
            this.xrBarCode16.Text = "4210000526";
            this.xrBarCode16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.BorderWidth = 0F;
            this.xrTableCell51.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell51.StyleName = "TextPaddingStyle";
            this.xrTableCell51.StylePriority.UseBackColor = false;
            this.xrTableCell51.StylePriority.UseBorderWidth = false;
            this.xrTableCell51.Text = resources.GetString("xrTableCell51.Text");
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell51.Weight = 0.47324913892078074D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.BackColor = System.Drawing.Color.White;
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow18.StylePriority.UseBackColor = false;
            this.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow18.Weight = 0.13984097407903812D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell52.Multiline = true;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell52.StyleName = "TextPaddingStyle";
            this.xrTableCell52.StylePriority.UseBackColor = false;
            this.xrTableCell52.Text = "EAN13\r\nwith\r\nUPC Suppl. 2";
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell52.Weight = 0.14936854190585536D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode19,
            this.xrBarCode17});
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell53.StylePriority.UseBackColor = false;
            this.xrTableCell53.Text = "xrTableCell53";
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell53.Weight = 0.3773823191733639D;
            // 
            // xrBarCode19
            // 
            this.xrBarCode19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode19.LocationFloat = new DevExpress.Utils.PointFloat(159F, 48.3335F);
            this.xrBarCode19.Module = 1F;
            this.xrBarCode19.Name = "xrBarCode19";
            this.xrBarCode19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F);
            this.xrBarCode19.SizeF = new System.Drawing.SizeF(83.84622F, 60F);
            this.xrBarCode19.StylePriority.UseBackColor = false;
            this.xrBarCode19.Symbology = upcSupplemental2Generator1;
            this.xrBarCode19.Text = "01";
            this.xrBarCode19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrBarCode17
            // 
            this.xrBarCode17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode17.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 48.3335F);
            this.xrBarCode17.Module = 1F;
            this.xrBarCode17.Name = "xrBarCode17";
            this.xrBarCode17.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode17.SizeF = new System.Drawing.SizeF(133F, 60F);
            this.xrBarCode17.StylePriority.UseBackColor = false;
            this.xrBarCode17.Symbology = eaN13Generator2;
            this.xrBarCode17.Text = "978531800111";
            this.xrBarCode17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell54.StyleName = "TextPaddingStyle";
            this.xrTableCell54.StylePriority.UseBackColor = false;
            this.xrTableCell54.Text = resources.GetString("xrTableCell54.Text");
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell54.Weight = 0.47324913892078074D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow19.StylePriority.UseBackColor = false;
            this.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow19.Weight = 0.058001705662949148D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.BorderWidth = 0F;
            this.xrTableCell55.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell55.StyleName = "TextPaddingStyle";
            this.xrTableCell55.StylePriority.UseBackColor = false;
            this.xrTableCell55.StylePriority.UseBorderWidth = false;
            this.xrTableCell55.Text = "EAN13\r\nwith\r\nUPC Suppl. 5";
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell55.Weight = 0.14936854190585536D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell56.BorderWidth = 1F;
            this.xrTableCell56.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode18,
            this.xrBarCode20});
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell56.StylePriority.UseBackColor = false;
            this.xrTableCell56.StylePriority.UseBorders = false;
            this.xrTableCell56.StylePriority.UseBorderWidth = false;
            this.xrTableCell56.Text = "xrTableCell56";
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell56.Weight = 0.3773823191733639D;
            // 
            // xrBarCode18
            // 
            this.xrBarCode18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode18.BorderWidth = 0F;
            this.xrBarCode18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode18.LocationFloat = new DevExpress.Utils.PointFloat(25F, 0F);
            this.xrBarCode18.Module = 1F;
            this.xrBarCode18.Name = "xrBarCode18";
            this.xrBarCode18.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode18.SizeF = new System.Drawing.SizeF(133F, 60F);
            this.xrBarCode18.StylePriority.UseBackColor = false;
            this.xrBarCode18.StylePriority.UseBorderWidth = false;
            this.xrBarCode18.Symbology = eaN13Generator3;
            this.xrBarCode18.Text = "978531800111";
            this.xrBarCode18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode20
            // 
            this.xrBarCode20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode20.BorderWidth = 0F;
            this.xrBarCode20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AutoModule", "?AutoModuleParameter")});
            this.xrBarCode20.LocationFloat = new DevExpress.Utils.PointFloat(158F, 0F);
            this.xrBarCode20.Module = 1F;
            this.xrBarCode20.Name = "xrBarCode20";
            this.xrBarCode20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F);
            this.xrBarCode20.SizeF = new System.Drawing.SizeF(75F, 60F);
            this.xrBarCode20.StylePriority.UseBackColor = false;
            this.xrBarCode20.StylePriority.UseBorderWidth = false;
            this.xrBarCode20.Symbology = upcSupplemental5Generator1;
            this.xrBarCode20.Text = "01234";
            this.xrBarCode20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.BorderWidth = 0F;
            this.xrTableCell57.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell57.StyleName = "TextPaddingStyle";
            this.xrTableCell57.StylePriority.UseBackColor = false;
            this.xrTableCell57.StylePriority.UseBorderWidth = false;
            this.xrTableCell57.Text = "5-digit supplemental barcodes are used on books to indicate a suggested retail pr" +
    "ice.";
            this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell57.Weight = 0.47324913892078074D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel3});
            this.ReportHeader.HeightF = 32F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(42F, 25F);
            this.xrLabel1.Text = "Note: ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(43F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(627F, 25F);
            this.xrLabel3.Text = "You may print the following barcodes and then read them by any suitable barcode s" +
    "canner";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomJustify;
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.Black;
            this.PageHeader.BorderColor = System.Drawing.Color.White;
            this.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageHeader.ForeColor = System.Drawing.Color.White;
            this.PageHeader.HeightF = 34F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(670F, 34F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.Text = "Symbology";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.14936854190585536D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.Text = "Example";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.3773823191733639D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.Text = "Description";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.47324913892078074D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 93F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            // TextPaddingStyle
            // 
            this.TextPaddingStyle.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.TextPaddingStyle.Name = "TextPaddingStyle";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 86F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // AutoModuleParameter
            // 
            this.AutoModuleParameter.Description = "AutoModule";
            this.AutoModuleParameter.Name = "AutoModuleParameter";
            this.AutoModuleParameter.Type = typeof(bool);
            this.AutoModuleParameter.ValueInfo = "False";
            // 
            // BarCodeTypesReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.Margins = new DevExpress.Drawing.DXMargins(98F, 80F, 86F, 93F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AutoModuleParameter});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TextPaddingStyle});
            this.Version = "24.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            xrWatermark1});
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

		internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow20;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell58;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell59;
		private DevExpress.XtraReports.UI.XRBarCode xrBarCode21;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell60;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.Parameters.Parameter AutoModuleParameter;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell61;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell62;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell63;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode22;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow21;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell67;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell68;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode24;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell69;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow24;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell70;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell71;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell72;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell76;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell77;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell78;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell73;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell75;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode28;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell74;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode26;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell79;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell80;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell81;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode29;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell82;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell83;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell84;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode30;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell85;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell86;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell87;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell91;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell92;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell93;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow30;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell88;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell89;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode33;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell90;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell94;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell95;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell96;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow33;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell97;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell98;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode35;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell99;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell100;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell102;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell101;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode39;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow35;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell103;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell104;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode36;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell105;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode23;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow36;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell106;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell107;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode37;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell108;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell64;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell65;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode38;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell66;
    }
}
