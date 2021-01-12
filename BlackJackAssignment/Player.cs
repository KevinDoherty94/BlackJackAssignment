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
    }
}
