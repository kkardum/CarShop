using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Blog
    {
        [Required]
        public int BlogID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}