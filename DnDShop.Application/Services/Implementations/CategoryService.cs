using AutoMapper;
using DnDShop.Application.Models;
using DnDShop.Application.Services.DTO;
using DnDShop.Application.Services.Interfaces;
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
         private readonly IMapper _mapper;
         private readonly ICategoryRepository _categoryReposity;

         public CategoryService(
             IMapper mapper,
             ICategoryRepository categoryReposity)
         {
             _mapper = mapper;
             _categoryReposity = categoryReposity;
         }

         public async Task<long?> CreateCategoryAsync(
             CreateUpdateCategoryDTO createCategory)
         {
             var category = Category.Create(
                 createCategory.Name);

             var categoryId = await _categoryReposity.SaveAsync(
                 category);

             return categoryId;
         }

         public async Task DeleteCategoryAsync(
             long? categoryId)
         {
             if (categoryId is null)
             {
                 throw new ArgumentNullException(
                     nameof(categoryId),
                     "Category id is requred");
             }

             var category = await _categoryReposity.GetAsync(
                 categoryId);

             if (category is null)
             {
                 throw new ArgumentException(
                     $"Category with id {categoryId} does not exist",
                     nameof(category));
             }

             await _categoryReposity.DeleteAsync(category);
         }

         public async Task UpdateCategoryAsync(
             long? categoryId,
             CreateUpdateCategoryDTO updateCategory)
         {
             if (categoryId is null)
             {
                 throw new ArgumentNullException(
                     nameof(categoryId),
                     "Category id is requred");
             }

             var category = await _categoryReposity.GetAsync(
                 categoryId);

             if (category is null)
             {
                 throw new ArgumentException(
                     $"Product wit id {categoryId} does not exist",
                     nameof(category));
             }

             category.Update(updateCategory.Name);

             await _categoryReposity.UpdateAsync(category);
         }

         public async Task<IEnumerable<CategoryShortDTO>> GetCategoryListAsync()
         {
             var categories = await _categoryReposity.GetAsync();

             return _mapper.Map<IEnumerable<CategoryShortDTO>>(categories);
         }
    }
}
