namespace BlackJackAssignment
{
    using System;
    using System.Threading;

    /// <summary>
    /// Defines the <see cref="DealHand" />.
    /// </summary>
    internal class DealHand
    {
        //Properties
        /// <summary>
        /// Gets or sets the CardDealt.
        /// </summary>
        public string CardDealt { get; set; }

        /// <summary>
        /// Gets or sets the CardNumber.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the CardSuite.
        /// </summary>
        public string CardSuite { get; set; }

        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the Total.
        /// </summary>
        public int Total { get; set; }

        //Array which stores card face values
        /// <summary>
        /// Defines the cardFaceValues.
        /// </summary>
        private readonly string[] cardFaceValues = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };

        //Array that stores card suites
        /// <summary>
        /// Defines the cardSuite.
        /// </summary>
        private readonly string[] cardSuite = { "Hearts", "Spades", "Clubs", "Diamonds" };

        //Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="DealHand"/> class.
        /// </summary>
        public DealHand()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DealHand"/> class.
        /// </summary>
        /// <param name="currentTotal">The currentTotal<see cref="int"/>.</param>
        /// <param name="drawNumber">The drawNumber<see cref="int"/>.</param>
        public DealHand(int currentTotal, int drawNumber)
        {
            OutputCardValuesToConsole(currentTotal, drawNumber);
        }

        //public DealHand(string cardNumber, string cardSuite, int value, int total, string cardDealt)
        //{
        //    CardDealt = cardDealt;
        //    CardNumber = cardNumber;
        //    CardSuite = cardSuite;
        //    Value = value;
        //    Total = total;
        //}

        //public DealHand(string cardNumber, string cardSuite, int value)
        //{
        //    CardNumber = cardNumber;
        //    CardSuite = cardSuite;
        //    Value = value;
        //}

        //Class methods
        /// <summary>
        /// The OutputCardValuesToConsole.
        /// </summary>
        /// <param name="currentTotal">The currentTotal<see cref="int"/>.</param>
        /// <param name="drawNumber">The drawNumber<see cref="int"/>.</param>
        public void OutputCardValuesToConsole(int currentTotal, int drawNumber)
        {
            int num1;
            Total = 0;

            for (int i = 0; i < drawNumber; i++)
            {
                // Added to stop dupication
                Thread.Sleep(1);

                Console.WriteLine("Card dealt is the {0} of {1}, value {2}", GetCardNumber(), GetsCardSuite(), num1 = GetValue());

                Total += num1;
            }

            Total += currentTotal;
        }

        /// <summary>
        /// The GetCardNumber.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetCardNumber()
        {
            Random rand = new Random();
            CardNumber = cardFaceValues[rand.Next(0, cardFaceValues.Length)];

            return CardNumber;
        }

        /// <summary>
        /// The GetsCardSuite.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetsCardSuite()
        {
            Random rand = new Random();
            CardSuite = cardSuite[rand.Next(0, cardSuite.Length)];

            return CardSuite;
        }

        /// <summary>
        /// The GetValue.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int GetValue()
        {
            // 2 - 9 numbers only lenght of 1, Ace, Jack and Queen are greater
            if (CardNumber.Length == 1)
            {
                return Convert.ToInt16(CardNumber);
            }

            // Ace
            if (CardNumber == cardFaceValues[0])
            {
                return 1;
            }

            // Jack, Queen or King
            return 10;
        }
    }
}
