namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryAdd<TEntity,TCodigo>
        where TEntity: Entities.Core.Entity<TCodigo>
    {
        void Add(TEntity entity);
    }
}