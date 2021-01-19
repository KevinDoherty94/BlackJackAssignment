namespace BlackJackAssignment
{
    using System;

   
    internal class Program
    {
       
        private const int MaxValue = 21;

       
        public static int DrawNumber { get; set; } = 2;

        
        public static int CurrentPlayerTotal { get; set; }

       
        public static string StickOrTwist { get; set; }

        
        private static void Main(string[] args)
        {
            // Black Jack Flow
            Console.WriteLine("Player Plays");
            DealPlayerHand();

            Console.WriteLine("Dealer Plays");
            DealDealerHand();
        }

        private static void DealPlayerHand()
        {
            DealHand newHand = new DealHand(CurrentPlayerTotal, DrawNumber);
            Console.WriteLine("Your score is {0}", newHand.Total);

            if (newHand.Total < MaxValue)
            {
                Console.WriteLine("Do you want to stick or twist - s/t?");
                StickOrTwist = Console.ReadLine();

                if (StickOrTwist.ToLower() == "t")
                {
                    DrawNumber = 1;
                    CurrentPlayerTotal = newHand.Total;
                    DealPlayerHand();
                }
            }
            else if (newHand.Total > MaxValue)
            {
                Console.WriteLine($"Bust! Score above {MaxValue}");
            }

            // reset
            CurrentPlayerTotal = 0;
            DrawNumber = 2;
            Console.WriteLine(string.Empty);
        }

        
        private static void DealDealerHand()
        {
            DealHand newHand = new DealHand(CurrentPlayerTotal, DrawNumber);
            Console.WriteLine("Dealer score is {0}", newHand.Total);

            if (newHand.Total < MaxValue)
            {
                Console.WriteLine("Do you want to stick or twist - s/t?");
                StickOrTwist = Console.ReadLine();

                if (StickOrTwist.ToLower() == "t")
                {
                    DrawNumber = 1;
                    CurrentPlayerTotal = newHand.Total;
                    DealDealerHand();
                }
            }
            else if (newHand.Total > MaxValue)
            {
                Console.WriteLine($"Bust! Score above {MaxValue}");
            }
        }
    }
}