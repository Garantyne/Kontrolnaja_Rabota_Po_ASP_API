using Kontrolnaja_Rabota_Po_ASP_API.Db.Repository;
using Kontrolnaja_Rabota_Po_ASP_API.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Kontrolnaja_Rabota_Po_ASP_API.Controller
{
    [Route("/orders")]
    [ApiController]
    public class OrderController
        
    {
        IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [HttpGet]
        public async Task<List<Order>> OrderList()
        {
            return await _orderRepository.GetList();
        }
        [HttpGet("{id}")]
        public async Task<Order> GetOrderById(int id)
        {
            return await _orderRepository.GetById(id);
        }
        [HttpDelete("{id}")]
        public async Task<string> DeleteOrderById(int id)
        {
            if (_orderRepository.DeleteById(id).Result)
            {
                return "Удалил";
            }
            return "Не удалил";
        }
    }
}
