using System.Linq;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.Parameters;

namespace XtraReportsDemos.ReportMerging {
    public partial class ChartReport : DevExpress.XtraReports.UI.XtraReport {
        public ChartReport() {
            InitializeComponent();

            Name = ReportNames.ChartName;
            DisplayName = ReportNames.Chart;

            System.Collections.Generic.IEnumerable<LookUpValue> lookups = xrChart1
                .GetAppearanceNames()
                .Select(x => new LookUpValue { Value = x });

            AppearanceParameter.Value = xrChart1.AppearanceName;
            ((StaticListLookUpSettings)AppearanceParameter.LookUpSettings).LookUpValues.AddRange(lookups);
        }

        void Report_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            xrChart1.AppearanceName = (string)AppearanceParameter.Value;

            bool colorEach = (bool)ColorEachParameter.Value;
            foreach(Series series in xrChart1.Series) {
                if(series.View is SeriesViewColorEachSupportBase)
                    ((SeriesViewColorEachSupportBase)series.View).ColorEach = colorEach;
                else if(series.View is SeriesView3DColorEachSupportBase)
                    ((SeriesView3DColorEachSupportBase)series.View).ColorEach = colorEach;
            }
        }
    }
}
