namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateHospitalAdminTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HospitalAdmins",
                c => new
                    {
                        hospitaladmin_id = c.Int(nullable: false, identity: true),
                        hadmin_name = c.String(nullable: false),
                        email = c.String(nullable: false),
                        hadmin_password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.hospitaladmin_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HospitalAdmins");
        }
    }
}
