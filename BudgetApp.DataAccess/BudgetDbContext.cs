using BudgetApp.Domain.Models;
using BudgetApp.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess
{
    public class BudgetDbContext : IdentityDbContext<User>
    {
        public BudgetDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relations
            modelBuilder.Entity<User>()
                .HasMany(u => u.Incomes)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Expenses)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            // Data seeding
            string adminRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                }   
            );

            var hasher = new PasswordHasher<User>();
            string adminId = Guid.NewGuid().ToString();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "adminadmin"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   UserId = adminId,
                   RoleId = adminRoleId
               }
            );

            modelBuilder.Entity<Income>().HasData(
                new Income
                {
                    Id = 1,
                    Date = DateTime.UtcNow,
                    IncomeType = IncomeType.Salary,
                    IncomeValue = 100.0,
                    UserId = adminId
                }    
            );

            modelBuilder.Entity<Expense>().HasData(
                new Expense
                {
                    Id = 1,
                    Date = DateTime.UtcNow,
                    ExpensesType = ExpensesType.Grocery,
                    ExpensesValue = 30.0,
                    UserId = adminId
                }    
            );
        }
    }
}
