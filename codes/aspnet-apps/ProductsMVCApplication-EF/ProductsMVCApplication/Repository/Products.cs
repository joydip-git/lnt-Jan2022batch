using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductsMVCApplication.Repository
{
    public partial class Products
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
    }
}
