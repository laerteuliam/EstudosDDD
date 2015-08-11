﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Contracts.Repositories.Core;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Repositories
{
    public sealed class PessoaRepository : IPessoaRepository
    {
        private readonly EstudosDbContext _context;

        public PessoaRepository(EstudosDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PessoaEntity> GetAll()
        {
            return _context.PessoaEntities.ToList();
        }

        public int Add(PessoaEntity entity)
        {
            _context.PessoaEntities.Add(entity);
            return _context.SaveChanges();
        }

        public void Update(PessoaEntity t)
        {
            var entity = _context.PessoaEntities.Find(t.Codigo);
            _context.Entry(entity).State = EntityState.Modified;

            entity.Nome = t.Nome;
            entity.SobreNome = t.SobreNome;
            entity.DataNascimento = t.DataNascimento;

            _context.SaveChanges();
        }
    }
}