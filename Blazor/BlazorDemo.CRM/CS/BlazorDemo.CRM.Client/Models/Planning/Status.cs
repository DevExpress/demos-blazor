using System.Drawing;

namespace BlazorDemo.CRM.Models {
    public class Status {
        public required int Id { get; set; }
        public required string Caption { get; set; }
        public required Color Color { get; set; }
    }

    public static class Statuses {
        static Lazy<List<Status>> statusesLazy = new(() => {
            return new List<Status>() {
                new Status() { Id = 0, Caption = "Open", Color = ColorTranslator.FromHtml("#eeeeee") },
                new Status() {Id = 1, Caption = "In Progress", Color = ColorTranslator.FromHtml("#bd4b0f") },
                new Status() {Id = 2, Caption = "Completed", Color = ColorTranslator.FromHtml("#0da133") },
                new Status() {Id = 3, Caption = "Deferred", Color = ColorTranslator.FromHtml("#bd0f0f") },
            };
        }, true);

        public static List<Status> GetStatuses() => statusesLazy.Value;
    }
}
