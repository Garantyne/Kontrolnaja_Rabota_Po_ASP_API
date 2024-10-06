namespace Kontrolnaja_Rabota_Po_ASP_API.Model.Entity
{
    public class ProductInOrder
    {
        public Order? Order { get; set; }
        public Product? Product { get; set; }
        public int QuantityProductInOrder { get; set; }
    }
}
