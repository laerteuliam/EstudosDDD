using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceInserir<TEntity,TCodigo>
        where TEntity : Entity<TCodigo>
    {
        int Inserir(TEntity t);
    }
}