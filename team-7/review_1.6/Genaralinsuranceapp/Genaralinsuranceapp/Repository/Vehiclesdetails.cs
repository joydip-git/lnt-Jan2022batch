using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class Vehiclesdetails
    {
        public string RegistrationNumber { get; set; }
        public string Manufacturer { get; set; }
        public long? CustomerId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? PolicyNumber { get; set; }
        public string Model { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual Policydetails PolicyNumberNavigation { get; set; }
        public virtual Vehicletypes VehicleType { get; set; }
    }
}
