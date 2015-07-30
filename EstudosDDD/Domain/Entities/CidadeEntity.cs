using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDDD.Domain.Entities
{
    public class CidadeEntity : Core.Entity<int>
    {
        public string Nome { get; set; }
        public int CodigoEstado { get; set; }
        public EstadoEntity Estado { get; set; }
    }
}
