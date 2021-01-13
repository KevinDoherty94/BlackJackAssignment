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

        string[] cardNumber = new string[12] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };
        string[] cardSuite = { "Hearts", "Spades", "Clubs", "Diamonds" };




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

        public string OutputConsole()
        {


           
           

            int num1, total = 0;
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Card dealt is the {0} of {1}, value {2}", GetCardNumber(), GetsCardSuite(), GetValue());
                num1 = GetValue();
                total +=  num1;
            }
            Console.WriteLine("Your score is {0}", total);

            return Console.ReadLine();




        }
        public string GetCardNumber()
        {
            Random rand = new Random();

            
            int _cardNumber = rand.Next(cardNumber.Length);
            CardNumber = cardNumber[_cardNumber];
            return CardNumber;
        }
        public string GetsCardSuite()
        {
            Random rand = new Random();
            
            int _cardSuite = rand.Next(cardSuite.Length);
            CardSuite = cardSuite[_cardSuite];
            return CardSuite;

        }
        public int GetValue()
        {
            int value = 0;


            if (GetCardNumber() == cardNumber[9])
            {
                value = 10;
            }
            if (GetCardNumber() == cardNumber[10])
            {
                value = 10;
            }
            if (GetCardNumber() == cardNumber[11])
            {
                value = 10;
            }
            if (GetCardNumber() == cardNumber[1])
            {
                value = 2;
            }
            if (GetCardNumber() == cardNumber[2])
            {
                value = 3;
            }
            if (GetCardNumber() == cardNumber[3])
            {
                value = 4;
            }
            if (GetCardNumber() == cardNumber[4])
            {
                value = 5;
            }
            if (GetCardNumber() == cardNumber[5])
            {
                value = 6;
            }
            if (GetCardNumber() == cardNumber[6])
            {
                value = 7;
            }
            if (GetCardNumber() == cardNumber[7])
            {
                value = 8;
            }
            if (GetCardNumber() == cardNumber[8])
            {
                value = 9;
            }
            if (GetCardNumber() == cardNumber[0])
            {
                value = 11;
            }

            Value = value;

            return Value;
        }

    }
}

