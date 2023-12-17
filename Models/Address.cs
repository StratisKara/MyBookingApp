using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BookingApp.Models
{
    public class Address
    {
        [ForeignKey("Accommodation")]
        public Guid Id { get; set; }

        [JsonIgnore]
        public virtual Accommodation Accommodation { get; set; }

        [Required(ErrorMessage = "You must enter the street number and name of your accommodation")]
        [Display(Name = "Street and Number")]
        public String StreetAndNumber { get; set; }

        [Required(ErrorMessage = "You must enter the city of your accommodation")]
        [Display(Name = "City")]
        public String City { get; set; }

        [Required(ErrorMessage = "You must enter the country of your accommodation")]
        [Display(Name = "Country")]
        public String Country { get; set; }

    }
}