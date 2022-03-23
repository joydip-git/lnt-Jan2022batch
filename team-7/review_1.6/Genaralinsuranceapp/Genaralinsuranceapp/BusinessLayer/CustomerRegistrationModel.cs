using System;
using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class CustomerRegistrationModel
    {
       
            public CustomerRegistrationModel()
            {
                Policydetails = new HashSet<PolicydetailsModel>();
                Vehiclesdetails = new HashSet<VehiclesdetailsModel>();
            }

            public string FirstName { get; set; }
            public string Address { get; set; }
            public string Password { get; set; }
            public DateTime? Dob { get; set; }
            public string ContactNo { get; set; }
            public int? PolicyNumber { get; set; }
            public long CustomerId { get; set; }
            public string Email { get; set; }

            public virtual ICollection<PolicydetailsModel> Policydetails { get; set; }
            public virtual ICollection<VehiclesdetailsModel> Vehiclesdetails { get; set; }
        

    }
}
