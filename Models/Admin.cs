using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace OneStopMiniProject.Models
{
    public class Admin
    {
        [Key]
        public int admin_id { get; set; }

        [Required(ErrorMessage ="AdminName Required")]
        public string admin_name { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}