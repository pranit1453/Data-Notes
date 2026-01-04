
using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.Services
{
    public interface IProductService
    {
        Task<List<Products>> GetAllProducts();
    }
}
