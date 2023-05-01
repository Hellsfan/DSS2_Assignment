﻿using DnDShop.Application.Services.DTO;
using DnDShop.Application.Services.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DnDShop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(
            ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCategoryAsync(
            CreateUpdateCategoryDTO createCategory)
        {
            var productId = await _categoryService.CreateCategoryAsync(createCategory);
            return Ok(productId);
        }

        [HttpDelete("delete/{categoryId}")]
        public async Task<IActionResult> DeleteCategoryAsync(
            long? categoryId)
        {
            await _categoryService.DeleteCategoryAsync(categoryId);
            return Ok(categoryId);
        }

        [HttpPatch("update/{categoryId}")]
        public async Task<IActionResult> UpdateProductAsync(
            long? categoryId,
            CreateUpdateCategoryDTO updateCategory)
        {
            await _categoryService.UpdateCategoryAsync(
                categoryId,
                updateCategory);

            return Ok(categoryId);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetCategoryListAsync()
        {
            var categories = await _categoryService.GetCategoryListAsync();

            return Ok(categories);
        }
    }
}
