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
        const int MINIMUM_BET = 25;
        const int MAXIMUM_BET = 50;

        //Properties

        public static int DrawNumber = 2;

        public static int PlayerTotal;

        public static int DealerTotal;

        public static string StickOrTwist;

        public static decimal BankTotal;



       public static void Main(string[] args)
        {

            
            Console.WriteLine("\nPlease enter how much you want to place in the bank\nNote if you dont want to bet today your money will be returned to you after the game");
            Console.Write("Enter value here: ");
            BankTotal = decimal.Parse(Console.ReadLine());
          
            Bet();

            Console.WriteLine("\nPlayer Plays");

            DealPlayerHand();

        }//Main Method

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

                PlayAgain();
            }

            else
            {
                DealDealerHand();
            }
            Console.ReadLine();


        }//End of DealPlayerHand method

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

                PlayAgain();

            }
            else if (DealerTotal > MAX_VALUE)
            {

                Console.WriteLine($"\nBust! Score above {MAX_VALUE}\nPlayer wins");

                PlayAgain();

            }
            else if (PlayerTotal == DealerTotal)
            {
                Console.WriteLine($"\nIts a draw");

                PlayAgain();

            }
            else
            {
                Console.WriteLine("\nDealer wins");

                PlayAgain();

            }
            Console.ReadLine();

            



        }//End of DealDealerHand method

        public static void PlayAgain()
        {
            DealHand playAgain = new DealHand();

            playAgain.Total = 0;
            DealerTotal = 0;
            PlayerTotal = 0;
            DrawNumber = 2;

            string response = "";
            Console.WriteLine("\nDo you want to play another game? - Please enter y/n");
            response = Console.ReadLine();

            while (response == "y")
            {
                Console.Clear();
                Bet();
                Console.WriteLine("\nPlayer Plays");
                DealPlayerHand();

            }

            Console.WriteLine("\nThanks for playing");

            Console.ReadLine();

        }// End of PlayAgain method

        public static void Bet()
        {
            Bank bet = new Bank();

            string betResponse = "";

            Console.WriteLine("\nYou can place a bet on this table\nThe Minimum bet value is 25 and the Maximum is 50 ");

            Console.WriteLine("\nDo you want to place a bet? - please enter y/n\n");

            betResponse = Console.ReadLine();

            if (betResponse.ToLower() == "y")
            {

                Console.WriteLine("\nHow much do you want to bet this round?");
                bet.BetAmount = decimal.Parse(Console.ReadLine());

                while ((bet.BetAmount != MINIMUM_BET) && (bet.BetAmount != MAXIMUM_BET))
                {
                    Console.WriteLine("\nIncorrect amount entered\nThe Minimum bet value is 25 and the Maximum is 50\nPlease enter your bet again");

                    Console.WriteLine("\nHow much do you want to bet?");
                    bet.BetAmount = decimal.Parse(Console.ReadLine());
                }

                Console.WriteLine($"\nYou have {BankTotal} in your bank\nYour current bet is {bet.BetAmount}\nPress enter to continue ...");
            }

            if (betResponse.ToLower() == "n")
            {
                Console.WriteLine("\nThat's okay, if you change your mind you can bet next game\nPlease press enter to continue ...");
            }
            Console.ReadLine();

        }//End of Bet method
       
    }
}