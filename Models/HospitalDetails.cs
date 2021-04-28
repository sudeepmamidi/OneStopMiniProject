using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneStopMiniProject.Models
{
    public class HospitalDetails
    {
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Hospital Name")]
        public string HospitalName { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "City")]
        public string HospitalCity { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "State")]
        public string HospitalState { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "ZipCode")]
        public double Zip { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Certification")]
        public string Certification { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "SuccessFullOperation")]
        public string Operations { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Achivements")]
        public string Achivements { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Facilities Available")]
        public string Facilities { get; set; }

        public AdminCategory? Category { get; set; }

        public enum AdminCategory
        {
            HospitalAdmin
        }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "ClinicID")]
        [Key]
        public string HospitalID { get; set; }

        public bool Approved { get; set; }
    }
}