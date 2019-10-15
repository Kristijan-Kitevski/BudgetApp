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

        public Income GetByDate(DateTime date)
        {
            return _context.Incomes.FirstOrDefault(x => x.Date == date);
        }


         public Income GetByTimePeriod(DateTime startDate, DateTime endDate)
        {
            var startTime = _context.Incomes.Where(s => s.Date == startDate);
            var endTime = _context.Incomes.Where(e => e.Date == endDate);
            //for (IEnumerable time = startTime; time <= endTime;)
            //{
            //    nekoja logika sto vrakja tabeli od do datum
            //}
            throw new NotImplementedException();
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
