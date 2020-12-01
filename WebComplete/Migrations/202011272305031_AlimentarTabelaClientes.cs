namespace WebComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlimentarTabelaClientes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Clients Values('Joao Maria','jmaria@gmail.com','2020-01-02', '2020-10-19','1')");
            Sql("Insert Into Clients Values('Antoio Campos','acampos@gmail.com','2020-01-03', '2020-10-19','2')");
            Sql("Insert Into Clients Values('Adelaide Ferreia','aferreira@sapo.pt','2020-01-05', '2020-10-19','1')");
            Sql("Insert Into Clients Values('Americo Venancio','CLima@alianca.com','2020-12-23', '2020-10-19','2')");
        }
        
        public override void Down()
        {
        }
    }
}
