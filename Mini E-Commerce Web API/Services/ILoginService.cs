using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.Services
{
    public interface ILoginService
    {
        bool RegisterUser(Users user);
        bool Validate(string username, string password);
    }
}
