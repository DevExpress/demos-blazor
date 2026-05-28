using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.NorthwindTraders {
    public partial class CatalogReport : DevExpress.XtraReports.UI.XtraReport {

        public CatalogReport() {
            InitializeComponent();

            Name = ReportNames.NorthwindTraders_CatalogName;
            DisplayName = ReportNames.NorthwindTraders_Catalog;

            parameterSortGroupsType.Type = typeof(SortGroupsType);
            parameterSortGroupsType.Value = SortGroupsType.Count;
            parameterSortGroupsOrder.Type = typeof(XRColumnSortOrder);
            parameterSortGroupsOrder.Value = XRColumnSortOrder.Ascending;

            UpdateGroupSortingSummary();
        }

        void UpdateGroupSortingSummary() {
            GroupHeader1.SortingSummary.Enabled = true;
            GroupHeader1.SortingSummary.FieldName = "UnitPrice";
            if(parameterSortGroupsOrder.Value is XRColumnSortOrder)
                GroupHeader1.SortingSummary.SortOrder = (XRColumnSortOrder)parameterSortGroupsOrder.Value;
            GroupHeader1.SortingSummary.IgnoreNullValues = true;

            SortGroupsType sortGroupsType = parameterSortGroupsType.Value is SortGroupsType
                ? (SortGroupsType)parameterSortGroupsType.Value
                : SortGroupsType.Count;

            switch(sortGroupsType) {
                case SortGroupsType.None:
                    GroupHeader1.SortingSummary.Enabled = false;
                    break;
                case SortGroupsType.Count:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Count;
                    break;
                case SortGroupsType.TotalSales:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Sum;
                    GroupHeader1.SortingSummary.FieldName = "ProductSales";
                    break;
                case SortGroupsType.LowestPrice:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Min;
                    break;
                case SortGroupsType.HighestPrice:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Max;
                    break;
            }
        }
        protected override void OnBeforePrint(System.ComponentModel.CancelEventArgs e) {
            base.OnBeforePrint(e);
            UpdateGroupSortingSummary();
        }
    }
}
