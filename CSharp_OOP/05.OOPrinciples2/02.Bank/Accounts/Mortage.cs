namespace _02.Bank.Accounts
{
    using System;
    using _02.Bank.Customers;

    public class Mortage : Account
    {
        public Mortage(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer,initialBalance,initialInterestRate)
        {

        }

        public override void DepositMoney(decimal deposingSum)
        {
            this.Balance += deposingSum;
            Console.WriteLine("Successful! The morgage deposit of {0} is accepted!",deposingSum);
            Console.WriteLine("The balance is now: " + this.Balance);
        }

        public override void CalculatingInterestAmount(int months)
        {
           if(this.Customer.GetType() == typeof(Company))
           {
               if(months<12)
               {
                   Console.WriteLine("The interest for the {0}'s account is {1}", this.Customer, (months * this.InterestRate)/2);
               }
               else
               {
                   Console.WriteLine("The interest for the {0}'s account is {1}", this.Customer, months * this.InterestRate);
               }
           }
           else
           {
               if(months<6)
               {
                   Console.WriteLine("No interest for this account!");
               }
               else
               {
                   Console.WriteLine("The interest for the {0}'s account is {1}", this.Customer, months * this.InterestRate);
               }
           }
        }
    }
}
