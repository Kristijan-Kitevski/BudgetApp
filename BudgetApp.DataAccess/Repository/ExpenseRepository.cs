using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public class ExpenseRepository : BaseRepository, IRepository<Expense>
    {
        public ExpenseRepository(BudgetDbContext context) : base (context)
        {

        }

       
        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses;
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
            _context.Expenses.Update(entity);
            return _context.SaveChanges();

        }

        public int Delete(int id)
        {
            Expense expense = _context.Expenses.FirstOrDefault(e => e.Id == id);
            if (expense == null)
            {
                return -1;
            }
            _context.Expenses.Remove(expense);
            return _context.SaveChanges();

        }

    }


}
