In this demo, the DevExpress Blazor TreeList displays an in-place editor when a user clicks a data cell. Users can edit the current cell and activate editors for other cells within the same row. When focus moves to a different row, the component validates user input and saves changes.

To enable cell editing:

1. Set the [EditMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditMode) property to `EditCell`.
2. Specify the [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName) property. If not set, the TreeList uses standard [.NET value equality comparison](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/equality-comparisons) to identify data items.
3. Handle the [CustomizeEditModel](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomizeEditModel) event to initialize an edit model for new data rows (set predefined cell values and link new nodes to their parent).
4. (Optional) Declare a [DxTreeListCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Columns) template to create and delete data rows. In addition to predefined **New** and **Delete** buttons, this column displays **Edit**, **Save**, and **Cancel** commands that are redundant in cell editing mode. Disable [EditButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.EditButtonVisible), [CancelButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.CancelButtonVisible), and [SaveButtonVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListCommandColumn.SaveButtonVisible) properties to hide these buttons.
5. Handle the following events to make final data changes, check access permissions, post changes to the underlying data source, and reload TreeList data:
    - [EditModelSaving](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditModelSaving) — Fires when a user saves the edited row and validation passes.
    - [DataItemDeleting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.DataItemDeleting) — Fires when a user confirms the delete operation in the delete confirmation dialog.

You can use the following [keyboard shortcuts](https://docs.devexpress.com/Blazor/405207/components/treelist/keyboard-support) in cell editing mode:

**Enter / Shift+Enter**

Opens an in-place editor for the focused cell (if not already open).

If an in-place editor is already open, **Enter** applies changes and closes the editor. Focus can then move to the next/previous cell depending on the [EnterKeyDirection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EnterKeyDirection) property. If the [EditNextCellOnEnter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditNextCellOnEnter) option is enabled, the TreeList component opens an in-place editor in the next cell. Use checkboxes above the component to try these options.

**Note:** <kbd>Shift</kbd>+<kbd>Enter</kbd> moves focus in the opposite direction.

**Esc**

Hides the in-place editor and discards changes made in that cell.

If the in-place editor is hidden, discards all changes made in the row and cancels row editing.

**Tab / Shift+Tab**

Hides the editor, focuses the next/previous data cell, and displays an editor in the newly focused cell.

**Start typing in a focused cell**

When the [EditOnKeyPress](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditOnKeyPress) property is enabled, users can start editing a cell by entering a value within it. The editor opens automatically and accepts entered characters. Select the **Edit on Key Press** option to try it out.

In this demo, you can open a context menu to test edit cell mode in combination with other TreeList features.

For additional information on how you can enable data editing and use edit-related options, refer to the following help topic: [Edit Cell](https://docs.devexpress.com/Blazor/405166/components/treelist/editing-and-validation/edit-modes/edit-cell).
