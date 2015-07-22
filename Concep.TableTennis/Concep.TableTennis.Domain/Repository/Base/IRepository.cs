using Concep.TableTennis.Domain.Model.Base;
using System.Collections.Generic;

namespace Concep.TableTennis.Domain.Repository.Base
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>, new()
    {
        void Add(TEntity entity);

        IEnumerable<TEntity> FindAll();
    }
}