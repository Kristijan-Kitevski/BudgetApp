using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess.Interfaces
{
   public interface IUserRepository
    {
        User GetByUsername(string username);
        User GetById(string id);
    }
}
