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
            HasRequired(x => x.Estado).WithMany().HasForeignKey(x => x.CodigoEstado);
        }
    }
}