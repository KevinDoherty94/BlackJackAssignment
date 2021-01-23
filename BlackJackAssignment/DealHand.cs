namespace BlackJackAssignment
{
    using System;
    using System.Threading;

    
    public class DealHand
    {
       //Class Properties

        public string CardDealt { get; set; }

        public string CardNumber { get; set; }

        public string CardSuite { get; set; }

        public int Total { get; set; }

        public int CurrentTotal { get; set; }

        //Class Arrays

        private readonly string[] cardFaceValues = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };

       
        private readonly string[] cardSuite = { "Hearts", "Spades", "Clubs", "Diamonds" };

        //Class Constructors
        
        public DealHand()
        {
        }

        public DealHand(int currentTotal, int drawNumber)
        {
            OutputCardValuesToConsole(currentTotal, drawNumber);
            GetValue(currentTotal);


        }

        //Class methods

        public void OutputCardValuesToConsole(int currentTotal, int drawNumber)
        {
            int num1;
            Total = 0;

            for (int i = 0; i < drawNumber; i++)
            {
                // Added to stop duplication
                Thread.Sleep(1);

                Console.WriteLine("Card dealt is the {0} of {1}, value {2}",GetCardNumber(), GetsCardSuite(), num1 = GetValue(currentTotal));

                Total += num1;
            }

            Total += currentTotal;

            //Keeps a total to determine ace is 11 or 1 

            
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

        public int GetValue(int currentTotal)
        {
           

            // 2 - 9 numbers only lenght of 1, Ace, Jack and Queen are greater
            if (CardNumber.Length == 1)
            {
                return Convert.ToInt16(CardNumber);
            }

            // Ace
           
            if (CardNumber == cardFaceValues[0])
            {
                if (currentTotal >= 11)
                {
                    return 1;

                }
                if (currentTotal < 11) {

                    return 11;
                }
                
            }

            // Jack, Queen or King
            return 10;
        }
    }
}
