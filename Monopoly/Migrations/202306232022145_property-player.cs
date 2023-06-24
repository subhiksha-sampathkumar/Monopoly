namespace Monopoly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propertyplayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "PlayerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Properties", "PlayerID");
            AddForeignKey("dbo.Properties", "PlayerID", "dbo.Player", "PlayerID",
                cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "PlayerID", "dbo.Player");
            DropIndex("dbo.Properties", new[] { "PlayerID" });
            DropColumn("dbo.Properties", "PlayerID");
        }
    }
}
