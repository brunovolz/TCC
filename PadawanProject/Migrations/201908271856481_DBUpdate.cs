namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUpdate : DbMigration
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
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusLocacao = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                        Cor_Id = c.Int(),
                        Marca_Id = c.Int(),
                        Modelo_Id = c.Int(),
                        Periodo_Id = c.Int(),
                        Termo_Id = c.Int(),
                        TipoVeiculo_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .ForeignKey("dbo.Cor", t => t.Cor_Id)
                .ForeignKey("dbo.Marca", t => t.Marca_Id)
                .ForeignKey("dbo.Modelo", t => t.Modelo_Id)
                .ForeignKey("dbo.Periodo", t => t.Periodo_Id)
                .ForeignKey("dbo.TermoUso", t => t.Termo_Id)
                .ForeignKey("dbo.TipoVeiculo", t => t.TipoVeiculo_Id)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Cor_Id)
                .Index(t => t.Marca_Id)
                .Index(t => t.Modelo_Id)
                .Index(t => t.Periodo_Id)
                .Index(t => t.Termo_Id)
                .Index(t => t.TipoVeiculo_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        TipoVeiculo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculo", t => t.TipoVeiculo_Id)
                .Index(t => t.TipoVeiculo_Id);
            
            CreateTable(
                "dbo.TipoVeiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Marca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marca", t => t.Marca_Id)
                .Index(t => t.Marca_Id);
            
            CreateTable(
                "dbo.Periodo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InicioLocacao = c.DateTime(nullable: false),
                        FimLocacao = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TermoUso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
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
                        DataNasc = c.DateTime(nullable: false),
                        Pcd = c.Boolean(nullable: false),
                        Cidade = c.Boolean(nullable: false),
                        Noturno = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacao", "Usuario_Id", "dbo.Usuario");
            DropForeignKey("dbo.Locacao", "TipoVeiculo_Id", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Locacao", "Termo_Id", "dbo.TermoUso");
            DropForeignKey("dbo.Locacao", "Periodo_Id", "dbo.Periodo");
            DropForeignKey("dbo.Locacao", "Modelo_Id", "dbo.Modelo");
            DropForeignKey("dbo.Modelo", "Marca_Id", "dbo.Marca");
            DropForeignKey("dbo.Locacao", "Marca_Id", "dbo.Marca");
            DropForeignKey("dbo.Marca", "TipoVeiculo_Id", "dbo.TipoVeiculo");
            DropForeignKey("dbo.Locacao", "Cor_Id", "dbo.Cor");
            DropForeignKey("dbo.Locacao", "Cliente_Id", "dbo.Cliente");
            DropIndex("dbo.Modelo", new[] { "Marca_Id" });
            DropIndex("dbo.Marca", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Locacao", new[] { "Usuario_Id" });
            DropIndex("dbo.Locacao", new[] { "TipoVeiculo_Id" });
            DropIndex("dbo.Locacao", new[] { "Termo_Id" });
            DropIndex("dbo.Locacao", new[] { "Periodo_Id" });
            DropIndex("dbo.Locacao", new[] { "Modelo_Id" });
            DropIndex("dbo.Locacao", new[] { "Marca_Id" });
            DropIndex("dbo.Locacao", new[] { "Cor_Id" });
            DropIndex("dbo.Locacao", new[] { "Cliente_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.TermoUso");
            DropTable("dbo.Periodo");
            DropTable("dbo.Modelo");
            DropTable("dbo.TipoVeiculo");
            DropTable("dbo.Marca");
            DropTable("dbo.Locacao");
            DropTable("dbo.Cor");
            DropTable("dbo.Cliente");
        }
    }
}
