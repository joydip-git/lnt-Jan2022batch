using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class InsurancedurationModel
    {
        public partial class Insuranceduration
        {
            public Insuranceduration()
            {
                Policydetails = new HashSet<PolicydetailsModel>();
            }

            public string DurationValue { get; set; }
            public int DurationId { get; set; }

            public virtual ICollection<PolicydetailsModel> Policydetails { get; set; }
        }


    }
}
