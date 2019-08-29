namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Cliente", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Cliente", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Cliente", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Cor", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Cor", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Cor", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Cor", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Locacao", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Locacao", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Locacao", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Locacao", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Marca", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Marca", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Marca", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Marca", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.TipoVeiculo", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.TipoVeiculo", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.TipoVeiculo", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.TipoVeiculo", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Modelo", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Modelo", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Modelo", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Modelo", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Periodo", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Periodo", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Periodo", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Periodo", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.TermoUso", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.TermoUso", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.TermoUso", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.TermoUso", "DataAlteracao", c => c.DateTime());
            AlterColumn("dbo.Usuario", "UsuarioCriacao", c => c.Int());
            AlterColumn("dbo.Usuario", "UsuarioAlteracao", c => c.Int());
            AlterColumn("dbo.Usuario", "DataCriacao", c => c.DateTime());
            AlterColumn("dbo.Usuario", "DataAlteracao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Usuario", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Usuario", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuario", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.TermoUso", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TermoUso", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TermoUso", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.TermoUso", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Periodo", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Periodo", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Periodo", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Periodo", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Modelo", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Modelo", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Modelo", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Modelo", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.TipoVeiculo", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TipoVeiculo", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TipoVeiculo", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.TipoVeiculo", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Marca", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Marca", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Marca", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Marca", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacao", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Cor", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cor", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cor", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Cor", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "DataAlteracao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cliente", "DataCriacao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cliente", "UsuarioAlteracao", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "UsuarioCriacao", c => c.Int(nullable: false));
        }
    }
}
