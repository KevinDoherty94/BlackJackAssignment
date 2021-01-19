namespace BlackJackAssignment
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the MaxValue.
        /// </summary>
        private const int MaxValue = 21;

        /// <summary>
        /// Gets or sets the DrawNumber.
        /// </summary>
        public static int DrawNumber { get; set; } = 2;

        /// <summary>
        /// Gets or sets the CurrentPlayerTotal.
        /// </summary>
        public static int CurrentPlayerTotal { get; set; }

        /// <summary>
        /// Gets or sets the StickOrTwist.
        /// </summary>
        public static string StickOrTwist { get; set; }

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        private static void Main(string[] args)
        {
            // Black Jack Flow
            Console.WriteLine("Player Plays");
            DealPlayerHand();

            Console.WriteLine("Dealer Plays");
            DealDealerHand();
        }

        protected Program()
        {
        }

        /// <summary>
        /// The DealPlayerHand.
        /// </summary>
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

        /// <summary>
        /// The DealDealerHand.
        /// </summary>
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