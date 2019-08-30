namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ceasar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "StatusLocacaoFK", c => c.Int());
            AlterColumn("dbo.Usuario", "DataNasc", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "DataNasc", c => c.DateTime());
            DropColumn("dbo.Locacao", "StatusLocacaoFK");
        }
    }
}
