using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class Doctor
    {
       [Key]
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "DoctorId")]
        public String Doctorid { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Doctor Name")]
        public String DoctorName { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "HospitalId")]
        public String HospitalId { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Hospital Name")]
        public String HospitalName { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Speciality")]
        public string Speciality { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Availability From")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}", ApplyFormatInEditMode = true)]
        public DateTime AvailabilityFrom { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Availability to")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}", ApplyFormatInEditMode = true)]
        public DateTime AvailabilityTo { get; set; }
    }
}