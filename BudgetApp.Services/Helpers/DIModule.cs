
using BudgetApp.DataAccess;
using BudgetApp.DataAccess.Interfaces;
using BudgetApp.DataAccess.Repository;
using BudgetApp.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Helpers
{
    public class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {

            services.AddDbContext<BudgetDbContext>
                (x => x.UseSqlServer(connectionString));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
            .AddRoleManager<RoleManager<IdentityRole>>()
            .AddEntityFrameworkStores<BudgetDbContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IRepository<Income>, IncomeRepository>();
            services.AddTransient<IRepository<Expense>, ExpenseRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;

        }
    }
}
