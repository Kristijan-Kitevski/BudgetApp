using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers
{
    public class IncomeController : Controller
    {
        //private readonly IUserService _userService;
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        public IActionResult CreateNewIncome()
        {

            //var incomesbefore = _incomeService.GetAllIncomes();

            //_incomeService.CreateIncome(new IncomeViewModel
            //{
            //    Id = 100,
            //    Date = DateTime.Now,
            //    IncomeType = IncomeTypeViewModel.BusinessIncome,
            //    IncomeValue = 100,
            //    User = new UserViewModel
            //    {
            //        Id = "1",
            //        FullName = "name",
            //        UserName = "user"
            //    }
            //});

            //var incomesafter = _incomeService.GetAllIncomes();

            return View(new IncomeViewModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNewIncome(int IncomeValue, IncomeTypeViewModel IncomeType)
        {

            return RedirectToAction("");
        }

    }
}