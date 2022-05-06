namespace AssignmentTwo_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForNameInAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountNumber = c.Int(nullable: false),
                        Name = c.String(),
                        CurrentBalance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.AccountNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
