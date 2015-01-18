using System;
using System.Collections.Generic;
using System.Linq;


/*
 *Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop. 
 */



class Program
{
    static void Main()
    {
        Console.WriteLine("How many numbers you want to sum: ");
        int nNumbers = int.Parse(Console.ReadLine());
        Convert.ToDouble(nNumbers);
        double[] array = new double[nNumbers];

        for (int i = 0; i <= array.Length-1; i++)
        {
            Console.WriteLine("Enter number: ");

            double newNumber = double.Parse(Console.ReadLine());
            array.SetValue(newNumber, i);
        }
        double sum = array.Sum();
        Console.WriteLine("The sum is: "+ sum);
    }
}

