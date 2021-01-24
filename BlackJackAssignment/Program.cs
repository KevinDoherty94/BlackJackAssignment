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

        public static decimal BankTotal = 0m;

        public static decimal BetAmount;

        public static decimal BetReturned = 0m;



       public static void Main(string[] args)
        {

            
            Console.WriteLine("\nPlease enter how much you want to place in the bank\nNote if you dont want to bet today your money will be returned to you after the game");
            Console.Write("Enter value here: ");
            BankTotal = decimal.Parse(Console.ReadLine());
          
            Bet();

            Console.Clear();

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
                BankTotal = BankTotal -((BetAmount * 2) - BetAmount);
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

                BankTotal = BankTotal + BetAmount;

                PlayAgain();

            }
            else if (DealerTotal > MAX_VALUE)
            {

                Console.WriteLine($"\nBust! Score above {MAX_VALUE}\nPlayer wins");

                BankTotal = BankTotal + BetAmount;

                PlayAgain();

            }
            else if (PlayerTotal == DealerTotal)
            {
                Console.WriteLine($"\nIts a draw");

                BankTotal = BankTotal + BetAmount;

                PlayAgain();

            }
            else
            {
                Console.WriteLine("\nDealer wins");

                BankTotal = BankTotal - ((BetAmount * 2) - BetAmount);

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

            Console.Clear();

            Console.WriteLine("\nThanks for playing");

            Console.WriteLine($"\nYour bank amount of {BankTotal} has been returned to you");

            Console.ReadLine();

        }// End of PlayAgain method

        public static void Bet()
        {
           
            string betResponse = "";

            Console.WriteLine("\nYou can place a bet on this table\nThe Minimum bet value is 25 and the Maximum is 50");

            Console.WriteLine("\nDo you want to place a bet? - please enter y/n\n");

            betResponse = Console.ReadLine();

            if (betResponse.ToLower() == "y")
            {
                if (BankTotal <= 0)
                {
                    string topUpResponse = "";
                    Console.WriteLine("\nYou haven't enough in your bank to keep playing\nDo you want to top up - y/n");
                    topUpResponse = Console.ReadLine();

                    if(topUpResponse == "y")
                    {
                        Console.WriteLine("\nPlease enter how much you want to place in the bank\nNote if you dont want to bet today your money will be returned to you after the game");
                        Console.Write("\nEnter value here: ");
                        BankTotal = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nNo problem you can continue to play without betting or quit the game\nPress enter to decide ...");
                        PlayAgain();
                    }
                    

                }
                Console.WriteLine("\nHow much do you want to bet this round?");
                BetAmount = decimal.Parse(Console.ReadLine());

                while ((BetAmount != MINIMUM_BET) && (BetAmount != MAXIMUM_BET))
                {
                    Console.WriteLine("\nIncorrect amount entered\nThe Minimum bet value is 25 and the Maximum is 50\nPlease enter your bet again");

                    Console.WriteLine("\nHow much do you want to bet?");
                    BetAmount = decimal.Parse(Console.ReadLine());
                }

                Console.WriteLine($"\nYou have {BankTotal} in your bank\nYour current bet is {BetAmount}\nPress enter to continue ...");
                
            }

            if (betResponse.ToLower() == "n")
            {
                Console.WriteLine("\nThat's okay, if you change your mind you can bet next game\nPlease press enter to continue ...");
            }
            Console.ReadLine();

        }//End of Bet method
       
    }
}