using System.Data.Entity.ModelConfiguration;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Mappings
{
    public sealed class EnderecoMap
        : EntityTypeConfiguration<EnderecoEntity>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");
            HasKey(x => x.Codigo);
        }
    }
}
