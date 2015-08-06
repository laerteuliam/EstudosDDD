using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryAdd<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        void Add(TEntity entity);
    }
}