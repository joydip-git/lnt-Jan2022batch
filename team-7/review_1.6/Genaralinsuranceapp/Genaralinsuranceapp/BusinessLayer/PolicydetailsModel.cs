using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class PolicydetailsModel
    {
        public PolicydetailsModel()
        {
            Claimhistory = new HashSet<claimhistoryModel>();
            Vehiclesdetails = new HashSet<VehiclesdetailsModel>();
        }

        public int PolicyNumber { get; set; }
        public int? DurationId { get; set; }
        public int? PlanId { get; set; }
        public long? CustomerId { get; set; }
        public int? VehicletypeId { get; set; }

        public virtual CustomerRegistrationModel Customer { get; set; }
        public virtual InsurancedurationModel Duration { get; set; }
        public virtual InsuranceplantypeModel Plan { get; set; }
        public virtual VehicletypesModel Vehicletype { get; set; }
        public virtual ICollection<claimhistoryModel> Claimhistory { get; set; }
        public virtual ICollection<VehiclesdetailsModel> Vehiclesdetails { get; set; }
    }



}

