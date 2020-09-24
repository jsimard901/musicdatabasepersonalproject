using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Bands.Models
{
    public class ShowModel
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        [Required(ErrorMessage = "Show Date is Required")]
        [Display(Name = "Show Date")]
        public string showDate {get; set;}

        [Required(ErrorMessage = "Show Venue is Required")]
        [Display(Name = "Show Venue")]
        public string showVenue {get; set;}

        [Range(1,10)]
        [Required(ErrorMessage = "Show Rating is Required and must be between 1 and 10")]
        [Display(Name = "Show Rating")]
        public int showRating {get; set;}

        [Required(ErrorMessage = "Show Description is Required")]
        [Display(Name = "Show Description")]
        public string showDescription {get; set;}
    
    }

}