using System;
using System.Linq;
/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 */


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] arr = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int counter = 1;
        int maxSeq = 1;
        int maxCounter = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxSeq = arr[i];
                }
            }
            else
            {
                counter = 1;
            }
        }
        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write("{0}, ", maxSeq);
        }
        Console.WriteLine("\b\b ");
    }
}

