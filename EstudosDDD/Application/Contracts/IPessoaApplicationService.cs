using System.Collections.Generic;
using EstudosDDD.Application.Contracts.Core;
using EstudosDDD.Application.Dtos;
using EstudosDDD.Application.Dtos.Core;

namespace EstudosDDD.Application.Contracts
{
    public interface IPessoaApplicationService
        : IApplicationServiceSalvar<PessoaDto,int>,
        IApplicationServiceListar<PessoaDto,int>
    {
        
    }
}