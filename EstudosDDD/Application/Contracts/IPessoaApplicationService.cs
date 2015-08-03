using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Application.Dtos;

namespace EstudosDDD.Application.Contracts
{
    interface IPessoaApplicationService
    {
        void Cadastrar(PessoaDto pessoaDto);
        IEnumerable<PessoaDto> Listar();
    }
}
