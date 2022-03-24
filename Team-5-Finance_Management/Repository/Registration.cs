using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class Registration
    {
        public Registration()
        {
            EmiTable = new HashSet<EmiTable>();
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public decimal? Number { get; set; }
        public string Address { get; set; }
        public decimal RegId { get; set; }
        public string Cardtype { get; set; }
        public string Bank { get; set; }
        public string Accno { get; set; }
        public string IfscCode { get; set; }
        public decimal? Userid { get; set; }

        public virtual Logintype User { get; set; }
        public virtual ICollection<EmiTable> EmiTable { get; set; }
    }
}
