using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.DataAccess;

namespace XtraReportsDemos.VehicleInspectionReport {
    public partial class Report {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table6 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox49 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox50 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox51 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox52 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox53 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox54 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox55 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox56 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox57 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox19 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox20 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox21 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox22 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox23 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox24 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox25 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox26 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox27 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox28 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox29 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox30 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox31 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox32 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox33 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox34 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox35 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox36 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox37 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox38 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox39 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox40 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox41 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox42 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox43 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox44 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox45 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox46 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox47 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox48 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.checkBox3 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.checkBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.checkBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox3 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox4 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox5 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox6 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox7 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox8 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox9 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox10 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox11 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox12 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox13 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox14 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox15 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox16 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox17 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox18 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.labelCurrentDate = new DevExpress.XtraReports.UI.XRLabel();
            this.label15 = new DevExpress.XtraReports.UI.XRLabel();
            this.label14 = new DevExpress.XtraReports.UI.XRLabel();
            this.label13 = new DevExpress.XtraReports.UI.XRLabel();
            this.label12 = new DevExpress.XtraReports.UI.XRLabel();
            this.label11 = new DevExpress.XtraReports.UI.XRLabel();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.table10 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow56 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.checkBox24 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox101 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow57 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox100 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox102 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table9 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow54 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox79 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox80 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox81 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox85 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox86 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox87 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow55 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox82 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox83 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox84 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox88 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox89 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox90 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.table8 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow45 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox58 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox59 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox60 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow46 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox61 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox62 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox63 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow49 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox64 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox65 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox66 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow50 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox67 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox68 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox69 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow51 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox70 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox71 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox72 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow52 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox73 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox74 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox75 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow53 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox76 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox77 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox78 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pictureBox7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.tableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.table7 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.checkBox10 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.checkBox11 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.checkBox12 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow41 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow42 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox91 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox92 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox93 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow43 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow44 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox94 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox95 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox96 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow47 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableRow48 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCheckBox97 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox98 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox99 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.tableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.EditorKeyStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.EditorValueStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GeneralTextStyleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.SectionTitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.parameterLanguage = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.table6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table6,
            this.label6,
            this.table4,
            this.table3,
            this.pictureBox4,
            this.label4,
            this.label3,
            this.label2,
            this.table2,
            this.table1});
            this.Detail.Name = "Detail";
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            // 
            // table6
            // 
            this.table6.Name = "table6";
            this.table6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow37,
            this.tableRow38,
            this.tableRow39});
            // 
            // tableRow37
            // 
            this.tableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell73,
            this.tableCell74});
            this.tableRow37.Name = "tableRow37";
            // 
            // tableCell73
            // 
            this.tableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox49,
            this.xrCheckBox50,
            this.xrCheckBox51});
            this.tableCell73.Multiline = true;
            this.tableCell73.Name = "tableCell73";
            // 
            // xrCheckBox49
            // 
            this.xrCheckBox49.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox49.Checked = true;
            this.xrCheckBox49.EditOptions.Enabled = true;
            this.xrCheckBox49.EditOptions.GroupID = "Battery Charge";
            this.xrCheckBox49.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox49.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox49.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox49.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox49.Name = "xrCheckBox49";
            this.xrCheckBox49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox50
            // 
            this.xrCheckBox50.EditOptions.Enabled = true;
            this.xrCheckBox50.EditOptions.GroupID = "Battery Charge";
            this.xrCheckBox50.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox50.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox50.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox50.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox50.Name = "xrCheckBox50";
            this.xrCheckBox50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox51
            // 
            this.xrCheckBox51.EditOptions.Enabled = true;
            this.xrCheckBox51.EditOptions.GroupID = "Battery Charge";
            this.xrCheckBox51.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox51.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox51.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox51.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox51.Name = "xrCheckBox51";
            this.xrCheckBox51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell74
            // 
            this.tableCell74.Multiline = true;
            this.tableCell74.Name = "tableCell74";
            this.tableCell74.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow38
            // 
            this.tableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell75,
            this.tableCell76});
            this.tableRow38.Name = "tableRow38";
            // 
            // tableCell75
            // 
            this.tableCell75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox52,
            this.xrCheckBox53,
            this.xrCheckBox54});
            this.tableCell75.Multiline = true;
            this.tableCell75.Name = "tableCell75";
            // 
            // xrCheckBox52
            // 
            this.xrCheckBox52.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox52.Checked = true;
            this.xrCheckBox52.EditOptions.Enabled = true;
            this.xrCheckBox52.EditOptions.GroupID = "Battery Condition";
            this.xrCheckBox52.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox52.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox52.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox52.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox52.Name = "xrCheckBox52";
            this.xrCheckBox52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox53
            // 
            this.xrCheckBox53.EditOptions.Enabled = true;
            this.xrCheckBox53.EditOptions.GroupID = "Battery Condition";
            this.xrCheckBox53.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox53.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox53.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox53.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox53.Name = "xrCheckBox53";
            this.xrCheckBox53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox54
            // 
            this.xrCheckBox54.EditOptions.Enabled = true;
            this.xrCheckBox54.EditOptions.GroupID = "Battery Condition";
            this.xrCheckBox54.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox54.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox54.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox54.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox54.Name = "xrCheckBox54";
            this.xrCheckBox54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell76
            // 
            this.tableCell76.Multiline = true;
            this.tableCell76.Name = "tableCell76";
            this.tableCell76.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow39
            // 
            this.tableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell77,
            this.tableCell78});
            this.tableRow39.Name = "tableRow39";
            // 
            // tableCell77
            // 
            this.tableCell77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox55,
            this.xrCheckBox56,
            this.xrCheckBox57});
            this.tableCell77.Multiline = true;
            this.tableCell77.Name = "tableCell77";
            // 
            // xrCheckBox55
            // 
            this.xrCheckBox55.EditOptions.Enabled = true;
            this.xrCheckBox55.EditOptions.GroupID = "Cables & Connections";
            this.xrCheckBox55.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox55.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox55.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox55.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox55.Name = "xrCheckBox55";
            this.xrCheckBox55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox56
            // 
            this.xrCheckBox56.EditOptions.Enabled = true;
            this.xrCheckBox56.EditOptions.GroupID = "Cables & Connections";
            this.xrCheckBox56.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox56.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox56.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox56.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox56.Name = "xrCheckBox56";
            this.xrCheckBox56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox57
            // 
            this.xrCheckBox57.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox57.Checked = true;
            this.xrCheckBox57.EditOptions.Enabled = true;
            this.xrCheckBox57.EditOptions.GroupID = "Cables & Connections";
            this.xrCheckBox57.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox57.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox57.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox57.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox57.Name = "xrCheckBox57";
            this.xrCheckBox57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell78
            // 
            this.tableCell78.Multiline = true;
            this.tableCell78.Name = "tableCell78";
            this.tableCell78.StyleName = "GeneralTextStyleStyle";
            // 
            // label6
            // 
            this.label6.Multiline = true;
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.StyleName = "EditorKeyStyle";
            // 
            // table4
            // 
            this.table4.Name = "table4";
            this.table4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow24,
            this.tableRow25,
            this.tableRow26,
            this.tableRow27,
            this.tableRow28,
            this.tableRow29,
            this.tableRow30,
            this.tableRow31,
            this.tableRow32,
            this.tableRow33});
            // 
            // tableRow24
            // 
            this.tableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell47,
            this.tableCell48});
            this.tableRow24.Name = "tableRow24";
            // 
            // tableCell47
            // 
            this.tableCell47.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox19,
            this.xrCheckBox20,
            this.xrCheckBox21});
            this.tableCell47.Multiline = true;
            this.tableCell47.Name = "tableCell47";
            // 
            // xrCheckBox19
            // 
            this.xrCheckBox19.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox19.Checked = true;
            this.xrCheckBox19.EditOptions.Enabled = true;
            this.xrCheckBox19.EditOptions.GroupID = "Engine Oil";
            this.xrCheckBox19.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox19.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox19.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox19.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox19.Name = "xrCheckBox19";
            this.xrCheckBox19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox20
            // 
            this.xrCheckBox20.EditOptions.Enabled = true;
            this.xrCheckBox20.EditOptions.GroupID = "Engine Oil";
            this.xrCheckBox20.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox20.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox20.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox20.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox20.Name = "xrCheckBox20";
            this.xrCheckBox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox21
            // 
            this.xrCheckBox21.EditOptions.Enabled = true;
            this.xrCheckBox21.EditOptions.GroupID = "Engine Oil";
            this.xrCheckBox21.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox21.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox21.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox21.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox21.Name = "xrCheckBox21";
            this.xrCheckBox21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell48
            // 
            this.tableCell48.Multiline = true;
            this.tableCell48.Name = "tableCell48";
            this.tableCell48.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow25
            // 
            this.tableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell49,
            this.tableCell50});
            this.tableRow25.Name = "tableRow25";
            // 
            // tableCell49
            // 
            this.tableCell49.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox22,
            this.xrCheckBox23,
            this.xrCheckBox24});
            this.tableCell49.Multiline = true;
            this.tableCell49.Name = "tableCell49";
            // 
            // xrCheckBox22
            // 
            this.xrCheckBox22.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox22.Checked = true;
            this.xrCheckBox22.EditOptions.Enabled = true;
            this.xrCheckBox22.EditOptions.GroupID = "Brake Fluid";
            this.xrCheckBox22.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox22.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox22.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox22.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox22.Name = "xrCheckBox22";
            this.xrCheckBox22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox23
            // 
            this.xrCheckBox23.EditOptions.Enabled = true;
            this.xrCheckBox23.EditOptions.GroupID = "Brake Fluid";
            this.xrCheckBox23.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox23.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox23.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox23.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox23.Name = "xrCheckBox23";
            this.xrCheckBox23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox24
            // 
            this.xrCheckBox24.EditOptions.Enabled = true;
            this.xrCheckBox24.EditOptions.GroupID = "Brake Fluid";
            this.xrCheckBox24.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox24.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox24.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox24.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox24.Name = "xrCheckBox24";
            this.xrCheckBox24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell50
            // 
            this.tableCell50.Multiline = true;
            this.tableCell50.Name = "tableCell50";
            this.tableCell50.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow26
            // 
            this.tableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell51,
            this.tableCell52});
            this.tableRow26.Name = "tableRow26";
            // 
            // tableCell51
            // 
            this.tableCell51.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox25,
            this.xrCheckBox26,
            this.xrCheckBox27});
            this.tableCell51.Multiline = true;
            this.tableCell51.Name = "tableCell51";
            // 
            // xrCheckBox25
            // 
            this.xrCheckBox25.EditOptions.Enabled = true;
            this.xrCheckBox25.EditOptions.GroupID = "Power Steering Fluid";
            this.xrCheckBox25.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox25.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox25.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox25.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox25.Name = "xrCheckBox25";
            this.xrCheckBox25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox26
            // 
            this.xrCheckBox26.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox26.Checked = true;
            this.xrCheckBox26.EditOptions.Enabled = true;
            this.xrCheckBox26.EditOptions.GroupID = "Power Steering Fluid";
            this.xrCheckBox26.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox26.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox26.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox26.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox26.Name = "xrCheckBox26";
            this.xrCheckBox26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox27
            // 
            this.xrCheckBox27.EditOptions.Enabled = true;
            this.xrCheckBox27.EditOptions.GroupID = "Power Steering Fluid";
            this.xrCheckBox27.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox27.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox27.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox27.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox27.Name = "xrCheckBox27";
            this.xrCheckBox27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell52
            // 
            this.tableCell52.Multiline = true;
            this.tableCell52.Name = "tableCell52";
            this.tableCell52.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow27
            // 
            this.tableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell53,
            this.tableCell54});
            this.tableRow27.Name = "tableRow27";
            // 
            // tableCell53
            // 
            this.tableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox28,
            this.xrCheckBox29,
            this.xrCheckBox30});
            this.tableCell53.Multiline = true;
            this.tableCell53.Name = "tableCell53";
            // 
            // xrCheckBox28
            // 
            this.xrCheckBox28.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox28.Checked = true;
            this.xrCheckBox28.EditOptions.Enabled = true;
            this.xrCheckBox28.EditOptions.GroupID = "Washer Fluid";
            this.xrCheckBox28.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox28.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox28.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox28.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox28.Name = "xrCheckBox28";
            this.xrCheckBox28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox29
            // 
            this.xrCheckBox29.EditOptions.Enabled = true;
            this.xrCheckBox29.EditOptions.GroupID = "Washer Fluid";
            this.xrCheckBox29.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox29.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox29.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox29.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox29.Name = "xrCheckBox29";
            this.xrCheckBox29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox30
            // 
            this.xrCheckBox30.EditOptions.Enabled = true;
            this.xrCheckBox30.EditOptions.GroupID = "Washer Fluid";
            this.xrCheckBox30.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox30.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox30.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox30.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox30.Name = "xrCheckBox30";
            this.xrCheckBox30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell54
            // 
            this.tableCell54.Multiline = true;
            this.tableCell54.Name = "tableCell54";
            this.tableCell54.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow28
            // 
            this.tableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell55,
            this.tableCell56});
            this.tableRow28.Name = "tableRow28";
            // 
            // tableCell55
            // 
            this.tableCell55.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox31,
            this.xrCheckBox32,
            this.xrCheckBox33});
            this.tableCell55.Multiline = true;
            this.tableCell55.Name = "tableCell55";
            // 
            // xrCheckBox31
            // 
            this.xrCheckBox31.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox31.Checked = true;
            this.xrCheckBox31.EditOptions.Enabled = true;
            this.xrCheckBox31.EditOptions.GroupID = "Belts & Hoses";
            this.xrCheckBox31.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox31.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox31.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox31.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox31.Name = "xrCheckBox31";
            this.xrCheckBox31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox32
            // 
            this.xrCheckBox32.EditOptions.Enabled = true;
            this.xrCheckBox32.EditOptions.GroupID = "Belts & Hoses";
            this.xrCheckBox32.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox32.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox32.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox32.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox32.Name = "xrCheckBox32";
            this.xrCheckBox32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox33
            // 
            this.xrCheckBox33.EditOptions.Enabled = true;
            this.xrCheckBox33.EditOptions.GroupID = "Belts & Hoses";
            this.xrCheckBox33.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox33.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox33.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox33.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox33.Name = "xrCheckBox33";
            this.xrCheckBox33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell56
            // 
            this.tableCell56.Multiline = true;
            this.tableCell56.Name = "tableCell56";
            this.tableCell56.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow29
            // 
            this.tableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell57,
            this.tableCell58});
            this.tableRow29.Name = "tableRow29";
            // 
            // tableCell57
            // 
            this.tableCell57.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox34,
            this.xrCheckBox35,
            this.xrCheckBox36});
            this.tableCell57.Multiline = true;
            this.tableCell57.Name = "tableCell57";
            // 
            // xrCheckBox34
            // 
            this.xrCheckBox34.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox34.Checked = true;
            this.xrCheckBox34.EditOptions.Enabled = true;
            this.xrCheckBox34.EditOptions.GroupID = "Antifreeze / Coolant";
            this.xrCheckBox34.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox34.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox34.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox34.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox34.Name = "xrCheckBox34";
            this.xrCheckBox34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox35
            // 
            this.xrCheckBox35.EditOptions.Enabled = true;
            this.xrCheckBox35.EditOptions.GroupID = "Antifreeze / Coolant";
            this.xrCheckBox35.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox35.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox35.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox35.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox35.Name = "xrCheckBox35";
            this.xrCheckBox35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox36
            // 
            this.xrCheckBox36.EditOptions.Enabled = true;
            this.xrCheckBox36.EditOptions.GroupID = "Antifreeze / Coolant";
            this.xrCheckBox36.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox36.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox36.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox36.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox36.Name = "xrCheckBox36";
            this.xrCheckBox36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell58
            // 
            this.tableCell58.Multiline = true;
            this.tableCell58.Name = "tableCell58";
            this.tableCell58.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow30
            // 
            this.tableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell59,
            this.tableCell60});
            this.tableRow30.Name = "tableRow30";
            // 
            // tableCell59
            // 
            this.tableCell59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox37,
            this.xrCheckBox38,
            this.xrCheckBox39});
            this.tableCell59.Multiline = true;
            this.tableCell59.Name = "tableCell59";
            // 
            // xrCheckBox37
            // 
            this.xrCheckBox37.EditOptions.Enabled = true;
            this.xrCheckBox37.EditOptions.GroupID = "Air Filter";
            this.xrCheckBox37.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox37.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox37.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox37.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox37.Name = "xrCheckBox37";
            this.xrCheckBox37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox38
            // 
            this.xrCheckBox38.EditOptions.Enabled = true;
            this.xrCheckBox38.EditOptions.GroupID = "Air Filter";
            this.xrCheckBox38.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox38.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox38.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox38.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox38.Name = "xrCheckBox38";
            this.xrCheckBox38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox39
            // 
            this.xrCheckBox39.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox39.Checked = true;
            this.xrCheckBox39.EditOptions.Enabled = true;
            this.xrCheckBox39.EditOptions.GroupID = "Air Filter";
            this.xrCheckBox39.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox39.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox39.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox39.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox39.Name = "xrCheckBox39";
            this.xrCheckBox39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell60
            // 
            this.tableCell60.Multiline = true;
            this.tableCell60.Name = "tableCell60";
            this.tableCell60.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow31
            // 
            this.tableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell61,
            this.tableCell62});
            this.tableRow31.Name = "tableRow31";
            // 
            // tableCell61
            // 
            this.tableCell61.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox40,
            this.xrCheckBox41,
            this.xrCheckBox42});
            this.tableCell61.Multiline = true;
            this.tableCell61.Name = "tableCell61";
            // 
            // xrCheckBox40
            // 
            this.xrCheckBox40.EditOptions.Enabled = true;
            this.xrCheckBox40.EditOptions.GroupID = "Cabin Filter";
            this.xrCheckBox40.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox40.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox40.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox40.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox40.Name = "xrCheckBox40";
            this.xrCheckBox40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox41
            // 
            this.xrCheckBox41.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox41.Checked = true;
            this.xrCheckBox41.EditOptions.Enabled = true;
            this.xrCheckBox41.EditOptions.GroupID = "Cabin Filter";
            this.xrCheckBox41.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox41.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox41.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox41.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox41.Name = "xrCheckBox41";
            this.xrCheckBox41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox42
            // 
            this.xrCheckBox42.EditOptions.Enabled = true;
            this.xrCheckBox42.EditOptions.GroupID = "Cabin Filter";
            this.xrCheckBox42.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox42.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox42.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox42.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox42.Name = "xrCheckBox42";
            this.xrCheckBox42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell62
            // 
            this.tableCell62.Multiline = true;
            this.tableCell62.Name = "tableCell62";
            this.tableCell62.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow32
            // 
            this.tableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell63,
            this.tableCell64});
            this.tableRow32.Name = "tableRow32";
            // 
            // tableCell63
            // 
            this.tableCell63.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox43,
            this.xrCheckBox44,
            this.xrCheckBox45});
            this.tableCell63.Multiline = true;
            this.tableCell63.Name = "tableCell63";
            // 
            // xrCheckBox43
            // 
            this.xrCheckBox43.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox43.Checked = true;
            this.xrCheckBox43.EditOptions.Enabled = true;
            this.xrCheckBox43.EditOptions.GroupID = "Fuel Filter";
            this.xrCheckBox43.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox43.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox43.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox43.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox43.Name = "xrCheckBox43";
            this.xrCheckBox43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox44
            // 
            this.xrCheckBox44.EditOptions.Enabled = true;
            this.xrCheckBox44.EditOptions.GroupID = "Fuel Filter";
            this.xrCheckBox44.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox44.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox44.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox44.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox44.Name = "xrCheckBox44";
            this.xrCheckBox44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox45
            // 
            this.xrCheckBox45.EditOptions.Enabled = true;
            this.xrCheckBox45.EditOptions.GroupID = "Fuel Filter";
            this.xrCheckBox45.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox45.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox45.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox45.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox45.Name = "xrCheckBox45";
            this.xrCheckBox45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell64
            // 
            this.tableCell64.Multiline = true;
            this.tableCell64.Name = "tableCell64";
            this.tableCell64.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow33
            // 
            this.tableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell65,
            this.tableCell66});
            this.tableRow33.Name = "tableRow33";
            // 
            // tableCell65
            // 
            this.tableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox46,
            this.xrCheckBox47,
            this.xrCheckBox48});
            this.tableCell65.Multiline = true;
            this.tableCell65.Name = "tableCell65";
            // 
            // xrCheckBox46
            // 
            this.xrCheckBox46.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox46.Checked = true;
            this.xrCheckBox46.EditOptions.Enabled = true;
            this.xrCheckBox46.EditOptions.GroupID = "Spark Plugs / Wires";
            this.xrCheckBox46.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox46.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox46.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox46.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox46.Name = "xrCheckBox46";
            this.xrCheckBox46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox47
            // 
            this.xrCheckBox47.EditOptions.Enabled = true;
            this.xrCheckBox47.EditOptions.GroupID = "Spark Plugs / Wires";
            this.xrCheckBox47.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox47.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox47.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox47.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox47.Name = "xrCheckBox47";
            this.xrCheckBox47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox48
            // 
            this.xrCheckBox48.EditOptions.Enabled = true;
            this.xrCheckBox48.EditOptions.GroupID = "Spark Plugs / Wires";
            this.xrCheckBox48.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox48.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox48.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox48.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox48.Name = "xrCheckBox48";
            this.xrCheckBox48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell66
            // 
            this.tableCell66.Multiline = true;
            this.tableCell66.Name = "tableCell66";
            this.tableCell66.StyleName = "GeneralTextStyleStyle";
            // 
            // table3
            // 
            this.table3.Name = "table3";
            this.table3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow17,
            this.tableRow18,
            this.tableRow19,
            this.tableRow20,
            this.tableRow21,
            this.tableRow22,
            this.tableRow23});
            // 
            // tableRow17
            // 
            this.tableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell33,
            this.tableCell34});
            this.tableRow17.Name = "tableRow17";
            // 
            // tableCell33
            // 
            this.tableCell33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.checkBox3,
            this.checkBox2,
            this.checkBox1});
            this.tableCell33.Multiline = true;
            this.tableCell33.Name = "tableCell33";
            // 
            // checkBox3
            // 
            this.checkBox3.EditOptions.Enabled = true;
            this.checkBox3.EditOptions.GroupID = "Exterior Body";
            this.checkBox3.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox3.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.checkBox3.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.checkBox3.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // checkBox2
            // 
            this.checkBox2.EditOptions.Enabled = true;
            this.checkBox2.EditOptions.GroupID = "Exterior Body";
            this.checkBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox2.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.checkBox2.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.checkBox2.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // checkBox1
            // 
            this.checkBox1.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.checkBox1.Checked = true;
            this.checkBox1.EditOptions.Enabled = true;
            this.checkBox1.EditOptions.GroupID = "Exterior Body";
            this.checkBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox1.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.checkBox1.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.checkBox1.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell34
            // 
            this.tableCell34.Multiline = true;
            this.tableCell34.Name = "tableCell34";
            this.tableCell34.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow18
            // 
            this.tableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell35,
            this.tableCell36});
            this.tableRow18.Name = "tableRow18";
            // 
            // tableCell35
            // 
            this.tableCell35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox1,
            this.xrCheckBox2,
            this.xrCheckBox3});
            this.tableCell35.Multiline = true;
            this.tableCell35.Name = "tableCell35";
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.EditOptions.Enabled = true;
            this.xrCheckBox1.EditOptions.GroupID = "Windshield / Glass";
            this.xrCheckBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox1.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox1.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox2
            // 
            this.xrCheckBox2.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox2.Checked = true;
            this.xrCheckBox2.EditOptions.Enabled = true;
            this.xrCheckBox2.EditOptions.GroupID = "Windshield / Glass";
            this.xrCheckBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox2.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox2.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox2.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox2.Name = "xrCheckBox2";
            this.xrCheckBox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox3
            // 
            this.xrCheckBox3.EditOptions.Enabled = true;
            this.xrCheckBox3.EditOptions.GroupID = "Windshield / Glass";
            this.xrCheckBox3.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox3.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox3.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox3.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox3.Name = "xrCheckBox3";
            this.xrCheckBox3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell36
            // 
            this.tableCell36.Multiline = true;
            this.tableCell36.Name = "tableCell36";
            this.tableCell36.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow19
            // 
            this.tableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell37,
            this.tableCell38});
            this.tableRow19.Name = "tableRow19";
            // 
            // tableCell37
            // 
            this.tableCell37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox4,
            this.xrCheckBox5,
            this.xrCheckBox6});
            this.tableCell37.Multiline = true;
            this.tableCell37.Name = "tableCell37";
            // 
            // xrCheckBox4
            // 
            this.xrCheckBox4.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox4.Checked = true;
            this.xrCheckBox4.EditOptions.Enabled = true;
            this.xrCheckBox4.EditOptions.GroupID = "Wipers";
            this.xrCheckBox4.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox4.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox4.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox4.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox4.Name = "xrCheckBox4";
            this.xrCheckBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox5
            // 
            this.xrCheckBox5.EditOptions.Enabled = true;
            this.xrCheckBox5.EditOptions.GroupID = "Wipers";
            this.xrCheckBox5.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox5.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox5.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox5.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox5.Name = "xrCheckBox5";
            this.xrCheckBox5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox6
            // 
            this.xrCheckBox6.EditOptions.Enabled = true;
            this.xrCheckBox6.EditOptions.GroupID = "Wipers";
            this.xrCheckBox6.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox6.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox6.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox6.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox6.Name = "xrCheckBox6";
            this.xrCheckBox6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell38
            // 
            this.tableCell38.Multiline = true;
            this.tableCell38.Name = "tableCell38";
            this.tableCell38.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow20
            // 
            this.tableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell39,
            this.tableCell40});
            this.tableRow20.Name = "tableRow20";
            // 
            // tableCell39
            // 
            this.tableCell39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox7,
            this.xrCheckBox8,
            this.xrCheckBox9});
            this.tableCell39.Multiline = true;
            this.tableCell39.Name = "tableCell39";
            // 
            // xrCheckBox7
            // 
            this.xrCheckBox7.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox7.Checked = true;
            this.xrCheckBox7.EditOptions.Enabled = true;
            this.xrCheckBox7.EditOptions.GroupID = "Lights (Head, Brake, Turn)";
            this.xrCheckBox7.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox7.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox7.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox7.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox7.Name = "xrCheckBox7";
            this.xrCheckBox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox8
            // 
            this.xrCheckBox8.EditOptions.Enabled = true;
            this.xrCheckBox8.EditOptions.GroupID = "Lights (Head, Brake, Turn)";
            this.xrCheckBox8.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox8.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox8.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox8.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox8.Name = "xrCheckBox8";
            this.xrCheckBox8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox9
            // 
            this.xrCheckBox9.EditOptions.Enabled = true;
            this.xrCheckBox9.EditOptions.GroupID = "Lights (Head, Brake, Turn)";
            this.xrCheckBox9.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox9.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox9.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox9.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox9.Name = "xrCheckBox9";
            this.xrCheckBox9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell40
            // 
            this.tableCell40.Multiline = true;
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow21
            // 
            this.tableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell41,
            this.tableCell42});
            this.tableRow21.Name = "tableRow21";
            // 
            // tableCell41
            // 
            this.tableCell41.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox10,
            this.xrCheckBox11,
            this.xrCheckBox12});
            this.tableCell41.Multiline = true;
            this.tableCell41.Name = "tableCell41";
            // 
            // xrCheckBox10
            // 
            this.xrCheckBox10.EditOptions.Enabled = true;
            this.xrCheckBox10.EditOptions.GroupID = "Interior Lights";
            this.xrCheckBox10.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox10.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox10.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox10.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox10.Name = "xrCheckBox10";
            this.xrCheckBox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox11
            // 
            this.xrCheckBox11.EditOptions.Enabled = true;
            this.xrCheckBox11.EditOptions.GroupID = "Interior Lights";
            this.xrCheckBox11.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox11.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox11.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox11.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox11.Name = "xrCheckBox11";
            this.xrCheckBox11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox12
            // 
            this.xrCheckBox12.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox12.Checked = true;
            this.xrCheckBox12.EditOptions.Enabled = true;
            this.xrCheckBox12.EditOptions.GroupID = "Interior Lights";
            this.xrCheckBox12.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox12.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox12.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox12.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox12.Name = "xrCheckBox12";
            this.xrCheckBox12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell42
            // 
            this.tableCell42.Multiline = true;
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow22
            // 
            this.tableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell43,
            this.tableCell44});
            this.tableRow22.Name = "tableRow22";
            // 
            // tableCell43
            // 
            this.tableCell43.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox13,
            this.xrCheckBox14,
            this.xrCheckBox15});
            this.tableCell43.Multiline = true;
            this.tableCell43.Name = "tableCell43";
            // 
            // xrCheckBox13
            // 
            this.xrCheckBox13.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox13.Checked = true;
            this.xrCheckBox13.EditOptions.Enabled = true;
            this.xrCheckBox13.EditOptions.GroupID = "AC Operation";
            this.xrCheckBox13.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox13.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox13.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox13.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox13.Name = "xrCheckBox13";
            this.xrCheckBox13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox14
            // 
            this.xrCheckBox14.EditOptions.Enabled = true;
            this.xrCheckBox14.EditOptions.GroupID = "AC Operation";
            this.xrCheckBox14.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox14.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox14.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox14.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox14.Name = "xrCheckBox14";
            this.xrCheckBox14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox15
            // 
            this.xrCheckBox15.EditOptions.Enabled = true;
            this.xrCheckBox15.EditOptions.GroupID = "AC Operation";
            this.xrCheckBox15.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox15.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox15.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox15.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox15.Name = "xrCheckBox15";
            this.xrCheckBox15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell44
            // 
            this.tableCell44.Multiline = true;
            this.tableCell44.Name = "tableCell44";
            this.tableCell44.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow23
            // 
            this.tableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell45,
            this.tableCell46});
            this.tableRow23.Name = "tableRow23";
            // 
            // tableCell45
            // 
            this.tableCell45.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox16,
            this.xrCheckBox17,
            this.xrCheckBox18});
            this.tableCell45.Multiline = true;
            this.tableCell45.Name = "tableCell45";
            // 
            // xrCheckBox16
            // 
            this.xrCheckBox16.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox16.Checked = true;
            this.xrCheckBox16.EditOptions.Enabled = true;
            this.xrCheckBox16.EditOptions.GroupID = "Heating";
            this.xrCheckBox16.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox16.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox16.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox16.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox16.Name = "xrCheckBox16";
            this.xrCheckBox16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox17
            // 
            this.xrCheckBox17.EditOptions.Enabled = true;
            this.xrCheckBox17.EditOptions.GroupID = "Heating";
            this.xrCheckBox17.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox17.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox17.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox17.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox17.Name = "xrCheckBox17";
            this.xrCheckBox17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox18
            // 
            this.xrCheckBox18.EditOptions.Enabled = true;
            this.xrCheckBox18.EditOptions.GroupID = "Heating";
            this.xrCheckBox18.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox18.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox18.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox18.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox18.Name = "xrCheckBox18";
            this.xrCheckBox18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell46
            // 
            this.tableCell46.Multiline = true;
            this.tableCell46.Name = "tableCell46";
            this.tableCell46.StyleName = "GeneralTextStyleStyle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.EditOptions.EditorName = "DamageDiagram";
            this.pictureBox4.EditOptions.Enabled = true;
            this.pictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.pictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pictureBox4.ImageSource"));
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.UseImageResolution = false;
            // 
            // label4
            // 
            this.label4.Multiline = true;
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label4.StyleName = "EditorKeyStyle";
            // 
            // label3
            // 
            this.label3.Multiline = true;
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.StyleName = "SectionTitleStyle";
            // 
            // label2
            // 
            this.label2.Multiline = true;
            this.label2.Name = "label2";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label2.StyleName = "SectionTitleStyle";
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2,
            this.tableRow3,
            this.tableRow4});
            this.table2.StyleName = "GeneralTextStyleStyle";
            this.table2.StylePriority.UseBackColor = false;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 20, 0, 100F);
            this.tableRow2.StylePriority.UsePadding = false;
            // 
            // tableCell3
            // 
            this.tableCell3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox1});
            this.tableCell3.Multiline = true;
            this.tableCell3.Name = "tableCell3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.pictureBox1.Name = "pictureBox1";
            // 
            // tableCell4
            // 
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5,
            this.tableCell6});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.tableRow3.StylePriority.UsePadding = false;
            // 
            // tableCell5
            // 
            this.tableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox2});
            this.tableCell5.Multiline = true;
            this.tableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 6, 6, 100F);
            this.tableCell5.Name = "tableCell5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.pictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.pictureBox2.Name = "pictureBox2";
            // 
            // tableCell6
            // 
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 20, 100F);
            this.tableRow4.StylePriority.UsePadding = false;
            // 
            // tableCell7
            // 
            this.tableCell7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox3});
            this.tableCell7.Multiline = true;
            this.tableCell7.Name = "tableCell7";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.pictureBox3.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.pictureBox3.Name = "pictureBox3";
            // 
            // tableCell8
            // 
            this.tableCell8.Multiline = true;
            this.tableCell8.Name = "tableCell8";
            // 
            // table1
            // 
            this.table1.Name = "table1";
            this.table1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1,
            this.tableRow5,
            this.tableRow6,
            this.tableRow7,
            this.tableRow8,
            this.tableRow9,
            this.tableRow10,
            this.tableRow11,
            this.tableRow12,
            this.tableRow13,
            this.tableRow14,
            this.tableRow15,
            this.tableRow16});
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Name = "tableRow1";
            // 
            // tableCell1
            // 
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "EditorKeyStyle";
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.StylePriority.UseTextAlignment = false;
            // 
            // tableCell2
            // 
            this.tableCell2.EditOptions.Enabled = true;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "EditorValueStyle";
            this.tableCell2.StylePriority.UseBorderColor = false;
            this.tableCell2.StylePriority.UseBorderWidth = false;
            this.tableCell2.StylePriority.UseFont = false;
            this.tableCell2.StylePriority.UsePadding = false;
            this.tableCell2.StylePriority.UseTextAlignment = false;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10});
            this.tableRow5.Name = "tableRow5";
            // 
            // tableCell9
            // 
            this.tableCell9.Multiline = true;
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StylePriority.UseFont = false;
            this.tableCell9.StylePriority.UseTextAlignment = false;
            // 
            // tableCell10
            // 
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StylePriority.UseBorderColor = false;
            this.tableCell10.StylePriority.UseBorderWidth = false;
            this.tableCell10.StylePriority.UseFont = false;
            this.tableCell10.StylePriority.UsePadding = false;
            this.tableCell10.StylePriority.UseTextAlignment = false;
            // 
            // tableRow6
            // 
            this.tableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell11,
            this.tableCell12});
            this.tableRow6.Name = "tableRow6";
            // 
            // tableCell11
            // 
            this.tableCell11.Multiline = true;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "EditorKeyStyle";
            this.tableCell11.StylePriority.UseFont = false;
            this.tableCell11.StylePriority.UseTextAlignment = false;
            // 
            // tableCell12
            // 
            this.tableCell12.EditOptions.Enabled = true;
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "EditorValueStyle";
            this.tableCell12.StylePriority.UseBorderColor = false;
            this.tableCell12.StylePriority.UseBorderWidth = false;
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.StylePriority.UseTextAlignment = false;
            // 
            // tableRow7
            // 
            this.tableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell13,
            this.tableCell14});
            this.tableRow7.Name = "tableRow7";
            // 
            // tableCell13
            // 
            this.tableCell13.Multiline = true;
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StylePriority.UseFont = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            // 
            // tableCell14
            // 
            this.tableCell14.Multiline = true;
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StylePriority.UseBorderColor = false;
            this.tableCell14.StylePriority.UseBorderWidth = false;
            this.tableCell14.StylePriority.UseFont = false;
            this.tableCell14.StylePriority.UsePadding = false;
            this.tableCell14.StylePriority.UseTextAlignment = false;
            // 
            // tableRow8
            // 
            this.tableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15,
            this.tableCell16});
            this.tableRow8.Name = "tableRow8";
            // 
            // tableCell15
            // 
            this.tableCell15.Multiline = true;
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "EditorKeyStyle";
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.StylePriority.UseTextAlignment = false;
            // 
            // tableCell16
            // 
            this.tableCell16.EditOptions.Enabled = true;
            this.tableCell16.Multiline = true;
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "EditorValueStyle";
            this.tableCell16.StylePriority.UseBorderColor = false;
            this.tableCell16.StylePriority.UseBorderWidth = false;
            this.tableCell16.StylePriority.UseFont = false;
            this.tableCell16.StylePriority.UsePadding = false;
            this.tableCell16.StylePriority.UseTextAlignment = false;
            // 
            // tableRow9
            // 
            this.tableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell17,
            this.tableCell18});
            this.tableRow9.Name = "tableRow9";
            // 
            // tableCell17
            // 
            this.tableCell17.Multiline = true;
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StylePriority.UseFont = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            // 
            // tableCell18
            // 
            this.tableCell18.Multiline = true;
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.StylePriority.UseBorderColor = false;
            this.tableCell18.StylePriority.UseBorderWidth = false;
            this.tableCell18.StylePriority.UseFont = false;
            this.tableCell18.StylePriority.UsePadding = false;
            this.tableCell18.StylePriority.UseTextAlignment = false;
            // 
            // tableRow10
            // 
            this.tableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell19,
            this.tableCell20});
            this.tableRow10.Name = "tableRow10";
            // 
            // tableCell19
            // 
            this.tableCell19.Multiline = true;
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.StyleName = "EditorKeyStyle";
            this.tableCell19.StylePriority.UseFont = false;
            this.tableCell19.StylePriority.UseTextAlignment = false;
            // 
            // tableCell20
            // 
            this.tableCell20.EditOptions.Enabled = true;
            this.tableCell20.Multiline = true;
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.StyleName = "EditorValueStyle";
            this.tableCell20.StylePriority.UseBorderColor = false;
            this.tableCell20.StylePriority.UseBorderWidth = false;
            this.tableCell20.StylePriority.UseFont = false;
            this.tableCell20.StylePriority.UsePadding = false;
            this.tableCell20.StylePriority.UseTextAlignment = false;
            // 
            // tableRow11
            // 
            this.tableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell21,
            this.tableCell22});
            this.tableRow11.Name = "tableRow11";
            // 
            // tableCell21
            // 
            this.tableCell21.Multiline = true;
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.StylePriority.UseFont = false;
            this.tableCell21.StylePriority.UseTextAlignment = false;
            // 
            // tableCell22
            // 
            this.tableCell22.Multiline = true;
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.StylePriority.UseBorderColor = false;
            this.tableCell22.StylePriority.UseBorderWidth = false;
            this.tableCell22.StylePriority.UseFont = false;
            this.tableCell22.StylePriority.UsePadding = false;
            this.tableCell22.StylePriority.UseTextAlignment = false;
            // 
            // tableRow12
            // 
            this.tableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell23,
            this.tableCell24});
            this.tableRow12.Name = "tableRow12";
            // 
            // tableCell23
            // 
            this.tableCell23.Multiline = true;
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.StyleName = "EditorKeyStyle";
            this.tableCell23.StylePriority.UseFont = false;
            this.tableCell23.StylePriority.UseTextAlignment = false;
            // 
            // tableCell24
            // 
            this.tableCell24.EditOptions.Enabled = true;
            this.tableCell24.Multiline = true;
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "EditorValueStyle";
            this.tableCell24.StylePriority.UseBorderColor = false;
            this.tableCell24.StylePriority.UseBorderWidth = false;
            this.tableCell24.StylePriority.UseFont = false;
            this.tableCell24.StylePriority.UsePadding = false;
            this.tableCell24.StylePriority.UseTextAlignment = false;
            // 
            // tableRow13
            // 
            this.tableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell25,
            this.tableCell26});
            this.tableRow13.Name = "tableRow13";
            // 
            // tableCell25
            // 
            this.tableCell25.Multiline = true;
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.StylePriority.UseFont = false;
            this.tableCell25.StylePriority.UseTextAlignment = false;
            // 
            // tableCell26
            // 
            this.tableCell26.Multiline = true;
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.StylePriority.UseBorderColor = false;
            this.tableCell26.StylePriority.UseBorderWidth = false;
            this.tableCell26.StylePriority.UseFont = false;
            this.tableCell26.StylePriority.UsePadding = false;
            this.tableCell26.StylePriority.UseTextAlignment = false;
            // 
            // tableRow14
            // 
            this.tableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell27,
            this.tableCell28});
            this.tableRow14.Name = "tableRow14";
            // 
            // tableCell27
            // 
            this.tableCell27.Multiline = true;
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.StyleName = "EditorKeyStyle";
            this.tableCell27.StylePriority.UseFont = false;
            this.tableCell27.StylePriority.UseTextAlignment = false;
            // 
            // tableCell28
            // 
            this.tableCell28.EditOptions.Enabled = true;
            this.tableCell28.Multiline = true;
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.StyleName = "EditorValueStyle";
            this.tableCell28.StylePriority.UseBorderColor = false;
            this.tableCell28.StylePriority.UseBorderWidth = false;
            this.tableCell28.StylePriority.UseFont = false;
            this.tableCell28.StylePriority.UsePadding = false;
            this.tableCell28.StylePriority.UseTextAlignment = false;
            // 
            // tableRow15
            // 
            this.tableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell29,
            this.tableCell30});
            this.tableRow15.Name = "tableRow15";
            // 
            // tableCell29
            // 
            this.tableCell29.Multiline = true;
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.StylePriority.UseFont = false;
            this.tableCell29.StylePriority.UseTextAlignment = false;
            // 
            // tableCell30
            // 
            this.tableCell30.Multiline = true;
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.StylePriority.UseBorderColor = false;
            this.tableCell30.StylePriority.UseBorderWidth = false;
            this.tableCell30.StylePriority.UseFont = false;
            this.tableCell30.StylePriority.UsePadding = false;
            this.tableCell30.StylePriority.UseTextAlignment = false;
            // 
            // tableRow16
            // 
            this.tableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell31,
            this.tableCell32});
            this.tableRow16.Name = "tableRow16";
            // 
            // tableCell31
            // 
            this.tableCell31.Multiline = true;
            this.tableCell31.Name = "tableCell31";
            this.tableCell31.StyleName = "EditorKeyStyle";
            this.tableCell31.StylePriority.UseFont = false;
            this.tableCell31.StylePriority.UseTextAlignment = false;
            // 
            // tableCell32
            // 
            this.tableCell32.EditOptions.Enabled = true;
            this.tableCell32.Multiline = true;
            this.tableCell32.Name = "tableCell32";
            this.tableCell32.StyleName = "EditorValueStyle";
            this.tableCell32.StylePriority.UseBorderColor = false;
            this.tableCell32.StylePriority.UseBorderWidth = false;
            this.tableCell32.StylePriority.UseFont = false;
            this.tableCell32.StylePriority.UsePadding = false;
            this.tableCell32.StylePriority.UseTextAlignment = false;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.labelCurrentDate,
            this.label15,
            this.label14,
            this.label13,
            this.label12,
            this.label11,
            this.label10,
            this.table10,
            this.table9,
            this.label9,
            this.table8,
            this.label8,
            this.label5,
            this.table5,
            this.label7,
            this.table7});
            this.SubBand1.KeepTogether = true;
            this.SubBand1.Name = "SubBand1";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Today()")});
            this.labelCurrentDate.Multiline = true;
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 2, 2, 100F);
            this.labelCurrentDate.StyleName = "EditorValueStyle";
            this.labelCurrentDate.StylePriority.UsePadding = false;
            this.labelCurrentDate.StylePriority.UseTextAlignment = false;
            // 
            // label15
            // 
            this.label15.Multiline = true;
            this.label15.Name = "label15";
            this.label15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label15.StyleName = "EditorKeyStyle";
            // 
            // label14
            // 
            this.label14.EditOptions.Enabled = true;
            this.label14.Name = "label14";
            this.label14.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 2, 2, 100F);
            this.label14.StyleName = "EditorValueStyle";
            this.label14.StylePriority.UsePadding = false;
            this.label14.StylePriority.UseTextAlignment = false;
            // 
            // label13
            // 
            this.label13.Multiline = true;
            this.label13.Name = "label13";
            this.label13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label13.StyleName = "EditorKeyStyle";
            // 
            // label12
            // 
            this.label12.EditOptions.Enabled = true;
            this.label12.Multiline = true;
            this.label12.Name = "label12";
            this.label12.StyleName = "EditorValueStyle";
            this.label12.StylePriority.UsePadding = false;
            this.label12.StylePriority.UseTextAlignment = false;
            this.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label11
            // 
            this.label11.Multiline = true;
            this.label11.Name = "label11";
            this.label11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label11.StyleName = "EditorKeyStyle";
            // 
            // label10
            // 
            this.label10.Multiline = true;
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label10.StyleName = "EditorKeyStyle";
            // 
            // table10
            // 
            this.table10.Name = "table10";
            this.table10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow56,
            this.tableRow57});
            // 
            // tableRow56
            // 
            this.tableRow56.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell129,
            this.tableCell130,
            this.tableCell131,
            this.tableCell132});
            this.tableRow56.Name = "tableRow56";
            // 
            // tableCell129
            // 
            this.tableCell129.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.checkBox24});
            this.tableCell129.Multiline = true;
            this.tableCell129.Name = "tableCell129";
            // 
            // checkBox24
            // 
            this.checkBox24.EditOptions.Enabled = true;
            this.checkBox24.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox24.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"));
            this.checkBox24.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"));
            this.checkBox24.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell130
            // 
            this.tableCell130.Multiline = true;
            this.tableCell130.Name = "tableCell130";
            this.tableCell130.StyleName = "GeneralTextStyleStyle";
            // 
            // tableCell131
            // 
            this.tableCell131.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox101});
            this.tableCell131.Multiline = true;
            this.tableCell131.Name = "tableCell131";
            // 
            // xrCheckBox101
            // 
            this.xrCheckBox101.EditOptions.Enabled = true;
            this.xrCheckBox101.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox101.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"));
            this.xrCheckBox101.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"));
            this.xrCheckBox101.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox101.Name = "xrCheckBox101";
            this.xrCheckBox101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell132
            // 
            this.tableCell132.Multiline = true;
            this.tableCell132.Name = "tableCell132";
            this.tableCell132.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow57
            // 
            this.tableRow57.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell133,
            this.tableCell134,
            this.tableCell135,
            this.tableCell136});
            this.tableRow57.Name = "tableRow57";
            // 
            // tableCell133
            // 
            this.tableCell133.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox100});
            this.tableCell133.Multiline = true;
            this.tableCell133.Name = "tableCell133";
            // 
            // xrCheckBox100
            // 
            this.xrCheckBox100.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox100.Checked = true;
            this.xrCheckBox100.EditOptions.Enabled = true;
            this.xrCheckBox100.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox100.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"));
            this.xrCheckBox100.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"));
            this.xrCheckBox100.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox100.Name = "xrCheckBox100";
            this.xrCheckBox100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell134
            // 
            this.tableCell134.Multiline = true;
            this.tableCell134.Name = "tableCell134";
            this.tableCell134.StyleName = "GeneralTextStyleStyle";
            // 
            // tableCell135
            // 
            this.tableCell135.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox102});
            this.tableCell135.Multiline = true;
            this.tableCell135.Name = "tableCell135";
            // 
            // xrCheckBox102
            // 
            this.xrCheckBox102.EditOptions.Enabled = true;
            this.xrCheckBox102.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox102.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_On"));
            this.xrCheckBox102.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Off"));
            this.xrCheckBox102.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox102.Name = "xrCheckBox102";
            this.xrCheckBox102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell136
            // 
            this.tableCell136.Multiline = true;
            this.tableCell136.Name = "tableCell136";
            this.tableCell136.StyleName = "GeneralTextStyleStyle";
            // 
            // table9
            // 
            this.table9.Name = "table9";
            this.table9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow54,
            this.tableRow55});
            // 
            // tableRow54
            // 
            this.tableRow54.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell121,
            this.tableCell122,
            this.tableCell125,
            this.tableCell127});
            this.tableRow54.Name = "tableRow54";
            // 
            // tableCell121
            // 
            this.tableCell121.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox79,
            this.xrCheckBox80,
            this.xrCheckBox81});
            this.tableCell121.Multiline = true;
            this.tableCell121.Name = "tableCell121";
            // 
            // xrCheckBox79
            // 
            this.xrCheckBox79.EditOptions.Enabled = true;
            this.xrCheckBox79.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LF";
            this.xrCheckBox79.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox79.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox79.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox79.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox79.Name = "xrCheckBox79";
            this.xrCheckBox79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox80
            // 
            this.xrCheckBox80.EditOptions.Enabled = true;
            this.xrCheckBox80.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LF";
            this.xrCheckBox80.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox80.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox80.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox80.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox80.Name = "xrCheckBox80";
            this.xrCheckBox80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox81
            // 
            this.xrCheckBox81.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox81.Checked = true;
            this.xrCheckBox81.EditOptions.Enabled = true;
            this.xrCheckBox81.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LF";
            this.xrCheckBox81.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox81.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox81.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox81.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox81.Name = "xrCheckBox81";
            this.xrCheckBox81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell122
            // 
            this.tableCell122.Multiline = true;
            this.tableCell122.Name = "tableCell122";
            this.tableCell122.StyleName = "GeneralTextStyleStyle";
            // 
            // tableCell125
            // 
            this.tableCell125.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox85,
            this.xrCheckBox86,
            this.xrCheckBox87});
            this.tableCell125.Multiline = true;
            this.tableCell125.Name = "tableCell125";
            // 
            // xrCheckBox85
            // 
            this.xrCheckBox85.EditOptions.Enabled = true;
            this.xrCheckBox85.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LR";
            this.xrCheckBox85.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox85.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox85.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox85.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox85.Name = "xrCheckBox85";
            this.xrCheckBox85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox86
            // 
            this.xrCheckBox86.EditOptions.Enabled = true;
            this.xrCheckBox86.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LR";
            this.xrCheckBox86.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox86.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox86.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox86.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox86.Name = "xrCheckBox86";
            this.xrCheckBox86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox87
            // 
            this.xrCheckBox87.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox87.Checked = true;
            this.xrCheckBox87.EditOptions.Enabled = true;
            this.xrCheckBox87.EditOptions.GroupID = "WEAR PATTERN / DAMAGE LR";
            this.xrCheckBox87.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox87.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox87.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox87.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox87.Name = "xrCheckBox87";
            this.xrCheckBox87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell127
            // 
            this.tableCell127.Multiline = true;
            this.tableCell127.Name = "tableCell127";
            this.tableCell127.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow55
            // 
            this.tableRow55.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell123,
            this.tableCell124,
            this.tableCell126,
            this.tableCell128});
            this.tableRow55.Name = "tableRow55";
            // 
            // tableCell123
            // 
            this.tableCell123.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox82,
            this.xrCheckBox83,
            this.xrCheckBox84});
            this.tableCell123.Multiline = true;
            this.tableCell123.Name = "tableCell123";
            // 
            // xrCheckBox82
            // 
            this.xrCheckBox82.EditOptions.Enabled = true;
            this.xrCheckBox82.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RF";
            this.xrCheckBox82.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox82.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox82.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox82.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox82.Name = "xrCheckBox82";
            this.xrCheckBox82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox83
            // 
            this.xrCheckBox83.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox83.Checked = true;
            this.xrCheckBox83.EditOptions.Enabled = true;
            this.xrCheckBox83.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RF";
            this.xrCheckBox83.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox83.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox83.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox83.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox83.Name = "xrCheckBox83";
            this.xrCheckBox83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox84
            // 
            this.xrCheckBox84.EditOptions.Enabled = true;
            this.xrCheckBox84.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RF";
            this.xrCheckBox84.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox84.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox84.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox84.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox84.Name = "xrCheckBox84";
            this.xrCheckBox84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell124
            // 
            this.tableCell124.Multiline = true;
            this.tableCell124.Name = "tableCell124";
            this.tableCell124.StyleName = "GeneralTextStyleStyle";
            // 
            // tableCell126
            // 
            this.tableCell126.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox88,
            this.xrCheckBox89,
            this.xrCheckBox90});
            this.tableCell126.Multiline = true;
            this.tableCell126.Name = "tableCell126";
            // 
            // xrCheckBox88
            // 
            this.xrCheckBox88.EditOptions.Enabled = true;
            this.xrCheckBox88.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RR";
            this.xrCheckBox88.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox88.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox88.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox88.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox88.Name = "xrCheckBox88";
            this.xrCheckBox88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox89
            // 
            this.xrCheckBox89.EditOptions.Enabled = true;
            this.xrCheckBox89.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RR";
            this.xrCheckBox89.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox89.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox89.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox89.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox89.Name = "xrCheckBox89";
            this.xrCheckBox89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox90
            // 
            this.xrCheckBox90.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox90.Checked = true;
            this.xrCheckBox90.EditOptions.Enabled = true;
            this.xrCheckBox90.EditOptions.GroupID = "WEAR PATTERN / DAMAGE RR";
            this.xrCheckBox90.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox90.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox90.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox90.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox90.Name = "xrCheckBox90";
            this.xrCheckBox90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell128
            // 
            this.tableCell128.Multiline = true;
            this.tableCell128.Name = "tableCell128";
            this.tableCell128.StyleName = "GeneralTextStyleStyle";
            // 
            // label9
            // 
            this.label9.Multiline = true;
            this.label9.Name = "label9";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label9.StyleName = "EditorKeyStyle";
            // 
            // table8
            // 
            this.table8.Name = "table8";
            this.table8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow45,
            this.tableRow46,
            this.tableRow49,
            this.tableRow50,
            this.tableRow51,
            this.tableRow52,
            this.tableRow53});
            // 
            // tableRow45
            // 
            this.tableRow45.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell107,
            this.tableCell108});
            this.tableRow45.Name = "tableRow45";
            // 
            // tableCell107
            // 
            this.tableCell107.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox58,
            this.xrCheckBox59,
            this.xrCheckBox60});
            this.tableCell107.Multiline = true;
            this.tableCell107.Name = "tableCell107";
            // 
            // xrCheckBox58
            // 
            this.xrCheckBox58.EditOptions.Enabled = true;
            this.xrCheckBox58.EditOptions.GroupID = "Brakes (Pads / Shoes)";
            this.xrCheckBox58.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox58.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox58.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox58.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox58.Name = "xrCheckBox58";
            this.xrCheckBox58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox59
            // 
            this.xrCheckBox59.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox59.Checked = true;
            this.xrCheckBox59.EditOptions.Enabled = true;
            this.xrCheckBox59.EditOptions.GroupID = "Brakes (Pads / Shoes)";
            this.xrCheckBox59.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox59.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox59.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox59.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox59.Name = "xrCheckBox59";
            this.xrCheckBox59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox60
            // 
            this.xrCheckBox60.EditOptions.Enabled = true;
            this.xrCheckBox60.EditOptions.GroupID = "Brakes (Pads / Shoes)";
            this.xrCheckBox60.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox60.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox60.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox60.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox60.Name = "xrCheckBox60";
            this.xrCheckBox60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell108
            // 
            this.tableCell108.Multiline = true;
            this.tableCell108.Name = "tableCell108";
            this.tableCell108.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow46
            // 
            this.tableRow46.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell109,
            this.tableCell110});
            this.tableRow46.Name = "tableRow46";
            // 
            // tableCell109
            // 
            this.tableCell109.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox61,
            this.xrCheckBox62,
            this.xrCheckBox63});
            this.tableCell109.Multiline = true;
            this.tableCell109.Name = "tableCell109";
            // 
            // xrCheckBox61
            // 
            this.xrCheckBox61.EditOptions.Enabled = true;
            this.xrCheckBox61.EditOptions.GroupID = "Brake Lines / Hoses";
            this.xrCheckBox61.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox61.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox61.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox61.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox61.Name = "xrCheckBox61";
            this.xrCheckBox61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox62
            // 
            this.xrCheckBox62.EditOptions.Enabled = true;
            this.xrCheckBox62.EditOptions.GroupID = "Brake Lines / Hoses";
            this.xrCheckBox62.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox62.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox62.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox62.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox62.Name = "xrCheckBox62";
            this.xrCheckBox62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox63
            // 
            this.xrCheckBox63.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox63.Checked = true;
            this.xrCheckBox63.EditOptions.Enabled = true;
            this.xrCheckBox63.EditOptions.GroupID = "Brake Lines / Hoses";
            this.xrCheckBox63.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox63.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox63.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox63.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox63.Name = "xrCheckBox63";
            this.xrCheckBox63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell110
            // 
            this.tableCell110.Multiline = true;
            this.tableCell110.Name = "tableCell110";
            this.tableCell110.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow49
            // 
            this.tableRow49.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell111,
            this.tableCell112});
            this.tableRow49.Name = "tableRow49";
            // 
            // tableCell111
            // 
            this.tableCell111.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox64,
            this.xrCheckBox65,
            this.xrCheckBox66});
            this.tableCell111.Multiline = true;
            this.tableCell111.Name = "tableCell111";
            // 
            // xrCheckBox64
            // 
            this.xrCheckBox64.EditOptions.Enabled = true;
            this.xrCheckBox64.EditOptions.GroupID = "Steering System";
            this.xrCheckBox64.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox64.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox64.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox64.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox64.Name = "xrCheckBox64";
            this.xrCheckBox64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox65
            // 
            this.xrCheckBox65.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox65.Checked = true;
            this.xrCheckBox65.EditOptions.Enabled = true;
            this.xrCheckBox65.EditOptions.GroupID = "Steering System";
            this.xrCheckBox65.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox65.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox65.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox65.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox65.Name = "xrCheckBox65";
            this.xrCheckBox65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox66
            // 
            this.xrCheckBox66.EditOptions.Enabled = true;
            this.xrCheckBox66.EditOptions.GroupID = "Steering System";
            this.xrCheckBox66.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox66.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox66.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox66.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox66.Name = "xrCheckBox66";
            this.xrCheckBox66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell112
            // 
            this.tableCell112.Multiline = true;
            this.tableCell112.Name = "tableCell112";
            this.tableCell112.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow50
            // 
            this.tableRow50.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell113,
            this.tableCell114});
            this.tableRow50.Name = "tableRow50";
            // 
            // tableCell113
            // 
            this.tableCell113.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox67,
            this.xrCheckBox68,
            this.xrCheckBox69});
            this.tableCell113.Multiline = true;
            this.tableCell113.Name = "tableCell113";
            // 
            // xrCheckBox67
            // 
            this.xrCheckBox67.EditOptions.Enabled = true;
            this.xrCheckBox67.EditOptions.GroupID = "Shocks & Struts";
            this.xrCheckBox67.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox67.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox67.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox67.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox67.Name = "xrCheckBox67";
            this.xrCheckBox67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox68
            // 
            this.xrCheckBox68.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox68.Checked = true;
            this.xrCheckBox68.EditOptions.Enabled = true;
            this.xrCheckBox68.EditOptions.GroupID = "Shocks & Struts";
            this.xrCheckBox68.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox68.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox68.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox68.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox68.Name = "xrCheckBox68";
            this.xrCheckBox68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox69
            // 
            this.xrCheckBox69.EditOptions.Enabled = true;
            this.xrCheckBox69.EditOptions.GroupID = "Shocks & Struts";
            this.xrCheckBox69.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox69.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox69.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox69.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox69.Name = "xrCheckBox69";
            this.xrCheckBox69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell114
            // 
            this.tableCell114.Multiline = true;
            this.tableCell114.Name = "tableCell114";
            this.tableCell114.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow51
            // 
            this.tableRow51.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell115,
            this.tableCell116});
            this.tableRow51.Name = "tableRow51";
            // 
            // tableCell115
            // 
            this.tableCell115.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox70,
            this.xrCheckBox71,
            this.xrCheckBox72});
            this.tableCell115.Multiline = true;
            this.tableCell115.Name = "tableCell115";
            // 
            // xrCheckBox70
            // 
            this.xrCheckBox70.EditOptions.Enabled = true;
            this.xrCheckBox70.EditOptions.GroupID = "Driveline (Axles / CV Shaft)";
            this.xrCheckBox70.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox70.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox70.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox70.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox70.Name = "xrCheckBox70";
            this.xrCheckBox70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox71
            // 
            this.xrCheckBox71.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox71.Checked = true;
            this.xrCheckBox71.EditOptions.Enabled = true;
            this.xrCheckBox71.EditOptions.GroupID = "Driveline (Axles / CV Shaft)";
            this.xrCheckBox71.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox71.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox71.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox71.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox71.Name = "xrCheckBox71";
            this.xrCheckBox71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox72
            // 
            this.xrCheckBox72.EditOptions.Enabled = true;
            this.xrCheckBox72.EditOptions.GroupID = "Driveline (Axles / CV Shaft)";
            this.xrCheckBox72.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox72.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox72.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox72.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox72.Name = "xrCheckBox72";
            this.xrCheckBox72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell116
            // 
            this.tableCell116.Multiline = true;
            this.tableCell116.Name = "tableCell116";
            this.tableCell116.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow52
            // 
            this.tableRow52.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell117,
            this.tableCell118});
            this.tableRow52.Name = "tableRow52";
            // 
            // tableCell117
            // 
            this.tableCell117.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox73,
            this.xrCheckBox74,
            this.xrCheckBox75});
            this.tableCell117.Multiline = true;
            this.tableCell117.Name = "tableCell117";
            // 
            // xrCheckBox73
            // 
            this.xrCheckBox73.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox73.Checked = true;
            this.xrCheckBox73.EditOptions.Enabled = true;
            this.xrCheckBox73.EditOptions.GroupID = "Exhaust System";
            this.xrCheckBox73.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox73.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox73.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox73.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox73.Name = "xrCheckBox73";
            this.xrCheckBox73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox74
            // 
            this.xrCheckBox74.EditOptions.Enabled = true;
            this.xrCheckBox74.EditOptions.GroupID = "Exhaust System";
            this.xrCheckBox74.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox74.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox74.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox74.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox74.Name = "xrCheckBox74";
            this.xrCheckBox74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox75
            // 
            this.xrCheckBox75.EditOptions.Enabled = true;
            this.xrCheckBox75.EditOptions.GroupID = "Exhaust System";
            this.xrCheckBox75.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox75.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox75.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox75.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox75.Name = "xrCheckBox75";
            this.xrCheckBox75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell118
            // 
            this.tableCell118.Multiline = true;
            this.tableCell118.Name = "tableCell118";
            this.tableCell118.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow53
            // 
            this.tableRow53.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell119,
            this.tableCell120});
            this.tableRow53.Name = "tableRow53";
            // 
            // tableCell119
            // 
            this.tableCell119.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox76,
            this.xrCheckBox77,
            this.xrCheckBox78});
            this.tableCell119.Multiline = true;
            this.tableCell119.Name = "tableCell119";
            // 
            // xrCheckBox76
            // 
            this.xrCheckBox76.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox76.Checked = true;
            this.xrCheckBox76.EditOptions.Enabled = true;
            this.xrCheckBox76.EditOptions.GroupID = "Fuel Lines & Hoses";
            this.xrCheckBox76.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox76.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Green"));
            this.xrCheckBox76.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Check_Grey"));
            this.xrCheckBox76.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox76.Name = "xrCheckBox76";
            this.xrCheckBox76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox77
            // 
            this.xrCheckBox77.EditOptions.Enabled = true;
            this.xrCheckBox77.EditOptions.GroupID = "Fuel Lines & Hoses";
            this.xrCheckBox77.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox77.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Yellow"));
            this.xrCheckBox77.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Warning_Grey"));
            this.xrCheckBox77.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox77.Name = "xrCheckBox77";
            this.xrCheckBox77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox78
            // 
            this.xrCheckBox78.EditOptions.Enabled = true;
            this.xrCheckBox78.EditOptions.GroupID = "Fuel Lines & Hoses";
            this.xrCheckBox78.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox78.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Red"));
            this.xrCheckBox78.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Cross_Grey"));
            this.xrCheckBox78.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox78.Name = "xrCheckBox78";
            this.xrCheckBox78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell120
            // 
            this.tableCell120.Multiline = true;
            this.tableCell120.Name = "tableCell120";
            this.tableCell120.StyleName = "GeneralTextStyleStyle";
            // 
            // label8
            // 
            this.label8.Multiline = true;
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label8.StyleName = "SectionTitleStyle";
            this.label8.StylePriority.UseBorders = false;
            // 
            // label5
            // 
            this.label5.Multiline = true;
            this.label5.Name = "label5";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label5.StyleName = "SectionTitleStyle";
            this.label5.StylePriority.UseBorders = false;
            // 
            // table5
            // 
            this.table5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table5.Name = "table5";
            this.table5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow34,
            this.tableRow35,
            this.tableRow36});
            this.table5.StyleName = "GeneralTextStyleStyle";
            this.table5.StylePriority.UseBackColor = false;
            // 
            // tableRow34
            // 
            this.tableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell67,
            this.tableCell68});
            this.tableRow34.Name = "tableRow34";
            this.tableRow34.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 20, 0, 100F);
            this.tableRow34.StylePriority.UsePadding = false;
            // 
            // tableCell67
            // 
            this.tableCell67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox5});
            this.tableCell67.Multiline = true;
            this.tableCell67.Name = "tableCell67";
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.pictureBox5.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"));
            this.pictureBox5.Name = "pictureBox5";
            // 
            // tableCell68
            // 
            this.tableCell68.Multiline = true;
            this.tableCell68.Name = "tableCell68";
            // 
            // tableRow35
            // 
            this.tableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell69,
            this.tableCell70});
            this.tableRow35.Name = "tableRow35";
            this.tableRow35.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.tableRow35.StylePriority.UsePadding = false;
            // 
            // tableCell69
            // 
            this.tableCell69.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox6});
            this.tableCell69.Multiline = true;
            this.tableCell69.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 6, 6, 100F);
            this.tableCell69.Name = "tableCell69";
            // 
            // pictureBox6
            // 
            this.pictureBox6.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.pictureBox6.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"));
            this.pictureBox6.Name = "pictureBox6";
            // 
            // tableCell70
            // 
            this.tableCell70.Multiline = true;
            this.tableCell70.Name = "tableCell70";
            this.tableCell70.StylePriority.UseTextAlignment = false;
            // 
            // tableRow36
            // 
            this.tableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell71,
            this.tableCell72});
            this.tableRow36.Name = "tableRow36";
            this.tableRow36.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 20, 100F);
            this.tableRow36.StylePriority.UsePadding = false;
            // 
            // tableCell71
            // 
            this.tableCell71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox7});
            this.tableCell71.Multiline = true;
            this.tableCell71.Name = "tableCell71";
            // 
            // pictureBox7
            // 
            this.pictureBox7.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.pictureBox7.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"));
            this.pictureBox7.Name = "pictureBox7";
            // 
            // tableCell72
            // 
            this.tableCell72.Multiline = true;
            this.tableCell72.Name = "tableCell72";
            // 
            // label7
            // 
            this.label7.Multiline = true;
            this.label7.Name = "label7";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label7.StyleName = "EditorKeyStyle";
            // 
            // table7
            // 
            this.table7.Name = "table7";
            this.table7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.table7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow40,
            this.tableRow41,
            this.tableRow42,
            this.tableRow43,
            this.tableRow44,
            this.tableRow47,
            this.tableRow48});
            this.table7.StyleName = "GeneralTextStyleStyle";
            // 
            // tableRow40
            // 
            this.tableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell89,
            this.tableCell79,
            this.tableCell80,
            this.tableCell100});
            this.tableRow40.Name = "tableRow40";
            // 
            // tableCell89
            // 
            this.tableCell89.Multiline = true;
            this.tableCell89.Name = "tableCell89";
            this.tableCell89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.tableCell89.StylePriority.UseFont = false;
            this.tableCell89.StylePriority.UsePadding = false;
            this.tableCell89.StylePriority.UseTextAlignment = false;
            // 
            // tableCell79
            // 
            this.tableCell79.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.checkBox10,
            this.checkBox11,
            this.checkBox12});
            this.tableCell79.Multiline = true;
            this.tableCell79.Name = "tableCell79";
            this.tableCell79.StylePriority.UseFont = false;
            this.tableCell79.StylePriority.UseTextAlignment = false;
            // 
            // checkBox10
            // 
            this.checkBox10.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.checkBox10.Checked = true;
            this.checkBox10.EditOptions.Enabled = true;
            this.checkBox10.EditOptions.GroupID = "TREAD DEPTH LF";
            this.checkBox10.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox10.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"));
            this.checkBox10.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"));
            this.checkBox10.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // checkBox11
            // 
            this.checkBox11.EditOptions.Enabled = true;
            this.checkBox11.EditOptions.GroupID = "TREAD DEPTH LF";
            this.checkBox11.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox11.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"));
            this.checkBox11.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"));
            this.checkBox11.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // checkBox12
            // 
            this.checkBox12.EditOptions.Enabled = true;
            this.checkBox12.EditOptions.GroupID = "TREAD DEPTH LF";
            this.checkBox12.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox12.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"));
            this.checkBox12.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"));
            this.checkBox12.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell80
            // 
            this.tableCell80.EditOptions.EditorName = "IntegerPositive";
            this.tableCell80.EditOptions.Enabled = true;
            this.tableCell80.Name = "tableCell80";
            this.tableCell80.StyleName = "EditorValueStyle";
            this.tableCell80.StylePriority.UseBorderColor = false;
            this.tableCell80.StylePriority.UseBorderWidth = false;
            this.tableCell80.StylePriority.UseFont = false;
            this.tableCell80.StylePriority.UsePadding = false;
            this.tableCell80.StylePriority.UseTextAlignment = false;
            // 
            // tableCell100
            // 
            this.tableCell100.Multiline = true;
            this.tableCell100.Name = "tableCell100";
            this.tableCell100.StylePriority.UseBorderColor = false;
            this.tableCell100.StylePriority.UseBorderWidth = false;
            this.tableCell100.StylePriority.UseFont = false;
            this.tableCell100.StylePriority.UsePadding = false;
            this.tableCell100.StylePriority.UseTextAlignment = false;
            // 
            // tableRow41
            // 
            this.tableRow41.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell90,
            this.tableCell81,
            this.tableCell82,
            this.tableCell101});
            this.tableRow41.Name = "tableRow41";
            // 
            // tableCell90
            // 
            this.tableCell90.Multiline = true;
            this.tableCell90.Name = "tableCell90";
            this.tableCell90.StylePriority.UseFont = false;
            this.tableCell90.StylePriority.UseTextAlignment = false;
            // 
            // tableCell81
            // 
            this.tableCell81.Multiline = true;
            this.tableCell81.Name = "tableCell81";
            this.tableCell81.StylePriority.UseFont = false;
            this.tableCell81.StylePriority.UseTextAlignment = false;
            // 
            // tableCell82
            // 
            this.tableCell82.Multiline = true;
            this.tableCell82.Name = "tableCell82";
            this.tableCell82.StylePriority.UseBorderColor = false;
            this.tableCell82.StylePriority.UseBorderWidth = false;
            this.tableCell82.StylePriority.UseFont = false;
            this.tableCell82.StylePriority.UsePadding = false;
            this.tableCell82.StylePriority.UseTextAlignment = false;
            // 
            // tableCell101
            // 
            this.tableCell101.Multiline = true;
            this.tableCell101.Name = "tableCell101";
            this.tableCell101.StylePriority.UseBorderColor = false;
            this.tableCell101.StylePriority.UseBorderWidth = false;
            this.tableCell101.StylePriority.UseFont = false;
            this.tableCell101.StylePriority.UsePadding = false;
            this.tableCell101.StylePriority.UseTextAlignment = false;
            // 
            // tableRow42
            // 
            this.tableRow42.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell91,
            this.tableCell83,
            this.tableCell84,
            this.tableCell102});
            this.tableRow42.Name = "tableRow42";
            // 
            // tableCell91
            // 
            this.tableCell91.Multiline = true;
            this.tableCell91.Name = "tableCell91";
            this.tableCell91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.tableCell91.StylePriority.UseFont = false;
            this.tableCell91.StylePriority.UsePadding = false;
            this.tableCell91.StylePriority.UseTextAlignment = false;
            // 
            // tableCell83
            // 
            this.tableCell83.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox91,
            this.xrCheckBox92,
            this.xrCheckBox93});
            this.tableCell83.Multiline = true;
            this.tableCell83.Name = "tableCell83";
            this.tableCell83.StylePriority.UseFont = false;
            this.tableCell83.StylePriority.UseTextAlignment = false;
            // 
            // xrCheckBox91
            // 
            this.xrCheckBox91.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox91.Checked = true;
            this.xrCheckBox91.EditOptions.Enabled = true;
            this.xrCheckBox91.EditOptions.GroupID = "TREAD DEPTH LR";
            this.xrCheckBox91.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox91.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"));
            this.xrCheckBox91.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"));
            this.xrCheckBox91.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox91.Name = "xrCheckBox91";
            this.xrCheckBox91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox92
            // 
            this.xrCheckBox92.EditOptions.Enabled = true;
            this.xrCheckBox92.EditOptions.GroupID = "TREAD DEPTH LR";
            this.xrCheckBox92.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox92.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"));
            this.xrCheckBox92.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"));
            this.xrCheckBox92.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox92.Name = "xrCheckBox92";
            this.xrCheckBox92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox93
            // 
            this.xrCheckBox93.EditOptions.Enabled = true;
            this.xrCheckBox93.EditOptions.GroupID = "TREAD DEPTH LR";
            this.xrCheckBox93.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox93.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"));
            this.xrCheckBox93.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"));
            this.xrCheckBox93.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox93.Name = "xrCheckBox93";
            this.xrCheckBox93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell84
            // 
            this.tableCell84.EditOptions.EditorName = "IntegerPositive";
            this.tableCell84.EditOptions.Enabled = true;
            this.tableCell84.Multiline = true;
            this.tableCell84.Name = "tableCell84";
            this.tableCell84.StyleName = "EditorValueStyle";
            this.tableCell84.StylePriority.UseBorderColor = false;
            this.tableCell84.StylePriority.UseBorderWidth = false;
            this.tableCell84.StylePriority.UseFont = false;
            this.tableCell84.StylePriority.UsePadding = false;
            this.tableCell84.StylePriority.UseTextAlignment = false;
            // 
            // tableCell102
            // 
            this.tableCell102.Multiline = true;
            this.tableCell102.Name = "tableCell102";
            this.tableCell102.StylePriority.UseBorderColor = false;
            this.tableCell102.StylePriority.UseBorderWidth = false;
            this.tableCell102.StylePriority.UseFont = false;
            this.tableCell102.StylePriority.UsePadding = false;
            this.tableCell102.StylePriority.UseTextAlignment = false;
            // 
            // tableRow43
            // 
            this.tableRow43.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell92,
            this.tableCell85,
            this.tableCell86,
            this.tableCell103});
            this.tableRow43.Name = "tableRow43";
            // 
            // tableCell92
            // 
            this.tableCell92.Multiline = true;
            this.tableCell92.Name = "tableCell92";
            this.tableCell92.StylePriority.UseFont = false;
            this.tableCell92.StylePriority.UseTextAlignment = false;
            // 
            // tableCell85
            // 
            this.tableCell85.Multiline = true;
            this.tableCell85.Name = "tableCell85";
            this.tableCell85.StylePriority.UseFont = false;
            this.tableCell85.StylePriority.UseTextAlignment = false;
            // 
            // tableCell86
            // 
            this.tableCell86.Multiline = true;
            this.tableCell86.Name = "tableCell86";
            this.tableCell86.StylePriority.UseBorderColor = false;
            this.tableCell86.StylePriority.UseBorderWidth = false;
            this.tableCell86.StylePriority.UseFont = false;
            this.tableCell86.StylePriority.UsePadding = false;
            this.tableCell86.StylePriority.UseTextAlignment = false;
            // 
            // tableCell103
            // 
            this.tableCell103.Multiline = true;
            this.tableCell103.Name = "tableCell103";
            this.tableCell103.StylePriority.UseBorderColor = false;
            this.tableCell103.StylePriority.UseBorderWidth = false;
            this.tableCell103.StylePriority.UseFont = false;
            this.tableCell103.StylePriority.UsePadding = false;
            this.tableCell103.StylePriority.UseTextAlignment = false;
            // 
            // tableRow44
            // 
            this.tableRow44.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell97,
            this.tableCell87,
            this.tableCell88,
            this.tableCell104});
            this.tableRow44.Name = "tableRow44";
            // 
            // tableCell97
            // 
            this.tableCell97.Multiline = true;
            this.tableCell97.Name = "tableCell97";
            this.tableCell97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.tableCell97.StylePriority.UseFont = false;
            this.tableCell97.StylePriority.UsePadding = false;
            this.tableCell97.StylePriority.UseTextAlignment = false;
            // 
            // tableCell87
            // 
            this.tableCell87.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox94,
            this.xrCheckBox95,
            this.xrCheckBox96});
            this.tableCell87.Multiline = true;
            this.tableCell87.Name = "tableCell87";
            this.tableCell87.StylePriority.UseFont = false;
            this.tableCell87.StylePriority.UseTextAlignment = false;
            // 
            // xrCheckBox94
            // 
            this.xrCheckBox94.EditOptions.Enabled = true;
            this.xrCheckBox94.EditOptions.GroupID = "TREAD DEPTH RF";
            this.xrCheckBox94.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox94.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"));
            this.xrCheckBox94.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"));
            this.xrCheckBox94.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox94.Name = "xrCheckBox94";
            this.xrCheckBox94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox95
            // 
            this.xrCheckBox95.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox95.Checked = true;
            this.xrCheckBox95.EditOptions.Enabled = true;
            this.xrCheckBox95.EditOptions.GroupID = "TREAD DEPTH RF";
            this.xrCheckBox95.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox95.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"));
            this.xrCheckBox95.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"));
            this.xrCheckBox95.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox95.Name = "xrCheckBox95";
            this.xrCheckBox95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox96
            // 
            this.xrCheckBox96.EditOptions.Enabled = true;
            this.xrCheckBox96.EditOptions.GroupID = "TREAD DEPTH RF";
            this.xrCheckBox96.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox96.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"));
            this.xrCheckBox96.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"));
            this.xrCheckBox96.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox96.Name = "xrCheckBox96";
            this.xrCheckBox96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell88
            // 
            this.tableCell88.EditOptions.EditorName = "IntegerPositive";
            this.tableCell88.EditOptions.Enabled = true;
            this.tableCell88.Multiline = true;
            this.tableCell88.Name = "tableCell88";
            this.tableCell88.StyleName = "EditorValueStyle";
            this.tableCell88.StylePriority.UseBorderColor = false;
            this.tableCell88.StylePriority.UseBorderWidth = false;
            this.tableCell88.StylePriority.UseFont = false;
            this.tableCell88.StylePriority.UsePadding = false;
            this.tableCell88.StylePriority.UseTextAlignment = false;
            // 
            // tableCell104
            // 
            this.tableCell104.Multiline = true;
            this.tableCell104.Name = "tableCell104";
            this.tableCell104.StylePriority.UseBorderColor = false;
            this.tableCell104.StylePriority.UseBorderWidth = false;
            this.tableCell104.StylePriority.UseFont = false;
            this.tableCell104.StylePriority.UsePadding = false;
            this.tableCell104.StylePriority.UseTextAlignment = false;
            // 
            // tableRow47
            // 
            this.tableRow47.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell98,
            this.tableCell93,
            this.tableCell94,
            this.tableCell105});
            this.tableRow47.Name = "tableRow47";
            // 
            // tableCell98
            // 
            this.tableCell98.Multiline = true;
            this.tableCell98.Name = "tableCell98";
            this.tableCell98.StylePriority.UseFont = false;
            this.tableCell98.StylePriority.UseTextAlignment = false;
            // 
            // tableCell93
            // 
            this.tableCell93.Multiline = true;
            this.tableCell93.Name = "tableCell93";
            this.tableCell93.StylePriority.UseFont = false;
            this.tableCell93.StylePriority.UseTextAlignment = false;
            // 
            // tableCell94
            // 
            this.tableCell94.Multiline = true;
            this.tableCell94.Name = "tableCell94";
            this.tableCell94.StylePriority.UseBorderColor = false;
            this.tableCell94.StylePriority.UseBorderWidth = false;
            this.tableCell94.StylePriority.UseFont = false;
            this.tableCell94.StylePriority.UsePadding = false;
            this.tableCell94.StylePriority.UseTextAlignment = false;
            // 
            // tableCell105
            // 
            this.tableCell105.Multiline = true;
            this.tableCell105.Name = "tableCell105";
            this.tableCell105.StylePriority.UseBorderColor = false;
            this.tableCell105.StylePriority.UseBorderWidth = false;
            this.tableCell105.StylePriority.UseFont = false;
            this.tableCell105.StylePriority.UsePadding = false;
            this.tableCell105.StylePriority.UseTextAlignment = false;
            // 
            // tableRow48
            // 
            this.tableRow48.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell99,
            this.tableCell95,
            this.tableCell96,
            this.tableCell106});
            this.tableRow48.Name = "tableRow48";
            // 
            // tableCell99
            // 
            this.tableCell99.Multiline = true;
            this.tableCell99.Name = "tableCell99";
            this.tableCell99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.tableCell99.StylePriority.UseFont = false;
            this.tableCell99.StylePriority.UsePadding = false;
            this.tableCell99.StylePriority.UseTextAlignment = false;
            // 
            // tableCell95
            // 
            this.tableCell95.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox97,
            this.xrCheckBox98,
            this.xrCheckBox99});
            this.tableCell95.Multiline = true;
            this.tableCell95.Name = "tableCell95";
            this.tableCell95.StylePriority.UseFont = false;
            this.tableCell95.StylePriority.UseTextAlignment = false;
            // 
            // xrCheckBox97
            // 
            this.xrCheckBox97.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox97.Checked = true;
            this.xrCheckBox97.EditOptions.Enabled = true;
            this.xrCheckBox97.EditOptions.GroupID = "TREAD DEPTH RR";
            this.xrCheckBox97.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox97.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Green"));
            this.xrCheckBox97.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Smile_Grey"));
            this.xrCheckBox97.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox97.Name = "xrCheckBox97";
            this.xrCheckBox97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox98
            // 
            this.xrCheckBox98.EditOptions.Enabled = true;
            this.xrCheckBox98.EditOptions.GroupID = "TREAD DEPTH RR";
            this.xrCheckBox98.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox98.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Yellow"));
            this.xrCheckBox98.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Neutral_Grey"));
            this.xrCheckBox98.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox98.Name = "xrCheckBox98";
            this.xrCheckBox98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrCheckBox99
            // 
            this.xrCheckBox99.EditOptions.Enabled = true;
            this.xrCheckBox99.EditOptions.GroupID = "TREAD DEPTH RR";
            this.xrCheckBox99.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrCheckBox99.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Red"));
            this.xrCheckBox99.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("Sad_Grey"));
            this.xrCheckBox99.GlyphOptions.Size = new System.Drawing.SizeF(18F, 18F);
            this.xrCheckBox99.Name = "xrCheckBox99";
            this.xrCheckBox99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // tableCell96
            // 
            this.tableCell96.EditOptions.EditorName = "IntegerPositive";
            this.tableCell96.EditOptions.Enabled = true;
            this.tableCell96.Multiline = true;
            this.tableCell96.Name = "tableCell96";
            this.tableCell96.StyleName = "EditorValueStyle";
            this.tableCell96.StylePriority.UseBorderColor = false;
            this.tableCell96.StylePriority.UseBorderWidth = false;
            this.tableCell96.StylePriority.UseFont = false;
            this.tableCell96.StylePriority.UsePadding = false;
            this.tableCell96.StylePriority.UseTextAlignment = false;
            // 
            // tableCell106
            // 
            this.tableCell106.Multiline = true;
            this.tableCell106.Name = "tableCell106";
            this.tableCell106.StylePriority.UseBorderColor = false;
            this.tableCell106.StylePriority.UseBorderWidth = false;
            this.tableCell106.StylePriority.UseFont = false;
            this.tableCell106.StylePriority.UsePadding = false;
            this.tableCell106.StylePriority.UseTextAlignment = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseForeColor = false;
            this.label1.StylePriority.UsePadding = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // EditorKeyStyle
            // 
            this.EditorKeyStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.EditorKeyStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.EditorKeyStyle.Name = "EditorKeyStyle";
            this.EditorKeyStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.EditorKeyStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // EditorValueStyle
            // 
            this.EditorValueStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.EditorValueStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.EditorValueStyle.BorderWidth = 2F;
            this.EditorValueStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            this.EditorValueStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.EditorValueStyle.Name = "EditorValueStyle";
            this.EditorValueStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 5, 5, 100F);
            this.EditorValueStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GeneralTextStyleStyle
            // 
            this.GeneralTextStyleStyle.Font = new DevExpress.Drawing.DXFont("Arial", 9.5F);
            this.GeneralTextStyleStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.GeneralTextStyleStyle.Name = "GeneralTextStyleStyle";
            this.GeneralTextStyleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 2, 2, 100F);
            this.GeneralTextStyleStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SectionTitleStyle
            // 
            this.SectionTitleStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.SectionTitleStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.SectionTitleStyle.BorderWidth = 4F;
            this.SectionTitleStyle.Font = new DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SectionTitleStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.SectionTitleStyle.Name = "SectionTitleStyle";
            this.SectionTitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 5, 100F);
            // 
            // parameterLanguage
            // 
            this.parameterLanguage.Name = "parameterLanguage";
            this.parameterLanguage.ValueInfo = "Default";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("Default", "English"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("de", "German"));
            this.parameterLanguage.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin,
            this.ReportHeader});
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 90F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "de", "HeightF", 85.99999F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox1, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox1, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox10, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.907349E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox10, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox10, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox10, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox11, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(23.00001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox11, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox11, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox11, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox12, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(46F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox12, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox12, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox12, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox2, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox2, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox2, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox24, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox24, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox24, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox3, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox3, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.checkBox3, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 848.0001F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "Default", "Font", new DevExpress.Drawing.DXFont("Arial", 24.5F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.222659E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "de", "LocationFloat", new DevExpress.Utils.PointFloat(1.589457E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "Default", "SizeF", new System.Drawing.SizeF(650F, 65F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "de", "SizeF", new System.Drawing.SizeF(734.9999F, 65F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "Default", "Text", "Vehicle Inspection Report"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label1, "de", "Text", "KFZ-Inspektionsbericht"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label10, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 501F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label10, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 501F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label10, "Default", "SizeF", new System.Drawing.SizeF(295F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label10, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 26.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label10, "Default", "Text", "TIRE CHECK / OE INTERVAL SUGGESTIONS"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label10, "de", "Text", "Ratschläge zu Reifenprüfung und Herstellerintervallen"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label11, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 614F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label11, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 613.9999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label11, "Default", "SizeF", new System.Drawing.SizeF(295F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label11, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label11, "Default", "Text", "COMMENTS:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label11, "de", "Text", "Kommentare:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label12, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 641F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label12, "Default", "SizeF", new System.Drawing.SizeF(650F, 172.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label12, "de", "SizeF", new System.Drawing.SizeF(734.9998F, 172.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label13, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 840.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label13, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 840.0002F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label13, "Default", "SizeF", new System.Drawing.SizeF(460F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label13, "de", "SizeF", new System.Drawing.SizeF(520.4167F, 26.99988F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label13, "Default", "Text", "INSPECTED BY:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label13, "de", "Text", "Inspiziert von"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label14, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 867F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label14, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 867.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label14, "Default", "SizeF", new System.Drawing.SizeF(460F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label14, "de", "SizeF", new System.Drawing.SizeF(520.4167F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label15, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(470.0001F, 840.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label15, "de", "LocationFloat", new DevExpress.Utils.PointFloat(533.125F, 840.0002F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label15, "Default", "SizeF", new System.Drawing.SizeF(180F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label15, "de", "SizeF", new System.Drawing.SizeF(201.8749F, 26.99988F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label15, "Default", "Text", "DATE:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label15, "de", "Text", "Datum:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 375F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label2, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 375F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label2, "Default", "SizeF", new System.Drawing.SizeF(295F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label2, "de", "SizeF", new System.Drawing.SizeF(340F, 39.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label2, "Default", "Text", "INTERIOR / EXTERIOR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label2, "de", "Text", "INNENRAUM UND KAROSSERIE"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355F, 375F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label3, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9175F, 375F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label3, "Default", "SizeF", new System.Drawing.SizeF(295F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label3, "de", "SizeF", new System.Drawing.SizeF(340.0824F, 39.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label3, "Default", "Text", "UNDERHOOD"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label3, "de", "Text", "UNTER DER HAUBE"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.946274E-05F, 415F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label4, "de", "LocationFloat", new DevExpress.Utils.PointFloat(3.178914E-05F, 415F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label4, "Default", "SizeF", new System.Drawing.SizeF(295F, 45F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label4, "de", "SizeF", new System.Drawing.SizeF(340F, 45F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label4, "Default", "Text", "Note any existing exterior body damage or defects on diagram:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label4, "de", "Text", "Vermerken Sie bestehende externe Schäden im Diagramm:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label5, "Default", "SizeF", new System.Drawing.SizeF(295F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label5, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label5, "Default", "Text", "TIRES"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label5, "de", "Text", "REIFEN"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355.0001F, 740.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label6, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9175F, 740.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label6, "Default", "SizeF", new System.Drawing.SizeF(295F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label6, "de", "SizeF", new System.Drawing.SizeF(340.0827F, 26.99988F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label6, "Default", "Text", "BATTERY"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label6, "de", "Text", "Batterie"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 51.00006F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label7, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 51.00009F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label7, "Default", "SizeF", new System.Drawing.SizeF(295F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label7, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label7, "Default", "Text", "TREAD DEPTH"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label7, "de", "Text", "Profiltiefe"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label8, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9176F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label8, "Default", "SizeF", new System.Drawing.SizeF(295F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label8, "de", "SizeF", new System.Drawing.SizeF(340.0823F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label8, "Default", "Text", "UNDER VEHICLE"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label8, "de", "Text", "UNTER DEM FAHRZEUG"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label9, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 394F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label9, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 394F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label9, "Default", "SizeF", new System.Drawing.SizeF(295F, 26.99994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label9, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 27.00003F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label9, "Default", "Text", "WEAR PATTERN / DAMAGE"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.label9, "de", "Text", "Verschleißmuster / Beschädigungen"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.labelCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(470F, 867F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.labelCurrentDate, "de", "LocationFloat", new DevExpress.Utils.PointFloat(533.1248F, 867.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.labelCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(180F, 32.49994F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.labelCurrentDate, "de", "SizeF", new System.Drawing.SizeF(201.8751F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.labelCurrentDate, "Default", "TextFormatString", "{0:d}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.parameterLanguage, "Default", "Description", "Language:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox1, "Default", "SizeF", new System.Drawing.SizeF(44.75381F, 41.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox1, "de", "SizeF", new System.Drawing.SizeF(50.08271F, 39.84F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.051758E-05F, 3.814697E-06F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox2, "de", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox2, "Default", "SizeF", new System.Drawing.SizeF(44.75381F, 32.50001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox2, "de", "SizeF", new System.Drawing.SizeF(50.08271F, 31.2F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox3, "Default", "SizeF", new System.Drawing.SizeF(44.75381F, 41F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox3, "de", "SizeF", new System.Drawing.SizeF(50.08271F, 39.36F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 460F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox4, "Default", "SizeF", new System.Drawing.SizeF(295F, 190F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox4, "de", "SizeF", new System.Drawing.SizeF(340F, 190F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox5, "Default", "SizeF", new System.Drawing.SizeF(44.75381F, 41.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.051758E-05F, 3.814697E-06F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox6, "Default", "SizeF", new System.Drawing.SizeF(44.75381F, 32.50001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox6, "de", "SizeF", new System.Drawing.SizeF(44.75381F, 32.50001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox7, "Default", "SizeF", new System.Drawing.SizeF(44.75381F, 41F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "Vehicle Inspection Report"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Arial", 9.75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(100, 100, 90, 90)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "de", "Margins", new DevExpress.Drawing.DXMargins(45, 47, 86, 86)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "de", "PaperKind", System.Drawing.Printing.PaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportHeader, "Default", "HeightF", 65F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 899.5F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "de", "HeightF", 899.5001F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table1, "Default", "SizeF", new System.Drawing.SizeF(295F, 298.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table1, "de", "SizeF", new System.Drawing.SizeF(345F, 298.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table10, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(9.536745E-05F, 527.9999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table10, "Default", "SizeF", new System.Drawing.SizeF(295F, 54F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table10, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 54.00006F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table2, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9175F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table2, "Default", "SizeF", new System.Drawing.SizeF(295F, 115F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table2, "de", "SizeF", new System.Drawing.SizeF(340.0827F, 110.4F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 659F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table3, "Default", "SizeF", new System.Drawing.SizeF(295F, 189F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table3, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 189.0001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355F, 443F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table4, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9175F, 443F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table4, "Default", "SizeF", new System.Drawing.SizeF(295F, 270F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table4, "de", "SizeF", new System.Drawing.SizeF(340.0822F, 269.9999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 78F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table5, "Default", "SizeF", new System.Drawing.SizeF(295F, 115F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table5, "de", "SizeF", new System.Drawing.SizeF(340F, 115F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(354.9999F, 766.9999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table6, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9176F, 766.9999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table6, "Default", "SizeF", new System.Drawing.SizeF(295F, 81F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table6, "de", "SizeF", new System.Drawing.SizeF(340.0822F, 81F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 208F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table7, "Default", "SizeF", new System.Drawing.SizeF(295F, 157F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table7, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 157F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355F, 58F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table8, "de", "LocationFloat", new DevExpress.Utils.PointFloat(394.9176F, 58F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table8, "Default", "SizeF", new System.Drawing.SizeF(295F, 189F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table8, "de", "SizeF", new System.Drawing.SizeF(340.0821F, 189F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table9, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(9.536745E-05F, 420.9999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table9, "Default", "SizeF", new System.Drawing.SizeF(295F, 54F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.table9, "de", "SizeF", new System.Drawing.SizeF(339.9999F, 54.00003F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell1, "Default", "Text", "NAME:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell1, "de", "Text", "Name:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell1, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell1, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell10, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell10, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell100, "Default", "Text", "/32\""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell100, "de", "Text", "mm"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell100, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell100, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell101, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell101, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell102, "Default", "Text", "/32\""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell102, "de", "Text", "mm"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell102, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell102, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell103, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell103, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell104, "Default", "Text", "/32\""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell104, "de", "Text", "mm"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell104, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell104, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell105, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell105, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell106, "Default", "Text", "/32\""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell106, "de", "Text", "mm"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell106, "Default", "Weight", 0.73000020238445229D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell106, "de", "Weight", 0.80202322518802016D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell107, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell108, "Default", "Text", "Brakes (Pads / Shoes)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell108, "de", "Text", "Bremsen (Scheiben, Beläge, Bremsbacken)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell108, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell108, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell109, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell11, "Default", "Text", "PHONE:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell11, "de", "Text", "Telefon:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell11, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell11, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell110, "Default", "Text", "Brake Lines / Hoses"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell110, "de", "Text", "Bremsleitungen / -schläuche"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell110, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell110, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell111, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell112, "Default", "Text", "Steering System"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell112, "de", "Text", "Lenkanlage"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell112, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell112, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell113, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell114, "Default", "Text", "Shocks & Struts"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell114, "de", "Text", "Stoßdämpfer und Federbeine"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell114, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell114, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell115, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell116, "Default", "Text", "Driveline (Axles / CV Shaft)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell116, "de", "Text", "Antrieb und Fahrwerk (Achsen / Wellen)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell116, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell116, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell117, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell118, "Default", "Text", "Exhaust System"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell118, "de", "Text", "Abgasanlage"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell118, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell118, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell119, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell12, "Default", "Text", "(123) 456-7890"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell12, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell12, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell120, "Default", "Text", "Fuel Lines & Hoses"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell120, "de", "Text", "Kraftstoffleitungen und -schläuche"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell120, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell120, "de", "Weight", 2.7720227797709707D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell121, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell122, "Default", "Text", "LF"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell122, "de", "Text", "VL"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell122, "Default", "Weight", 0.81355938033379271D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell122, "de", "Weight", 1.0541760567118461D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell123, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell124, "Default", "Text", "RF"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell124, "de", "Text", "HL"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell124, "Default", "Weight", 0.81355938033379271D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell124, "de", "Weight", 1.0541760567118461D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell125, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell126, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell127, "Default", "Text", "LR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell127, "de", "Text", "VR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell127, "Default", "Weight", 0.81355938033379271D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell127, "de", "Weight", 1.0305685773795519D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell128, "Default", "Text", "RR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell128, "de", "Text", "HR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell128, "Default", "Weight", 0.81355938033379271D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell128, "de", "Weight", 1.0305685773795519D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell129, "Default", "Weight", 0.25423699115683063D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell13, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell13, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell130, "Default", "Text", "Alignment"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell130, "de", "Text", "Achsvermessung"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell130, "Default", "Weight", 1.2457631640173155D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell130, "de", "Weight", 1.4969728788609187D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell131, "Default", "Weight", 0.25423734029865042D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell132, "Default", "Text", "Rotation"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell132, "Default", "Weight", 1.2457628148754958D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell132, "de", "Weight", 1.4521795032888887D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell133, "Default", "Weight", 0.25423699115683063D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell134, "Default", "Text", "Balance"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell134, "de", "Text", "Auswuchtung"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell134, "Default", "Weight", 1.2457631640173155D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell134, "de", "Weight", 1.4969728788609187D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell135, "Default", "Weight", 0.25423734029865042D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell136, "Default", "Text", "New Tire"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell136, "de", "Text", "Neuer Reifen"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell136, "Default", "Weight", 1.2457628148754958D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell136, "de", "Weight", 1.4521795032888887D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell14, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell14, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell15, "Default", "Text", "EMAIL:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell15, "de", "Text", "Email:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell15, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell15, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell16, "Default", "Text", "john@devexpress.com"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell16, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell16, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell17, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell17, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell18, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell18, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell19, "Default", "Text", "VIN:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell19, "de", "Text", "Fahrgestellnummer:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell19, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell19, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell2, "Default", "Text", "John Smith"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell2, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell2, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell20, "Default", "Text", "1D4GP25B03108775"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell20, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell20, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell21, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell21, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell22, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell22, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell23, "Default", "Text", "MILEAGE:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell23, "de", "Text", "Kilometerstand:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell23, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell23, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell24, "Default", "Text", "123456"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell24, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell24, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell25, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell25, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell26, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell26, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell27, "Default", "Text", "LICENSE:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell27, "de", "Text", "Führerscheinnummer:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell27, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell27, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell28, "Default", "Text", "123456-78"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell28, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell28, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell29, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell29, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell3, "Default", "Weight", 0.30508474576271183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell30, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell30, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell31, "Default", "Text", "MODEL:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell31, "de", "Text", "Fahrzeughersteller und Typ:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell31, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell31, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell32, "Default", "Text", "Volkswagen Passat"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell32, "Default", "Weight", 2.1999999999999997D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell32, "de", "Weight", 1.5196969939723157D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell33, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell33, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell34, "Default", "Text", "Exterior Body"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell34, "de", "Text", "Karosserie"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell34, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell34, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell35, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell35, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell36, "Default", "Text", "Windshield / Glass"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell36, "de", "Text", "Windschutzscheibe"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell36, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell36, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell37, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell37, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell38, "Default", "Text", "Wipers"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell38, "de", "Text", "Scheibenwischer"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell38, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell38, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell39, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell39, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell4, "Default", "Text", "Checked and OK"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell4, "de", "Text", "Geprüft und in Ordnung"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell4, "Default", "Weight", 1.6949152542372881D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell4, "de", "Weight", 1.7665692036940925D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell40, "Default", "Text", "Lights (Head, Brake, Turn)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell40, "de", "Text", "Scheinwerfer, Bremslichter, Blinker"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell40, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell40, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell41, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell41, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell42, "Default", "Text", "Interior Lights"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell42, "de", "Text", "Innenbeleuchtung"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell42, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell42, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell43, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell43, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell44, "Default", "Text", "AC Operation"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell44, "de", "Text", "Klimaanlage"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell44, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell44, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell45, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell45, "de", "Weight", 0.61363713127814146D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell46, "Default", "Text", "Heating"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell46, "de", "Text", "Heizanlage"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell46, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell46, "de", "Weight", 2.4772717245186211D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell47, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell48, "Default", "Text", "Engine Oil"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell48, "de", "Text", "Motoröl"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell48, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell48, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell49, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell5, "Default", "Weight", 0.30508474576271183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell50, "Default", "Text", "Brake Fluid"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell50, "de", "Text", "Bremsflüssigkeit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell50, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell50, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell51, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell52, "Default", "Text", "Power Steering Fluid"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell52, "de", "Text", "Lenkungsöl"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell52, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell52, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell53, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell54, "Default", "Text", "Washer Fluid"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell54, "de", "Text", "Scheibenwaschflüssigkeit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell54, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell54, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell55, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell56, "Default", "Text", "Belts & Hoses"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell56, "de", "Text", "Riemen und Schläuche"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell56, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell56, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell57, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell58, "Default", "Text", "Antifreeze / Coolant"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell58, "de", "Text", "Kühlmittel"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell58, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell58, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell59, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell6, "Default", "Text", "May require attention"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell6, "de", "Text", "In naher Zukunft wieder prüfen"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell6, "Default", "Weight", 1.6949152542372881D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell6, "de", "Weight", 1.7665692036940925D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell60, "Default", "Text", "Air Filter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell60, "de", "Text", "Luftfilter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell60, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell60, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell61, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell62, "Default", "Text", "Cabin Filter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell62, "de", "Text", "Pollenfilter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell62, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell62, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell63, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell64, "Default", "Text", "Fuel Filter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell64, "de", "Text", "Kraftstofffilter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell64, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell64, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell65, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell66, "Default", "Text", "Spark Plugs / Wires"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell66, "de", "Text", "Zündkerzen / -kabel"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell66, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell66, "de", "Weight", 2.7720234227046818D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell67, "Default", "Weight", 0.30508474576271183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell68, "Default", "Text", "7/32\" or greater"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell68, "de", "Text", "7mm oder mehr"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell68, "Default", "Weight", 1.6949152542372881D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell68, "de", "Weight", 1.9999997931011653D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell69, "Default", "Weight", 0.30508474576271183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell7, "Default", "Weight", 0.30508474576271183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell70, "Default", "Text", "3/32\" to 6/32\""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell70, "de", "Text", "3mm bis 6mm"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell70, "Default", "Weight", 1.6949152542372881D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell70, "de", "Weight", 1.9999997931011653D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell71, "Default", "Weight", 0.30508474576271183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell72, "Default", "Text", "2/32\" or less"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell72, "de", "Text", "2mm oder weniger"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell72, "Default", "Weight", 1.6949152542372881D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell72, "de", "Weight", 1.9999997931011653D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell73, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell74, "Default", "Text", "Battery Charge"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell74, "de", "Text", "Batterieladung"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell74, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell74, "de", "Weight", 2.7720218264889134D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell75, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell76, "Default", "Text", "Battery Condition"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell76, "de", "Text", "Batteriezustand"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell76, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell76, "de", "Weight", 2.7720218264889134D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell77, "Default", "Weight", 0.68644077484035348D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell78, "Default", "Text", "Cables & Connections"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell78, "de", "Text", "Kabel und Verbindungen"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell78, "Default", "Weight", 2.3135595355079386D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell78, "de", "Weight", 2.7720218264889134D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell79, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell8, "Default", "Text", "Requires immediate attention"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell8, "de", "Text", "Sofort beheben lassen"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell8, "Default", "Weight", 1.6949152542372881D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell8, "de", "Weight", 1.7665692036940925D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell80, "Default", "Text", "8"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell80, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell80, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell81, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell82, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell82, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell83, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell84, "Default", "Text", "7"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell84, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell84, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell85, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell86, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell86, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell87, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell88, "Default", "Text", "5"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell88, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell88, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell89, "Default", "Text", "LF"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell89, "de", "Text", "VL"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell89, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell89, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell9, "Default", "Weight", 0.75000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell9, "de", "Weight", 1.430303006027684D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell90, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell90, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell91, "Default", "Text", "LR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell91, "de", "Text", "HL"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell91, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell91, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell92, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell92, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell93, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell94, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell94, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell95, "Default", "Weight", 0.770000078011074D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell96, "Default", "Text", "9"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell96, "Default", "Weight", 1.2000000834554068D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell96, "de", "Weight", 1.5154762831330966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell97, "Default", "Text", "RF"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell97, "de", "Text", "VR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell97, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell97, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell98, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell98, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell99, "Default", "Text", "RR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell99, "de", "Text", "HR"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell99, "Default", "Weight", 0.25000000000000011D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableCell99, "de", "Weight", 0.31250001219222617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow1, "Default", "Weight", 1.3000001508464096D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow10, "Default", "Weight", 1.300000069724381D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow11, "Default", "Weight", 0.35999999859049603D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow12, "Default", "Weight", 1.3000000662174627D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow13, "Default", "Weight", 0.36000000117826225D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow14, "Default", "Weight", 1.3000000638291813D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow15, "Default", "Weight", 0.36000000303031432D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow16, "Default", "Weight", 1.3000000620983545D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow17, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow18, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow19, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow2, "Default", "Weight", 1.0826088283372961D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow20, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow21, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow22, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow23, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow24, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow25, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow26, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow27, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow28, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow29, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow3, "Default", "Weight", 0.84782602061396062D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow30, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow31, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow32, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow33, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow34, "Default", "Weight", 1.0826088283372961D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow35, "Default", "Weight", 0.84782602061396062D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow36, "Default", "Weight", 1.0695651510487432D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow37, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow38, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow39, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow4, "Default", "Weight", 1.0695651510487432D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow40, "Default", "Weight", 1.3000001508464096D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow41, "Default", "Weight", 0.360000038146976D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow42, "Default", "Weight", 1.3000001094333777D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow43, "Default", "Weight", 0.36000002878248472D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow44, "Default", "Weight", 1.300000109433378D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow45, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow46, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow47, "Default", "Weight", 0.35999999859049603D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow48, "Default", "Weight", 1.3000000662174627D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow49, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow5, "Default", "Weight", 0.360000038146976D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow50, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow51, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow52, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow53, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow54, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow55, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow56, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow57, "Default", "Weight", 1.08D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow6, "Default", "Weight", 1.3000001094333777D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow7, "Default", "Weight", 0.36000002878248472D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow8, "Default", "Weight", 1.300000109433378D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tableRow9, "Default", "Weight", 1.0400000489787078D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 90F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "de", "HeightF", 85.99999F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox1, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox1, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox10, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0001271566F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox10, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox10, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox100, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox100, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox100, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox101, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.525879E-05F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox101, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox101, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox101, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox102, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0002593994F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox102, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox102, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox102, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox11, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.5001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox11, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox11, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox12, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45.00008F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox12, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox12, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox12, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox13, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0001271566F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox13, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox13, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox14, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.5001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox14, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox14, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox15, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45.00008F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox15, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox15, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox15, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox16, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0001271566F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox16, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox16, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox17, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.5001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox17, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox17, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox18, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45.00008F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox18, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox18, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox18, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox19, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox19, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox19, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49998F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox2, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox2, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox2, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox20, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox20, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox20, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox20, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox21, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox21, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox21, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox21, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox22, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox22, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox22, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox22, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox23, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox23, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox23, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox23, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox24, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox24, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox24, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox24, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox25, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox25, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox25, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox25, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox26, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox26, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox26, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox26, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox27, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox27, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox27, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox27, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox28, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox28, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox28, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox28, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox29, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox29, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox29, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox29, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99995F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox3, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox3, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox3, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox30, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox30, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox30, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox30, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox31, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox31, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox31, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox31, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox32, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox32, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox32, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox32, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox33, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox33, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox33, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox33, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox34, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox34, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox34, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox34, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox35, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox35, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox35, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox35, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox36, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox36, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox36, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox36, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox37, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox37, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox37, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox37, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox38, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox38, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox38, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox38, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox39, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox39, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox39, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox39, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0001271566F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox4, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox4, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox40, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox40, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox40, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox40, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox41, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49991F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox41, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox41, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox41, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox42, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99988F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox42, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox42, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox42, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox43, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox43, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox43, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox44, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49976F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox44, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox44, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox44, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox45, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99976F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox45, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox45, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox45, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox46, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(6.103516E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox46, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox46, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox46, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox47, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99976F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox47, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox47, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox47, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox48, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49976F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox48, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox48, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox48, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox49, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.051758E-05F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox49, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox49, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox49, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.5001F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox5, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox5, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox50, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99973F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox50, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox50, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox50, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox51, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49973F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox51, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox51, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox51, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox52, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.051758E-05F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox52, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox52, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox52, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox53, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99973F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox53, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox53, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox53, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox54, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49973F, 0.0001220703F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox54, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox54, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox54, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox55, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.051758E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox55, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox55, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox56, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99973F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox56, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox56, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox56, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox57, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49973F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox57, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox57, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox57, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox58, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 2.288818E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox58, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox58, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox58, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox59, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 2.288818E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox59, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox59, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox59, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45.00008F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox6, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox6, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox6, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox60, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 2.288818E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox60, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox60, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox60, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox61, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 7.629395E-06F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox61, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox61, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox61, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox62, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 7.629395E-06F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox62, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox62, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox62, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox63, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 7.629395E-06F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox63, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox63, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox63, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox64, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox64, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox64, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox64, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox65, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox65, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox65, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox65, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox66, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox66, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox66, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox66, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox67, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox67, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox67, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox67, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox68, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox68, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox68, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox68, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox69, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox69, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox69, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox69, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0001271566F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox7, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox7, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox70, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 1.525879E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox70, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox70, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox70, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox71, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 1.525879E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox71, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox71, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox71, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox72, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 1.525879E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox72, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox72, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox72, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox73, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox73, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox73, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox73, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox74, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox74, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox74, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox74, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox75, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox75, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox75, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox75, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox76, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0003051758F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox76, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox76, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox76, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox77, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50003F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox77, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox77, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox77, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox78, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox78, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox78, "de", "SizeF", new System.Drawing.SizeF(22.50001F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox78, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox79, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99998F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox79, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox79, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox79, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.5001F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox8, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox8, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox80, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox80, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox80, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox80, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox81, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0002861023F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox81, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox81, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox82, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99998F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox82, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox82, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox82, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox83, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.50001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox83, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox83, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox83, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox84, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0002861023F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox84, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox84, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox85, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99995F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox85, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox85, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox85, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox86, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49998F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox86, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox86, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox86, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox87, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0002593994F, 3.051758E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox87, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox87, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox87, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox88, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(44.99995F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox88, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox88, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox88, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox89, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.49998F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox89, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox89, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox89, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox9, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(45.00008F, 6.103516E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox9, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox9, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox9, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox90, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.0002593994F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox90, "Default", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox90, "de", "SizeF", new System.Drawing.SizeF(22.5F, 27F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox90, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox91, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.814697E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox91, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox91, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox92, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.99996F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox92, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox92, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox92, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox93, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(46.00004F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox93, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox93, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox93, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox94, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.814697E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox94, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox94, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox95, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.99996F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox95, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox95, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox95, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox96, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(46.00004F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox96, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox96, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox96, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox97, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.814697E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox97, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox97, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox98, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.99996F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox98, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox98, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox98, "Default", "Text", "checkBox1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox99, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(46.00004F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox99, "Default", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox99, "de", "SizeF", new System.Drawing.SizeF(23F, 32.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCheckBox99, "Default", "Text", "checkBox1")});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parameterLanguage});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EditorKeyStyle,
            this.EditorValueStyle,
            this.GeneralTextStyleStyle,
            this.SectionTitleStyle});
            this.Version = "20.1";
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.Report_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.table6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table6;
        private DevExpress.XtraReports.UI.XRTableRow tableRow37;
        private DevExpress.XtraReports.UI.XRTableCell tableCell73;
        private DevExpress.XtraReports.UI.XRTableCell tableCell74;
        private DevExpress.XtraReports.UI.XRTableRow tableRow38;
        private DevExpress.XtraReports.UI.XRTableCell tableCell75;
        private DevExpress.XtraReports.UI.XRTableCell tableCell76;
        private DevExpress.XtraReports.UI.XRTableRow tableRow39;
        private DevExpress.XtraReports.UI.XRTableCell tableCell77;
        private DevExpress.XtraReports.UI.XRTableCell tableCell78;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow24;
        private DevExpress.XtraReports.UI.XRTableCell tableCell47;
        private DevExpress.XtraReports.UI.XRTableCell tableCell48;
        private DevExpress.XtraReports.UI.XRTableRow tableRow25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell49;
        private DevExpress.XtraReports.UI.XRTableCell tableCell50;
        private DevExpress.XtraReports.UI.XRTableRow tableRow26;
        private DevExpress.XtraReports.UI.XRTableCell tableCell51;
        private DevExpress.XtraReports.UI.XRTableCell tableCell52;
        private DevExpress.XtraReports.UI.XRTableRow tableRow27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell53;
        private DevExpress.XtraReports.UI.XRTableCell tableCell54;
        private DevExpress.XtraReports.UI.XRTableRow tableRow28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell55;
        private DevExpress.XtraReports.UI.XRTableCell tableCell56;
        private DevExpress.XtraReports.UI.XRTableRow tableRow29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell57;
        private DevExpress.XtraReports.UI.XRTableCell tableCell58;
        private DevExpress.XtraReports.UI.XRTableRow tableRow30;
        private DevExpress.XtraReports.UI.XRTableCell tableCell59;
        private DevExpress.XtraReports.UI.XRTableCell tableCell60;
        private DevExpress.XtraReports.UI.XRTableRow tableRow31;
        private DevExpress.XtraReports.UI.XRTableCell tableCell61;
        private DevExpress.XtraReports.UI.XRTableCell tableCell62;
        private DevExpress.XtraReports.UI.XRTableRow tableRow32;
        private DevExpress.XtraReports.UI.XRTableCell tableCell63;
        private DevExpress.XtraReports.UI.XRTableCell tableCell64;
        private DevExpress.XtraReports.UI.XRTableRow tableRow33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell65;
        private DevExpress.XtraReports.UI.XRTableCell tableCell66;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell33;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox3;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox2;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell34;
        private DevExpress.XtraReports.UI.XRTableRow tableRow18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell35;
        private DevExpress.XtraReports.UI.XRTableCell tableCell36;
        private DevExpress.XtraReports.UI.XRTableRow tableRow19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell37;
        private DevExpress.XtraReports.UI.XRTableCell tableCell38;
        private DevExpress.XtraReports.UI.XRTableRow tableRow20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell39;
        private DevExpress.XtraReports.UI.XRTableCell tableCell40;
        private DevExpress.XtraReports.UI.XRTableRow tableRow21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell41;
        private DevExpress.XtraReports.UI.XRTableCell tableCell42;
        private DevExpress.XtraReports.UI.XRTableRow tableRow22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell43;
        private DevExpress.XtraReports.UI.XRTableCell tableCell44;
        private DevExpress.XtraReports.UI.XRTableRow tableRow23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell45;
        private DevExpress.XtraReports.UI.XRTableCell tableCell46;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox4;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableRow tableRow6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableRow tableRow7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableRow tableRow8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableRow tableRow9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableRow tableRow10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableRow tableRow11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTableRow tableRow12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.XRTableRow tableRow13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell26;
        private DevExpress.XtraReports.UI.XRTableRow tableRow14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell28;
        private DevExpress.XtraReports.UI.XRTableRow tableRow15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell30;
        private DevExpress.XtraReports.UI.XRTableRow tableRow16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell31;
        private DevExpress.XtraReports.UI.XRTableCell tableCell32;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRLabel labelCurrentDate;
        private DevExpress.XtraReports.UI.XRLabel label15;
        private DevExpress.XtraReports.UI.XRLabel label14;
        private DevExpress.XtraReports.UI.XRLabel label13;
        private DevExpress.XtraReports.UI.XRLabel label12;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRTable table10;
        private DevExpress.XtraReports.UI.XRTableRow tableRow56;
        private DevExpress.XtraReports.UI.XRTableCell tableCell129;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox24;
        private DevExpress.XtraReports.UI.XRTableCell tableCell130;
        private DevExpress.XtraReports.UI.XRTableCell tableCell131;
        private DevExpress.XtraReports.UI.XRTableCell tableCell132;
        private DevExpress.XtraReports.UI.XRTableRow tableRow57;
        private DevExpress.XtraReports.UI.XRTableCell tableCell133;
        private DevExpress.XtraReports.UI.XRTableCell tableCell134;
        private DevExpress.XtraReports.UI.XRTableCell tableCell135;
        private DevExpress.XtraReports.UI.XRTableCell tableCell136;
        private DevExpress.XtraReports.UI.XRTable table9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow54;
        private DevExpress.XtraReports.UI.XRTableCell tableCell121;
        private DevExpress.XtraReports.UI.XRTableCell tableCell122;
        private DevExpress.XtraReports.UI.XRTableCell tableCell125;
        private DevExpress.XtraReports.UI.XRTableCell tableCell127;
        private DevExpress.XtraReports.UI.XRTableRow tableRow55;
        private DevExpress.XtraReports.UI.XRTableCell tableCell123;
        private DevExpress.XtraReports.UI.XRTableCell tableCell124;
        private DevExpress.XtraReports.UI.XRTableCell tableCell126;
        private DevExpress.XtraReports.UI.XRTableCell tableCell128;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRTable table8;
        private DevExpress.XtraReports.UI.XRTableRow tableRow45;
        private DevExpress.XtraReports.UI.XRTableCell tableCell107;
        private DevExpress.XtraReports.UI.XRTableCell tableCell108;
        private DevExpress.XtraReports.UI.XRTableRow tableRow46;
        private DevExpress.XtraReports.UI.XRTableCell tableCell109;
        private DevExpress.XtraReports.UI.XRTableCell tableCell110;
        private DevExpress.XtraReports.UI.XRTableRow tableRow49;
        private DevExpress.XtraReports.UI.XRTableCell tableCell111;
        private DevExpress.XtraReports.UI.XRTableCell tableCell112;
        private DevExpress.XtraReports.UI.XRTableRow tableRow50;
        private DevExpress.XtraReports.UI.XRTableCell tableCell113;
        private DevExpress.XtraReports.UI.XRTableCell tableCell114;
        private DevExpress.XtraReports.UI.XRTableRow tableRow51;
        private DevExpress.XtraReports.UI.XRTableCell tableCell115;
        private DevExpress.XtraReports.UI.XRTableCell tableCell116;
        private DevExpress.XtraReports.UI.XRTableRow tableRow52;
        private DevExpress.XtraReports.UI.XRTableCell tableCell117;
        private DevExpress.XtraReports.UI.XRTableCell tableCell118;
        private DevExpress.XtraReports.UI.XRTableRow tableRow53;
        private DevExpress.XtraReports.UI.XRTableCell tableCell119;
        private DevExpress.XtraReports.UI.XRTableCell tableCell120;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow34;
        private DevExpress.XtraReports.UI.XRTableCell tableCell67;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell68;
        private DevExpress.XtraReports.UI.XRTableRow tableRow35;
        private DevExpress.XtraReports.UI.XRTableCell tableCell69;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell70;
        private DevExpress.XtraReports.UI.XRTableRow tableRow36;
        private DevExpress.XtraReports.UI.XRTableCell tableCell71;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell72;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRTable table7;
        private DevExpress.XtraReports.UI.XRTableRow tableRow40;
        private DevExpress.XtraReports.UI.XRTableCell tableCell89;
        private DevExpress.XtraReports.UI.XRTableCell tableCell79;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox10;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox11;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell80;
        private DevExpress.XtraReports.UI.XRTableCell tableCell100;
        private DevExpress.XtraReports.UI.XRTableRow tableRow41;
        private DevExpress.XtraReports.UI.XRTableCell tableCell90;
        private DevExpress.XtraReports.UI.XRTableCell tableCell81;
        private DevExpress.XtraReports.UI.XRTableCell tableCell82;
        private DevExpress.XtraReports.UI.XRTableCell tableCell101;
        private DevExpress.XtraReports.UI.XRTableRow tableRow42;
        private DevExpress.XtraReports.UI.XRTableCell tableCell91;
        private DevExpress.XtraReports.UI.XRTableCell tableCell83;
        private DevExpress.XtraReports.UI.XRTableCell tableCell84;
        private DevExpress.XtraReports.UI.XRTableCell tableCell102;
        private DevExpress.XtraReports.UI.XRTableRow tableRow43;
        private DevExpress.XtraReports.UI.XRTableCell tableCell92;
        private DevExpress.XtraReports.UI.XRTableCell tableCell85;
        private DevExpress.XtraReports.UI.XRTableCell tableCell86;
        private DevExpress.XtraReports.UI.XRTableCell tableCell103;
        private DevExpress.XtraReports.UI.XRTableRow tableRow44;
        private DevExpress.XtraReports.UI.XRTableCell tableCell97;
        private DevExpress.XtraReports.UI.XRTableCell tableCell87;
        private DevExpress.XtraReports.UI.XRTableCell tableCell88;
        private DevExpress.XtraReports.UI.XRTableCell tableCell104;
        private DevExpress.XtraReports.UI.XRTableRow tableRow47;
        private DevExpress.XtraReports.UI.XRTableCell tableCell98;
        private DevExpress.XtraReports.UI.XRTableCell tableCell93;
        private DevExpress.XtraReports.UI.XRTableCell tableCell94;
        private DevExpress.XtraReports.UI.XRTableCell tableCell105;
        private DevExpress.XtraReports.UI.XRTableRow tableRow48;
        private DevExpress.XtraReports.UI.XRTableCell tableCell99;
        private DevExpress.XtraReports.UI.XRTableCell tableCell95;
        private DevExpress.XtraReports.UI.XRTableCell tableCell96;
        private DevExpress.XtraReports.UI.XRTableCell tableCell106;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRControlStyle EditorKeyStyle;
        private DevExpress.XtraReports.UI.XRControlStyle EditorValueStyle;
        private DevExpress.XtraReports.UI.XRControlStyle GeneralTextStyleStyle;
        private DevExpress.XtraReports.UI.XRControlStyle SectionTitleStyle;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox49;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox50;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox51;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox52;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox53;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox54;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox55;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox56;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox57;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox19;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox20;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox21;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox22;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox23;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox24;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox25;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox26;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox27;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox28;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox29;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox30;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox31;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox32;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox33;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox34;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox35;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox36;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox37;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox38;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox39;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox40;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox41;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox42;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox43;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox44;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox45;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox46;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox47;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox48;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox1;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox2;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox3;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox4;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox5;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox6;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox7;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox8;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox9;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox10;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox11;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox12;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox13;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox14;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox15;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox16;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox17;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox18;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox79;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox80;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox81;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox85;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox86;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox87;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox82;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox83;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox84;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox88;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox89;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox90;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox58;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox59;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox60;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox61;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox62;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox63;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox64;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox65;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox66;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox67;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox68;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox69;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox70;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox71;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox72;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox73;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox74;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox75;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox76;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox77;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox78;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox91;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox92;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox93;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox94;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox95;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox96;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox97;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox98;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox99;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox101;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox100;
        private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox102;
        private DevExpress.XtraReports.Parameters.Parameter parameterLanguage;
    }
}
