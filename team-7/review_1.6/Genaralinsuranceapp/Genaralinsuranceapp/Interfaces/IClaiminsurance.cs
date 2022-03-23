using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Interfaces
{
    public interface IClaiminsurance
    {
        CustomerRegistration GetPolicyByEmail(string email);

        List<Claimreasons> Getclaimreasons();

        int AddClaimdetails(Claimdata claimdata);



    }
}
