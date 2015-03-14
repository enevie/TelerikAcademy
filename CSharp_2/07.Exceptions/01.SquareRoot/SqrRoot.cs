namespace SquareRoot
{
    using System;

    class SqrRoot
    {
        static void Main()
        {

            try
            {
                double number = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                if (number < 0)
                {
                    throw new FormatException("Invalid number!");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
