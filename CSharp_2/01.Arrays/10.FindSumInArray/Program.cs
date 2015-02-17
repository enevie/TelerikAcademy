using System;
using System.Linq;

//ite a program that finds in given array of integers a sequence of given sum S (if present).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] array = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine("Enter the sum we are searching: ");
        int sumToFind = int.Parse(Console.ReadLine());

        int startIndex = 0;
        int endIndex = 0;
        int currSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                currSum += array[j];
                if (currSum == sumToFind)
                {
                    startIndex = i;
                    endIndex = j;
                    break;
                }
                if (currSum > sumToFind)
                {
                    break;
                }
            }
            currSum = 0;
        }
        Console.Write("The digits in sequence with the searching sum: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine("\b\b ");
    }
}


