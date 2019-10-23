using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess.Repository
{
    public abstract class BaseRepository<Context>
        where Context : DbContext
    {
        protected readonly Context _context;
        public BaseRepository(Context context)
        {
            _context = context;
        }
    }
}
