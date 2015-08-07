using System.Collections.Generic;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Contracts.Services;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Services
{
    public sealed class PessoaDomainService : IPessoaDomainService
    {
        private readonly IPessoaRepository _repositoryPessoa;

        public PessoaDomainService(IPessoaRepository repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        public void Cadastrar(PessoaEntity entity)
        {
            _repositoryPessoa.Add(entity);
        }

        public IEnumerable<PessoaEntity> Listar()
        {
            return _repositoryPessoa.GetAll();
        }
    }
}