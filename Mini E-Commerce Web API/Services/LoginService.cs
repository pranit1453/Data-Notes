using Mini_E_Commerce_Web_API.DAL;
using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.Services
{
    public class LoginService:ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool Validate(string username, string password)
        {
            if(username!=null && password != null)
            {
                return _loginRepository.Validate(username, password);
            }
            else
            {
                return false;
            }
        }

        public bool RegisterUser(Users user)
        {
            return _loginRepository.RegisterUser(user);
        }
    }
}
