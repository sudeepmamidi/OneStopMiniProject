using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }

       
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        public string PatientName { get; set; }

        [Display(Name = "PatientId")]
        public string PatientId { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Doctor Name")]
        public string Id { get; set; }

        [Display(Name = "Disease")]
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        public string Disease { get; set; }

        [Display(Name = "Prescription Provided")]
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        public string PrescriptionProvided { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy hh:mm:ss}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        public DateTime DateAndTime { get; set; }

        

    }
}