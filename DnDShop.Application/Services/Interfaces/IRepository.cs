using DnDShop.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Services.Interfaces
{
    public interface IRepository
    {
        public interface IRepository<TEntity>
        where TEntity : IDatabaseModel
        {
            Task<TEntity> GetAsync(long? id);

            Task<IEnumerable<TEntity>> GetAsync();

            Task<long?> SaveAsync(TEntity entity);

            Task UpdateAsync(TEntity entity);

            Task DeleteAsync(TEntity entity);
        }
    }
}
