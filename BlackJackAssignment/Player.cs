using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAssignment
{
    class Player
    {
        public string CardDealt { get; set; }
        public string CardNumber { get; set; }
        public string CardSuite { get; set; }
        public int Value { get; set; }
        public int Total { get; set; }


        public Player()
        {

        }

        public Player(string cardNumber, string cardSuite, int value)
        {

            CardNumber = cardNumber;
            CardSuite = cardSuite;
            Value = value;

        }
        public int GetCardNumber()
        {
            Random Rand = new Random();
            int[] Deck = new int[52];
            string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };

            for (int i = 0; i < Deck.Length; i++)
            {
                Deck[i] = i;
            }

            for (int i = 0; i < Deck.Length; i++)
            {
                int index = Rand.Next(Deck.Length);
                int temp = Deck[i];
                Deck[i] = Deck[index];
                Deck[index] = temp;
            }

            for (int i = 0; i < 2; i++)
            {
                String suit = suits[Deck[i]/13];
                String rank = ranks[Deck[i]/13];
                int value = 0;
                value = Deck[i];
                Console.WriteLine("Card dealt is the {0} of {1}, value is {2}",ranks,suits,value );

            }
            return Console.Read();
        }
        public override string ToString()
        {
            return string.Format("{0}", GetCardNumber());
        }










    }
}

