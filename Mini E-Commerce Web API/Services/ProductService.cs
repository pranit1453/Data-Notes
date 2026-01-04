
using Mini_E_Commerce_Web_API.DAL;
using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Products>> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
