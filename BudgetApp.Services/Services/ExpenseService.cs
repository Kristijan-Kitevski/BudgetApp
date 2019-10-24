using AutoMapper;
using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetApp.Services.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepository<Expense> _expenseRepository;
        private readonly IMapper _mapper;

        public ExpenseService(IRepository<Expense> expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }

        public IEnumerable<ExpenseViewModel> GetAllExpenses()
        {
            return _mapper.Map<IEnumerable<ExpenseViewModel>>(
                _expenseRepository.GetAll()
            );
        }

        public IEnumerable<ExpenseViewModel> GetExpenses(SortBy sortBy, IEnumerable<Filter> filters)
        {
            var expense = _expenseRepository.GetAll();
            return _mapper.Map<IEnumerable<ExpenseViewModel>>(
                FilterExpenses(expense, filters)
            );
        }

        public ExpenseViewModel GetExpense(int id)
        {
            return _mapper.Map<ExpenseViewModel>(
                _expenseRepository.GetById(id)
            );
        }
        public void CreateExpense(ExpenseViewModel expense)
        {
            _expenseRepository.Insert(
                _mapper.Map<Expense>(expense)
            );
        }

        public void EditExpense(ExpenseViewModel expense)
        {
            _expenseRepository.Update(
                _mapper.Map<Expense>(expense)
            );
        }

        public void DeleteExpense(int id)
        {
            _expenseRepository.Delete(id);
        }

        private IEnumerable<Expense> FilterExpenses(IEnumerable<Expense> expenses, IEnumerable<Filter> filters)
        {
            IEnumerable<Expense> expensesFiltered = expenses;

            foreach (Filter filter in filters)
            {
                switch (filter.FilterBy)
                {
                    case FilterBy.Date:
                        expensesFiltered = expensesFiltered.Where(i =>
                            IsStartDateValid(i.Date, filter.Values.StartDate) &&
                            IsEndDateValid(i.Date, filter.Values.EndDate)
                        );
                        break;
                    case FilterBy.Type:
                        expensesFiltered = expensesFiltered.Where(i =>
                            i.ExpensesType == filter.Values.Type
                        );
                        break;
                    case FilterBy.Value:
                        expensesFiltered = expensesFiltered.Where(i =>
                            IsValueValid(i.ExpensesValue, filter.Values.ValueFrom, filter.Values.ValueTo)
                        );
                        break;
                    default:
                        break;
                }
            }

            return expensesFiltered;
        }

        private bool IsValueValid(double expenseValue, double valueFrom, double valueTo)
        {
            if (expenseValue >= valueFrom && expenseValue < valueTo)
                return true;
            else
                return false;
        }

        private bool IsStartDateValid(DateTime expenseDate, DateTime startDate)
        {
            int result = expenseDate.CompareTo(startDate);

            if (result == -1)
                return false;
            else if (result == 0 || result == 1)
                return true;
            else
                return false;
        }

        private bool IsEndDateValid(DateTime expenseDate, DateTime endDate)
        {
            int result = expenseDate.CompareTo(endDate);

            if (result == -1 || result == 0)
                return true;
            else
                return false;
        }

    }
}
