using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the arrays: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        int counter = 0;

        Console.WriteLine("Please enter the numbers in the first array");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter the numbers in the second array");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < firstArray.Length; i++)
        {
            if(firstArray[i]==secondArray[i])
            {
                ++counter;
            }
        }
        
        if(counter==n)
        {
            Console.WriteLine("Int are equal");
        }
        else
        {
            Console.WriteLine("Int are not equal");
        }

    }
}

