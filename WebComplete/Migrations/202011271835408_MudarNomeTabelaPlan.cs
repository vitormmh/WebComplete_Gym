namespace WebComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudarNomeTabelaPlan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plans", "Name", c => c.String(nullable: false, maxLength: 120));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plans", "Name", c => c.String());
        }
    }
}
