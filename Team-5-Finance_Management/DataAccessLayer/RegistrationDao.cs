using System.Linq;
using System.Collections.Generic;
using Finance_Management.Repository;
using System;
using Finance_Management.DataAccessLayer;

namespace Finance_Management.DataAccessLayer.DataAccessLayer
{
    public class RegistrationDao: IRegistration
    {
        private FinancedbContext db;

        public RegistrationDao(FinancedbContext  _db)
        {
            db =  _db;
        }

        public int Add(Registration registration)
        {
            throw new NotImplementedException();
        }

        public List<Registration> GetAllDetails()
        {
            return db.Registration.ToList<Registration>();
        }

        public Registration GetById(int id)
        {
            return db.Registration.Where(p => p.RegId == id).First<Registration>();
        }

        public int InsertRegistration(Registration AddRegistration)
        {
            throw new NotImplementedException();
        }
        //public RegistrationDao()
        //{
        //}

        //public decimal id { get; private set; }

        //public List<Registration> AllDetails => db.Registration.ToList<Registration>();

    }
}

