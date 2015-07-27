namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryAdd<TEntity,TCodigo>
        where TEntity: Entities.Core.Entity<TCodigo>
    {
        TCodigo Add(TEntity entity);
    }
}