namespace BlazorDemo.CRM.Models {
    public static class Resources {
        static Lazy<List<Resource>> resourcesLazy = new(() => {
            return new List<Resource>() {
                new Resource() { Id = 0, GroupId = 0, Name = "Brett Johnson", BackgroundCss = "resource-0-bg", TextCss = "resource-0-text" },
                new Resource() { Id = 1, GroupId = 0, Name = "Tasks", BackgroundCss = "resource-1-bg", TextCss = "resource-1-text" },
                new Resource() { Id = 2, GroupId = 0, Name = "Reminder", BackgroundCss = "resource-2-bg", TextCss = "resource-2-text" },
                new Resource() { Id = 3, GroupId = 0, Name = "Contacts", BackgroundCss = "resource-3-bg", TextCss = "resource-3-text"},
                new Resource() { Id = 4, GroupId = 1, Name = "Holidays", BackgroundCss = "resource-4-bg", TextCss = "resource-4-text" }
            };
        }, true);

        static Lazy<List<Resource>> resourceGroupsLazy = new(() => {
            return new List<Resource>() {
                new Resource() { Id = 0, Name = "My Calendars", IsGroup = true },
                new Resource() { Id = 1, Name = "Other Calendars", IsGroup = true }
            };
        }, true);

        public static List<Resource> GetResources() => resourcesLazy.Value;

        public static List<Resource> GetResourceGroups() => resourceGroupsLazy.Value;
    }

    public class Resource {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public required string Name { get; set; }
        public bool IsGroup { get; set; }
        public string? BackgroundCss { get; set; }
        public string? TextCss { get; set; }
        public override bool Equals(object? obj) {
            Resource? resource = obj as Resource;
            return resource != null && resource.Id == Id;
        }
        public override int GetHashCode() => Id;
    }
}
