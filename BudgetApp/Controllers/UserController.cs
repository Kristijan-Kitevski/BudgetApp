using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Serilog;

namespace BudgetApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;


        public UserController(IUserService userService, IToastNotification toastNotification)
        {
            _userService = userService;
            _toastNotification = toastNotification;
        }


        public IActionResult LogIn()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Login(model);
                
                _toastNotification.AddSuccessToastMessage("You have successfully loged in!");

                Log.Error($"User with username {model.Username} logged in as regular user!");

                return RedirectToAction("Index", "Budget");
            }
            _toastNotification.AddWarningToastMessage("Username or password are incorect!");
            return View(model);
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(model);
                return RedirectToAction("Index", "Budget");
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("LogIn", "User");
        }
    }
}
