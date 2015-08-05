using System.Collections.Generic;
using System.Linq;
using EstudosDDD.Application.Contracts;
using EstudosDDD.Application.Converters;
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

        public void Cadastrar(Dtos.PessoaDto pessoaDto)
        {
            Begin();
            _pessoaDomainService.Cadastrar(pessoaDto.ToEntity());
            SaveChanges();
        }

        public IEnumerable<Dtos.PessoaDto> Listar()
        {
            return _pessoaDomainService.Listar().ToList().ConvertAll(PessoaConverter.ToDto);
        }
    }
}
