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
    public sealed class ProductMapping
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product", "dbo");

            builder.HasKey(e => e.Id).HasName("id");
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .HasColumnType("TEXT")
                .HasMaxLength(254)
                .IsRequired();

            builder.Property(e => e.Description)
                .HasColumnName("description")
                .HasColumnType("TEXT")
                .HasMaxLength(2049);

            builder.Property(e => e.Quantity)
               .HasColumnName("quanitity")
               .HasColumnType("INTEGER")
               .HasDefaultValue(0);

            builder.Property(e => e.FileId)
              .HasColumnName("file_id")
              .HasColumnType("TEXT")
              .HasMaxLength(32);

            builder.Property(e => e.CategoryId)
                .HasColumnName("category_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.HasOne(e => e.Category)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId);

            builder.Property(e => e.Price)
              .HasColumnName("price")
              .HasColumnType("INTEGER")
              .HasDefaultValue(99);

            builder.HasIndex(e => e.Name)
                .IsUnique();
        }
    }
}
