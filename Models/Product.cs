using System.ComponentModel.DataAnnotations;

namespace Task_1_mvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(13)]
        public string name { get; set; }
        [Required]
        [MinLength(9)]
        public string description { get; set; }
        [Required]
        [Range(1000,90000)]
        public decimal price { get; set; }
        public string? img { get; set; }
        public string? category { get; set; }
    }
}
