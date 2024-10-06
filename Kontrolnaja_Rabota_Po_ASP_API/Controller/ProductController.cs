
using Kontrolnaja_Rabota_Po_ASP_API.Db.Repository;
using Kontrolnaja_Rabota_Po_ASP_API.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Kontrolnaja_Rabota_Po_ASP_API.Controller
{
    [Route("/product")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        public IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpPost]
        public async Task<Product> AddAsync(Product product)
        {
            return await productRepository.AddAsync(product);
        }
        [HttpGet]
        public async Task<List<Product>> ListAll()
        {
            return await productRepository.ListAll();
        }

        [HttpPatch("{id}")]
        public  void EditProduct(int id, Product product)
        {
            productRepository.Edit(id, product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
        [HttpGet("{id}")]
        public async Task<Product> GetAsync(int id)
        {
            return await productRepository.GetAsync(id);
        }

        [HttpGet("name")]
        public async Task<Product> GetByName()
        {
            string name = HttpContext.Request.Headers["name"].ToString();
            return await productRepository.GetByName(name);
        }
    }
}
