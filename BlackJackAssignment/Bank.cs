using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackAssignment
{
    class Bank
    {
        public decimal BankTotal { get; set; }

        public decimal CurrentBankTotal { get; set; }

        public decimal Remaining { get; set; }

        public decimal BetAmount { get; set; }

        public Bank()
        {

        }

        public Bank(decimal bankTotal, decimal remaining, decimal betAmount,decimal currentBankTotal)
        {
            BankTotal = bankTotal;

            Remaining = remaining;

            BetAmount = betAmount;

            CurrentBankTotal = currentBankTotal;
        }
    }
}
