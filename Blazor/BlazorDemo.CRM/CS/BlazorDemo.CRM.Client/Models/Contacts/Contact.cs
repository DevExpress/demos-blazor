using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BlazorDemo.CRM.Utils;

namespace BlazorDemo.CRM.Models {
    public class Contact {
        public int Id { get; set; }

        [Required] public string? Name { get; set; }
        [Required] public string? Status { get; set; }
        [Required] public string? Company { get; set; }
        [Required] public string? Position { get; set; }
        [Required] public string? AssignedTo { get; set; }
        [Required, JsonConverter(typeof(PhoneConverter))] public string? Phone { get; set; }
        [Required] public string? Email { get; set; }
    }
}
