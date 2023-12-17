using BookingApp.Data;
using BookingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookingApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedSearchController : ControllerBase
    {
        private readonly AppContextDB _context;

        public AdvancedSearchController(AppContextDB context)
        {
            _context = context;
        }

        [HttpGet("{city}/{arrivalDate}/{departureDate}/{type}")]
        public async Task<IEnumerable<Offer>> Get(string city, string arrivalDate, string departureDate, string type)
        {
            IEnumerable<Offer> offers = null;

            DateTime arrivalDateTime = DateTime.ParseExact(arrivalDate, "yyyy-MM-dd", null);
            DateTime departureDateTime = DateTime.ParseExact(departureDate, "yyyy-MM-dd", null);

            if (arrivalDateTime < departureDateTime && !city.Equals("") && !type.Equals(""))
            {
                int rentalPeriod = (int)(departureDateTime - arrivalDateTime).TotalDays;
                offers = await _context.Offers
                    .Where(o => o.StartAvailability <= arrivalDateTime && o.EndAvailability > arrivalDateTime && o.EndAvailability >= departureDateTime && rentalPeriod >= o.Accommodation.MinRentalPeriod && rentalPeriod <= o.Accommodation.MaxRentalPeriod && o.Accommodation.Address.City == city && o.Accommodation.Type == type)
                    .Select(o => new Offer {
                        Id = o.Id,
                        AddingDateTime = o.AddingDateTime,
                        StartAvailability = o.StartAvailability,
                        EndAvailability = o.EndAvailability,
                        PricePerNight = o.PricePerNight,

                        Accommodation = new Accommodation {
                            Name = o.Accommodation.Name,
                            Type = o.Accommodation.Type,
                            Description = o.Accommodation.Description,
                            PictureUrl = o.Accommodation.PictureUrl,

                            Address = new Address
                            {
                                City = o.Accommodation.Address.City,
                                Country = o.Accommodation.Address.Country
                            }
                        }
                    })
                    .ToListAsync();
            }

            return offers;
        }
    }
}
