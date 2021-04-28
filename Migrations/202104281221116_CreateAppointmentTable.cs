namespace OneStopMiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAppointmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Doctorid = c.String(nullable: false, maxLength: 128),
                        DoctorName = c.String(nullable: false),
                        HospitalId = c.String(nullable: false),
                        HospitalName = c.String(nullable: false),
                        Genders = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                        Approve = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Doctorid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appointments");
        }
    }
}
