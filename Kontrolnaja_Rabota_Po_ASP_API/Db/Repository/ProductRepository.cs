using Kontrolnaja_Rabota_Po_ASP_API.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kontrolnaja_Rabota_Po_ASP_API.Db.Repository
{
    public class ProductRepository:IProductRepository
    {
        public ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddAsync(Product product)
        {
            ProductDb productDb = new ProductDb()
            {
                IsPresent = product.IsPresent,
                Name = product.Name,
                Price = product.Price,
            };
            await _context._productsDb.AddAsync(productDb);
            _context.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            ProductDb productsDb = _context._productsDb.FirstOrDefault(c=>c.Id == id);
            if (productsDb != null)
            {
                _context.Remove(productsDb);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException($"Объект с id - {id} не найден");
            }
        }

        public void Edit(int id, Product product)
        {
            ProductDb prdb = _context._productsDb.FirstOrDefault(p=> p.Id == id);
            if (prdb == null)
            {
                throw new ArgumentNullException($"Объект с id - {id} не найден");
            }
            prdb.Name = product.Name;
            prdb.Price = product.Price;
            prdb.IsPresent = product.IsPresent;
            _context.SaveChanges();

        }

        public async Task<Product> GetAsync(int id)
        {
            ProductDb pdb = await _context._productsDb.FirstOrDefaultAsync(c=>c.Id==id);
            if(pdb == null)
            {
                throw new ArgumentNullException($"Объект с id - {id} не найден");
            }
            return new Product() { IsPresent = pdb.IsPresent,
            Name = pdb.Name,
            Price = pdb.Price,
            };
        }

        public async Task<Product> GetByName(string name)
        {
            ProductDb pdb = await _context._productsDb.FirstOrDefaultAsync(c => c.Name == name);
            if (pdb == null)
            {
                throw new ArgumentNullException($"Объект с name - {name} не найден");
            }
            return new Product()
            {
                IsPresent = pdb.IsPresent,
                Name = pdb.Name,
                Price = pdb.Price,
            };
        }

        public async Task<List<Product>> ListAll()
        {
            List<ProductDb> products = await _context._productsDb.ToListAsync();
            List<Product> result = new List<Product>();
            result = products.Select(c => new Product()
            {
                IsPresent = c.IsPresent,
                Name = c.Name,
                Price = c.Price
            }).ToList();
            return result;
        }
    }
}
