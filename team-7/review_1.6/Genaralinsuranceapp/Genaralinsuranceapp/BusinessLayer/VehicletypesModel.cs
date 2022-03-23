using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class VehicletypesModel
    {
        public VehicletypesModel()
        {
            Policydetails = new HashSet<PolicydetailsModel>();
        }

        public string Vehicletype { get; set; }
        public int VehicletypeId { get; set; }

        public virtual ICollection<PolicydetailsModel> Policydetails { get; set; }

    }
}
