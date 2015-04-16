namespace ExtensionClasses
{
    using System;
    using System.Collections.Generic;

    class StartExtensions
    {
        static void Main()
        {
            var numbers = new List<double>() { 2, 5, 7, 8, 6, 15 };
            var sum = ExtensionClasses.SumCalculating(numbers);
            Console.WriteLine(sum);

            var product = ExtensionClasses.ProductCalculating(numbers);
            Console.WriteLine(product);

            var minimum = ExtensionClasses.MinFinder(numbers);
            Console.WriteLine(minimum);

            var maximum = ExtensionClasses.MaxFinder(numbers);
            Console.WriteLine(maximum);

            var avarage = ExtensionClasses.AvarageSum(numbers);
            Console.WriteLine("{0:F2}", avarage);
        }
    }
}
