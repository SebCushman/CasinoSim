using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSim.Static_Classes
{
    public class Betting
    {
        public int currentBet = 0;

        public void Bet(int bet)
        {
            currentBet += bet;
            Player.wallet -= bet;
        }

        public void Payout(int multiplier)
        {
            Player.wallet += currentBet * multiplier;
            currentBet = 0;
        }
    }
}
