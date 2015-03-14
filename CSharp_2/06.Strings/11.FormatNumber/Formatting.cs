namespace FormatNumber
{
    using System;
    using System.Text;
    using System.Globalization;

    //Problem 11. Format number
    //Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    //Format the output aligned right in 15 symbols.

    class Format
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string DecimalNumber = String.Format("{0,15:G}", number);
            string hexaDecimal = String.Format("{0,15:X2}", number);
            string percentage = String.Format("{0,15:P2}",(number/100f).ToString("P02",new  CultureInfo("en-us")));
            string scientific = String.Format("{0,15:E2}", number);

            Console.WriteLine(DecimalNumber+hexaDecimal+percentage+scientific);
        }
    }
}
