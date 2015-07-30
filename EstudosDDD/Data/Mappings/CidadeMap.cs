using System.Data.Entity.ModelConfiguration;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Mappings
{
    public sealed class CidadeMap
        : EntityTypeConfiguration<CidadeEntity>
    {
        public CidadeMap()
        {
            HasKey(x => x.Codigo);
        }

    }
}
