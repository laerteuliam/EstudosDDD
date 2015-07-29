using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Repositories
{
    public interface IRepositoryPessoa:
        Core.IRepositoryAdd<PessoaEntity,int>,
        Core.IRepositoryGetAll<PessoaEntity,int>
    {
         
    }
}