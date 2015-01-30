using System;


/*
 *Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators. 
 */


class Multiplication
{
    static void Main()
    {
        Console.Write("first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("second number: ");
        double secondNum = double.Parse(Console.ReadLine());
         Console.Write("third number: ");
        double thirdNum = double.Parse(Console.ReadLine());


        if (firstNum <0 && secondNum>0 && thirdNum> 0)
        {
            Console.WriteLine("-");
        }
        else if(firstNum>0 && secondNum<0 && thirdNum>0)
        {
            Console.WriteLine("-");
        }
        else if(firstNum>0 && secondNum>0 && thirdNum<0)
        {
            Console.WriteLine("-");
        }
        else if(firstNum<0 && secondNum<0 && thirdNum<0)
        {
            Console.WriteLine("-");
        }
        else if(firstNum <0 && secondNum<0 && thirdNum>0)
        {
            Console.WriteLine("+");
        }
        else if (firstNum < 0 && secondNum > 0 && thirdNum < 0)
        {
            Console.WriteLine("+");
        }
        else if (firstNum > 0 && secondNum < 0 && thirdNum < 0)
        {
            Console.WriteLine("+");
        }
        else if (firstNum < 0 && secondNum < 0 && thirdNum > 0)
        {
            Console.WriteLine("+");
        }
        else if (firstNum > 0 && secondNum > 0 && thirdNum > 0)
        {
            Console.WriteLine("+");
        }
        else if(firstNum==0 || secondNum==0 || thirdNum==0)
        {
            Console.WriteLine("0");
        }

    }
}

