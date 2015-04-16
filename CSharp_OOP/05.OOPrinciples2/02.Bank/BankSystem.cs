namespace _02.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using _02.Bank.Accounts;
    using _02.Bank.Customers;

    class BankSystem
    {
        static void Main()
        {

            var customer = new IndividualCustomer("Pesho Peshov");
            var company = new Company("jocop");
            var account = new Deposit(customer, 5000, 3.25m);
            var accountCompany = new Loan(company, 52000, 3.25m);

            accountCompany.CalculatingInterestAmount(6);
        }
    }
}
