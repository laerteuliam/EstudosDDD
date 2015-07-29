namespace EstudosDDD.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryDelete<TCodigo>
    {
        void Delete(TCodigo t);
    }
}