using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Part
    {
        [Required]
        public int PartID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string ModelCompatibility { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Year_Of_Manufacture { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}