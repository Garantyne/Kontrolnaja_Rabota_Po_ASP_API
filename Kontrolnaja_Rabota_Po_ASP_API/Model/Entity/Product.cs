namespace Kontrolnaja_Rabota_Po_ASP_API.Model.Entity
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsPresent { get; set; }
        public Order? Order { get; set; }

        public Product() { }

    }
}
