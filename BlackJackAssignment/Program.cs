﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();

            int num1, total = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Card dealt is the {0} of {1}, value {2}", p1.GetCardNumber(), p1.GetsCardSuite(), p1.CardValue());
                num1 = p1.CardValue();
                total = total + num1;
            }
            Console.WriteLine("Your score is {0}", total );




            Console.ReadLine();


        }
       
        
    }
}
