namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserControlOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Locacao", "UsuarioCriacao", c => c.Int());
            AddColumn("dbo.Locacao", "UsuarioAlteracao", c => c.Int());
            AddColumn("dbo.Locacao", "DataCriacao", c => c.DateTime());
            AddColumn("dbo.Locacao", "DataAlteracao", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "DataAlteracao");
            DropColumn("dbo.Locacao", "DataCriacao");
            DropColumn("dbo.Locacao", "UsuarioAlteracao");
            DropColumn("dbo.Locacao", "UsuarioCriacao");
            DropColumn("dbo.Locacao", "Ativo");
        }
    }
}
