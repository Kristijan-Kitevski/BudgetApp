using BudgetApp.Domain.Models;
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

            modelBuilder.Entity<User>()
                .HasMany(u => u.Incomes)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.UserId);


            modelBuilder.Entity<User>()
                .HasMany(u => u.Expenses)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);
            
            string userId = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<User>();

          
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "adminadmin"),
                SecurityStamp = string.Empty
            });

        }
        

    }
}
