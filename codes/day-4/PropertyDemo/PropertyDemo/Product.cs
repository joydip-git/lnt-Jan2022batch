using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class Product
    {
        //a readonly data member can be assigned ONLY through CONSTRUCTOR
        private readonly int productId;
        private string productName;
        private decimal price;
        private string description;

        public Product() { }

        public Product(int id)
        {
            this.productId = id;
        }

        public Product(int id, string name, decimal price, string description)
        {
            this.productId = id;
            this.productName = name;
            this.price = price;
            this.description = description;
        }

        /*
        public int ProductId
        {
            get { return this.productId; }
        }

        public int ProductId
        {
            //the productId is readonly, ONLY constructor can be used to set the value
            //set => this.productId = value;
            get => this.productId;
        }
        */

        public int ProductId => this.productId;

        public string ProductName
        {
            get => this.ProductName;
            set => this.productName = value;
        }

        public decimal Price
        {
            get => this.price;
            set => this.price = value;
        }

        public string Description
        {
            get => this.description;
            set => this.description = value;
        }

        public string GetInfo()
        {
            return $"Name:{productName}, Price:{price}, Id: {productId}, description:{description}";
        }
    }
}
