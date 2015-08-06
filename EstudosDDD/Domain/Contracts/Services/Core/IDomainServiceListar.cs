using System.Collections.Generic;
using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceListar<TEntity, TCodigo>
        where TEntity : Entity<TCodigo>
    {
        IEnumerable<TEntity> Listar();
    }
}