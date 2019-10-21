using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public class IncomeRepository : BaseRepository, IRepository<Income>
    {
        public IncomeRepository(BudgetDbContext context) : base(context) { }

        

        public IEnumerable<Income> GetAll()
        {
            return _context.Incomes;
        }

        public Income GetById(int id)
        {
            return _context.Incomes.FirstOrDefault(x => x.Id == id);
        }



        public int Insert(Income entity)
        {
            _context.Incomes.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Income entity)
        {
            _context.Incomes.Update(entity);
            return _context.SaveChanges();
        }
         public int Delete(int id)
         {
            Income income = _context.Incomes.FirstOrDefault(x => x.Id == id);
            if (income == null)
                return -1;
            _context.Incomes.Remove(income);
            return _context.SaveChanges();
        }

    }
}
