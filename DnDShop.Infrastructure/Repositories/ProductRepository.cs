using DnDShop.Application.Models;
using DnDShop.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(long? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetByCategoryAsync(long? categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<long?> SaveAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
