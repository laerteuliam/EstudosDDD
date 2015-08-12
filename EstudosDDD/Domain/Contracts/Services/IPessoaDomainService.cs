using EstudosDDD.Domain.Contracts.Services.Core;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Services
{
    public interface IPessoaDomainService :
        IDomainServiceSalvar<PessoaEntity, int>,
        IDomainServiceListar<PessoaEntity, int>
    {
    }
}