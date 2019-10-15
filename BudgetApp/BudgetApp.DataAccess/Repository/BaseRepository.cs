using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public abstract class BaseRepository
    {
        protected readonly BudgetDbContext _context;
        public BaseRepository(BudgetDbContext context)
        {
            _context = context;
        }
    }
}
