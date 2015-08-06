using EstudosDDD.Domain.Contracts.Services.Core;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Services
{
    public interface IPessoaDomainService :
        IDomainServiceCadastrar<PessoaEntity, int>,
        IDomainServiceListar<PessoaEntity, int>
    {
    }
}