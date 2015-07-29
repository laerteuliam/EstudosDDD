using EstudosDDD.Domain.Contracts.Services.Core;

namespace EstudosDDD.Domain.Contracts.Services
{
    public interface IPessoaDomainService : 
        IDomainServiceCadastrar<Entities.PessoaEntity,int>,
        IDomainServiceListar<Entities.PessoaEntity,int>
    {
      
    }
}