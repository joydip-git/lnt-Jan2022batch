using System;

namespace InterfaceDemo
{
    interface IA
    {
        void M1();
    }
    interface IB
    {
        void M2();
    }
    class MyCls : IA, IB
    {
        public void M1() { }
        public void M2() { }
    }
    class Program
    {
        static void Main()
        {
            SavingsAccount joydipAcc = new SavingsAccount();
            joydipAcc.Name = "Joydip";
            joydipAcc.AccountBalance = 1000;
            Console.WriteLine(joydipAcc.CreateAccount());
            decimal currentBalance = joydipAcc.CreditIntoAccont(1000);
            Console.WriteLine($"current balance of {joydipAcc.Name} is {joydipAcc.AccountBalance}");

            //only members of that interface can be called
            IBankOperation account = new CurrentAccount();
            account.CreateAccount();
            account.CreditIntoAccont(1000);
            account.DebitFromAccount(100);
            account.Name = "Anil";
        }
    }
}
