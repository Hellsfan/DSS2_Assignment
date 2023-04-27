using DnDShop.Application.Models;
using DnDShop.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Infrastructure.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public Task<ShoppingCart> ClearShoppingCart(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> GetAsync(long? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShoppingCart>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long?> SaveAsync(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }
    }
}
