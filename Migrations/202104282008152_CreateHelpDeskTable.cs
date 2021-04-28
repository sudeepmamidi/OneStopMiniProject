namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateHelpDeskTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HelpDesks",
                c => new
                    {
                        Description = c.String(nullable: false, maxLength: 128),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Description);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HelpDesks");
        }
    }
}
