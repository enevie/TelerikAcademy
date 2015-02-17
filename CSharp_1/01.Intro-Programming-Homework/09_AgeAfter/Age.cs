using System;

/*
* Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

class Age
{
    static void Main()
    {
        Console.WriteLine("Please enter your date of  birth: ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int years = ((now - dateOfBirth).Days)/365;
        Console.WriteLine("You are " + years + " years old.");
        int afterYears = years + 10;
        Console.WriteLine("After 10 years you will be " + afterYears +" years old!");
    }
}

