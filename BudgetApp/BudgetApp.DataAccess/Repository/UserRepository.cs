using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public class UserRepository :BaseRepository, IUserRepository
    {
        public UserRepository(BudgetDbContext context) : base(context) { }


        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public User GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        
    }
}
