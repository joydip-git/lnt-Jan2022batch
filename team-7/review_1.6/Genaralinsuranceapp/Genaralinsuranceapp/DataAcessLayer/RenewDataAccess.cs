

using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Genaralinsuranceapp.DataAcessLayer
{
    public class RenewDataAccess : IRenew
    {


        private generalinsuranceContext db;


        public RenewDataAccess(generalinsuranceContext _db)
        {
            db = _db;
        }

        public List<Policydetails> GetAllPolicies()
        {
            return db.Policydetails.ToList<Policydetails>();
        }

        public CustomerRegistration GetPolicyByEmail(string email)
        {
            return db.CustomerRegistration.Where(p => p.Email == email).First<CustomerRegistration>();
        }



        //public int Updatepolicy(int id,  Policydetails policydetails)
        //{
        //    var entity = db.Policydetails.Where(n => n.PlanId == id);
        //    if (entity != null) ;
        //    return db.SaveChanges();


        //}
        public int Updatepolicy(Policydetails policydetails)
        {
            db.Entry(policydetails).State = EntityState.Modified;
            return db.SaveChanges();
            
        }

        
    }
}