using System.Collections.Generic;
using DevExpress.Images.Blazor;

namespace BlazorDemo.Data {
    public static class ComponentSets {
        private static readonly List<ComponentSet> componentSets =  new List<ComponentSet>() {
                new ComponentSet("Components", componentSets:
                    new List<ComponentSet>() {
                        new ComponentSet("Data Grid", IconStatic.TableSelectCursor.BlazorClassic.Regular.Monochrome.Size16, IconStatic.TableSelectCursor.Fluent.Filled.Monochrome.Size16,
                            "The DevExpress Data Grid for Blazor allows you to display and manage data in a tabular format."),
                        new ComponentSet("Pivot Grid", IconStatic.TableCalculator.BlazorClassic.Regular.Monochrome.Size16, IconStatic.TableCalculator.Fluent.Filled.Monochrome.Size16,
                            "The DevExpress Pivot Grid for Blazor allows you to display and analyze multi-dimensional data from an underlying data source."),
                        new ComponentSet("Charts", IconStatic.DataBarVerticalAscending.BlazorClassic.Regular.Monochrome.Size16, IconStatic.DataBarVerticalAscending.Fluent.Filled.Monochrome.Size16,
                            "DevExpress Charts for Blazor help you transform data to its most appropriate, concise, and readable visual representation."),
                        new ComponentSet("Scheduler", IconStatic.Calendar.BlazorClassic.Regular.Monochrome.Size16, IconStatic.Calendar.Fluent.Filled.Monochrome.Size16,
                            "The DevExpress Scheduler for Blazor allows you to create, display, and edit scheduled appointments in a calendar format."),
                        new ComponentSet("Data Editors", IconStatic.TextEdit.BlazorClassic.Regular.Monochrome.Size16, IconStatic.TextEdit.Fluent.Filled.Monochrome.Size16,
                            "DevExpress Data Editors for Blazor include components that can be used as standalone editors or within the Data Grid edit form."),
                    }
                )
            };

        public static List<ComponentSet> Data { get { return componentSets; } }
    }
}
