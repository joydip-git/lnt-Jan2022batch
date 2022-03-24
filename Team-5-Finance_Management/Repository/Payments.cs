using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class Payments
    {
        public Payments()
        {
            EmiTable = new HashSet<EmiTable>();
        }

        public decimal Paymentid { get; set; }
        public decimal? Downpayment { get; set; }
        public decimal? Remainingbalance { get; set; }
        public decimal? Orderid { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ICollection<EmiTable> EmiTable { get; set; }
    }
}
