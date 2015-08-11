using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryAdd<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        TCodigo Add(TEntity entity);
    }
}