using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Domain.Entities.Core
{
    public abstract class Entity<TCodigo>
    {
        public TCodigo Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
