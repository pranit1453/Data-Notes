
using Microsoft.EntityFrameworkCore;
using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.DAL
{
    public class ProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await _applicationDbContext.products.ToListAsync();
        }

    }
}
