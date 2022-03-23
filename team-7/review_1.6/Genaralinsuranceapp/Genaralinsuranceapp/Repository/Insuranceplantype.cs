using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class Insuranceplantype
    {
        public Insuranceplantype()
        {
            Policydetails = new HashSet<Policydetails>();
        }

        public int PlanId { get; set; }
        public string Planname { get; set; }

        public virtual ICollection<Policydetails> Policydetails { get; set; }
    }
}
