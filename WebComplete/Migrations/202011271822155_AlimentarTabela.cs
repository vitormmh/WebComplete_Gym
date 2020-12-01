namespace WebComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlimentarTabela : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Plans Values ('Plano A',60)");
            Sql("Insert Into Plans Values ('Plano B',80)");
            Sql("Insert Into Plans Values ('Plano C',120)");
        }
        
        public override void Down()
        {
        }
    }
}
