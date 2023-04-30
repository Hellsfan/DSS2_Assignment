using DnDShop.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Infrastructure.Database.Mappings
{
    public sealed class ShoppingCartMapping : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.ToTable("shopping_cart", "dbo");

            builder.HasKey(e => e.Id).HasName("id");
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.TotalPrice)
                .HasColumnName("total_price")
                .HasColumnType("REAL")
                .IsRequired();

            builder.HasMany(e => e.Products)
                 .WithOne(e => e.ShoppingCart)
                 .HasForeignKey(e => e.ShoppingCartId);
        }
    }
}
