using DnDShop.Application.Services.DTO;
using DnDShop.Application.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        public Task<long?> CreateProductAsync(CreateProductDTO createProduct)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(long? productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDetailsDTO> GetProductDetailsAsync(long? productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductShortDTO>> GetProductListAsync(long? categoryId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(long? productId, UpdateProductDTO updateProduct)
        {
            throw new NotImplementedException();
        }
    }
}
