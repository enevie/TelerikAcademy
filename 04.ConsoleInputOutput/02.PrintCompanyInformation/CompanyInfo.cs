using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter company: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter website: ");
        string website = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.Clear();

        Console.WriteLine(@"
{0}
Adress: {1}
Tel. {2}
Fax. {3}
Web site: {4}
Manager: {5} {6} ({7}, tel: {8})

", companyName, companyAdress, phoneNumber, faxNumber, website, firstName, lastName, age, managerPhone);
    }
}

