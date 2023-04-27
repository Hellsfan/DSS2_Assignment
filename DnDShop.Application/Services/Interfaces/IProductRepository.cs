using DnDShop.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnDShop.Application.Services.Interfaces.IRepository;

namespace DnDShop.Application.Services.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetByCategoryAsync(long? categoryId);
    }
}
