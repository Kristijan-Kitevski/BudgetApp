using BudgetAppWebModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppWebModels.ViewModels
{
     public class ExpenseViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ExpensesValue { get; set; }
        public ExpenseTypeViewModel ExpensesType { get; set; }
        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
