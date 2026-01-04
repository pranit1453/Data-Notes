
using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.DAL
{
    public interface IProductRepository
    {
        Task<List<Products>> GetAllProducts();
    }
}
