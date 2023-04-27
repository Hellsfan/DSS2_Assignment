using DnDShop.Application.Services.DTO;
using DnDShop.Application.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Implementations
{
    public class ShoppingCartService : IShoppingCartService
    {
        public Task<long?> CreateShoppingCart(long? productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCartDTO> GetShoppingCartDetailsAsync(long? shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShoppingCartDTO>> GetShoppingCartListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
