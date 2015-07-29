using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Repositories
{
    public sealed class PessoaRepository : Domain.Contracts.Repositories.IRepositoryPessoa
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
