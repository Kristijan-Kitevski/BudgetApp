using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Interface
{
    public interface IExpenseService
    {
        IEnumerable<ExpenseViewModel> GetAllExpenses();
        IEnumerable<ExpenseViewModel> GetExpenses(SortBy sortBy, IEnumerable<Filter> filters);
        ExpenseViewModel GetExpense(int id);
        void CreateExpense(ExpenseViewModel expense);
        void EditExpense(ExpenseViewModel expense);
        void DeleteExpense(int id);
    }
}
