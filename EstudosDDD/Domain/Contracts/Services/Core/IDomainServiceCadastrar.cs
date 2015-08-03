namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceCadastrar<TEntity,TCodigo>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        void Cadastrar(TEntity t);
    }
}