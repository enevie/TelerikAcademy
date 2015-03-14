namespace ReplaceTags
{
    using System;
    using System.Text;

    //Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

    class Program
    {
        static void Main()
        {

            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            var result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                result.Append(text[i]);
                result.Replace("a href", "URL");
                result.Replace("/a", "/URL");
            }
            Console.WriteLine(result.ToString());
        }
    }
}
