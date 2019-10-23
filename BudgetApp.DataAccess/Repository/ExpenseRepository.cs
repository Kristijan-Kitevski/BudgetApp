using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public class ExpenseRepository : BaseRepository<BudgetDbContext>, IRepository<Expense>
    {
        public ExpenseRepository(BudgetDbContext context) : base (context) { }
       
        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses.ToList();
        }

        public Expense GetById(int id)
        {
            return _context.Expenses.FirstOrDefault(e => e.Id == id);
        }

        public int Insert(Expense entity)
        {
            _context.Expenses.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Expense entity)
        {
            Expense expense = _context.Expenses.FirstOrDefault(e => e.Id == entity.Id);
            if (expense == null)
                return -1;

            expense.Date = entity.Date;
            expense.ExpensesType = entity.ExpensesType;
            expense.ExpensesValue = entity.ExpensesValue;

            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            Expense expense = _context.Expenses.FirstOrDefault(e => e.Id == id);
            if (expense == null)
                return -1;
            _context.Expenses.Remove(expense);
            return _context.SaveChanges();
        }
    }
}
