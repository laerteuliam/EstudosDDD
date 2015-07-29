using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
            
            #endregion

            #region Configurações

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
