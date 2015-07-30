using System.Data.Entity.ModelConfiguration;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Mappings
{
    public sealed class LoginMap
        : EntityTypeConfiguration<LoginEntity>
    {
        public LoginMap()
        {
            ToTable("Login");
            HasKey(x => x.Codigo);

            Property(x => x.Login)
                .HasColumnName("Login")
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(x => x.Senha)
                .HasMaxLength(12)
                .HasColumnName("Senha")
                .HasColumnType("varchar");
        }
    }
}