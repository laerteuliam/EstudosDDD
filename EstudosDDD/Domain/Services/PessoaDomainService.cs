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

        public IEnumerable<PessoaEntity> Listar()
        {
            return _repositoryPessoa.GetAll();
        }

        public void Editar(PessoaEntity t)
        {
            _repositoryPessoa.Update(t);
        }

        public int Inserir(PessoaEntity t)
        {
            return _repositoryPessoa.Add(t);
        }
    }
}