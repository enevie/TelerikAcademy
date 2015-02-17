using System;

//Write a program that finds the most frequent number in an array.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lenght of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxCounter = 0;
        int currCounter = 0;
        int startIndex = array[0];
        int currMaxNumber = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            startIndex = array[0 + i];
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == startIndex)
                {
                    currCounter++;
                }
                if (currCounter > maxCounter)
                {
                    maxCounter = currCounter;
                    currMaxNumber = array[j];
                }
            }
            currCounter = 0;
        }
        Console.WriteLine("{0} ({1} times)", currMaxNumber, maxCounter);

    }
}


