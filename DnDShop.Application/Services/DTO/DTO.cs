using DnDShop.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.DTO
{
    #region Product DTO
    public sealed class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quanitity { get; set; }
        public long? CategoryId { get; set; }
        public int Price { get; set; }
    }

    public sealed class UpdateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quanitity { get; set; }
        public int Price { get; set; }
    }

    public sealed class ProductDetailsDTO
    {
        public long? ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quanitity { get; set; }
        public int Price { get; set; }
    }

    public sealed class ProductShortDTO
    {
        public long? ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    #endregion

    #region Shopping Cart DTO
    public sealed class ShoppingCartDTO
    {
        public long Id { get; set; }
        public int TotalAmount { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }

    public sealed class CreateUpdateCartDTO
    {
        public long ProductId { get; set; }
        public int ProductCount { get; set; }
    }
    #endregion

    #region Category DTO
    public sealed class CreateUpdateCategoryDTO
    {
        public string Name { get; set; }
    }

    public sealed class CategoryShortDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    #endregion
}
