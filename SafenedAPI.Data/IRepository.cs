using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SafenedAPI.Domain;

namespace SafenedAPI.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        TEntity GetById(Guid id);

        IEnumerable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
