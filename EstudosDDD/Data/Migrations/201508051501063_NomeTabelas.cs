using System.Data.Entity.Migrations;

namespace EstudosDDD.Data.Migrations
{
    public partial class NomeTabelas : DbMigration
    {
        public override void Up()
        {
            RenameTable("dbo.CidadeEntity", "Cidade");
            RenameTable("dbo.EstadoEntity", "Estado");
        }

        public override void Down()
        {
            RenameTable("dbo.Estado", "EstadoEntity");
            RenameTable("dbo.Cidade", "CidadeEntity");
        }
    }
}