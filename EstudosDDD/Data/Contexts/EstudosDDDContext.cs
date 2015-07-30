using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Data.Mappings;

namespace EstudosDDD.Data.Contexts
{
    public sealed class EstudosDDDContext : DbContext
    {
        public EstudosDDDContext()
            : base(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=EstudosDDD;Integrated Security=true")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Convenções
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.ManyToManyCascadeDeleteConvention>();
            #endregion

            #region Configurações
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Domain.Entities.PessoaEntity> PessoaEntities { get; set; }
        public DbSet<Domain.Entities.LoginEntity> LoginEntities { get; set; }
        public DbSet<Domain.Entities.EnderecoEntity> EnderecoEntities { get; set; }
        public DbSet<Domain.Entities.CidadeEntity> CidadeEntities { get; set; }
        public DbSet<Domain.Entities.EstadoEntity> EstadoEntities { get; set; }

    }
}
