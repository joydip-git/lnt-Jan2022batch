using System;
using System.ComponentModel.DataAnnotations;

namespace DummyProject.BusinessModels
{
    public class ProductModel
    {     
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="length should not be mor ethan 50")]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime? ReleasedDate { get; set; }
        [Required]        
        public decimal? Price { get; set; }
        [Required]
        public decimal? StarRating { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
