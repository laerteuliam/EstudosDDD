using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Contracts.Services;

namespace EstudosDDD.Domain.Services
{
    public sealed class PessoaDomainService : IPessoaDomainService
    {
        public int Cadastrar(Entities.PessoaEntity t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.PessoaEntity> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
