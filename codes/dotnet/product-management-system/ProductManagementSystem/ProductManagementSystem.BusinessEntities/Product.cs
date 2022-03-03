using System;

namespace ProductManagementSystem.BusinessEntities
{
    public class Product //Object
    {
        public Product()
        {

        }
        public Product(int productId, string productName, string description, decimal price, string iamgePath, decimal starRating, DateTime releaseDate, int categoryId, Category categoryInfo = null)
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
            Price = price;
            ImagePath = iamgePath;
            StarRating = starRating;
            ReleaseDate = releaseDate;
            CategoryId = categoryId;
            CategoryInfo = categoryInfo;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public decimal StarRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public Category CategoryInfo { get; set; }

        public override bool Equals(object obj)
        {
            Product other = (Product)obj;
            if (this == other)
                return true;

            if (!this.ProductId.Equals(other.ProductId))
                return false;

            if (!this.ProductName.Equals(other.ProductName))
                return false;

            if (!this.Price.Equals(other.Price))
                return false;

            if (!this.Description.Equals(other.Description))
                return false;

            if (!this.ImagePath.Equals(other.ImagePath))
                return false;

            if (!this.StarRating.Equals(other.StarRating))
                return false;

            if (!this.CategoryId.Equals(other.CategoryId))
                return false;

            if (!this.ReleaseDate.Equals(other.ReleaseDate))
                return false;

            return true;
        }
    }
}
