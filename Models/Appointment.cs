using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class Appointment
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
        public SpecialityTypes? Genders { get; set; }

        public enum SpecialityTypes
        {
 Outrho,

 NeuroSergon,

Anesthesiology,

Dermatology,

Diagnostic,

InternalMedicine,

MedicalGenetics,

Neurology,

Nuclearmedicine,

ObstetricsAndGynecology,

Ophthalmology,

Pathology,

Pediatrics,
        }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDate{ get; set; }

        [Display(Name ="Appointment Approve")]
        public bool Approve { get; set; }
    }
}