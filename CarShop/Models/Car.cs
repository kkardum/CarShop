using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Car
    {
        [Required]
        public int CarID { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Year_Of_Manufacture { get; set; }

        [Required]
        public int Mileage { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Performance { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}