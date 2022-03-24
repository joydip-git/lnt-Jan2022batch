using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class Logintype
    {
        public Logintype()
        {
            Registration = new HashSet<Registration>();
        }

        public decimal Userid { get; set; }
        public string Password { get; set; }
        public decimal? UsertypeId { get; set; }

        public virtual UserType Usertype { get; set; }
        public virtual ICollection<Registration> Registration { get; set; }
    }
}
