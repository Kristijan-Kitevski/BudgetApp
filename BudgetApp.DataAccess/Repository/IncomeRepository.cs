using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public class IncomeRepository : BaseRepository<BudgetDbContext>, IRepository<Income>
    {
        public IncomeRepository(BudgetDbContext context) : base(context) { }

        public IEnumerable<Income> GetAll()
        {
            return _context.Incomes.ToList();
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
            Income income = _context.Incomes.FirstOrDefault(i => i.Id == entity.Id);
            if (income == null)
                return -1;

            income.Date = entity.Date;
            income.IncomeType = entity.IncomeType;
            income.IncomeValue = entity.IncomeValue;

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
