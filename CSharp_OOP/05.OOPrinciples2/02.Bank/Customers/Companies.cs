namespace _02.Bank.Customers
{
    using System;
    public class Company : Customer
    {
        public Company(string name)
            : base(name)
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
