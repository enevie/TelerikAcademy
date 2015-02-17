using System;


class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        double firstNum = double.Parse(numbers[0]);
        double secondNum = double.Parse(numbers[1]);
        double thirdNum = double.Parse(numbers[2]);
        double fourthNum = double.Parse(numbers[3]);
        double fifthNum = double.Parse(numbers[4]);
        double sum = firstNum + secondNum + thirdNum + fourthNum + fifthNum;
        Console.WriteLine("The sum of the 5 numbers is: " + sum);
    }
}

