namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateHospitalDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HospitalDetails",
                c => new
                    {
                        HospitalID = c.String(nullable: false, maxLength: 128),
                        HospitalName = c.String(nullable: false),
                        HospitalCity = c.String(nullable: false),
                        HospitalState = c.String(nullable: false),
                        Zip = c.Double(nullable: false),
                        Certification = c.String(nullable: false),
                        Operations = c.String(nullable: false),
                        Achivements = c.String(nullable: false),
                        Facilities = c.String(nullable: false),
                        Category = c.Int(),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HospitalID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HospitalDetails");
        }
    }
}
