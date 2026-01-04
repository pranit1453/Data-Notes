using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.DAL
{
    public interface ILoginRepository
    {
        bool RegisterUser(Users user);
        bool Validate(string username, string password);
    }
}
