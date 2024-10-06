using Kontrolnaja_Rabota_Po_ASP_API.Model;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db
{
    public class ProductDb
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsPresent { get; set; }
        public List<ProductInOrderDb>? ProducsInOrder { get; set; }
    }
}
