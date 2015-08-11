using System.Collections.Generic;
using EstudosDDD.Application.Dtos;

namespace EstudosDDD.Application.Contracts
{
    public interface IPessoaApplicationService
    {
        void Salvar(PessoaDto pessoaDto);
        IEnumerable<PessoaDto> Listar();
    }
}