using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSim.Static_Classes
{
    public class Banking
    {
        public void Deposit(int value)
        {
            Player.netWorth += value;
            Player.wallet -= value;
        }
        //this sentence is FALSE!!!!!!!
        public void Withdraw(int value)
        {
            Player.wallet += value;
            Player.netWorth -= value;
        }
    }
}

//