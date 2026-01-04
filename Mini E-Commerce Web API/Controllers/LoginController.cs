using Microsoft.AspNetCore.Mvc;
using Mini_E_Commerce_Web_API.Models;
using Mini_E_Commerce_Web_API.Services;

namespace Mini_E_Commerce_Web_API.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService=loginService;
        }
        [HttpGet]
        public IActionResult LoginView() => View();

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            bool status = _loginService.Validate(Username, Password);

            return status ? RedirectToAction("AllProducts", "Product") : RedirectToAction("LoginView", "Login");
        }
        [HttpGet]
        public IActionResult RegisterView() => View();

        [HttpPost]
        public IActionResult Register(Users user)
        {
            bool status = _loginService.RegisterUser(user);

            if (status)
            {
                TempData["Message"] = "Account Created Successfully";
            }
            else
            {
                TempData["Message"] = "Account not Created";
            }

            return RedirectToAction("LoginView", "Login");
        }
    }
}
