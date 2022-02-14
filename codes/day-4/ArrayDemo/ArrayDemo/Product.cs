using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    class Product
    {
        readonly int productId;
        string productName;
        decimal price;

        public int ProductId => this.productId;
        public string ProductName { set => this.productName = value; get => this.productName; }
        public decimal Price { set => this.price = value; get => this.price; }

        public Product() { }
        public Product(int pid) { this.productId = pid; }
        public Product(int pid, string name, decimal price)
        {
            this.productId = pid;
            this.productName = name;
            this.price = price;
        }
    }
}
