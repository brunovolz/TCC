namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocacaoId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locacao", "Cor_Id", "dbo.Cor");
            DropForeignKey("dbo.Locacao", "Marca_Id", "dbo.Marca");
            DropForeignKey("dbo.Locacao", "Modelo_Id", "dbo.Modelo");
            DropForeignKey("dbo.Locacao", "Periodo_Id", "dbo.Periodo");
            DropForeignKey("dbo.Locacao", "Termo_Id", "dbo.TermoUso");
            DropForeignKey("dbo.Locacao", "TipoVeiculo_Id", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Locacao", "Usuario_Id", "dbo.Usuario");
            DropIndex("dbo.Locacao", new[] { "Cor_Id" });
            DropIndex("dbo.Locacao", new[] { "Marca_Id" });
            DropIndex("dbo.Locacao", new[] { "Modelo_Id" });
            DropIndex("dbo.Locacao", new[] { "Periodo_Id" });
            DropIndex("dbo.Locacao", new[] { "Termo_Id" });
            DropIndex("dbo.Locacao", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Locacao", new[] { "Usuario_Id" });
            RenameColumn(table: "dbo.Locacao", name: "Cor_Id", newName: "CorId");
            RenameColumn(table: "dbo.Locacao", name: "Marca_Id", newName: "MarcaId");
            RenameColumn(table: "dbo.Locacao", name: "Modelo_Id", newName: "ModeloId");
            RenameColumn(table: "dbo.Locacao", name: "Periodo_Id", newName: "PeriodoId");
            RenameColumn(table: "dbo.Locacao", name: "Termo_Id", newName: "TermoId");
            RenameColumn(table: "dbo.Locacao", name: "TipoVeiculo_Id", newName: "TipoVeiculoId");
            RenameColumn(table: "dbo.Locacao", name: "Usuario_Id", newName: "UsuarioId");
            AlterColumn("dbo.Locacao", "CorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "MarcaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "ModeloId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "PeriodoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "TermoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "TipoVeiculoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "UsuarioId", c => c.Int(nullable: false));
            CreateIndex("dbo.Locacao", "TipoVeiculoId");
            CreateIndex("dbo.Locacao", "MarcaId");
            CreateIndex("dbo.Locacao", "ModeloId");
            CreateIndex("dbo.Locacao", "CorId");
            CreateIndex("dbo.Locacao", "PeriodoId");
            CreateIndex("dbo.Locacao", "UsuarioId");
            CreateIndex("dbo.Locacao", "TermoId");
            AddForeignKey("dbo.Locacao", "CorId", "dbo.Cor", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacao", "MarcaId", "dbo.Marca", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacao", "ModeloId", "dbo.Modelo", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacao", "PeriodoId", "dbo.Periodo", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacao", "TermoId", "dbo.TermoUso", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacao", "TipoVeiculoId", "dbo.TipoVeiculo", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacao", "UsuarioId", "dbo.Usuario", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
           
        }
    }
}
