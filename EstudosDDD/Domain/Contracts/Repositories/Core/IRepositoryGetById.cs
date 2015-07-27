namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetById<TEntity,TCodigo>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        TEntity GetById(TCodigo t);
    }
}