namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TVPlaca : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "Placa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "Placa");
        }
    }
}
