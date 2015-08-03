namespace EstudosDDD.Domain.Contracts.UnitOfWork.Core
{
    public interface IUnityOfWork
    {
        void Begin();
        void SaveChanges();
    }
}