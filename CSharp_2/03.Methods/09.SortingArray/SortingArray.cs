using System;
using System.Linq;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class SortingArray
{
    static int FindMaxDigit(int startIndex, int endIndex,int[] numbers)
    {
        int maxNumber = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if(numbers[i]>maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        return maxNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine("Enter start index of searching: ");
        int startIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end index of searching: ");
        int endIndex = int.Parse(Console.ReadLine());

        Console.WriteLine(FindMaxDigit(startIndex,endIndex,numbers));

    }
}

