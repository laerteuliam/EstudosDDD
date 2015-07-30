namespace EstudosDDD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PessoaEndereco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CidadeEntity",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CodigoEstado = c.Int(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.EstadoEntity", t => t.CodigoEstado)
                .Index(t => t.CodigoEstado);
            
            CreateTable(
                "dbo.EstadoEntity",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Estado = c.String(),
                        Sigla = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        TipoLogradouro = c.Int(nullable: false),
                        Logradouro = c.String(),
                        Complemento = c.String(),
                        Numero = c.String(),
                        CEP = c.String(),
                        CodigoCidade = c.Int(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.CidadeEntity", t => t.CodigoCidade)
                .Index(t => t.CodigoCidade);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        CodigoLogin = c.Int(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        SobreNome = c.String(maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        CodigoEndereco = c.Int(),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Endereco", t => t.CodigoEndereco)
                .ForeignKey("dbo.Login", t => t.CodigoLogin)
                .Index(t => t.CodigoLogin)
                .Index(t => t.CodigoEndereco);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoa", "CodigoLogin", "dbo.Login");
            DropForeignKey("dbo.Pessoa", "CodigoEndereco", "dbo.Endereco");
            DropForeignKey("dbo.Endereco", "CodigoCidade", "dbo.CidadeEntity");
            DropForeignKey("dbo.CidadeEntity", "CodigoEstado", "dbo.EstadoEntity");
            DropIndex("dbo.Pessoa", new[] { "CodigoEndereco" });
            DropIndex("dbo.Pessoa", new[] { "CodigoLogin" });
            DropIndex("dbo.Endereco", new[] { "CodigoCidade" });
            DropIndex("dbo.CidadeEntity", new[] { "CodigoEstado" });
            DropTable("dbo.Pessoa");
            DropTable("dbo.Endereco");
            DropTable("dbo.EstadoEntity");
            DropTable("dbo.CidadeEntity");
        }
    }
}
