using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAssignment
{
    class Bank
    {

        public decimal CurrentBankTotal { get; set; }

        public decimal Remaining { get; set; }

        public decimal BetAmount { get; set; }

        public Bank()
        {

        }

        public Bank(decimal remaining, decimal betAmount,decimal currentBankTotal)
        {
           
            Remaining = remaining;

            BetAmount = betAmount;

            CurrentBankTotal = currentBankTotal;
        }

      
    }
}
