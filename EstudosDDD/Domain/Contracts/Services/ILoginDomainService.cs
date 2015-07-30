using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Services
{
    public interface ILoginDomainService
    {
        bool Logar(LoginEntity l);
    }
}
