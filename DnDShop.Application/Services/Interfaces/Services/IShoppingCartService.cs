using DnDShop.Application.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Interfaces.Services
{
    public interface IShoppingCartService
    {
        Task<long?> CreateShoppingCart(
            long? productId,
            int quantity);

        Task<ShoppingCartDTO> GetShoppingCartDetailsAsync(
            long? shoppingCartId);

        Task<IEnumerable<ShoppingCartDTO>> GetShoppingCartListAsync();
    }
}
