using Genaralinsuranceapp.BusinessLayer;
using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Genaralinsuranceapp.DataAcessLayer
{
    public class BuyinsuranceDataAccess : IBuyinsurance
    {
        private generalinsuranceContext db;


        public BuyinsuranceDataAccess(generalinsuranceContext _db)
        {
            db = _db;
        }

        
        public int AddInsurance(Vehiclesdetails vehiclesdetails)
        {
            db.Vehiclesdetails.Add(vehiclesdetails);
            return db.SaveChanges();
        }

        public int AddPolicy(Policydetails policydetails, string email)
        {
            var customer = db.CustomerRegistration.Where(c => c.Email == email).First();
            var custid = customer.CustomerId;
            Vehiclesdetails vehicle = db.Vehiclesdetails.Where(vd => vd.CustomerId == custid).First();
            //vehicle.VehicleTypeId
            db.Policydetails.Add(policydetails);
            return db.SaveChanges();

        }

        public List<Insuranceduration> GetDuration()
        {
            List<Insuranceduration> year = new List<Insuranceduration>();
            year = (from Duration in db.Insuranceduration select Duration).ToList();
            return year;
        }

        public Vehiclesdetails GetInsuranceById(int id)
        {
            return db.Vehiclesdetails.Where(p => p.PolicyNumber == id).First<Vehiclesdetails>();
        }

        public List<Insuranceplantype> GetPlans()
        {
            List<Insuranceplantype> Plantype = new List<Insuranceplantype>();
            Plantype = (from plan in db.Insuranceplantype select plan).ToList();
            return Plantype;
            
        }

        public List<Vehicletypes> GetVehicletypes()
        {
            List<Vehicletypes> vehicletype = new List<Vehicletypes>();
            vehicletype = (from plan in db.Vehicletypes select plan).ToList();
            return vehicletype;
        }
    }


}