namespace _02.Bank
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
        {
            this.customer = initialCustomer;
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            protected set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set { this.interestRate = value; }
        }

        public abstract void DepositMoney(decimal depositSum);

        public abstract void CalculatingInterestAmount(int months);
    }
}
