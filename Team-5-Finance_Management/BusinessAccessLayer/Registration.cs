using System;
using System.Collections.Generic;

namespace Finance_Management.BusinessAccessLayer
{
    public class Registration
    {
        public Registration(decimal regId, string ifscCode)
        {
            RegId = regId;
            IfscCode = ifscCode;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public decimal RegId { get; set; }
        public string Cardtype { get; set; }
        public string Bank { get; set; }
        public string Accno { get; set; }
        public string IfscCode { get; set; }
        public int Userid { get; set; }

        internal static IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        internal static void Delete(object item)
        {
            throw new NotImplementedException();
        }


    }
}
