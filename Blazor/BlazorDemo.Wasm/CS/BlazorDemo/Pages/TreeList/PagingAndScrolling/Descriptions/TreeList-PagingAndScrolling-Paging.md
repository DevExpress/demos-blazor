The DevExpress Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) can split data into pages and display a built-in navigation control (pager). Vertical/horizontal scrollbars also appear if content height/width exceed the component size.

In this demo, you can use toolbar items to customize pager appearance:

- Toggle [page size selector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageSizeSelectorVisible) visibility.
- Toggle [pager summary](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerSummaryVisible) visibility.
- Specify [navigation controls](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerNavigationMode) displayed within the pager:
    - `InputBox` — An input box where users can enter a page number.
    - `NumericButtons` — Numeric buttons (1, 2, 3, etc.)
    - `Auto` — The pager switches from numeric buttons to the input box on small devices or when the page count reaches the [PagerSwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerSwitchToInputBoxButtonCount) limit.
- Change [pager position](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerPosition).

You can use keyboard shortcuts to navigate between pages. Focus the pager area and press the `Left Arrow`/`Right Arrow` to go to the previous/next page. To open the first/last page, focus the pager area and press `Home`/`End`.
