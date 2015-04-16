namespace _02.Bank
{
using System;
    public abstract class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
