using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cesi.IntroCS.MVC.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="Email obligatoire")]
        [EmailAddress(ErrorMessage ="Email invalide")]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Message { get; set; }
    }
}