using System;
using System.Text;


//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

    class Days
    {
        static void Main()
        {
          DayOfWeek today =  DateTime.Today.DayOfWeek;
          Console.WriteLine(today);
        }
    }

