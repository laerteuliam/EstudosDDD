using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetById<in TCodigo, out TEntity>
        where TEntity : Entity<TCodigo>
    {
        TEntity GetById(TCodigo t);
    }
}