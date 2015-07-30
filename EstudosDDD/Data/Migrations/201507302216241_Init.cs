namespace EstudosDDD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 20, unicode: false),
                        Senha = c.String(maxLength: 12, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Login");
        }
    }
}
