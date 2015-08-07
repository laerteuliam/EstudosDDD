using EstudosDDD.Domain.Contracts.Repositories.Core;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Repositories
{
    public interface IPessoaRepository :
        IRepositoryAdd<PessoaEntity, int>,
        IRepositoryGetAll<PessoaEntity, int>
    {
    }
}