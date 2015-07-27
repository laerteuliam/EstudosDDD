using System.Collections.Generic;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetAll<in TCodigo, out TEntity>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        IEnumerable<TEntity> GetAll();
    }
}