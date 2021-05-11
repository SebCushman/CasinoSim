using CasinoSim.Static_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CasinoSim
{
    public partial class BlackJackWindow : Window
    {
        private Betting betting = new Betting();

        public BlackJackWindow()
        {
            InitializeComponent();

            lbl_Money.Content = Player.wallet;
            lbl_Bet.Content = betting.currentBet;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void bet_1(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_5(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(5))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_10(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(10))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_20(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(20))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_50(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(50))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_100(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(100))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_500(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(500))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_1000(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(1000))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_5000(object sender, RoutedEventArgs e)
        {
            if (!betting.Bet(5000))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
            }
            lbl_Bet.Content = betting.currentBet;
            lbl_Money.Content = Player.wallet;
        }
    }
}
