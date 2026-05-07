namespace AdvancedRoutingMVC.Models
{
    public class Product
    {
        public string Category { get; set; }

        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
    }
}