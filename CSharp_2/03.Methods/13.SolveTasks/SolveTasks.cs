using System;
using System.Linq;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

class SolveTasks
{
    static string ReverseDigits(string number)
    {
        if (number[0] == '-')
        {
            return "The number shoud be positive!";
        }
        else
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    static float CalculatingAvarageSum(float[] numbers)
    {
        try
        {
            float avSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avSum += numbers[i];
            }
            avSum = avSum / numbers.Length;
            return avSum;
        }
        catch (DivideByZeroException)
        {
            return 0;
        }
    }

    static int SolvingLinearEquation(int a, int x, int b)
    {
        int result = a * x + b;
        return result;
    }


    static void Main()
    {
        Console.WriteLine(@"
You have 3 options of choosing between the tasks:
  1. The first choice reverse a number 
  2. The second choice calculates the avarage sum from sequence of numbers
  3. The third choice solves the task a*x+b, you must input 3 numbers");
        Console.WriteLine();
        Console.Write("Please enter a choice 1,2 or 3: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter a number to reverse: ");
                string number = Console.ReadLine();
                Console.WriteLine(ReverseDigits(number));
                break;

            case 2:
                float[] numbers = Console.ReadLine()
                  .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(z => float.Parse(z))
                  .ToArray();
                if (CalculatingAvarageSum(numbers) == 0)
                {
                    Console.WriteLine("Error, there is nothing to calculate!");
                }
                else
                {
                    Console.WriteLine("The avarage sum of these numbers is: " + CalculatingAvarageSum(numbers));
                }
                break;

            case 3:
                Console.WriteLine("Enter three numbers, each in new line: ");
                Console.Write("Please enter a:");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a must be a positive number");
                    break;
                }
                else
                {
                    Console.Write("Please enter x:");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Please enter b:");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("The sum is: " + SolvingLinearEquation(a, x, b));
                    break;
                }
        }
    }
}

