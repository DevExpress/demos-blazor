In this demo, the DevExpress Blazor Grid component is bound to a dataset that contains one thousand columns and over one million rows. Navigate between data records or edit/sort/group/filter data to explore DevExpress Blazor Grid performance capabilities.

The demo uses the following performance-related optimizations/options:

- [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) — A data source type designed to work with large datasets. It delegates data processing operations to an underlying query provider and loads only data required for screen display.
- [Virtual scrolling](https://docs.devexpress.com/Blazor/404753/components/grid/paging-and-scrolling/scrolling#virtual-scrolling) — Once activated, our Blazor Grid renders only a subset of rows/columns based on viewport size and loads additional cells dynamically (as users scroll).
- [Skeleton Rows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SkeletonRowsEnabled) — Allows you to activate skeleton rendering while cells are loading.
