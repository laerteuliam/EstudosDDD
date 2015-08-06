using System.Data.Entity.Migrations;

namespace EstudosDDD.Data.Migrations
{
    public partial class PessoaEndereco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CidadeEntity",
                c => new
                {
                    Codigo = c.Int(false, true),
                    Nome = c.String(),
                    CodigoEstado = c.Int(false),
                    DataCadastro = c.DateTime(false),
                })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.EstadoEntity", t => t.CodigoEstado)
                .Index(t => t.CodigoEstado);

            CreateTable(
                "dbo.EstadoEntity",
                c => new
                {
                    Codigo = c.Int(false, true),
                    Estado = c.String(),
                    Sigla = c.String(),
                    DataCadastro = c.DateTime(false),
                })
                .PrimaryKey(t => t.Codigo);

            CreateTable(
                "dbo.Endereco",
                c => new
                {
                    Codigo = c.Int(false, true),
                    TipoLogradouro = c.Int(false),
                    Logradouro = c.String(),
                    Complemento = c.String(),
                    Numero = c.String(),
                    CEP = c.String(),
                    CodigoCidade = c.Int(false),
                    DataCadastro = c.DateTime(false),
                })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.CidadeEntity", t => t.CodigoCidade)
                .Index(t => t.CodigoCidade);

            CreateTable(
                "dbo.Pessoa",
                c => new
                {
                    Codigo = c.Int(false, true),
                    CodigoLogin = c.Int(false),
                    Nome = c.String(maxLength: 100, unicode: false),
                    SobreNome = c.String(maxLength: 100, unicode: false),
                    DataNascimento = c.DateTime(false),
                    CodigoEndereco = c.Int(),
                    DataCadastro = c.DateTime(false),
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
            DropIndex("dbo.Pessoa", new[] {"CodigoEndereco"});
            DropIndex("dbo.Pessoa", new[] {"CodigoLogin"});
            DropIndex("dbo.Endereco", new[] {"CodigoCidade"});
            DropIndex("dbo.CidadeEntity", new[] {"CodigoEstado"});
            DropTable("dbo.Pessoa");
            DropTable("dbo.Endereco");
            DropTable("dbo.EstadoEntity");
            DropTable("dbo.CidadeEntity");
        }
    }
}