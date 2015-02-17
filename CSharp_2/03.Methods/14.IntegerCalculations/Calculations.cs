using System;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class Calculations
{
    static int Minimum(params int[] numbers)
    {
        int minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        return minimum;
    }
    static int Maximum(params int[] numbers)
    {
        int max = numbers[0];
        int currMax = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            currMax = Math.Max(numbers[i - 1], numbers[i]);
            if (currMax > max)
            {
                max = currMax;
            }
        }
        return max;
    }
    static double Avarage(params int[] numbers)
    {
        double avarage = 0;
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return avarage = sum / numbers.Length;
    }
    static int Sum(params int[] numbers)
    {
        int sum = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int Product(params int[] numbers)
    {
        int sum = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum *= numbers[i];
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("The minimal number is: " + Minimum(3, 5, 4, 2, 1));
        Console.WriteLine("The maximum number is: " + Maximum(3, 5, 4, 2, 1));
        Console.WriteLine("Avarage sum is: " + Avarage(3, 5, 4, 2, 1, 1));
        Console.WriteLine("The sum is: " + Sum(3, 5, 4, 2, 1));
        Console.WriteLine("The product sum is: " + Product(3, 5, 4, 2, 1));
    }
}

