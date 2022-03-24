using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class Orders
    {
        public Orders()
        {
            Payments = new HashSet<Payments>();
        }

        public decimal Orderid { get; set; }
        public decimal? OrderAmount { get; set; }
        public string Orderdate { get; set; }
        public decimal? RegId { get; set; }
        public decimal? ProductId { get; set; }

        public virtual Products Product { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
