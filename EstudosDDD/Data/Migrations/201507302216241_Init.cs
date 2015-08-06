using System.Data.Entity.Migrations;

namespace EstudosDDD.Data.Migrations
{
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                {
                    Codigo = c.Int(false, true),
                    Login = c.String(maxLength: 20, unicode: false),
                    Senha = c.String(maxLength: 12, unicode: false),
                    DataCadastro = c.DateTime(false),
                })
                .PrimaryKey(t => t.Codigo);
        }

        public override void Down()
        {
            DropTable("dbo.Login");
        }
    }
}