namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PODetail",
                c => new
                    {
                        SerialNumber = c.Int(nullable: false, identity: true),
                        PONumber = c.Int(nullable: false),
                        ItemCode = c.String(nullable: false),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Rate = c.Double(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SerialNumber)
                .ForeignKey("dbo.PurchaseMasters", t => t.PONumber, cascadeDelete: true)
                .Index(t => t.PONumber);
            
            CreateTable(
                "dbo.PurchaseMasters",
                c => new
                    {
                        PONumber = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(nullable: false, maxLength: 20),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PONumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PODetail", "PONumber", "dbo.PurchaseMasters");
            DropIndex("dbo.PODetail", new[] { "PONumber" });
            DropTable("dbo.PurchaseMasters");
            DropTable("dbo.PODetail");
        }
    }
}
