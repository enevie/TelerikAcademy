namespace StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Text;
  
    public static class SubstringExtension
    {
        static void Main()
        {
            var test = new StringBuilder();
            test.Append("Sunday");
            string result = test.Substring(2, 5).ToString();
            Console.WriteLine(result);
        }

        public static StringBuilder Substring(this StringBuilder builderToChange, int index, int lenght)
        {
            var builder = new StringBuilder();
            string toFormat = builderToChange.ToString();
            var chars = new List<char>();

            for (int i = 0; i < toFormat.Length; i++)
            {
                chars.Add(builderToChange[i]);
            }

            for (int i = index; i < lenght; i++)
            {
                builder.Append(chars[i]);
            }

            return builder;
        }
    }
}
