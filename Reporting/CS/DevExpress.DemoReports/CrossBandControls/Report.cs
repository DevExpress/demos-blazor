using System.Drawing;
using DevExpress.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CrossBandControls {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.CrossBandsName;
            DisplayName = ReportNames.CrossBands;
            BeforePrint += Report_BeforePrint;
        }

        void Report_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            SetFillEmptySpace();
        }

        public void SetFillEmptySpace() {
            if((bool)DrawZBelowTheTableParameter.Value) {
                GroupFooter1.PrintAtBottom = false;
                FillEmptySpace += report_FillEmptySpace;
            }
            else {
                GroupFooter1.PrintAtBottom = true;
                FillEmptySpace -= report_FillEmptySpace;
            }
        }

        private void report_FillEmptySpace(object sender, BandEventArgs e) {
            if(!(bool)DrawZBelowTheTableParameter.Value) {
                FillEmptySpace -= report_FillEmptySpace;
                return;
            }
            int bandHeight = GraphicsUnitConverter.Convert(e.Band.Height, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi());
            if(bandHeight <= 30)
                return;
            Size size = new Size(612, bandHeight - 30);
            Size sizeInPixels = XRConvert.Convert(size, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel);
            DXBitmap zBitmap = new DXBitmap(sizeInPixels.Width, sizeInPixels.Height);
            DXGraphics gr = DXGraphics.FromImage(zBitmap);
            using(DXPen pen = new DXPen(Color.FromArgb(205, 205, 205), 4)) {
                Point[] points = new Point[] {
                    new Point(0, 4),
                    new Point(sizeInPixels.Width, 4),
                    new Point(0, sizeInPixels.Height - 4),
                    new Point(sizeInPixels.Width, sizeInPixels.Height - 4)
                };
                gr.DrawLines(pen, points);
            }
            XRPictureBox pictureBox = new XRPictureBox();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Size = size;
            pictureBox.Location = new Point(19, 15);
            pictureBox.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(zBitmap);
            e.Band.Controls.Add(pictureBox);
        }
    }
}
