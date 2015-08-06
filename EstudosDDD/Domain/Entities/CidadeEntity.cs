using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Entities
{
    public class CidadeEntity : Entity<int>
    {
        public string Nome { get; set; }
        public int CodigoEstado { get; set; }
        public EstadoEntity Estado { get; set; }
    }
}