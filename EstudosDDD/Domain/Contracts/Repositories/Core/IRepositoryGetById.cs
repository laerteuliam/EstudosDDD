namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetById<in TCodigo, out TEntity>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        TEntity GetById(TCodigo t);
    }
}