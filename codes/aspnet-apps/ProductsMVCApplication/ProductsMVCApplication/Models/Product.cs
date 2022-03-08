using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsMVCApplication.Models
{
    public class Product
    {
        //automatic properties
        /*
         * private int _ProductId;
         * private string _ProductName;
         * private decimal _Price;
         * private string _Description;
         */
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public decimal Price { get; set; }
        public string Description { set; get; }
    }
}
