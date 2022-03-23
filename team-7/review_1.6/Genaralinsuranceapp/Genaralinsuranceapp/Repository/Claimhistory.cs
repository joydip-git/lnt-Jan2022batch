using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class Claimhistory
    {
        public int ClaimNo { get; set; }
        public int? PolicyNumber { get; set; }
        public bool? IsApproved { get; set; }
        public decimal? Amount { get; set; }
        public int? ClaimId { get; set; }

        public virtual Claimreasons Claim { get; set; }
        public virtual Policydetails PolicyNumberNavigation { get; set; }
    }
}
