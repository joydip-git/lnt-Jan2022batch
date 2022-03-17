using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DummyProject.DataAccessLayer.Models
{
    public partial class Products
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public string Imagepath { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Starrating { get; set; }
        public DateTime? Releaseddate { get; set; }
    }
}
