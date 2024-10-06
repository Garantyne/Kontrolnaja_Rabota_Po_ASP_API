using Microsoft.EntityFrameworkCore;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<OrderDb> _orderDbs { get; set; }
        public DbSet<ProductDb> _productsDb { get; set; }
        public DbSet<ProductInOrderDb> _productInOrderDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            string useConnection = configuration.GetSection("UseConnection").Value ?? "DefaultConnection";
            string? connectionString = configuration.GetConnectionString(useConnection);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
