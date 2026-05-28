The DevExpress Blazor Pivot Table component can display and analyze multi-dimensional data with absolute ease. In this demo, our Pivot Table is bound to a local data collection with 100,000 records. The Pivot Table leverages its built-in [virtual scrolling mode](https://docs.devexpress.com/Blazor/405626/components/pivottable/scrolling) to maximize overall performance. You can click the **Refresh** button to generate a new dataset and assign it to the Pivot Table.

To replicate this sample, you must:

1. Bind the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PivotTable.DxPivotTable.Data) property to a C# field/property.
2. Handle the `OnInitialized`/`OnInitializedAsync` lifecycle method. In the event handler, populate this field/property with an [IListSource](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ilistsource) or [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1) dataset.
3. Add [fields](https://docs.devexpress.com/Blazor/405459/components/pivottable/pivot-table-basics#add-fields) to the component.
