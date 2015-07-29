using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Repositories
{
    public interface IRepositoryLogin : 
        Core.IRepositoryAdd<LoginEntity,int>
    {
        void GetByLoginSenha(string login, string senha);
    }
}