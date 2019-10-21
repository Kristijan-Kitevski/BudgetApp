using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Interface
{
    public interface IIncomeServices
    {
       
        IEnumerable<IncomeViewModel> GetAllIncomes();
        IncomeViewModel GetIncomeByPeriod(DateTime startDate, DateTime endDate);
       

        int CreateIncome(IncomeViewModel income, string userId);

        int UpdateIncome(int incomeId, Enum IncomeTypeViewModel, DateTime incomeDate, double incomeValue);

        int RemoveIncome(int incomeId);


    }
}
