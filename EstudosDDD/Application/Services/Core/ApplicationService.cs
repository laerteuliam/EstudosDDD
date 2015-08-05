using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Contracts.UnitOfWork;
using Microsoft.Practices.ServiceLocation;

namespace EstudosDDD.Application.Services.Core
{
    public abstract class ApplicationService
    {
        private IEstudosDDDUnityOfWork _context;

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
