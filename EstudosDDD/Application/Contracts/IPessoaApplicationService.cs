using System.Collections.Generic;
using EstudosDDD.Application.Dtos;

namespace EstudosDDD.Application.Contracts
{
    public interface IPessoaApplicationService
    {
        void Cadastrar(PessoaDto pessoaDto);
        IEnumerable<PessoaDto> Listar();
    }
}