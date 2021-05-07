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
    /// Interaction logic for Banking_Window.xaml
    /// </summary>
    public partial class Banking_Window : Window
    {
        public Banking_Window()
        {
            InitializeComponent();

            lbl_netWorth.Content = Player.netWorth;
            lbl_wallet.Content = Player.wallet;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Withdrawl_Click(object sender, RoutedEventArgs e)
        {
            int dMoney = int.Parse(txtBox_withdrawl.Text);
            Player.netWorth -= dMoney;
            Player.wallet += dMoney;

            lbl_netWorth.Content = Player.netWorth;
            lbl_wallet.Content = Player.wallet;
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            int dMoney = int.Parse(txtBox_deposit.Text);
            Player.netWorth += dMoney;
            Player.wallet -= dMoney;

            lbl_netWorth.Content = Player.netWorth;
            lbl_wallet.Content = Player.wallet;
        }
    }
}
