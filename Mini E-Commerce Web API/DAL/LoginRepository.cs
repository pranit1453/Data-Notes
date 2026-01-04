using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.DAL
{
    public class LoginRepository: ILoginRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public LoginRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public bool Validate(string username, string password)
        {
            if(username!=null && password != null)
            {
                return _applicationDbContext.users.Any(u=> u.Username==username && u.Password==password);
            }
            else
            {
                return false;
            }
        }

        public bool RegisterUser(Users user)
        {
            if(user == null) return false;

            var users = new Users
            {
                Username = user.Username,
                Password = user.Password,
                EmailID = user.EmailID,
            };

            _applicationDbContext.users.Add(users);
            return _applicationDbContext.SaveChanges() > 0;
        }
    }
}
