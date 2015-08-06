using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryUpdate<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        void Update(TEntity t);
    }
}