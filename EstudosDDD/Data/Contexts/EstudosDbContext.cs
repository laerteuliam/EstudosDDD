using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EstudosDDD.Data.Mappings;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Contexts
{
    public sealed class EstudosDbContext : DbContext
    {
        public EstudosDbContext()
            : base(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=EstudosDDD;Integrated Security=true")
        {
        }

        public DbSet<PessoaEntity> PessoaEntities { get; set; }
        public DbSet<LoginEntity> LoginEntities { get; set; }
        public DbSet<EnderecoEntity> EnderecoEntities { get; set; }
        public DbSet<CidadeEntity> CidadeEntities { get; set; }
        public DbSet<EstadoEntity> EstadoEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Convenções

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #endregion

            #region Mappings

            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EstadoMap());

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}