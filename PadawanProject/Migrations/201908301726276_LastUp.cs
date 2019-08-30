namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastUp : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Locacao", name: "TermoId", newName: "TermoUsoId");
            RenameIndex(table: "dbo.Locacao", name: "IX_TermoId", newName: "IX_TermoUsoId");
            AddColumn("dbo.Locacao", "AceitarTermoUso", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "AceitarTermoUso");
            RenameIndex(table: "dbo.Locacao", name: "IX_TermoUsoId", newName: "IX_TermoId");
            RenameColumn(table: "dbo.Locacao", name: "TermoUsoId", newName: "TermoId");
        }
    }
}
