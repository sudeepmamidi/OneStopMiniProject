using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<HospitalAdmin> HospitalAdmins { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<HospitalDetails> HospitalDetails { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<NotificationLink> notificationLinks { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}