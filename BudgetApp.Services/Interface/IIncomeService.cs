using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Interface
{
    public interface IIncomeService
    {
        IEnumerable<IncomeViewModel> GetAllIncomes();
        IEnumerable<IncomeViewModel> GetIncomes(SortBy sortBy, IEnumerable<Filter> filters);
        IncomeViewModel GetIncome(int id);
        void CreateIncome(IncomeViewModel income);
        void EditIncome(IncomeViewModel income);
        void DeleteIncome(int id);
    }
}
