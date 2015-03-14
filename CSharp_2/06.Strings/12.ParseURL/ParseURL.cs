namespace ParseURL
{
    using System;
    using System.Text;


    //Write a program that parses an URL address given in the format: [protocol],[server],[resource]:
    //Example:

    //URL	Information
    //http://telerikacademy.com/Courses/Courses/Details/212	
    //[protocol] = http
    //[server] = telerikacademy.com 
    //[resource] = /Courses/Courses/Details/212

    class URL 
    {
        static void Main()
        {
            string text = "http://telerikacademy.com/Courses/Courses/Details/212";

            var protocolResult = new StringBuilder();
            string server = string.Empty;
            string resource = string.Empty;

            int protocolParse = text.IndexOf("://");
           
            int serverParse = text.IndexOf("/",protocolParse+3);
            for (int i = 0; i < protocolParse; i++)
            {
                protocolResult.Append(text[i]);
            }
            protocolParse += 3;
            server = text.Substring(protocolParse, (serverParse - protocolParse));
            resource = text.Substring(serverParse, text.Length - serverParse);

            Console.WriteLine("[protocol]: {0}",protocolResult.ToString());
            Console.WriteLine("[server]: {0}",server);
            Console.WriteLine("[resource]: {0}",resource);

        }
    }
}
