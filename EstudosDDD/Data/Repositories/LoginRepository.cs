using System;
using System.Linq;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Repositories
{
    public sealed class LoginRepository : ILoginRepository
    {
        private readonly EstudosDbContext _context;

        public LoginRepository(EstudosDbContext context)
        {
            _context = context;
        }
    }
}