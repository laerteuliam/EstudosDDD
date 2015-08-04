using System;
using System.Collections.Generic;
using System.Linq;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Repositories
{
    public sealed class PessoaRepository : IRepositoryPessoa
    {
        private readonly EstudosDbContext _context;

        public PessoaRepository(EstudosDbContext context)
        {
            _context = context;
        }

        public void Add(PessoaEntity entity)
        {
            _context.LoginEntities.Add(entity.Login);

        }

        public IEnumerable<PessoaEntity> GetAll()
        {
            return _context.PessoaEntities.ToList();
        }
    }
}