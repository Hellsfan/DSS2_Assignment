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
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(
            IMapper mapper,
            IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<long?> CreateProductAsync(
            CreateProductDTO createProduct)
        {

            var product = Product.Create(
                createProduct.Name,
                createProduct.Description,
                createProduct.CategoryId,
                createProduct.Quantity,
                createProduct.Price);


            var productId = await _productRepository.SaveAsync(
                product);

            return productId;
        }

        public async Task DeleteProductAsync(
            long? productId)
        {
            if (productId is null)
            {
                throw new ArgumentNullException(
                    nameof(productId),
                    "Product id is requred");
            }

            var product = await _productRepository.GetAsync(
                productId);

            if (product is null)
            {
                throw new ArgumentException(
                    $"Product wit id {productId} does not exist",
                    nameof(product));
            }

            await _productRepository.DeleteAsync(product);
        }

        public async Task UpdateProductAsync(
            long? productId,
            UpdateProductDTO updateProduct)
        {
            if (productId is null)
            {
                throw new ArgumentNullException(
                    nameof(productId),
                    "Product id is requred");
            }

            var product = await _productRepository.GetAsync(
                productId);

            if (product is null)
            {
                throw new ArgumentException(
                    $"Product wit id {productId} does not exist",
                    nameof(product));
            }

            product.Update(
                updateProduct.Name,
                updateProduct.Description,
                updateProduct.Quantity,
                updateProduct.Price);

            await _productRepository.UpdateAsync(product);
        }

        public async Task<ProductDetailsDTO> GetProductDetailsAsync(
            long? productId)
        {
            if (productId is null)
            {
                throw new ArgumentNullException(
                    nameof(productId),
                    "Product id is requred");
            }

            var product = await _productRepository.GetAsync(
                productId);

            if (product is null)
            {
                throw new ArgumentException(
                    $"Product wit id {productId} does not exist",
                    nameof(product));
            }

            return _mapper.Map<ProductDetailsDTO>(product);
        }

        public async Task<IEnumerable<ProductShortDTO>> GetProductListAsync(
            long? categoryId)
        {
            var products = categoryId == null
                ? await _productRepository.GetAsync()
                : await _productRepository.GetByCategoryAsync(categoryId);

            return _mapper.Map<IEnumerable<ProductShortDTO>>(products);
        }
    }
}
