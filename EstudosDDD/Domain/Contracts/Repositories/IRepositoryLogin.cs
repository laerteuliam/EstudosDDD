using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Repositories
{
    public interface IRepositoryLogin : 
        Core.IRepositoryAdd<LoginEntity,int>
    {
        LoginEntity GetByLoginSenha(string login, string senha);
    }
}