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
using CasinoSim.Static_Classes;

namespace CasinoSim
{
    /// <summary>
    /// Interaction logic for CrapsWindow.xaml
    /// </summary>
    public partial class CrapsWindow : Window
    {
        private Betting betting = new Betting();
        public CrapsWindow()
        {
            InitializeComponent();

            lbl_Chips.Content = Player.wallet;
            lbl_Bet.Content = betting.currentBet;
        }

        int totalBet = 0;

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (totalBet == 0)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                //lbl_InvalidBet.Content = "Cannot exit while betting";
            }
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
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
            lbl_Chips.Content = Player.wallet;
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_AnyCraps_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dbl6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_SnakeEyes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_5and5_6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_1and2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dbl3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dbl1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dbl2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dbl5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
