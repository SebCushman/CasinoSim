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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CasinoSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BlackJack_Click(object sender, RoutedEventArgs e)
        {
            BlackJackWindow blackJackWindow = new BlackJackWindow();
            blackJackWindow.Show();
            Close();
        }

        private void Craps_Click(object sender, RoutedEventArgs e)
        {
            CrapsWindow crapsWindow = new CrapsWindow();
            crapsWindow.Show();
            Close();
        }

        private void Roulette_Click(object sender, RoutedEventArgs e)
        {
            RouletteWindow rouletteWindow = new RouletteWindow();
            rouletteWindow.Show();
            Close();
        }

        private void Poker_Click(object sender, RoutedEventArgs e)
        {
            Poker pokerWindow = new Poker();
            pokerWindow.Show();
            Close();
        }

        private void Slots_Click(object sender, RoutedEventArgs e)
        {
            SlotsWindow slotsWindow = new SlotsWindow();
            slotsWindow.Show();
            Close();
        }

        private void Banking_Click(object sender, RoutedEventArgs e)
        {
            Banking_Window bankingWindow = new Banking_Window();
            bankingWindow.Show();
            Close();
        }
        
    }
}
