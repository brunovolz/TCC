namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculoId = c.Int(nullable: false),
                        Placa = c.String(),
                        MarcaId = c.Int(),
                        CorId = c.Int(),
                        PeriodoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        TermoId = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cor", t => t.CorId)
                .ForeignKey("dbo.Marca", t => t.MarcaId)
                .ForeignKey("dbo.Periodo", t => t.PeriodoId, cascadeDelete: true)
                .ForeignKey("dbo.TermoUso", t => t.TermoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.MarcaId)
                .Index(t => t.CorId)
                .Index(t => t.PeriodoId)
                .Index(t => t.UsuarioId)
                .Index(t => t.TermoId);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        TipoVeiculoMarcaFK = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculo", t => t.TipoVeiculoMarcaFK, cascadeDelete: true)
                .Index(t => t.TipoVeiculoMarcaFK);
            
            CreateTable(
                "dbo.TipoVeiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Periodo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InicioLocacao = c.DateTime(nullable: false),
                        FimLocacao = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        TipoVeiculoPeriodoFK = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculo", t => t.TipoVeiculoPeriodoFK, cascadeDelete: true)
                .Index(t => t.TipoVeiculoPeriodoFK);
            
            CreateTable(
                "dbo.TermoUso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Matricula = c.String(),
                        Email = c.String(),
                        DataNasc = c.DateTime(),
                        Pcd = c.Boolean(nullable: false),
                        Cidade = c.Boolean(nullable: false),
                        Noturno = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        TipoModeloMarcaFK = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(),
                        UsuarioAlteracao = c.Int(),
                        DataCriacao = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marca", t => t.TipoModeloMarcaFK, cascadeDelete: true)
                .Index(t => t.TipoModeloMarcaFK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modelo", "TipoModeloMarcaFK", "dbo.Marca");
            DropForeignKey("dbo.Locacao", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Locacao", "TermoId", "dbo.TermoUso");
            DropForeignKey("dbo.Locacao", "PeriodoId", "dbo.Periodo");
            DropForeignKey("dbo.Periodo", "TipoVeiculoPeriodoFK", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Locacao", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Marca", "TipoVeiculoMarcaFK", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Locacao", "CorId", "dbo.Cor");
            DropIndex("dbo.Modelo", new[] { "TipoModeloMarcaFK" });
            DropIndex("dbo.Periodo", new[] { "TipoVeiculoPeriodoFK" });
            DropIndex("dbo.Marca", new[] { "TipoVeiculoMarcaFK" });
            DropIndex("dbo.Locacao", new[] { "TermoId" });
            DropIndex("dbo.Locacao", new[] { "UsuarioId" });
            DropIndex("dbo.Locacao", new[] { "PeriodoId" });
            DropIndex("dbo.Locacao", new[] { "CorId" });
            DropIndex("dbo.Locacao", new[] { "MarcaId" });
            DropTable("dbo.Modelo");
            DropTable("dbo.Usuario");
            DropTable("dbo.TermoUso");
            DropTable("dbo.Periodo");
            DropTable("dbo.TipoVeiculo");
            DropTable("dbo.Marca");
            DropTable("dbo.Locacao");
            DropTable("dbo.Cor");
            DropTable("dbo.Cliente");
        }
    }
}
