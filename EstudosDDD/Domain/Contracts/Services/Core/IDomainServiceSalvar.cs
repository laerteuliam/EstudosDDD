using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceSalvar<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        void Salvar(TEntity t);
    }
}