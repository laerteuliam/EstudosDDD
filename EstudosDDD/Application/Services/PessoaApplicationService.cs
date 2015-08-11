using System.Collections.Generic;
using System.Linq;
using EstudosDDD.Application.Contracts;
using EstudosDDD.Application.Converters;
using EstudosDDD.Application.Dtos;
using EstudosDDD.Application.Services.Core;
using EstudosDDD.Domain.Contracts.Services;

namespace EstudosDDD.Application.Services
{
    public sealed class PessoaApplicationService :
        Core.ApplicationService,
        IPessoaApplicationService
    {
        private readonly IPessoaDomainService _pessoaDomainService;

        public PessoaApplicationService(IPessoaDomainService pessoaDomainService)
        {
            _pessoaDomainService = pessoaDomainService;
        }

        public void Salvar(PessoaDto pessoaDto)
        {
            Begin();
            if(pessoaDto.Codigo>0)
                _pessoaDomainService.Editar(pessoaDto.ToEntity());
            else
                _pessoaDomainService.Inserir(pessoaDto.ToEntity());
            SaveChanges();
        }

        public IEnumerable<PessoaDto> Listar()
        {
            return _pessoaDomainService.Listar().ToList().ConvertAll(PessoaConverter.ToDto);
        }
    }
}