namespace BlackJackAssignment
{
    using System;
    using System.Threading;

    
    public class DealHand
    {
       
        public string CardDealt { get; set; }

       
        public string CardNumber { get; set; }

       
        public string CardSuite { get; set; }

       
        public int Value { get; set; }

        
        public int Total { get; set; }

       

        private readonly string[] cardFaceValues = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };

       
        private readonly string[] cardSuite = { "Hearts", "Spades", "Clubs", "Diamonds" };

        
        public DealHand()
        {
        }

        
        public DealHand(int currentTotal, int drawNumber)
        {
            OutputCardValuesToConsole(currentTotal, drawNumber);
        }

        public void OutputCardValuesToConsole(int currentTotal, int drawNumber)
        {
            int num1;
            Total = 0;

            for (int i = 0; i < drawNumber; i++)
            {
                // Added to stop duplication
                Thread.Sleep(1);

                Console.WriteLine("Card dealt is the {0} of {1}, value {2}", GetCardNumber(), GetsCardSuite(), num1 = GetValue());

                Total += num1;
            }

            Total += currentTotal;
        }

       
        public string GetCardNumber()
        {
            Random rand = new Random();
            CardNumber = cardFaceValues[rand.Next(0, cardFaceValues.Length)];

            return CardNumber;
        }

        
        public string GetsCardSuite()
        {
            Random rand = new Random();
            CardSuite = cardSuite[rand.Next(0, cardSuite.Length)];

            return CardSuite;
        }

        
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
                return 11;
            }

            // Jack, Queen or King
            return 10;
        }
    }
}
