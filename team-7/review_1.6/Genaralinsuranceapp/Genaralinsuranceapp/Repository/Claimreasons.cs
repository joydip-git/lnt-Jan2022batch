using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class Claimreasons
    {
        public Claimreasons()
        {
            Claimdata = new HashSet<Claimdata>();
            Claimhistory = new HashSet<Claimhistory>();
        }

        public int ClaimId { get; set; }
        public string Claimreason { get; set; }

        public virtual ICollection<Claimdata> Claimdata { get; set; }
        public virtual ICollection<Claimhistory> Claimhistory { get; set; }
    }
}
