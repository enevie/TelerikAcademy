using System;
using System.Linq;

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class SearchForFirstLarger
{
    static int ReturnFirstLargerIndex(params int[] numbers)
    {
        int index = 0;
        for (int i = 1; i <= numbers.Length; i++)
        {
          if(numbers[i]>numbers[i+1] && numbers[i]>numbers[i-1])
          {
              index = i;
              return index;
          }
        }
        return -1;
    }

    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int index = ReturnFirstLargerIndex(numbers);
        int result = numbers[index];
        Console.WriteLine("The first number larger then his neighbours is with index: "+index);
        Console.WriteLine("The number is: "+result);
    }
}

