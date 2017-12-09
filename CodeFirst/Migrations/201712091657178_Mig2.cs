namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EmpCode = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProductMasters", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));

            CreateStoredProcedure("dbo.GetProductDetails",p=>new {PONumber=p.Int() }, @"select * from PurchaseMasters pm 
                    Inner join PODetail pd on pm.PONumber = pd.PONumber where pm.PONumber=@PONumber");
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductMasters", "UnitPrice");
            DropTable("dbo.EmployeeMasters");
            DropStoredProcedure("dbo.GetProductDetails");

        }
    }
}
