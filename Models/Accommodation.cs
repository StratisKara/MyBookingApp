using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookingApp.Models
{
    public class Accommodation
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        [Display(Name = "User")]
        [JsonIgnore]
        public virtual User User { get; set; }

        [Display(Name = "Offers")]
        [JsonIgnore]
        public virtual List<Offer> Offers { get; set; }

        [Display(Name = "Address")]
        public virtual Address Address { get; set; }

        [Required(ErrorMessage = "You must enter a name for your accommodation")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must select the type of accommodation")]
        [Display(Name = "Type")]
        [RegularExpression("Apartment|House|Room",
            ErrorMessage = "Please select a valid type of accommodation")]
        public string Type { get; set; }

        [Required(ErrorMessage = "You must specify the minimum rental period")]
        [Display(Name = "Minimum Rental Period")]
        public int MinRentalPeriod { get; set; }

        [Required(ErrorMessage = "You must specify the maximum rental period")]
        [Display(Name = "Maximum Rental Period")]
        public int MaxRentalPeriod { get; set; }

        [Required(ErrorMessage = "You must enter a description for your accommodation")]
        public string Description { get; set; }

        [Required(ErrorMessage = "You must add picture")]
        [Display(Name = "Picture")]
        public string PictureUrl { get; set; }
    }
}