using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Contracts.Services;

namespace EstudosDDD.Domain.Services
{
    public sealed class PessoaDomainService : IPessoaDomainService
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public PessoaDomainService(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        public void Cadastrar(Entities.PessoaEntity entity)
        {
            _repositoryPessoa.Add(entity);
        }

        public IEnumerable<Entities.PessoaEntity> Listar()
        {
            return _repositoryPessoa.GetAll();
        }
    }
}
