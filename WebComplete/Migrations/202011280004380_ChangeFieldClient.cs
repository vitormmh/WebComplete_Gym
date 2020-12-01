namespace WebComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFieldClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clients", "Mail", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Mail", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
