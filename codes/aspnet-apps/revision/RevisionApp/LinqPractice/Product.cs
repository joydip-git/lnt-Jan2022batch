using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    public class Product
    {
        //auto-implemented properties (C# 3.0 -2007)
        public int ProductId { set; get; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, decimal price, string description)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.Price = price;
            this.Description = description;
        }
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

            return true;
        }
        public override string ToString()
        {
            return $"Name:{ProductName}, Id: {ProductId}, Price: {Price}, Description:{Description}";
        }
    }
}
