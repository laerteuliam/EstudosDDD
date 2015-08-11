using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceEditar<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        void Editar(TEntity t);
    }
}