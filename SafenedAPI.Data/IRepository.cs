using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SafenedAPI.Data
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
