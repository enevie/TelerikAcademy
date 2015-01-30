using System;
using System.Linq;
using System.Text;

/*
 * Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
 */


class Program
{
    static void Main()
    {
        string[] cards = new string[15];

        for (int i = 2; i <= 10; i++)
        {
            cards[i] = i.ToString();
        }
        cards[11] = "J";
        cards[12] = "Q";
        cards[13] = "K";
        cards[14] = "A";

        string testCards = Console.ReadLine().ToUpper();
        if(cards.Contains(testCards))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

