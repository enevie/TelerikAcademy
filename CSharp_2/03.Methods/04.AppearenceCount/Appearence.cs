using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

class Appearence
{
    static int[] CountNumberInArray(params int[] array)
    {
        int currCount = 0;
        int maxCount = 0;
        int[] result = new int[2];
        int startIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            startIndex = array[i];
            for (int j = 0; j < array.Length; j++)
            {
                if (startIndex == array[j])
                {
                    currCount++;
                }
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    result[0] = maxCount;
                    result[1] = array[i];
                }
            }
            currCount = 0;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter how many numbers in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrNumbers = new int[n];

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Console.WriteLine("Please enter number ({0}):", i + 1);
            arrNumbers[i] = int.Parse(Console.ReadLine());
        }

        int[] result = CountNumberInArray(arrNumbers);
        Console.WriteLine("Number {0} - Maximum times: {1}", result[1], result[0]);
    }
}

