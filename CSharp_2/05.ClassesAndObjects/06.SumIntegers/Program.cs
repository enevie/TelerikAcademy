using System;
using System.Text;
using System.Linq;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.



class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        Console.WriteLine("The sum is: " +CalculatingSum(numbers));
    }
    private static int CalculatingSum(string[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += Convert.ToInt32(number);
        }
        return sum;
    }
}

