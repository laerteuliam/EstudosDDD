using EstudosDDD.Domain.Entities.Core;

namespace EstudosDDD.Domain.Entities
{
    public sealed class EstadoEntity : Entity<int>
    {
        public string Estado { get; set; }
        public string Sigla { get; set; }
    }
}