using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Rest.Models
{
    public class RestViewModel
    {
        [Display(Name = "Reviewer Name:")]
        [Required]
        public string name { get; set; }
        [Display(Name = "Stars:")]
        [Required]
        public int stars { get; set; }
        [Display(Name = "Restaurant Name:")]
        [Required]
        public string rest_name { get; set; }
        [Display(Name = "Review:")]
        [Required]
        [MinLength (10, ErrorMessage="Must have more than 10 characters!")]
        public string review { get; set; }
        [Display(Name = "Date of visit:")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
    }
}