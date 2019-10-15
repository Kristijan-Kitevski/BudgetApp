using BudgetApp.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.DataAccess
{
    class BudgetDbContext : IdentityDbContext<User>
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

            //seeding user id.
            
            string userId = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<User>();

            // SEEDING ADMIN USER WITHOUT ROLE
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId,
                UserName = "supplier",
                NormalizedUserName = "SUPPLIER",
                Email = "supplier@mail.com",
                NormalizedEmail = "supplier@mail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Admin#"),
                SecurityStamp = string.Empty
            });

        }
        

    }
}
