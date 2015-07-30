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
        private readonly EstudosDDDContext _context;

        public PessoaRepository(EstudosDDDContext context)
        {
            _context = context;
        }

        public int Add(PessoaEntity entity)
        {
            _context.LoginEntities.Add(entity.Login);
            int CodigoLogin = _context.SaveChanges();
            entity.CodigoLogin = CodigoLogin;
            _context.PessoaEntities.Add(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<PessoaEntity> GetAll()
        {
            return _context.PessoaEntities.ToList();
        }
    }
}