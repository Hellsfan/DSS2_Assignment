using DnDShop.Application.Services.Implementations;
using DnDShop.Application.Services.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Configurations
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddServices(
           this IServiceCollection services)
        {
            services.AddAutoMapper(
                Assembly.GetExecutingAssembly(),
                Assembly.GetEntryAssembly(),
                Assembly.GetCallingAssembly());

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
