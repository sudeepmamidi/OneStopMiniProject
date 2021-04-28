namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateQuestionsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        que_id = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Ease = c.Int(nullable: false),
                        Fast = c.Int(nullable: false),
                        Overall = c.Int(nullable: false),
                        Suggestions = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.que_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
