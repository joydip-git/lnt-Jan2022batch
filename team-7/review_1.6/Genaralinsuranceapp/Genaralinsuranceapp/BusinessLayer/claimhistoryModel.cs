namespace Genaralinsuranceapp.BusinessLayer
{
    public class claimhistoryModel
    {
        public partial class Claimhistory
        {
            public int ClaimNo { get; set; }
            public int? PolicyNumber { get; set; }
            public bool? IsApproved { get; set; }
            public decimal? Amount { get; set; }
            public int? ClaimId { get; set; }

            public virtual ClaimreasonsModel Claim { get; set; }
            public virtual PolicydetailsModel PolicyNumberNavigation { get; set; }
        }
    }
}
