using Kontrolnaja_Rabota_Po_ASP_API.Model;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db
{
    public class ProductInOrderDb
    {
        public int Id { get; set; }
        public OrderDb? OrderDb { get; set; }
        public ProductDb? ProductDb { get; set; }
        public int QuantityProductInOrder { get; set; }
    }
}
