using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ShopUI.Interfaces;
using ShopUI.Services;
using System.Security.Claims;

namespace ShopUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService = new UserService();
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterUser(string name, string userName, string pass)
        {
            _userService.Add(name, userName, pass);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogInUser(string userName, string pass)
        {
            var user = _userService.LogIn(userName, pass);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                };
                var identity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Password or UserName is Incorrect!!!";
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return RedirectToAction("LogIn", "User");
        }

    }
}
