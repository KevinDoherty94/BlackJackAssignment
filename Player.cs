using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAssignment
{
    class Player
    {
        //Properties

        public string CardDealt { get; set; }
        public string CardNumber { get; set; }
        public string CardSuite { get; set; }
        public int Value { get; set; }
        public int Total { get; set; }


        //Array which stores card face values
        string[] cardNumber = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };

        //Array that stores card suites
        string[] cardSuite = { "Hearts", "Spades", "Clubs", "Diamonds" };


        //Constructors

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

        //Class methods

        public void OutputConsole()
        {
            int num1, total = 0;
            for (int i = 0; i < 2; i++)
            {
               

                Console.WriteLine("Card dealt is the {0} of {1}, value {2}", GetCardNumber(), GetsCardSuite(), GetValue());
                num1 = GetValue();
                total +=  num1;
            }
            Console.WriteLine("Your score is {0}", total);
            Console.ReadLine();

            
        }
        public string GetCardNumber()
        {
            Random rand = new Random();

            int _cardNumber = rand.Next(cardNumber.Length); //Randomises cardNumber Array to out card number
            CardNumber = cardNumber[_cardNumber];
            return CardNumber;
        }
        public string GetsCardSuite()
        {
            Random rand = new Random();
            
            int _cardSuite = rand.Next(cardSuite.Length);//Randomises cardSuite Array to out card suite
            CardSuite = cardSuite[_cardSuite];
            return CardSuite;

        }
        public int GetValue()
        {
            //Uses cardNumber indexes from the cardNumber Array which converts its string value to an int of its face value

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

