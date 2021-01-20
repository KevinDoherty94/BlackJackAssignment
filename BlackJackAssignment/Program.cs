namespace BlackJackAssignment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        //Constants

        const int MAX_VALUE = 21;
        const int DEALER_BELOW = 17;

        //Properties

        public static int DrawNumber = 2;


        public static int PlayerTotal;


        public static int DealerTotal;



        public static string StickOrTwist;


        static void Main(string[] args)
        {
            string response = "";

            do
            {
                DealPlayerHand();
                Console.WriteLine("Do you want to play another game? - y/n");
                response = Console.ReadLine();

            } while (response != "y");

        }

        //Methods

        public static void DealPlayerHand()
        {
            Console.WriteLine("Player Plays\n");
            DealHand newHand = new DealHand(PlayerTotal, DrawNumber);
            Console.WriteLine("\nYour score is {0}", newHand.Total);

            if (newHand.Total < MAX_VALUE)
            {
                Console.WriteLine("\nDo you want to stick or twist - s/t?\n");
                StickOrTwist = Console.ReadLine();

                if (StickOrTwist.ToLower() == "t")
                {
                    DrawNumber = 1;
                    PlayerTotal = newHand.Total;
                    DealPlayerHand();
                }

                if (StickOrTwist.ToLower() == "s")
                {
                    // reset
                    PlayerTotal = 0;
                    DrawNumber = 2;
                    Console.WriteLine(string.Empty);

                    Console.WriteLine("Dealer Plays\n");
                    DealDealerHand();

                }
            }

            else if (newHand.Total > MAX_VALUE)
            {
                Console.WriteLine($"\nBust! Score above {MAX_VALUE}\nDealer wins");
                Console.ReadLine();
            }


        }


        public static void DealDealerHand()
        {
            DealHand newHand = new DealHand(DealerTotal, DrawNumber);
            Console.WriteLine("\nDealer score is {0}", newHand.Total);

            if (newHand.Total < DEALER_BELOW)
            {

                Console.WriteLine("");
                DrawNumber = 1;
                DealerTotal = newHand.Total;
                DealDealerHand();

            }
            else if (PlayerTotal > DealerTotal)
            {
                Console.WriteLine("");
                Console.WriteLine("Player wins");

            }
            else if (newHand.Total > MAX_VALUE)
            {
                Console.WriteLine("");
                Console.WriteLine($"Bust! Score above {MAX_VALUE}\nPlayer wins");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Dealer wins");

            }
            Console.ReadLine();



        }

    }
}