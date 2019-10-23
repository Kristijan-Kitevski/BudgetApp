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
    public class BudgetController : Controller
    {
        private readonly IIncomeService _incomeService;
        private readonly IExpenseService _expenseService;

        public BudgetController(IIncomeService incomeService, IExpenseService expenseService)
        {
            _incomeService = incomeService;
            _expenseService = expenseService;
        }

        public IActionResult Index()
        {
            var incomes = _incomeService.GetAllIncomes();
            var expenses = _expenseService.GetAllExpenses();

            BudgetViewModel model = new BudgetViewModel
            {
                Incomes = incomes,
                Expenses = expenses,
                IncomeSum = incomes.Sum(i => i.IncomeValue),
                ExpenseSum = expenses.Sum(e => e.ExpensesValue)
            };

            return View(model);
        }
    }
}