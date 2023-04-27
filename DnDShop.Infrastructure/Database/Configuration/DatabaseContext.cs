using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DnDShop.Application.Services.Interfaces;
using DnDShop.Infrastructure.Repositories;
using DnDShop.Application.Models;
using System.Diagnostics.CodeAnalysis;
using DnDShop.Infrastructure.Database.Mappings;

namespace DnDShop.Infrastructure.Database.Configuration
{
    public class DatabaseContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext([NotNull] DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ProductMapping).Assembly);

            var category1 = Category.Create("Other");
            category1.Id = 1;

            modelBuilder.Entity<Category>()
                .HasData(category1);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=main.db", config =>
                {
                    config.MigrationsAssembly("DnDShop.Infrastructure");
                    config.MigrationsHistoryTable("migration_history", "dbo");
                });

                optionsBuilder.EnableDetailedErrors(true);
                optionsBuilder.ConfigureWarnings(e =>
                {
                    e.Default(WarningBehavior.Log);
                });
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
