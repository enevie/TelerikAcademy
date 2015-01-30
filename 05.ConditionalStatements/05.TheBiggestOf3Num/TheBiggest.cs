using System;

/*
 * Write a program that finds the biggest of three numbers.
 */


class Program
{
    static void Main()
    {
        Console.Write("first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("third number: ");
        double thirdNum = double.Parse(Console.ReadLine());
   

        if(firstNum>secondNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("The biggest num is : "+ firstNum);
            }
            else
            {
                Console.WriteLine("The biggest num is: "+ thirdNum);
            }
        }
        else
        {
            if(secondNum>thirdNum)
            {
                Console.WriteLine("The biggest num is: " + secondNum);
            }
            else
            {
                Console.WriteLine("The biggest num is: " + thirdNum);
            }
        }
       
    }
}

