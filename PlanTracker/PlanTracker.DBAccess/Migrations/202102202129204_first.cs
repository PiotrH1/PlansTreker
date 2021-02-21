namespace PlanTracker.DBAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DirectionName = c.String(maxLength: 100, unicode: false),
                        DirectionDescription = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        TodoID = c.Int(nullable: false, identity: true),
                        DirectionID = c.Int(nullable: false),
                        TodoName = c.String(maxLength: 100, unicode: false),
                        TodoDescription = c.String(),
                        CreatedtDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TodoID)
                .ForeignKey("dbo.Directions", t => t.DirectionID, cascadeDelete: true)
                .Index(t => t.DirectionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "DirectionID", "dbo.Directions");
            DropIndex("dbo.Todoes", new[] { "DirectionID" });
            DropTable("dbo.Todoes");
            DropTable("dbo.Directions");
        }
    }
}
