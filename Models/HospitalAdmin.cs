using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class HospitalAdmin
    {
        [Key]
        public int hospitaladmin_id { get; set; }

        [Required(ErrorMessage ="Required FullName")]
        public String hadmin_name { get; set; }

        [Required(ErrorMessage ="Required EmailID")]
        public string email { get; set; }

        [Required(ErrorMessage ="Required Password")]
        public String hadmin_password { get; set; }
    }
}