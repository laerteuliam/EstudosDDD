namespace EstudosDDD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeTabelas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CidadeEntity", newName: "Cidade");
            RenameTable(name: "dbo.EstadoEntity", newName: "Estado");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Estado", newName: "EstadoEntity");
            RenameTable(name: "dbo.Cidade", newName: "CidadeEntity");
        }
    }
}
