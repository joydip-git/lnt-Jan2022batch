using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Finance_Management.BusinessAccessLayer;
using System.Collections.Generic;
using Finance_Management.Repository;

namespace Finance_Management.DataAccessLayer.Implementation
{
    public class EmiTableDao : IEmiTable
    {

        private FinancedbContext db;
        public EmiTableDao(FinancedbContext financeDbContext)
        {
            db = financeDbContext;
        }

        public EmiModel FetchbyId(decimal id)
        {
            //return db.EmiTable.Where(p => p.EmiId.Value == id).First<EmiTable>();
            return db
                .EmiTable
                .Where(e => e.EmiId.Value == id)
                .Select(e => new EmiModel { EmiId = e.EmiId.Value, EmiAmount = e.EmiAmount.Value, EmitypeId = e.EmitypeId, Orderid = e.Orderid.Value, Paymentid = e.Paymentid.Value, RegId = e.RegId.Value })
                .First();
            //return null;
        }

        public EmiModel FetchByid(int id)
        {
            throw new NotImplementedException();
        }

        public object FetchById()
        {
            throw new NotImplementedException();
        }
    }
}
