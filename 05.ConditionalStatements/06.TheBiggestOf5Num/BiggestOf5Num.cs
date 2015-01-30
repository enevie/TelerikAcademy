using System;
using System.Linq;

/*
 * Write a program that finds the biggest of five numbers by using only five if statements.
 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers: ");

        double[] array = new double[5];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        if (array[0] == array.Max())
        {
            Console.WriteLine("The biggest num is: " + array[0]);
        }
        if (array[1] == array.Max())
        {
            Console.WriteLine("The biggest num is: " + array[1]);
        }
        if (array[2] == array.Max())
        {
            Console.WriteLine("The biggest num is: " + array[2]);
        }
        if (array[3] == array.Max())
        {
            Console.WriteLine("The biggest num is: " + array[3]);
        }
        if (array[4] == array.Max())
        {
            Console.WriteLine("The biggest num is: " + array[4]);
        }

    }
}

