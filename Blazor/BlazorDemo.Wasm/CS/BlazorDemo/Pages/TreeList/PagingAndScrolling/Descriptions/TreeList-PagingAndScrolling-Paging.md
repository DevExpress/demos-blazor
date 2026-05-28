The DevExpress Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist?v=26.1) can split data into pages and display a built-in navigation control (pager). Vertical/horizontal scrollbars also appear if content height/width exceeds component size.

In this demo, you can use toolbar items to customize pager appearance:

- Toggle [page size selector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PageSizeSelectorVisible?v=26.1) visibility.
- Toggle [pager summary](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerSummaryVisible?v=26.1) visibility.
- Specify [navigation controls](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerNavigationMode?v=26.1) displayed within the pager:
    - `InputBox` — An input box where users can enter a page number.
    - `NumericButtons` — Numeric buttons (1, 2, 3, etc.)
    - `Auto` — The pager switches from numeric buttons to the input box on small devices or when page count reaches the [PagerSwitchToInputBoxButtonCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerSwitchToInputBoxButtonCount?v=26.1) limit.
- Change [pager position](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.PagerPosition?v=26.1).

You can use keyboard shortcuts to navigate between pages. Focus the pager area and press the `Left Arrow`/`Right Arrow` to go to the previous/next page. To open the first/last page, focus the pager area and press `Home`/`End`.
