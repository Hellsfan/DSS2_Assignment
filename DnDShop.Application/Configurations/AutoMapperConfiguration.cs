using AutoMapper;
using DnDShop.Application.Models;
using DnDShop.Application.Services.DTO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddMappings(
            this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ProductProfile).Assembly);
            return services;
        }
    }

    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDetailsDTO>(MemberList.None)
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));

            CreateMap<Product, ProductShortDTO>(MemberList.None)
               .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<CreateProductDTO, Product>(MemberList.None)
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price));

            CreateMap<UpdateProductDTO, Product>(MemberList.None)
               .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }

    internal class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryShortDTO>(MemberList.None)
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }

    internal class ShoppingCartProfile : Profile
    {
        public ShoppingCartProfile()
        {
            CreateMap<ShoppingCart, ShoppingCartDTO>(MemberList.None)
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalPrice))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
        }
    }
}
