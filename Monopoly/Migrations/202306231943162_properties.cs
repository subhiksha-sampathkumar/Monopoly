namespace Monopoly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class properties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyID = c.Int(nullable: false, identity: true),
                        PropertyName = c.String(),
                        PropertyRent = c.Int(nullable: false),
                        PropertyPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
        }
    }
}
