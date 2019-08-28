namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeingPeriodo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Marca", "TipoVeiculo_Id", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Modelo", "Marca_Id", "dbo.Marca");
            DropForeignKey("dbo.Periodo", "TipoVeiculo_Id", "dbo.TipoVeiculo");
            DropIndex("dbo.Marca", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Modelo", new[] { "Marca_Id" });
            DropIndex("dbo.Periodo", new[] { "TipoVeiculo_Id" });
            RenameColumn(table: "dbo.Marca", name: "TipoVeiculo_Id", newName: "TipoVeiculoMarcaFK");
            RenameColumn(table: "dbo.Modelo", name: "Marca_Id", newName: "TipoModeloMarcaFK");
            RenameColumn(table: "dbo.Periodo", name: "TipoVeiculo_Id", newName: "TipoVeiculoPeriodoFK");
            AlterColumn("dbo.Marca", "TipoVeiculoMarcaFK", c => c.Int(nullable: false));
            AlterColumn("dbo.Modelo", "TipoModeloMarcaFK", c => c.Int(nullable: false));
            AlterColumn("dbo.Periodo", "TipoVeiculoPeriodoFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Marca", "TipoVeiculoMarcaFK");
            CreateIndex("dbo.Modelo", "TipoModeloMarcaFK");
            CreateIndex("dbo.Periodo", "TipoVeiculoPeriodoFK");
            AddForeignKey("dbo.Marca", "TipoVeiculoMarcaFK", "dbo.TipoVeiculo", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Modelo", "TipoModeloMarcaFK", "dbo.Marca", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Periodo", "TipoVeiculoPeriodoFK", "dbo.TipoVeiculo", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Periodo", "TipoVeiculoPeriodoFK", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Modelo", "TipoModeloMarcaFK", "dbo.Marca");
            DropForeignKey("dbo.Marca", "TipoVeiculoMarcaFK", "dbo.TipoVeiculo");
            DropIndex("dbo.Periodo", new[] { "TipoVeiculoPeriodoFK" });
            DropIndex("dbo.Modelo", new[] { "TipoModeloMarcaFK" });
            DropIndex("dbo.Marca", new[] { "TipoVeiculoMarcaFK" });
            AlterColumn("dbo.Periodo", "TipoVeiculoPeriodoFK", c => c.Int());
            AlterColumn("dbo.Modelo", "TipoModeloMarcaFK", c => c.Int());
            AlterColumn("dbo.Marca", "TipoVeiculoMarcaFK", c => c.Int());
            RenameColumn(table: "dbo.Periodo", name: "TipoVeiculoPeriodoFK", newName: "TipoVeiculo_Id");
            RenameColumn(table: "dbo.Modelo", name: "TipoModeloMarcaFK", newName: "Marca_Id");
            RenameColumn(table: "dbo.Marca", name: "TipoVeiculoMarcaFK", newName: "TipoVeiculo_Id");
            CreateIndex("dbo.Periodo", "TipoVeiculo_Id");
            CreateIndex("dbo.Modelo", "Marca_Id");
            CreateIndex("dbo.Marca", "TipoVeiculo_Id");
            AddForeignKey("dbo.Periodo", "TipoVeiculo_Id", "dbo.TipoVeiculo", "Id");
            AddForeignKey("dbo.Modelo", "Marca_Id", "dbo.Marca", "Id");
            AddForeignKey("dbo.Marca", "TipoVeiculo_Id", "dbo.TipoVeiculo", "Id");
        }
    }
}
