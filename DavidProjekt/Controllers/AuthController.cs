using DavidProjekt.Data.Models;
using DavidProjekt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet("register")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(UserRegisterViewModel model)

        {
            if (model == null)
            {
                return View();
            }
            var user = new User { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, LastName = model.LastName };

            var check = _userManager.CreateAsync(user, model.Password).Result;

            if (!check.Succeeded)
            {
                ViewBag.error = "Registration failed.";
                return View();
            }
            if (check.Succeeded)
            {
                var signInCheck = LogIn(new UserLogInViewModel { Email = user.Email, Password = model.Password });
            }

            return RedirectToAction("/");
        }
        [HttpPost("login")]
        public IActionResult LogIn(UserLogInViewModel model)
        {
            if (model == null)
            {
                return View();
            }
            //var user = new User { Email = model.Email, UserName = model.Email };
            var user = _userManager.FindByEmailAsync(model.Email).Result;
            if (user == null)
            {
                ViewBag.error = "Error";
                return View();
            }
            var check = _signInManager.PasswordSignInAsync(user, model.Password, true, false).Result;
            if (check.Succeeded)
            {
                return Redirect("/home/index");
            }

            return View();
        }
        [HttpGet("login")]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return Redirect("/home/index");
        }
    }
}
