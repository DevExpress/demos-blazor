The DevExpress Blazor Grid allows you to display Context Menus with both predefined and custom commands. Use the [ContextMenus](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ContextMenus) property to activate Context Menus for specific Grid elements. Handle the [CustomizeContextMenu](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeContextMenu) event to modify the menu item collection.

This demo uses Context Menus for the following Blazor Grid elements:

- Group Panel
- Column Headers
- Data Rows (custom item deletes the row)
- Footer Cells (custom items add/remove total summaries)
- Group Footer Cells (custom items add/remove group summaries)

To invoke the context menu at runtime, you can right-click (on mouse-equipped devices) or long press (on touch-enabled devices, [except for iOS](https://docs.devexpress.com/Blazor/403291/troubleshooting/navigation-component-related-issues/ios-device-does-not-display-the-context-menu)) the area where you want to display the context menu.