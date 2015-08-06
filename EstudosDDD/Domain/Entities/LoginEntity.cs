using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Infra.CrossCutting.Resources;

namespace EstudosDDD.Domain.Entities
{
    public sealed class LoginEntity : Core.Entity<int>
    {
        private LoginEntity()
        {
            
        }

        public LoginEntity(string login, string senha)
        {
            if(senha.Length<6)
                throw new ApplicationException(string.Format(Messages.LoginSenhaMinimoCaracteres,6));
            
            if(login.Length<3)
                throw new ApplicationException(string.Format(Messages.LoginMinimoCaracteres,3));

            Login = login;
            Senha = senha;
        }
        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}
