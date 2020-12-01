namespace WebComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelacionarTabelaClientePlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Mail", c => c.String());
            AddColumn("dbo.Clients", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "SubscribeDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "PlanID", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "PlanID");
            AddForeignKey("dbo.Clients", "PlanID", "dbo.Plans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "PlanID", "dbo.Plans");
            DropIndex("dbo.Clients", new[] { "PlanID" });
            DropColumn("dbo.Clients", "PlanID");
            DropColumn("dbo.Clients", "SubscribeDate");
            DropColumn("dbo.Clients", "BirthDate");
            DropColumn("dbo.Clients", "Mail");
        }
    }
}
