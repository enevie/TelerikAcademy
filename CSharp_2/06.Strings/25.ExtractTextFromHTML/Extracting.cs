namespace ExtractTextFromHTML
{
    using System;
    using System.Text;

    //    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
    //Example input:

    //<html>
    //  <head><title>News</title></head>
    //  <body><p><a href="http://academy.telerik.com">Telerik
    //    Academy</a>aims to provide free real-world practical
    //    training for young people who want to turn into
    //    skilful .NET software engineers.</p></body>
    //</html>
    //Output:

    //Title: News

    //Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

    class Program
    {
        static void Main()
        {
            var input = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                input.AppendLine(Console.ReadLine());
            }
            string text = input.ToString();

            string title = string.Empty;

            int titleStart = text.IndexOf("<title>");
            int titleLast = text.IndexOf("</title>");
            title = text.Substring(titleStart + 7, titleLast - titleStart - 7);
            Console.WriteLine("title: " + title);

            int bodyStart = text.IndexOf("<body>");
            int bodyEnd = text.IndexOf("</body>");

            var body = new StringBuilder();
            bool isInATag = false;


            for (int i = bodyStart + 6; i < bodyEnd; i++)
            {
                if(body.ToString() == "<a href")
                {
                    isInATag = true;
                    body.Replace("<a href", "");
                }
                if(isInATag && text[i] == '>')
                {
                    isInATag = false;
                    continue;
                }
                if(isInATag)
                {
                    continue;
                }
                else
                {
                    body.Append(text[i]);
                }
                body.Replace("<p>", "");
                body.Replace("</p>", "");
                body.Replace("</a>", " ");
                body.Replace("\r\n", "");
                body.Replace("    ", " ");
            }

            Console.WriteLine("text:  "+body.ToString());
        }
    }
}
