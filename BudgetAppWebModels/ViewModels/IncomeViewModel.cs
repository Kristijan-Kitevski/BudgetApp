using BudgetAppWebModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppWebModels.ViewModels
{
    public class IncomeViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double IncomeValue { get; set; }
        public IncomeTypeViewModel IncomeType { get; set; }
        public UserViewModel User { get; set; }
    }
}
