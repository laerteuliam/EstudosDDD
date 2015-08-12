using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryInsertOrUpdate<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        void InsertOrUpdate(TEntity t);
    }
}