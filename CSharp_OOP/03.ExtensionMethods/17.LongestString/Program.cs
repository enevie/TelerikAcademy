namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            string[] words = new string[5] { "petko", "ala-bala", "kokalche", "beer", "azsymnai-dylgiq" };

            string longest = words.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine(longest);
        }
    }
}
