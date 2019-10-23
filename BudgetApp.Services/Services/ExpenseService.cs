using AutoMapper;
using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepository<Expense> _expenseRepo;
        private readonly IMapper _mapper;

        public ExpenseService(IRepository<Expense> expenseRepo, IMapper mapper)
        {
            _expenseRepo = expenseRepo;
            _mapper = mapper;
        }

        public IEnumerable<ExpenseViewModel> GetAllExpenses()
        {
            return _mapper.Map<IEnumerable<ExpenseViewModel>>(
                _expenseRepo.GetAll()
            );
        }

        public IEnumerable<ExpenseViewModel> GetExpenses(SortBy sortBy, IEnumerable<Filter> filters)
        {
            throw new NotImplementedException();
        }

        public ExpenseViewModel GetExpense(int id)
        {
            throw new NotImplementedException();
        }
        public void CreateExpense(ExpenseViewModel income)
        {
            throw new NotImplementedException();
        }

        public void EditExpense(ExpenseViewModel income)
        {
            throw new NotImplementedException();
        }

        public void DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }
    }
}
