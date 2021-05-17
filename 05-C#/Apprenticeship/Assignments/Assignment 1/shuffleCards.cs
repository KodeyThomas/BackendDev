using System;

namespace assignment1
{
    class Program
    {
        static Random rd = new Random();
        static void Main()
        {
            String[] arrayOfCards = new String[] {"notUsed","Ace of Clubs","2 of Clubs","3 of Clubs","4 of Clubs","5 of Clubs","6 of Clubs","7 of Clubs","8 of CLubs","9 of Clubs","Jack of Clubs","Queen of Clubs","King of Clubs","Ace of Spades","2 of Spades","3 of Spades","4 of Spades","5 of Spades","6 of Spades","7 of Spades","8 of Spades","9 of Spades","Jack of Spades","Queen of Spades","King of Spades","Ace of Hearts","2 of Hearts","3 of Hearts","4 of Hearts","5 of Hearts","6 of Hearts","7 of Hearts","8 of Hearts","9 of Hearts","Jack of Hearts","Queen of Hearts","King of Hearts","Ace of Diamonds","2 of Diamonds","3 of Diamonds","4 of Diamonds","5 of Diamonds","6 of Diamonds","7 of Diamonds","8 of Diamonds","9 of Diamonds","Jack of Diamonds","Queen of Diamonds","King of Diamonds"};
            Console.WriteLine("The array before shuffling is : {0}", arrayOfCards);
            for(int p = 52; p > 1; p--)
            {
                int r = rd.Next(1, 53);
                String temp = arrayOfCards[r];
                arrayOfCards[r] = arrayOfCards[p];
                arrayOfCards[p] = temp;
            }
            Console.WriteLine("The array after shuffling is : {0}", arrayOfCards);
            Console.ReadLine();
        }
    }
}
