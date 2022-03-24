using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class EmiTable
    {
        public decimal? EmiId { get; set; }
        public decimal? EmiAmount { get; set; }
        public decimal EmitypeId { get; set; }
        public decimal? Orderid { get; set; }
        public decimal? RegId { get; set; }
        public decimal? Paymentid { get; set; }

        public virtual Payments Payment { get; set; }
        public virtual Registration Reg { get; set; }
    }
}
