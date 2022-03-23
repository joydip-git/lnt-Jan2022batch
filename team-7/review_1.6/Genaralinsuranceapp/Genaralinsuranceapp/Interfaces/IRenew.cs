using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Interfaces
{
    public interface IRenew
    {

        int Updatepolicy (Policydetails policydetails);

        List<Policydetails> GetAllPolicies ();

        CustomerRegistration GetPolicyByEmail(string email);


    }
}
