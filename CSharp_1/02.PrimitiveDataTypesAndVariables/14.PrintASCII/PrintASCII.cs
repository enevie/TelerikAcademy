    using System;
    using System.Text;
    /*
    * Find online more information about ASCII (American Standard Code for Information Interchange) 
    * and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
    Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
    */

    class PrintASCII
    {
    static void Main()
    {
   Console.OutputEncoding = Encoding.Unicode;

            for (byte index = 0; index < byte.MaxValue; index++)
            {
                byte[] byteArray = { index };
                char[] asciiArray = Encoding.GetEncoding(437).GetChars(byteArray);
                char asciiSign = asciiArray[0];
                //or: char asciiSign = Encoding.GetEncoding(437).GetChars(new byte[]{index})[0];
                
                switch (index)
                {
                    case 0:   Console.WriteLine("{0} = not visible (null)", index); break;
                    case 7:   Console.WriteLine(@"{0} = not visible (""beep!"" sound)", index); break;
                    case 8:   Console.WriteLine("{0} = not visible (backspace)", index); break;
                    case 9:   Console.WriteLine("{0} = not visible (horizontal tab)", index); break;
                    case 10:  Console.WriteLine("{0} = not visible (new line)", index); break;
                    case 13: Console.WriteLine("{0} = not visible (carriage return)", index); break;
                    case 127: Console.WriteLine("{0} = not visible (DEL)", index); break;
                    case 32: Console.WriteLine("{0} = space", index); break;
              
                    default: Console.WriteLine("{0} = {1}", index, asciiSign); break;
                }               
            }
            char lastChar = Encoding.GetEncoding(437).GetChars(new byte[] { 255 })[0];
            Console.WriteLine("{0} = not visible", 255, lastChar);
        }
    }


