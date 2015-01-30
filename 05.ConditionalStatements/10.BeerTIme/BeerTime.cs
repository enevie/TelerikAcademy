using System;
using System.Linq;
using System.Globalization;

/*
 * A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
 */


class BeerTime
{
    static void Main()
    {
        DateTime newTime = DateTime.ParseExact(Console.ReadLine(),"h:mm tt",System.Globalization.CultureInfo.InvariantCulture);
        DateTime beerTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);
        DateTime anotherBeer = DateTime.ParseExact("03:00 AM", "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);

        if(newTime.TimeOfDay.CompareTo(beerTime.TimeOfDay)>=0 || newTime.TimeOfDay.CompareTo(anotherBeer.TimeOfDay) <0)
        {
            Console.WriteLine("beer time!");
        }
        else
        {
            Console.WriteLine("non beer time!");
        }
    }
}

