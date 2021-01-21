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


            Console.WriteLine("Player Plays\n");
            DealPlayerHand();

        }

        //Methods

        public static void DealPlayerHand()
        {


            DealHand newHand = new DealHand(PlayerTotal, DrawNumber);
            Console.WriteLine("\nYour score is {0}", newHand.Total);

            if (newHand.Total <= MAX_VALUE)
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
                    DrawNumber = 2;
                    PlayerTotal = newHand.Total;
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("\nDealer Plays\n");
                    DealDealerHand();

                }
            }

            else if (newHand.Total > MAX_VALUE)
            {
                Console.WriteLine($"\nBust! Score above {MAX_VALUE}\nDealer wins");
                Console.WriteLine("\nDo you want to play another game? - Please enter y/n");
                string response = "";



                while (response != "y")
                {
                    
                    response = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nPlayer Plays");
                    DealPlayerHand();
                }

            }

            else
            {
                DealDealerHand();
            }
            Console.ReadLine();


        }


        public static void DealDealerHand()
        {
            DealHand newHand = new DealHand(DealerTotal, DrawNumber);
            Console.WriteLine("\nDealer score is {0}", newHand.Total);

            DealerTotal = newHand.Total;

            if (DealerTotal < DEALER_BELOW)
            {

                Console.WriteLine("");
                DrawNumber = 1;
                DealDealerHand();

            }
            else if (PlayerTotal > DealerTotal)
            {

                Console.WriteLine("\nPlayer wins");
                Console.WriteLine("\nDo you want to play another game? - Please enter y/n");

                string response = "";



                while (response != "y")
                {

                    response = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nPlayer Plays");
                    DealPlayerHand();
                }
            }
            else if (DealerTotal > MAX_VALUE)
            {

                Console.WriteLine($"\nBust! Score above {MAX_VALUE}\nPlayer wins");
                Console.WriteLine("\nDo you want to play another game? - Please enter y/n");

                string response = "";
              



                while (response != "y")
                {

                    response = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nPlayer Plays");
                    DealPlayerHand();
                }
            }
            else if (PlayerTotal == DealerTotal)
            {
                Console.WriteLine($"\nIts a draw");
                Console.WriteLine("\nDo you want to play another game? - Please enter y/n");

                string response = "";
                



                while (response != "y")
                {

                    response = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nPlayer Plays");
                    DealPlayerHand();
                }
            }
            else
            {

                Console.WriteLine("\nDealer wins");
                Console.WriteLine("\nDo you want to play another game? - Please enter y/n");

                string response = "";



                while (response != "y")
                {

                    response = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nPlayer Plays");
                    DealPlayerHand();
                }
            }
            Console.ReadLine();



        }

    }
}