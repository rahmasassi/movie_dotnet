using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie.Models
{
    public class ApplicationUser : IdentityUser
    {
        //This is additional data to the user model without modifying the built-in IdentityUser class
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
