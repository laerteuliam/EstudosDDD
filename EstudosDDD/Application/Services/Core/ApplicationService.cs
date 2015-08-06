using EstudosDDD.Domain.Contracts.UnitOfWork;
using Microsoft.Practices.ServiceLocation;

namespace EstudosDDD.Application.Services.Core
{
    public abstract class ApplicationService
    {
        private readonly IEstudosDDDUnityOfWork _context;

        public ApplicationService()
        {
            _context = ServiceLocator.Current.GetInstance<IEstudosDDDUnityOfWork>();
        }

        public void Begin()
        {
            _context.Begin();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}