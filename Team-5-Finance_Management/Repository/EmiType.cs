using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class EmiType
    {
        public string Emiduration { get; set; }
        public decimal? EmitypeId { get; set; }

        public virtual EmiTable Emitype { get; set; }
    }
}
