using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Domain.Contracts.Services
{
    public interface ILoginDomainService
    {
        bool Logar(LoginEntity l);
    }
}