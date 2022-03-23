using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class Policydetails
    {
        public Policydetails()
        {
            Claimhistory = new HashSet<Claimhistory>();
            Vehiclesdetails = new HashSet<Vehiclesdetails>();
        }

        public int PolicyNumber { get; set; }
        public int? DurationId { get; set; }
        public int? PlanId { get; set; }
        public long? CustomerId { get; set; }
        public int? VehicletypeId { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual Insuranceduration Duration { get; set; }
        public virtual Insuranceplantype Plan { get; set; }
        public virtual Vehicletypes Vehicletype { get; set; }
        public virtual Claimdata Claimdata { get; set; }
        public virtual ICollection<Claimhistory> Claimhistory { get; set; }
        public virtual ICollection<Vehiclesdetails> Vehiclesdetails { get; set; }
    }
}
