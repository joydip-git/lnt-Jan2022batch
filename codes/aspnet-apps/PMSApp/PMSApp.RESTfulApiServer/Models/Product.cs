using System;

namespace PMSApp.RESTfulApiServer.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? StarRating { get; set; }
        public DateTime? ReleasedDate { get; set; }
    }
}
