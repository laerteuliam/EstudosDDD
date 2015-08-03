using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Application.Contracts;
using EstudosDDD.Application.Converters;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Contracts.Services;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Application.Services
{
    public class PessoaApplicationService : 
        Core.ApplicationService,
        IPessoaApplicationService
    {
        private readonly IPessoaDomainService _pessoaDomainService;
        private readonly IRepositoryPessoa _repositoryPessoa;

        public PessoaApplicationService(IPessoaDomainService pessoaDomainService,
            IRepositoryPessoa repositoryPessoa)
        {
            _pessoaDomainService = pessoaDomainService;
            _repositoryPessoa = repositoryPessoa;
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
