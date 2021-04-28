using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class FeedBack
    {
        [Key]
        [Required]
        public int FeedBackID { get; set; }
        
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "About Doctor FeedBack")]
        public String DoctorFeedBack{ get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "About Hospital FeedBack")]
        public String HospitalFeedBack { get; set; }
    }
}