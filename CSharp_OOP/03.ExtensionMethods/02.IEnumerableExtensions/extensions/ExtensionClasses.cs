namespace ExtensionClasses
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public static class ExtensionClasses
    {

        public static T SumCalculating<T>(this IEnumerable<T> list)
        {
            T sum = (dynamic)0;
            foreach (var item in list)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T ProductCalculating<T>(this IEnumerable<T> list)
        {
            T sum = (dynamic)1;
            foreach (var item in list)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }

        public static T MinFinder<T>(this IEnumerable<T> list)
        {
            T minumum = (dynamic)int.MaxValue;
            foreach (var item in list)
            {
                if (minumum > (dynamic)item)
                {
                    minumum = item;
                }
            }
            return minumum;
        }

        public static T MaxFinder<T>(this IEnumerable<T> list)
        {
            T maximum = (dynamic)int.MinValue;

            foreach (var item in list)
            {
                if (maximum < (dynamic)item)
                {
                    maximum = item;
                }
            }
            return maximum;
        }

        public static T AvarageSum<T>(this IEnumerable<T> list)
        {
            T maximum = (dynamic)0;
            int count = 0;

            foreach (var item in list)
            {
                maximum += (dynamic)item;
                count++;
            }
            return maximum/(dynamic)count;
        }

    }
}
