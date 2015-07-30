using EstudosDDD.Domain.Entities.Core;
using EstudosDDD.Domain.ValueObjects;

namespace EstudosDDD.Domain.Entities
{
    public sealed class EnderecoEntity : Entity<int>
    {
        public TipoLogradouroValueObject TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public int CodigoCidade { get; set; }
        public CidadeEntity Cidade { get; set; }
    }
}
