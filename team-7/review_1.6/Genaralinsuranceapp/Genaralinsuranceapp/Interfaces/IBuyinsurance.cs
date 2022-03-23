
using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Interfaces
    
{
    public interface IBuyinsurance
    {

       
        int AddInsurance(Vehiclesdetails vehiclesdetails);

        int AddPolicy(Policydetails policydetails, string email);
       


        List<Vehicletypes> GetVehicletypes();
        
        Vehiclesdetails GetInsuranceById(int id);

        List<Insuranceplantype> GetPlans();

        List<Insuranceduration> GetDuration();

    }

   
}
