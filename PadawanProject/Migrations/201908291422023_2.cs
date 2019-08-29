namespace PadawanProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuario", "DataNasc", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "DataNasc", c => c.DateTime(nullable: false));
        }
    }
}
