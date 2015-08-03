using System.Data.Entity.ModelConfiguration;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Mappings
{
    public sealed class PessoaMap
        : EntityTypeConfiguration<PessoaEntity>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");
            HasKey(x => x.Codigo);

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(x => x.SobreNome)
                .HasColumnName("SobreNome")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(x => x.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("Datetime");

            HasRequired(x => x.Login)
                .WithMany()
                .HasForeignKey(x => x.CodigoLogin);

            HasOptional(x => x.Endereco)
                .WithMany()
                .HasForeignKey(x => x.CodigoEndereco);
        }
    }
}