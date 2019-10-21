using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppWebModels.ViewModels
{
    public class CalculatorViewModel
    {
        public int Id { get; set; }

        public int IncomeId { get; set; }

        public virtual IncomeViewModel IncomeViewModels { get; set; }

        public int ExpenseId { get; set; }

        public virtual ExpenseViewModel ExpenseViewModels { get; set; }
    }
}
