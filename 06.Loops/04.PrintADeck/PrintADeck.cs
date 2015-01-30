using System;
using System.Linq;



class PrintADeck
{
    enum Cards
    {
        _2 = 0,
        _3 = 1,
        _4 = 2,
        _5 = 3,
        _6 = 4,
        _7 = 5,
        _8 = 6,
        _9 = 7,
        _10 = 8,
        _J = 9,
        _Q = 10,
        _K = 11,
        _A = 12
    }
    enum Suits
    {
        spades = 0,
        clubs = 1,
        hearts = 2,
        diamonds = 3
    }
    static void Main()
    {

        for (int card = 0; card < 13; card++)
        {
            for (int suits = 0; suits < 4; suits++)
            {
                
                Console.Write(((Cards)card)
                                       .ToString()
                                       .TrimStart('_')
                                       .PadLeft(2)
                                       + " of " + (Suits)suits);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
           
    }
}


