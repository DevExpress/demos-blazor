To use the DevExpress Icon Library in your DevExpress-powered Blazor app, install the `DevExpress.Images.Blazor` NuGet package and register the corresponding namespace. You can assign icons to Blazor components using their `IconUrl` properties (such as [DxAccordionItem.IconUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxAccordionItem.IconUrl) or [DxRibbonItem.IconUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRibbonButtonBase-1.IconUrl)).

This demo assigns icons to commands in the DevExpress [Blazor Ribbon](https://docs.devexpress.com/Blazor/405288/components/navigation-controls/ribbon) component. Each command references an icon using an adaptive identifier (metaphor). Such identifiers only include icon names and do not specify size or style attributes. The framework automatically selects the appropriate icon version based on current theme and UI settings.

Switch between themes and size modes to see how icons adapt to different UI settings.
