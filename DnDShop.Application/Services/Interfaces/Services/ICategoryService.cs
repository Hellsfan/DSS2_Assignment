using DnDShop.Application.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<long?> CreateCategoryAsync(CreateUpdateCategoryDTO createCategory);
        Task DeleteCategoryAsync(long? categoryId);
        Task<IEnumerable<CategoryShortDTO>> GetCategoryListAsync();
        Task UpdateCategoryAsync(long? categoryId, CreateUpdateCategoryDTO updateCategory);
    }
}
