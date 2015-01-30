using System;
using System.Linq;

/*
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */

class MinMaxSum
{
    static void Main()
    {
        Console.Write("Please enter how many digits to input: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
   
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("min =" + numbers.Min());
        Console.WriteLine("max =" + numbers.Max());
        Console.WriteLine("sum =" + numbers.Sum());
        Console.WriteLine("avarage ={0:0.00}", numbers.Average());
    }
}


