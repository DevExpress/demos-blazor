namespace BlazorDemo.CRM.Models {
    public class Opportunity {
        public string? Name { get; set; }
        public double Total { get; set; }
        public double Price { get => Total; set => Total = value; }
        public int Products { get; set; }
        public string? Manager { get; set; }
    }
}
