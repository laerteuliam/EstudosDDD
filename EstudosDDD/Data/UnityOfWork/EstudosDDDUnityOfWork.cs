﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Contracts.UnitOfWork;
using Microsoft.Practices.ServiceLocation;

namespace EstudosDDD.Data.UnityOfWork
{
    public sealed class EstudosDDDUnityOfWork : IEstudosDDDUnityOfWork
    {
        private EstudosDbContext _context;
        
        public void Begin()
        {
            _context = ServiceLocator.Current.GetInstance<EstudosDbContext>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
