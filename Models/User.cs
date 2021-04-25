using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneStopMiniProject.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}", ApplyFormatInEditMode = true)]
        public DateTime DoB { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Display(Name = "Gender")]

        public GenderTypes? Genders { get; set; }

        public enum GenderTypes
        {
            Male,
            Female
        }


        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [RegularExpression("\\d{10}", ErrorMessage = "Please Enter 10 Numbers")]
        [Display(Name = "Phone Number")]
        public double ContactNumber { get; set; }
        [Required(ErrorMessage = "Email is a Required field.")]
        [Display(Name = "Email Id")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        [Key]
        [RegularExpression("^[a-zA-Z0-9_]*$", ErrorMessage = "Admin Id is Required and must be properly formatted.")]
        [Display(Name = "User Id")]

        public string UserId { get; set; }

        [Required(ErrorMessage = "Please update the highlighted mandatory fields")]
        public string Password { get; set; }

        public CategoryType? Category { get; set; }

        public enum     CategoryType
        {
            Patient,
            Doctor
        }
    }
}