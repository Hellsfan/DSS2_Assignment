using DnDShop.Application.Services.DTO;
using DnDShop.Application.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        public Task<long?> CreateCategoryAsync(CreateUpdateCategoryDTO createCategory)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(long? categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryShortDTO>> GetCategoryListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(long? categoryId, CreateUpdateCategoryDTO updateCategory)
        {
            throw new NotImplementedException();
        }
    }
}
