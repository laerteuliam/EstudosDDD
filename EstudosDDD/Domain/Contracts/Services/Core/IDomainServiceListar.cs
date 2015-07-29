
using System.Collections.Generic;

namespace EstudosDDD.Domain.Contracts.Services.Core
{
    public interface IDomainServiceListar<TEntity,TCodigo>
        where TEntity : Entities.Core.Entity<TCodigo>
    {
        IEnumerable<TEntity> Listar();
    }
}