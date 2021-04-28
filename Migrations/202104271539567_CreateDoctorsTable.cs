namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDoctorsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "DoctorName", c => c.String(nullable: false));
            AddColumn("dbo.Doctors", "HospitalId", c => c.String(nullable: false));
            AddColumn("dbo.Doctors", "HospitalName", c => c.String(nullable: false));
            DropColumn("dbo.Doctors", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Doctors", "HospitalName");
            DropColumn("dbo.Doctors", "HospitalId");
            DropColumn("dbo.Doctors", "DoctorName");
        }
    }
}
