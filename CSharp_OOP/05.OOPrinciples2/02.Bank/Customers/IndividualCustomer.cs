namespace _02.Bank.Customers
{
    using System;

    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name)
            : base(name)
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
