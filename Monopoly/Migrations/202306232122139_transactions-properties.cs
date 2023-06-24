namespace Monopoly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transactionsproperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        TransactionType = c.String(),
                        TransactionRemarks = c.String(),
                    })
                .PrimaryKey(t => t.TransactionID);
            
            CreateTable(
                "dbo.TransactionProperties",
                c => new
                    {
                        Transaction_TransactionID = c.Int(nullable: false),
                        Property_PropertyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Transaction_TransactionID, t.Property_PropertyID })
                .ForeignKey("dbo.Transactions", t => t.Transaction_TransactionID, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.Property_PropertyID, cascadeDelete: true)
                .Index(t => t.Transaction_TransactionID)
                .Index(t => t.Property_PropertyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionProperties", "Property_PropertyID", "dbo.Properties");
            DropForeignKey("dbo.TransactionProperties", "Transaction_TransactionID", "dbo.Transactions");
            DropIndex("dbo.TransactionProperties", new[] { "Property_PropertyID" });
            DropIndex("dbo.TransactionProperties", new[] { "Transaction_TransactionID" });
            DropTable("dbo.TransactionProperties");
            DropTable("dbo.Transactions");
        }
    }
}
