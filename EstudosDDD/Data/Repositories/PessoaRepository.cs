using System;
using System.Collections.Generic;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Repositories
{
    public sealed class PessoaRepository : IRepositoryPessoa
    {
        private readonly EstudosDDDContext _context;

        public PessoaRepository(EstudosDDDContext context)
        {
            _context = context;
        }

        public int Add(PessoaEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}