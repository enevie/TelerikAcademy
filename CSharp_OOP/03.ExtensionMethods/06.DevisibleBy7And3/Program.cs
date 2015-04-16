namespace _06.DevisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 2, 5, 7, 10, 21, 8, 53, 147, 99, 15 };


            var devisible =
                             from number in numbers
                             where number % 7 == 0 && number % 3 == 0
                             select number;

            foreach (var number in devisible)
            {
                Console.WriteLine(number);
            }


            List<int> devisible2 = numbers.FindAll(x => x % 7 == 0 && x % 3 == 0);

            foreach (var number in devisible2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
