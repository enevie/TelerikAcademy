using System;

/*
* A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.
Print the data at the console.
*/


class Program
{
static void Main()
{
    Console.WriteLine("Please, enter your FIRST name: ");
    string firstName = Console.ReadLine();

    Console.WriteLine("Please, enter your LAST name: ");
    string lastName = Console.ReadLine();

    Console.WriteLine("Please, enter your AGE: ");
    byte age = byte.Parse(Console.ReadLine());

    Console.WriteLine("Please, enter your GENDER: m/f ");
    char genderChek = char.Parse(Console.ReadLine());
    string gender = "";

    if (genderChek == 'm')
    {
        gender = "Male";
    }
    else if (genderChek == 'f')
    {
        gender = "Female";
    }
        
    Console.WriteLine("Please, enter your PERSONAL ID: ");
    long personalID = long.Parse(Console.ReadLine());

    Console.WriteLine("Please, enter your UNIQUE NUMBER: ");
    long uniqueNumber = long.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine(@"
    Employee Names:           {0} {1}
    Employee Age:             {2}
    Employee Gender:          {3}
    Employee Personal ID:     {4}
    Emplyee Unique Number:    {5}
",firstName,lastName,age,gender,personalID,uniqueNumber);

}
}

