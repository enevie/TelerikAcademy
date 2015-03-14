namespace _16.DateDifference
{
    using System;
    using System.Text;
    using System.Globalization;

    class Date
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            DateTime dateF = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            string secondDate = Console.ReadLine();
            DateTime dateS = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

            TimeSpan difference = dateS - dateF;
            string formattedResult = difference.ToString();
            var ebasiKolko = new StringBuilder();
            for (int i = 0; i < formattedResult.Length; i++)
            {
                if(formattedResult[i]=='0')
                {
                    continue;
                }
                if(char.IsDigit(formattedResult[i]))
                {
                    ebasiKolko.Append(formattedResult[i]);
                }
            }
            Console.WriteLine("first date: "+firstDate);
            Console.WriteLine("second date: "+secondDate);
            Console.WriteLine("days :" + ebasiKolko.ToString());



        }
    }
}
