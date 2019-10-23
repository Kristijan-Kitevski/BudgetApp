using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppWebModels.ViewModels
{
    public class BudgetViewModel
    {
        public IEnumerable<IncomeViewModel> Incomes { get; set; }
        public IEnumerable<ExpenseViewModel> Expenses { get; set; }
        public double IncomeSum { get; set; }
        public double ExpenseSum { get; set; }
    }
}
