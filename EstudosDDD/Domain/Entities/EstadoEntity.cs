using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Domain.Entities
{
    public sealed class EstadoEntity : Core.Entity<int>
    {
        public string Estado { get; set; }
        public string Sigla { get; set; }
    }
}
