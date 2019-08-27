namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAtivo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cor", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cor", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Cor", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Cor", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cor", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Locacao", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Locacao", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Locacao", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Locacao", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Locacao", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Marca", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Marca", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Marca", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Marca", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Marca", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.TipoVeiculo", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.TipoVeiculo", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.TipoVeiculo", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.TipoVeiculo", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.TipoVeiculo", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Modelo", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Modelo", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Modelo", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Modelo", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Modelo", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Periodo", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Periodo", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Periodo", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Periodo", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Periodo", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.TermoUso", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.TermoUso", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.TermoUso", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.TermoUso", "DataAlteracao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TermoUso", "DataAlteracao");
            DropColumn("dbo.TermoUso", "DataCriacao");
            DropColumn("dbo.TermoUso", "UsuarioAlteracao");
            DropColumn("dbo.TermoUso", "UsuarioCriacao");
            DropColumn("dbo.Periodo", "DataAlteracao");
            DropColumn("dbo.Periodo", "DataCriacao");
            DropColumn("dbo.Periodo", "UsuarioAlteracao");
            DropColumn("dbo.Periodo", "UsuarioCriacao");
            DropColumn("dbo.Periodo", "Ativo");
            DropColumn("dbo.Modelo", "DataAlteracao");
            DropColumn("dbo.Modelo", "DataCriacao");
            DropColumn("dbo.Modelo", "UsuarioAlteracao");
            DropColumn("dbo.Modelo", "UsuarioCriacao");
            DropColumn("dbo.Modelo", "Ativo");
            DropColumn("dbo.TipoVeiculo", "DataAlteracao");
            DropColumn("dbo.TipoVeiculo", "DataCriacao");
            DropColumn("dbo.TipoVeiculo", "UsuarioAlteracao");
            DropColumn("dbo.TipoVeiculo", "UsuarioCriacao");
            DropColumn("dbo.TipoVeiculo", "Ativo");
            DropColumn("dbo.Marca", "DataAlteracao");
            DropColumn("dbo.Marca", "DataCriacao");
            DropColumn("dbo.Marca", "UsuarioAlteracao");
            DropColumn("dbo.Marca", "UsuarioCriacao");
            DropColumn("dbo.Marca", "Ativo");
            DropColumn("dbo.Locacao", "DataAlteracao");
            DropColumn("dbo.Locacao", "DataCriacao");
            DropColumn("dbo.Locacao", "UsuarioAlteracao");
            DropColumn("dbo.Locacao", "UsuarioCriacao");
            DropColumn("dbo.Locacao", "Ativo");
            DropColumn("dbo.Cor", "DataAlteracao");
            DropColumn("dbo.Cor", "DataCriacao");
            DropColumn("dbo.Cor", "UsuarioAlteracao");
            DropColumn("dbo.Cor", "UsuarioCriacao");
            DropColumn("dbo.Cor", "Ativo");
        }
    }
}
