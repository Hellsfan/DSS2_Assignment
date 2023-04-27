using DnDShop.Application.Models;
using DnDShop.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAsync(long? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<long?> SaveAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
