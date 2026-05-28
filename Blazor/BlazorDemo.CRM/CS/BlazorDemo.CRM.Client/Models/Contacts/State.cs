namespace BlazorDemo.CRM.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string? StateShort { get; set; }
        public string? StateLong { get; set; }
        public string? StateCoords { get; set; }

        public string? Flag48px { get; set; }
        public string? Flag24px { get; set; }

        public string? SSSMATimestamp { get; set; }

        public List<ContactDetail>? Contacts { get; set; }
    }
}
