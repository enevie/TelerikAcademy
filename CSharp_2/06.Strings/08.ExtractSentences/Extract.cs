namespace ExtractSentences
{
    using System;
    using System.Text;
    using System.Linq;

    //    Write a program that extracts from a given text all sentences containing given word.
    //Example:

    //The word is: in

    //The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

    //The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

    //Consider that the sentences are separated by . and the words – by non-letter symbols.



    class Extract
    {
        static void Main()
        {
            var result = new StringBuilder();
            string rawText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. We are in love! Pasteti. We are in good shape?";
            int startIndex = 0;
            int findIndex = 0;

            for (int i = 0; i < rawText.Length; i++)
            {
                int index = rawText.IndexOf(" in ", startIndex);
                startIndex = index + 1;
                if (index < 0)
                {
                    break;
                }

                if (index > 0)
                {
                    if (i > 0)
                    {
                        for (int k = startIndex; ; k--)
                        {
                            if (rawText[k] == '.' ||  rawText[k] == '!' || rawText[k] == '?')
                            {
                                findIndex = k + 1;
                                break;
                            }
                        }
                    }

                    for (int j = findIndex; j < rawText.Length; j++)
                    {
                        result.Append(rawText[j]);
                        if (rawText[j] == '.' ||  rawText[j] == '!' || rawText[j] == '?')
                        {
                            findIndex = j;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
