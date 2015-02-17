using System;
using System.Linq;


/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
   Find in the array those K elements that have maximal sum
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter numbers in array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter k");
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        for (int i = arr.Length - 1; i > arr.Length-k-1; i--)
        {
            sum += arr[i];
        }
        Console.WriteLine("The sum of maximum K numbers is :{0}",sum);

    }
}

