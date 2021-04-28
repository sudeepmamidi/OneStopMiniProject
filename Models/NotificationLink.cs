using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class NotificationLink
    {
        [Key]
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "HospitalId")]
        public string Hospital_id { get; set; }
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Hosiptal Name")]
        public string Hospial_Name { get; set; }
        public bool Approvalstatus { get; set; }
    }
}