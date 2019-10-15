using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public class ExpenseRepository : BaseRepository, IRepository<Expense>
    {
        public ExpenseRepository(BudgetDbContext context) : base (context)
        {

        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expense> GetAll()
        {
            throw new NotImplementedException();
        }

        public Expense GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public int Insert(Expense entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Expense entity)
        {
            throw new NotImplementedException();
        }
    }


}
