namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNotificationListTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotificationLinks",
                c => new
                    {
                        Hospital_id = c.String(nullable: false, maxLength: 128),
                        Hospial_Name = c.String(nullable: false),
                        Approvalstatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Hospital_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NotificationLinks");
        }
    }
}
