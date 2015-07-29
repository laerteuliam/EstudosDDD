using System.Collections.Generic;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetAll<TEntity,TCodigo>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        IEnumerable<TEntity> GetAll();
    }
}