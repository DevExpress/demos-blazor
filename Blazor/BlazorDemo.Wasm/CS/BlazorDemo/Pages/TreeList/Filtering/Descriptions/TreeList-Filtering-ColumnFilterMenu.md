The DevExpress Blazor TreeList includes column filter menus — Excel-inspired drop-down lists used to filter column values. You can access these menus using column header buttons.

Use the **Display Filter Menu Buttons** option to specify filter button visibility. Click a button to open the filter menu, select/deselect values, and view results within the DevExpress Blazor TreeList. Note: The **Progress** column uses a custom template to display a filter value list.

**Tips**:

- The size grip in the corner of the filter menu allows you to resize the menu.
- Once you apply a filter to a column, filter menus across other columns hide values that do not match the current criteria. Hold down `Shift` and click a filter button to display all values.
- You can focus a column header and press `Alt`+`Down Arrow` or `Shift`+`Alt`+`Down Arrow` to open the filter menu.

Specify [FilterMenuButtonDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FilterMenuButtonDisplayMode) at the component/column level to activate filter menus for all/specific columns within your project/app. Handle the [CustomizeFilterMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeFilterMenu) event to customize filter items. Use [DataColumnFilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.DataColumnFilterMenuTemplate) or [FilterMenuTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListDataColumn.FilterMenuTemplate) to display custom content within filter menus. Refer to the following help topic for additional information: [Column Filter Menu](https://docs.devexpress.com/Blazor/405186/components/treelist/data-shaping/filter-data/filter-menu).
