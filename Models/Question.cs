using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneStopMiniProject.Models
{
    public class Question
    {
        [Key]
        public int que_id { get; set; }

        [Required(ErrorMessage = "Rating Required")]
        [Display(Name = "Rating from 1 to 10")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Field required")]
        [Display(Name = " Rate Understandability from 1 to 10")]
        public int Ease { get; set; }

        [Required(ErrorMessage = "Field required")]
        [Display(Name = "Rate fastness of application from 1 to 10")]
        public int Fast { get; set; }

        [Required(ErrorMessage = "Overall Rating required")]
        [Display(Name = "Overall Rating from 1 to 10")]
        public int Overall { get; set; }

        [Required(ErrorMessage = "Field required")]
        [Display(Name = "Suggestions")]
        public string Suggestions { get; set; }

    }
}