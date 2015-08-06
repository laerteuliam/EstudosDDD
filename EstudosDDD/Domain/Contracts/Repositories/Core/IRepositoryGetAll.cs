using System.Collections.Generic;
using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetAll<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        IEnumerable<TEntity> GetAll();
    }
}