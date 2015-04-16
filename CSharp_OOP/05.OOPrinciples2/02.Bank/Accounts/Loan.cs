namespace _02.Bank.Accounts
{
    using System;
    using _02.Bank.Customers;
    public class Loan : Account
    {
        public Loan(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer, initialBalance, initialInterestRate)
        {

        }


        public override void DepositMoney(decimal deposingSum)
        {
            this.Balance += deposingSum;
            Console.WriteLine("Successful! The loan deposit of {0} is accepted!", deposingSum);
            Console.WriteLine("The balance is now: " + this.Balance);
        }

        public override void CalculatingInterestAmount(int months)
        {

            if (this.Customer.GetType() == typeof(IndividualCustomer))
            {
                if (months < 3)
                {
                    Console.WriteLine("No Interesta amount for the first 3 months!");
                }
                else
                {
                    Console.WriteLine("The interest for the {0}'s account is {1}", this.Customer, months * this.InterestRate);
                }
            }
            else
            {
                if (months < 2)
                {
                    Console.WriteLine("No interest amount for companies for the first two months!");
                }
                else
                {
                    Console.WriteLine("The interest for the {0}'s account is {1}", this.Customer, months * this.InterestRate);
                }
            }
        }
    }
}
