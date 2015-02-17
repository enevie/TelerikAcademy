using System;
using System.Linq;

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

class Larger
{
    static int ChecksNeighbourDigits(int numberPosition, params int[] number)
    {
        try
        {
            bool nextNeighbourIsSmaller = (number[numberPosition] > number[numberPosition + 1]);
            bool priviousNeighbourIsSmaller = (number[numberPosition] > number[numberPosition - 1]);
            if (nextNeighbourIsSmaller && priviousNeighbourIsSmaller)
            {
                return 1;
            }
        }
        catch (IndexOutOfRangeException)
        {
            return 2;
        }
        return 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        Console.WriteLine("Enter the index of the number you want to check (starting from 0):");
        int numberPosition = int.Parse(Console.ReadLine());

        int result = ChecksNeighbourDigits(numberPosition, numbers);

        if (result == 1)
        {
            Console.WriteLine("The neighbors digits are smaller!");
        }
        else if (result == 2)
        {
            Console.WriteLine("The number don't have 2 neighbours, indexes out of range!");
        }
        else
        {
            Console.WriteLine("The neighbor are smaller");
        }
    }
}

