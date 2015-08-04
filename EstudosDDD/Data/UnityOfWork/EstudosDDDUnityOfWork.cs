using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.UnitOfWork;

namespace EstudosDDD.Data.UnityOfWork
{
    public sealed class EstudosDDDUnityOfWork : IEstudosDDDUnityOfWork
    {
        private readonly EstudosDbContext _context;
        
        public EstudosDDDUnityOfWork()
        {
           
        }

        public void Begin()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
