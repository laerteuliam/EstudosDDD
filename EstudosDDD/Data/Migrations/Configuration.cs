using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using EstudosDDD.Data.Contexts;
using EstudosDDD.Domain.Entities;

namespace EstudosDDD.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EstudosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EstudosDbContext context)
        {
            if (System.Diagnostics.Debugger.IsAttached == false) System.Diagnostics.Debugger.Launch();

            context.LoginEntities.AddOrUpdate(x => x.Login, new LoginEntity("login1", "senha1"));
            context.LoginEntities.AddOrUpdate(x => x.Login, new LoginEntity("login2", "senha2"));
            context.LoginEntities.AddOrUpdate(x => x.Login, new LoginEntity("login3", "senha3"));

            LoginEntity login = context.LoginEntities.FirstOrDefault(x => x.Login == "login1");
            context.PessoaEntities.AddOrUpdate(x => x.Nome, new PessoaEntity("nome1", "sobrenome1", new DateTime(1983,11,26),login));
        }
    }
}