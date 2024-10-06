using Kontrolnaja_Rabota_Po_ASP_API.Model.Entity;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db.Repository
{
    public interface IProductRepository
    {
        Task<Product> AddAsync(Product product);
        void Delete(int id);
        void Edit(int id, Product product);
        Task<Product> GetAsync(int id);
        Task<Product> GetByName(string name);
        Task<List<Product>> ListAll();
    }
}
