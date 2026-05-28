using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.CRM.Models {
    public class Note {
        [Required]
        public string? Text { get; set; }
        public DateTime? Date { get; set; }
        public string? Manager { get; set; }
    }
}
