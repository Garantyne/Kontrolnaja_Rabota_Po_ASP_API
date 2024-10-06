using Kontrolnaja_Rabota_Po_ASP_API.Model;
using Microsoft.EntityFrameworkCore;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db
{
    [Index(nameof(Shiphr), IsUnique = true)]
    public class OrderDb
    {
        public int Id { get; set; }
        public string Shiphr { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public DateTime DateOfFormation { get; set; }
        public List<ProductInOrderDb>? ProducsInOrder { get; set; }
    }
}
