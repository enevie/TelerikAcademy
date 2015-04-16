namespace _02.Bank.Accounts
{
    using System;
    using _02.Bank;

    public class Deposit : Account, IDrawMoney
    {
        public Deposit(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer, initialBalance, initialInterestRate)
        {

        }

        public override void DepositMoney(decimal depositSum)
        {
            this.Balance += depositSum;
            Console.WriteLine("Successfull depositing, new deposit account value: " + this.Balance);
        }


        public override void CalculatingInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                Console.WriteLine("There is no interest for this deposit");
            }
            else
            {
                Console.WriteLine("The interest is :" + months * this.InterestRate);
            }
        }

        public void DrawMoney(decimal amountToDraw)
        {
            this.Balance -= amountToDraw;
        }
    }
}
