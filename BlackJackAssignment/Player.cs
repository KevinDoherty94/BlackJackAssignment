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

        public Player(string cardNumber, string cardSuite, int value, int total, string cardDealt)
        {
            CardDealt = cardDealt;
            CardNumber = cardNumber;
            CardSuite = cardSuite;
            Value = value;
            Total = total;
        }
        public Player(string cardNumber, string cardSuite, int value)
        {
            CardNumber = cardNumber;
            CardSuite = cardSuite;
            Value = value;
        }
      
        public static string GetCardNumber()
        {
            Random rand = new Random();

            string[] _CardNumber = new string[12] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };
            int cardNumber = rand.Next(_CardNumber.Length);
            return _CardNumber[cardNumber];
        }
        public  string GetsCardSuite()
        {
            Random rand = new Random();
            string[] _CardSuite = { "Hearts", "Spades", "Clubs", "Diamonds" };
            int cardSuite = rand.Next(_CardSuite.Length);
            return _CardSuite[cardSuite];

        }
        public  int CardValue()
        {
            int value = 0;


            if (GetCardNumber() == "Jack")
            {
                value = 10;
            }
            if (GetCardNumber() == "Queen")
            {
                value = 10;
            }
            if (GetCardNumber() == "King")
            {
                value = 10;
            }
            if (GetCardNumber() == "2")
            {
                value = 2;
            }
            if (GetCardNumber() == "3")
            {
                value = 3;
            }
            if (GetCardNumber() == "4")
            {
                value = 4;
            }
            if (GetCardNumber() == "5")
            {
                value = 5;
            }
            if (GetCardNumber() == "6")
            {
                value = 6;
            }
            if (GetCardNumber() == "7")
            {
                value = 7;
            }
            if (GetCardNumber() == "8")
            {
                value = 8;
            }
            if (GetCardNumber() == "9")
            {
                value = 9;
            }
            if (GetCardNumber() == "Ace")
            {
                value = 11;
            }


            return value;
        }

    }
}
