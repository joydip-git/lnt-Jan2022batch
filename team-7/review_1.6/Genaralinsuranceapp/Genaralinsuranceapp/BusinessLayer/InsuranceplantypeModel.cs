using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class InsuranceplantypeModel
    {
       
            public InsuranceplantypeModel()
            {
                Policydetails = new HashSet<PolicydetailsModel>();
            }

            public string Planname { get; set; }
            public int PlanId { get; set; }

            public virtual ICollection<PolicydetailsModel> Policydetails { get; set; }
        


    }
}
