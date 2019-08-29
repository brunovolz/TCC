namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocoesRemove : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locacao", "Cliente_Id", "dbo.Cliente");
            DropIndex("dbo.Locacao", new[] { "Cliente_Id" });
            DropColumn("dbo.Locacao", "StatusLocacao");
            DropColumn("dbo.Locacao", "Cliente_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locacao", "Cliente_Id", c => c.Int());
            AddColumn("dbo.Locacao", "StatusLocacao", c => c.Int(nullable: false));
            CreateIndex("dbo.Locacao", "Cliente_Id");
            AddForeignKey("dbo.Locacao", "Cliente_Id", "dbo.Cliente", "Id");
        }
    }
}
