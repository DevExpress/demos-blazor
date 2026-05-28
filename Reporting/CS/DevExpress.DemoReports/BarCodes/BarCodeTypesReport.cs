using System;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.BarCodes {
    public partial class BarCodeTypesReport : XtraReport {
        static BarCodeTypesReport() {
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(typeof(XRBarCode), "AutoModule", new DevExpress.XtraReports.Expressions.ExpressionBindingDescription(new[] { "BeforePrint" }, 1000, Array.Empty<string>()));
        }

        public BarCodeTypesReport() {
            InitializeComponent();
            Name = ReportNames.BarCodes_BarcodeTypesName;
            DisplayName = ReportNames.BarCodes_BarcodeTypes;
        }
    }
}
