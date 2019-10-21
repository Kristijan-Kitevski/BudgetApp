using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Interface
{
    public interface IExpenseServices
    {
        IEnumerable<ExpenseViewModel> GetAllExpenses();
        ExpenseViewModel GetExpenseByPeriod(DateTime startDate, DateTime endDate);

        int CreateExpense(ExpenseViewModel expense, string userId);

        int UpdateExpense(int expenseId, Enum ExpenseTypeViewModel, DateTime expenseDate, double expenseValue);
        int RemoveExpense(int expenseId);
    }
}
