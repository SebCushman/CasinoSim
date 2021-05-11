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

        public bool Bet(int bet)
        {
            bool isValid = false;
            if (Player.wallet >= bet)
            {
                currentBet += bet;
                Player.wallet -= bet;
                isValid = true;
            }
            return isValid;
        }

        public void Payout(int multiplier)
        {
            Player.wallet += currentBet * multiplier;
            currentBet = 0;
        }
    }
}