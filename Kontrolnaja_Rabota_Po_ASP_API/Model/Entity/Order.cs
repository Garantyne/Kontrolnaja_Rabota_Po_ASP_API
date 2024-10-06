namespace Kontrolnaja_Rabota_Po_ASP_API.Model.Entity
{
    public class Order
    {
        public string Shiphr { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public DateTime DateOfFormation { get; set; }
        public List<Product>? Items { get; set; }

        public Order() { }
    }
}
