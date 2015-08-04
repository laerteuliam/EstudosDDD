using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Contracts.Repositories;
using EstudosDDD.Domain.Contracts.Services;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Services
{
    public sealed class LoginDomainService : ILoginDomainService
    {
        private readonly IRepositoryLogin _repositoryLogin;

        public bool Logar(Entities.LoginEntity l)
        {
            LoginEntity login = null;
            login = _repositoryLogin.GetByLoginSenha(l.Login, l.Senha);
            return (login != null);
        }
    }
}
