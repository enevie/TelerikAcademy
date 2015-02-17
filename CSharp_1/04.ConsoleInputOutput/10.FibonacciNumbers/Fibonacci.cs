using System;
using System.Collections.Generic;
using System.Linq;


/*
 * Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 * 
 */


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] Fibonacci = new int[n];
            Fibonacci[0] = 0;
            Fibonacci[1] = 1;


            for (int i = 2; i <= Fibonacci.Length - 1; i++)
            {
                Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];

            }
            Console.WriteLine(string.Join(", ", Fibonacci));
        }
    }
}
