In this demo, the DevExpress Blazor Grid displays an in-place editor when a user clicks a data cell. Users can edit the current cell and activate editors for other cells within the same row. When focus moves to a different row, the component validates user input and saves changes.

To enable cell editing:

1. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditMode) property to `EditCell`.
2. If your data object has a primary key, assign it to the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldName) or [KeyFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyFieldNames) property. The Grid uses field values to compare and identify data items. If you do not specify these properties, the Grid uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
3. (Optional) Declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template to allow users to create and delete data rows. In addition to predefined **New** and **Delete** buttons, this column displays **Edit**, **Save**, and **Cancel** commands that are redundant in cell editing mode. Disable [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.EditButtonVisible), [CancelButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CancelButtonVisible), and [SaveButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.SaveButtonVisible) properties to hide these buttons.
4. Handle the following events to make final data changes, check access permissions, post changes to the underlying data source, and reload Grid data:
    - [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    - [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog.
5. (Optional) Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeEditModel) event to initialize an edit model for new data rows.

You can use the following [keyboard shortcuts](https://docs.devexpress.com/Blazor/404652/components/grid/keyboard-support) in cell editing mode:

**Enter / Shift+Enter**

Opens an in-place editor for the focused cell (if not already open). 

If an in-place editor is already open, **Enter** applies changes and closes the editor. Focus can then move to the next/previous cell depending on the [EnterKeyDirection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EnterKeyDirection) property. If the [EditNextCellOnEnter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditNextCellOnEnter) option is enabled, the Grid component opens an in-place editor in the next cell. Use checkboxes above the component to try these options.

**Note:** <kbd>Shift</kbd>+<kbd>Enter</kbd> moves focus in the opposite direction.

**Esc**

Hides the in-place editor and discards changes made in that cell.

If the in-place editor is hidden, discards all changes made in the row and cancels row editing.

**Tab / Shift+Tab**

Hides the editor, focuses the next/previous data cell, and displays an editor in the newly focused cell.

**Start typing in a focused cell**

When the [EditOnKeyPress](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditOnKeyPress) property is enabled, users can start editing a cell by entering a value within it. The editor opens automatically and accepts entered characters. Select the **Edit on Key Press** option to try it out.

In this demo, you can open a context menu to test edit cell mode in combination with other Grid features.

For additional information on how you can enable data editing and use edit-related options, refer to the following help topic: [Edit Cell](https://docs.devexpress.com/Blazor/404756/components/grid/editing-and-validation/edit-modes/edit-cell).
