using System;
using System.Collections.Generic;
using System.Linq;


  class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the frist array: ");
            int n = int.Parse(Console.ReadLine());
            char[] firstArr = new char[n];

            Console.Write("Enter the lenght of the second array: ");
            int m = int.Parse(Console.ReadLine());
            char[] secondArr = new char[m];

            int counter = 0;

            if(n==m)
            {
                Console.WriteLine("Enter the chars in the first array: ");
                for (int i = 0; i < n; i++)
                {
                    firstArr[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the chars in the second array: ");
                for (int i = 0; i < n; i++)
                {
                    secondArr[i] = char.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArr.Length; i++)
                {
                    if(firstArr[i] == secondArr[i])
                    {
                        counter++;
                    }
                }
                if(counter==n)
                {
                    Console.WriteLine("Chars in the arrays are equal");
                }
                else
                {
                    Console.WriteLine("Chars in the arrays are not equal");
                }

            }
            else
            {
                Console.WriteLine("Chars in the arrays are not equal");
            }

        }
    }

