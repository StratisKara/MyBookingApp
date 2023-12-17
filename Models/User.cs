using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookingApp.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [PersonalData]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [PersonalData]
        [Display(Name = "Balance")]
        public Double Balance { get; set; }

        [Display(Name = "Accommodations")]
        public virtual List<Accommodation> Accommodations { get; set; }

        [Display(Name = "Bookmarks")]
        public virtual List<Bookmark> Bookmarks { get; set; }
    }
}
