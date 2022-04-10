using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentingSystem.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }

        public int DealerId { get; set; }
        [ForeignKey("DealerId")]
        public Dealer Dealer { get; set; }

        public int Price { get; set; }
       
        [Required(ErrorMessage = "Date is required")]
        public DateTime DateCreated { get; set; }
        public DateTime DateExpired { get; set; }
    }
}
