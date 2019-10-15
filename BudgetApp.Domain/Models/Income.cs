using BudgetApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BudgetApp.Domain.Models
{
    public class Income
    {
        public int Id { get; set; }
        public DataType Date { get; set; }
        public double IncomeValue { get; set; }
        public IncomeType IncomeType { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }


    }
}
