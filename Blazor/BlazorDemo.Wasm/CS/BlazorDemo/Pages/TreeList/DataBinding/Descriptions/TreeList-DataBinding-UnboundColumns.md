The [DevExpress Blazor TreeList](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList) allows you to display values not stored in the assigned data source (using unbound columns). This demo includes two unbound columns:

* **Q2 Sales** — Values are calculated based on data in other columns and the use of [UnboundExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.UnboundExpression?v=26.1).
* **Q2 YoY Change (%)** — Values are calculated in the [UnboundColumnData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.UnboundColumnData?v=26.1) event handler.

**Note**: Unbound columns must use [FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FieldName) values that have no matching field name values in the TreeList data source.
