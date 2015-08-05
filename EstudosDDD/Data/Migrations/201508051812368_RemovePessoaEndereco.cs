namespace EstudosDDD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePessoaEndereco : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pessoa", "CodigoEndereco", "dbo.Endereco");
            DropIndex("dbo.Pessoa", new[] { "CodigoEndereco" });
            DropColumn("dbo.Pessoa", "CodigoEndereco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoa", "CodigoEndereco", c => c.Int());
            CreateIndex("dbo.Pessoa", "CodigoEndereco");
            AddForeignKey("dbo.Pessoa", "CodigoEndereco", "dbo.Endereco", "Codigo");
        }
    }
}
