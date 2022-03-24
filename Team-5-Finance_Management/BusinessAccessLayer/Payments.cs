using System;

namespace Finance_Management.BusinessAccessLayer
{
    public class Payments
    {
        public int Paymentid { get; set; }
        public decimal Downpayment { get; set; }
        public decimal Remainingbalance { get; set; }
        public int Orderid { get; set; }

        
    }
}
