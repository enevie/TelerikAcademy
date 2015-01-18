using System;

/*
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

class BankAccountData
{
    static void Main()
    {
        
        Console.WriteLine("Please, enter your FIRST name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please, enter your MIDDLE name: ");
        string middleName = Console.ReadLine();

        Console.WriteLine("Please, enter your LAST name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter the amount of money in the bank account: ");
        decimal money = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter your BANK name: ");
        string bankName = Console.ReadLine();

        Console.WriteLine("Enter your IBAN: ");
        string IBAN = Console.ReadLine();

        Console.WriteLine("Enter the number of the first bank card: ");
        long firstBankCard = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of the second bank card: ");
        long secondBankCard = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of the third bank card: ");
        long thirdBankCard = long.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine(@"

            Bank name:      {0}
            Holder Name:    {1} {2} {3}
            IBAN:           {4}
            Amount:         {5}
            First Card:     {6}
            Second Card:    {7}
            Third Card:     {8}

", bankName,firstName,middleName,lastName,IBAN,money,firstBankCard,secondBankCard,thirdBankCard);
        
        }
    }


