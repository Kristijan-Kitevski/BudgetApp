﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers
{
    [Authorize]
    public class IncomeController : Controller
    {
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }
        [AllowAnonymous]
        public IActionResult CreateNewIncome()
        {
            return View(new IncomeViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNewIncome(IncomeViewModel income)
        {
            _incomeService.CreateIncome(income);

            return RedirectToAction("Index", "Budget");
        }

    }
}