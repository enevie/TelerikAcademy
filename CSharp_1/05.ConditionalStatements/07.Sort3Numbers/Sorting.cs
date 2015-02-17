using System;

/*
Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements. 
 */


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: ");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

          if(firstNum>secondNum)
          {
              if(firstNum>thirdNum)
              {
                  Console.WriteLine("{0}, {1}, {2}", firstNum,secondNum,thirdNum);
              }
              else
              {
                  Console.WriteLine("{0}, {1}, {2}", thirdNum,firstNum,secondNum);
              }
          }
          else
          {
              if (secondNum > thirdNum)
              {
                  Console.WriteLine("{0}, {1}, {2}", secondNum, thirdNum, firstNum);
              }
              else
              {
                  Console.WriteLine("{0}, {1}, {2}", thirdNum, secondNum, firstNum);
              }
          }
        
    }
}

