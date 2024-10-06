using Kontrolnaja_Rabota_Po_ASP_API.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteById(int id)
        {
            OrderDb odb = await _context._orderDbs.FirstOrDefaultAsync(x => x.Id == id);
            if (odb != null)
            {
                _context.Remove(odb);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<Order> GetById(int id)
        {
            OrderDb odb = await _context._orderDbs.FirstOrDefaultAsync(c => c.Id == id);
            if (odb == null)
            {
                throw new NullReferenceException("Такого заказа в списке нет");
            }
            return new Order()
            {
                ClientName = odb.ClientName,
                DateOfFormation = odb.DateOfFormation,
                Shiphr = odb.Shiphr
            };
        }

        public async Task<List<Order>> GetList()
        {
            List<OrderDb> odb = await _context._orderDbs.
                                        ToListAsync();
            List<Order> orders = odb.Select(orderDb => new Order
            {
                Shiphr = orderDb.Shiphr,
                ClientName = orderDb.ClientName,
                DateOfFormation = orderDb.DateOfFormation
            }).ToList();
        
            return orders;
        }
    }
}
