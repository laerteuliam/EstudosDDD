using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Data.Repositories
{
    public sealed class LoginRepository : IRepositoryLogin
    {
        private readonly EstudosDbContext _context;

        public LoginRepository(EstudosDbContext context)
        {
            _context = context;
        }

        public void Add(Domain.Entities.LoginEntity entity)
        {
            throw new NotImplementedException();
        }

        Domain.Entities.LoginEntity IRepositoryLogin.GetByLoginSenha(string login, string senha)
        {
            var ret = _context.LoginEntities.FirstOrDefault(x => x.Login == login && x.Senha==senha);
            return ret;
        }
    }
}
