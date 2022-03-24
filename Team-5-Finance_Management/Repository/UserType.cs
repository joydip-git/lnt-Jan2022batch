using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class UserType
    {
        public UserType()
        {
            Logintype = new HashSet<Logintype>();
        }

        public string Usertypename { get; set; }
        public decimal UsertypeId { get; set; }

        public virtual ICollection<Logintype> Logintype { get; set; }
    }
}
