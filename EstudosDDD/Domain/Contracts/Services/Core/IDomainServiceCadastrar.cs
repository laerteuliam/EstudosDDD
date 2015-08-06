using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceCadastrar<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        void Cadastrar(TEntity t);
    }
}