using System;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter a year to check if it's leap: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap =  DateTime.IsLeapYear(year);
        Console.WriteLine(isLeap ? "The year is leap":"The year isn't leap");
    }
}

