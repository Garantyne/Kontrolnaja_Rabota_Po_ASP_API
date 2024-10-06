using Kontrolnaja_Rabota_Po_ASP_API.Model.Entity;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db.Repository
{
    public interface IOrderRepository
    {
        Task<bool> DeleteById(int id);
        Task<Order> GetById(int id);
        Task<List<Order>> GetList();
    }
}
