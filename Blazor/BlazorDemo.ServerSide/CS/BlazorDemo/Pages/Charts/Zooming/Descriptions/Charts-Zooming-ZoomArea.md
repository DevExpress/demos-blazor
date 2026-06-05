The DevExpress Blazor [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows users to zoom a specific chart region (when the [AllowDragToZoom](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.AllowDragToZoom) option is active). To pan the chart when zoomed, drag the mouse while pressing the specified [PanKey](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.PanKey) (**Shift** in this demo).

You can use the [DxChartZoomAndPanDragBoxStyle](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanDragBoxStyle) object to customize drag (selection) box appearance settings, such as [Color](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanDragBoxStyle.Color) and [Opacity](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanDragBoxStyle.Opacity).

When the [AllowDragToZoom](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.AllowDragToZoom) property is set to `false`, users can pan the chart with the mouse or use touch gestures without pressing any key.

When you zoom or pan the chart, axis visual ranges change. You can handle the [VisualRangeChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.VisualRangeChanged) event to react to changes. Call the following methods to modify visual ranges:

* [ResetVisualRange](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.ResetVisualRange) — Resets visual ranges for all axes to match a data range. 
* [SetArgumentAxisVisualRange](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.SetArgumentAxisVisualRange(System.Collections.Generic.List-System.Object-)) — Sets the visual range for the argument axis.
* [SetValueAxisVisualRange](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.SetValueAxisVisualRange(System.Collections.Generic.List-System.Object--System.String)) — Sets the visual range for a specific value axis.

In this demo, these methods implement accessibility-friendly zoom and pan operations (that conforms to the [Dragging Movements](https://www.w3.org/WAI/WCAG22/Understanding/dragging-movements.html) criteria). Click toolbar items to zoom/pan the chart plane or reset axes visual range.
