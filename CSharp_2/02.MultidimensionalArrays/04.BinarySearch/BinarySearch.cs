using System;
using System.Linq;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] matrix = new int[n];
        int maxNumber = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine("Enter the {0}-th element of the array", i);
            matrix[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(matrix);

        Console.WriteLine("Enter the number K");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < matrix.Length; i++)
        {
            if(matrix[i]<k)
            {
                maxNumber = matrix[i];
            }
        }
        int find = Array.BinarySearch(matrix, maxNumber);

        if (find < 0)
        {
            Console.WriteLine("There are no numbers lesser then K");
        }
        else
        {
            Console.WriteLine("The biggest number leser then K is {0}", maxNumber);
        }
    }
}

