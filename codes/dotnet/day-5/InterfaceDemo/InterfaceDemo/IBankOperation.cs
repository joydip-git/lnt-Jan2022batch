using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    //interface: pure abstract class
    interface IBankOperation
    {
        decimal CreditIntoAccont(decimal amount);
        decimal DebitFromAccount(decimal amount);
        string CreateAccount();
        string Name { set; get; }
    }
    interface IAdditionalServices
    {
        string OpenDematAccount();
        string UseOnlineFacility();
    }
    //implement the interface
    //abstract class
    abstract class BankAccount : IBankOperation, IAdditionalServices
    {
        string accountHolderName;
        decimal accountBalance;
        public string Name
        {
            get => accountHolderName;
            set => accountHolderName = value;
        }
        public decimal AccountBalance { get => accountBalance; set => accountBalance = value; }

        public decimal CreditIntoAccont(decimal amount)
        {
            accountBalance = accountBalance + amount;
            return accountBalance;
        }

        public decimal DebitFromAccount(decimal amount)
        {
            accountBalance = accountBalance - amount;
            return accountBalance;
        }

        //since in class, nothing is by default public and abstract, that's why you have to use public and abstract keyword to write the member that you do not want to implement
        public abstract string CreateAccount();

        public string OpenDematAccount()
        {
            return "demat account opened";
        }

        public string UseOnlineFacility()
        {
            return "providing online money transaction facility";
        }
    }

    //concrete class
    class SavingsAccount : BankAccount
    {
        public override string CreateAccount()
        {
            return "Bank account created...";
        }
    }

    class CurrentAccount : BankAccount
    {
        public override string CreateAccount()
        {
            return "Current Bank account created...";
        }
    }
}
