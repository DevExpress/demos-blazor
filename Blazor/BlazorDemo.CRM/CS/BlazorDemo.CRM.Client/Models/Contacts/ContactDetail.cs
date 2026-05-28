using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BlazorDemo.CRM.Utils;

namespace BlazorDemo.CRM.Models {
    public class ContactDetail {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Required] public string? FirstName { get; set; }
        [Required] public string? LastName { get; set; }
        [Required] public string? City { get; set; }
        public State? State { get; set; }
        [Required] public string? StateShort { get => State?.StateShort; set => (State ??= new()).StateShort = value; }
        [Required] public int? ZipCode { get; set; }
        [Required] public string? Status { get; set; }
        [Required] public string? Company { get; set; }
        [Required] public string? Position { get; set; }
        [Required] public string? Manager { get; set; }
        [Required, JsonConverter(typeof(PhoneConverter))] public string? Phone { get; set; }
        [Required] public string? Email { get; set; }
        [Required] public string? Address { get; set; }

        public List<Activity>? Activities { get; set; }

        public List<Opportunity>? Opportunities { get; set; }
        public List<Note>? Notes { get; set; }

        public List<WorkTask>? Tasks { get; set; }

        public byte[]? Image { get; set; }

        public void Copy(ContactDetail from, Action<string>? onFieldChanged = null) {
            if(Id != from.Id) {
                Id = from.Id;
                onFieldChanged?.Invoke(nameof(ContactDetail.Id));
            }
            if(Name != from.Name) {
                Name = from.Name;
                onFieldChanged?.Invoke(nameof(ContactDetail.Name));
            }
            if(FirstName != from.FirstName) {
                FirstName = from.FirstName;
                onFieldChanged?.Invoke(nameof(ContactDetail.FirstName));
            }
            if(LastName != from.LastName) {
                LastName = from.LastName;
                onFieldChanged?.Invoke(nameof(ContactDetail.LastName));
            }
            if(Status != from.Status) {
                Status = from.Status;
                onFieldChanged?.Invoke(nameof(ContactDetail.Status));
            }
            if(Position != from.Position) {
                Position = from.Position;
                onFieldChanged?.Invoke(nameof(ContactDetail.Position));
            }
            if(Company != from.Company) {
                Company = from.Company;
                onFieldChanged?.Invoke(nameof(ContactDetail.Company));
            }
            if(Manager != from.Manager) {
                Manager = from.Manager;
                onFieldChanged?.Invoke(nameof(ContactDetail.Manager));
            }
            if(Address != from.Address) {
                Address = from.Address;
                onFieldChanged?.Invoke(nameof(ContactDetail.Address));
            }
            if(City != from.City) {
                City = from.City;
                onFieldChanged?.Invoke(nameof(ContactDetail.City));
            }
            if(ZipCode != from.ZipCode) {
                ZipCode = from.ZipCode;
                onFieldChanged?.Invoke(nameof(ContactDetail.ZipCode));
            }
            if(StateShort != from.StateShort) {
                StateShort = from.StateShort;
                onFieldChanged?.Invoke(nameof(ContactDetail.StateShort));
            }
            if(Phone != from.Phone) {
                Phone = from.Phone;
                onFieldChanged?.Invoke(nameof(ContactDetail.Phone));
            }
            if(Email != from.Email) {
                Email = from.Email;
                onFieldChanged?.Invoke(nameof(ContactDetail.Email));
            }
        }
    }
}
