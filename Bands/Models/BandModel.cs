using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Bands.Models
{
    public class BandModel
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        [Required(ErrorMessage = "Band Name is Required")]
        [Display(Name = "Band Name")]
        public string bandName {get; set;}


        public List<ShowModel> showList {get; set;}


    
    }

}