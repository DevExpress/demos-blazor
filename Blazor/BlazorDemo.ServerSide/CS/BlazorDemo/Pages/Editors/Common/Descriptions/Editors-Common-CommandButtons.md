The DevExpress Blazor Editors library ships with built-in command buttons designed to open dropdowns or increase/decrease editor values (via the mouse or keyboard shortcuts).

You can customize [command buttons](https://docs.devexpress.com/Blazor/404267) as follows:

* Hide built-in buttons using `Show***Button` properties.
* Add component-specific command buttons and customize associated appearance:
    * [DxComboBoxDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBoxDropDownButton) — Opens a drop-down menu in the [DxComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) component.
    * [DxDateEditDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEditDropDownButton) — Opens a drop-down calendar in the [DxDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1) component.
    * [DxDropDownBoxDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBoxDropDownButton) — Opens a drop-down window in the [DxDropDownBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox) component. 
    * [DxSpinButtons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinButtons) — Spin buttons that allow you to increase and decrease values in the [DxSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1) component.
    * [DxTimeEditDropDownButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEditDropDownButton) — Opens a drop-down time picker in the [DxTimeEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1) component.

* Use [DxEditorButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxEditorButton) to add a custom button to an editor ([DxComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2), [DxDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1), [DxMaskedInput](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1), [DxDropDownBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDropDownBox), [DxSpinEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1), [DxTextBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox), and [DxTimeEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1)). You can define button appearance and behavior as neccessary.

This sample hides built-in buttons, customizes component-specific buttons, and adds custom buttons to editors as follows:

* ComboBox — "Add Employee" button
* Spin Edit — "Currency" button
* Spin Edit — "Large Increment" button
* Date Edit — "Next Date" and "Previous Date" buttons
* Masked Input — "Send Email" button

You can mark customized component-specific buttons and custom buttons focusable (set the `Focusable` property to `true`). When implemented, buttons are included in the page tab sequence, and users can access them via keyboard:

* **Tab** / **Shift+Tab** - Moves focus through focusable elements on a given page (including buttons).
* **Enter** / **Space** - Invokes a click event handler for a focused button.

Enable the **Focusable Custom Buttons** option to activate this capability in the demo.
