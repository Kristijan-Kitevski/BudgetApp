using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult CreateNewExpense()
        {
            return View(new ExpenseViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNewExpense(int ExpenceValue, ExpenseTypeViewModel IncomeType)
        {


            return RedirectToAction("");
        }
    }
}