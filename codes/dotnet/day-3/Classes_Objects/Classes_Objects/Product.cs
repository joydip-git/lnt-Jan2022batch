using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Objects
{
    class Product
    {
        //encapsulation: putting data and functionalities together inside the class is known as encapsulation

        //class data members or fields or global variables
        //access specifiers of class members: public, private

        //protecting the data for security (so that no one can directly manipulate the data), by using private access specifier, is known as data abstraction
        int productId; //=0
        string productName; //=NULL
        decimal price; //=0
        string description; //=NULL

        //funtionalities

        //a sepcial function (without any return type, NOT EVEN void)
        //whose name is same as that of the class name
        //this function assigns default values to the data members
        //this sepcial function is known as Constructor
        //job of constructor is to assign values to data members

        //the following constructor is known as default constructor, whose job is to assign default values to all data members
        public Product()
        {

        }

        //the following constructor is known as paremeterized constructor (constructor with parameters) and is used to assign user values to the data members
        public Product(string name, int id, decimal price, string description)
        {
            this.productId = id;
            this.productName = name;
            this.price = price;
            this.description = description;
        }

        public string PrintInfo()
        {
            return $"Name:{this.productName}, Id:{productId}, Price:{price}, Description:{description}";
        }
    }
}
