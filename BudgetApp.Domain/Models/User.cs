using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BudgetApp.Domain.Models
{
    public class User : IdentityUser
    {
        
        public string FullName { get; set; }
        public int IncomeId { get; set; }
        public virtual IEnumerable<Income> Incomes { get; set; }
        public int ExpenseId { get; set; }
        public virtual IEnumerable<Expense> Expenses { get; set; }

    }
}
