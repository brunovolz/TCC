namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Periodotype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Periodo", "Quantidade", c => c.Int(nullable: false));
            AddColumn("dbo.Periodo", "TipoVeiculo_Id", c => c.Int());
            CreateIndex("dbo.Periodo", "TipoVeiculo_Id");
            AddForeignKey("dbo.Periodo", "TipoVeiculo_Id", "dbo.TipoVeiculo", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Periodo", "TipoVeiculo_Id", "dbo.TipoVeiculo");
            DropIndex("dbo.Periodo", new[] { "TipoVeiculo_Id" });
            DropColumn("dbo.Periodo", "TipoVeiculo_Id");
            DropColumn("dbo.Periodo", "Quantidade");
        }
    }
}
