using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class ClaimreasonsModel
    {
        public ClaimreasonsModel()
        {
            Claimhistory = new HashSet<claimhistoryModel>();
        }

        public string Claimreason { get; set; }
        public int ClaimId { get; set; }

        public virtual ICollection<claimhistoryModel> Claimhistory { get; set; }
    }
}
