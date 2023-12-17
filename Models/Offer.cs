using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class Offer
    {
        public Guid Id { get; set; }

        public Guid AccommodationId { get; set; }
        [Display(Name = "Accommodation")]
        public virtual Accommodation Accommodation { get; set; }

        [Display(Name = "Adding Date")]
        [DataType(DataType.DateTime)]
        public DateTime AddingDateTime { get; set; }

        [Display(Name = "Start Availability")]
        [DataType(DataType.Date)]
        public DateTime StartAvailability { get; set; }

        [Display(Name = "End Availability")]
        [DataType(DataType.Date)]
        public DateTime EndAvailability { get; set; }

        [Display(Name = "Price Per Night")]
        public double PricePerNight { get; set; }
        public Offer()
        {
            this.AddingDateTime = DateTime.Now;
        }
    }
}
