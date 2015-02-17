using System;
using System.Collections.Generic;
using System.Linq;


/*
* Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

*/


class Numbers
{
static void Main()
{
    Console.Write("Enter the first number: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    int b = int.Parse(Console.ReadLine());
    int count = 0;

    for (int i = a; i <= b; i++)
    {
        if (i % 5 == 0)
        {
            ++count;
        }
    }
    Console.WriteLine("p = "+count);
}
}

