using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetByDate(DateTime date);
        T GetByTimePeriod(DateTime starDate, DateTime endDate);
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
