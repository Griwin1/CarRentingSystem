using System;
using static CarRentingSystem.Data.DataConstants;

namespace CarRentingSystem.Models
{
    public class ReservationViewModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateExpired { get; set; }

        public int Price { get; set; }

        public int CarId { get; set; }
        public Car Car { get; init; }

        public int DealerId { get; set; }
        public Dealer Dealer { get; init; }
        
        public int Id { get; set; }
    }
}
