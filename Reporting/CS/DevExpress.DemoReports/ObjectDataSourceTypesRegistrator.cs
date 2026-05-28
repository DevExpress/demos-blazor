using DevExpress.Utils;

namespace XtraReportsDemos {
    public static class ObjectDataSourceTypesRegistrator {
        public static void RegisterTrustedTypes() {
            DeserializationSettings.RegisterTrustedClass(typeof(BalanceSheetReport.BalanceSheetData));
            DeserializationSettings.RegisterTrustedClass(typeof(CachedDocumentSourceReport.DataItemList));
            DeserializationSettings.RegisterTrustedClass(typeof(CarryoverSummaryReport.DataSource));
            DeserializationSettings.RegisterTrustedClass(typeof(HierarchicalReport.DataSource));
            DeserializationSettings.RegisterTrustedClass(typeof(MultiColumnReport.DataSource));
            DeserializationSettings.RegisterTrustedClass(typeof(ProfitAndLossReport.Data));
            DeserializationSettings.RegisterTrustedClass(typeof(RestaurantMenu.DataSource));
            DeserializationSettings.RegisterTrustedClass(typeof(SwissQRCode.BillDS));
            DeserializationSettings.RegisterTrustedClass(typeof(NorthwindTraders.SortGroupsType));

            DeserializationSettings.RegisterTrustedClass(typeof(PollingReport.ResultingData));
        }
    }
}
