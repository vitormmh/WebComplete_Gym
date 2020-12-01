namespace WebComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscrivedToNewsToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "IsSubscrivedToNews", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "IsSubscrivedToNews");
        }
    }
}
