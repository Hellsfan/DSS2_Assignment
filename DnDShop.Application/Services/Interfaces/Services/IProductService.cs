using DnDShop.Application.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Interfaces.Services
{
    public interface IProductService
    {
        Task<long?> CreateProductAsync(
           CreateProductDTO createProduct);

        Task UpdateProductAsync(
            long? productId,
            UpdateProductDTO updateProduct);

        Task DeleteProductAsync(
           long? productId);

        Task<ProductDetailsDTO> GetProductDetailsAsync(
            long? productId);

        Task<IEnumerable<ProductShortDTO>> GetProductListAsync(
            long? categoryId);
    }
}
