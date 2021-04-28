namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFeedBackTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        FeedBackID = c.Int(nullable: false, identity: true),
                        DoctorFeedBack = c.String(nullable: false),
                        HospitalFeedBack = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FeedBackID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FeedBacks");
        }
    }
}
