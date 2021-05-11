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
    /// <summary>
    /// Interaction logic for RouletteWindow.xaml
    /// </summary>
    public partial class RouletteWindow : Window
    {
        int totalBet = 0;
        Button btnSelected = null;

        // 36:1
        Betting bet1 { get; set; } = new Betting();
        Betting bet2 { get; set; } = new Betting();
        Betting bet3 { get; set; } = new Betting();
        Betting bet4 { get; set; } = new Betting();
        Betting bet5 { get; set; } = new Betting();
        Betting bet6 { get; set; } = new Betting();
        Betting bet7 { get; set; } = new Betting();
        Betting bet8 { get; set; } = new Betting();
        Betting bet9 { get; set; } = new Betting();
        Betting bet10 { get; set; }= new Betting();
        Betting bet11 { get; set; }= new Betting();
        Betting bet12 { get; set; }= new Betting();
        Betting bet13 { get; set; }= new Betting();
        Betting bet14 { get; set; }= new Betting();
        Betting bet15 { get; set; }= new Betting();
        Betting bet16 { get; set; }= new Betting();
        Betting bet17 { get; set; }= new Betting();
        Betting bet18 { get; set; }= new Betting();
        Betting bet19 { get; set; }= new Betting();
        Betting bet20 { get; set; }= new Betting();
        Betting bet21 { get; set; }= new Betting();
        Betting bet22 { get; set; }= new Betting();
        Betting bet23 { get; set; }= new Betting();
        Betting bet24 { get; set; }= new Betting();
        Betting bet25 { get; set; }= new Betting();
        Betting bet26 { get; set; }= new Betting();
        Betting bet27 { get; set; }= new Betting();
        Betting bet28 { get; set; }= new Betting();
        Betting bet29 { get; set; }= new Betting();
        Betting bet30 { get; set; }= new Betting();
        Betting bet31 { get; set; }= new Betting();
        Betting bet32 { get; set; }= new Betting();
        Betting bet33 { get; set; }= new Betting();
        Betting bet34 { get; set; }= new Betting();
        Betting bet35 { get; set; }= new Betting();
        Betting bet36 { get; set; } = new Betting();

        // 1:1
        Betting betRed { get; set; } = new Betting();
        Betting betBlack { get; set; } = new Betting();
        Betting betOdd { get; set; } = new Betting();
        Betting betEven { get; set; } = new Betting();
        Betting betHigh { get; set; } = new Betting();
        Betting betLow { get; set; } = new Betting();

        // 3:1
        Betting betDozen1 { get; set; } = new Betting();
        Betting betDozen2 { get; set; } = new Betting();
        Betting betDozen3 { get; set; } = new Betting();
        Betting betRow1 { get; set; } = new Betting();
        Betting betRow2 { get; set; } = new Betting();
        Betting betRow3 { get; set; } = new Betting();

        // 9:1
        Betting sqr1_2_4_5 { get; set; } = new Betting();
        Betting sqr2_3_5_6 { get; set; } = new Betting();
        Betting sqr4_5_7_8 { get; set; } = new Betting();
        Betting sqr5_6_8_9 { get; set; } = new Betting();
        Betting sqr7_8_10_11 { get; set; } = new Betting();
        Betting sqr8_9_11_12 { get; set; } = new Betting();
        Betting sqr10_11_13_14 { get; set; } = new Betting();
        Betting sqr11_12_14_15 { get; set; } = new Betting();
        Betting sqr13_14_16_17 { get; set; } = new Betting();
        Betting sqr14_15_17_18 { get; set; } = new Betting();
        Betting sqr16_17_19_20 { get; set; } = new Betting();
        Betting sqr17_18_20_21 { get; set; } = new Betting();
        Betting sqr19_20_22_23 { get; set; } = new Betting();
        Betting sqr20_21_23_24 { get; set; } = new Betting();
        Betting sqr22_23_25_26 { get; set; } = new Betting();
        Betting sqr23_24_26_27 { get; set; } = new Betting();
        Betting sqr25_26_28_29 { get; set; } = new Betting();
        Betting sqr26_27_29_30 { get; set; } = new Betting();
        Betting sqr28_29_31_32 { get; set; } = new Betting();
        Betting sqr29_30_32_33 { get; set; } = new Betting();
        Betting sqr31_32_34_35 { get; set; } = new Betting();
        Betting sqr32_33_35_36 { get; set; } = new Betting();

        // 18:1
        Betting split1_2 { get; set; } = new Betting();
        Betting split2_3 { get; set; } = new Betting();
        Betting split4_5 { get; set; } = new Betting();
        Betting split5_6 { get; set; } = new Betting();
        Betting split7_8 { get; set; } = new Betting();
        Betting split8_9 { get; set; } = new Betting();
        Betting split10_11 { get; set; } = new Betting();
        Betting split11_12 { get; set; } = new Betting();
        Betting split13_14 { get; set; } = new Betting();
        Betting split14_15 { get; set; } = new Betting();
        Betting split16_17 { get; set; } = new Betting();
        Betting split17_18 { get; set; } = new Betting();
        Betting split19_20 { get; set; } = new Betting();
        Betting split20_21 { get; set; } = new Betting();
        Betting split22_23 { get; set; } = new Betting();
        Betting split23_24 { get; set; } = new Betting();
        Betting split25_26 { get; set; } = new Betting();
        Betting split26_27 { get; set; } = new Betting();
        Betting split28_29 { get; set; } = new Betting();
        Betting split29_30 { get; set; } = new Betting();
        Betting split31_32 { get; set; } = new Betting();
        Betting split32_33 { get; set; } = new Betting();
        Betting split34_35 { get; set; } = new Betting();
        Betting split35_36 { get; set; } = new Betting();
        Betting split1_4 { get; set; } = new Betting();
        Betting split2_5 { get; set; } = new Betting();
        Betting split3_6 { get; set; } = new Betting();
        Betting split4_7 { get; set; } = new Betting();
        Betting split5_8 { get; set; } = new Betting();
        Betting split6_9 { get; set; } = new Betting();
        Betting split7_10 { get; set; } = new Betting();
        Betting split8_11 { get; set; } = new Betting();
        Betting split9_12 { get; set; } = new Betting();
        Betting split10_13 { get; set; } = new Betting();
        Betting split11_14 { get; set; } = new Betting();
        Betting split12_15 { get; set; } = new Betting();
        Betting split13_16 { get; set; } = new Betting();
        Betting split14_17 { get; set; } = new Betting();
        Betting split15_18 { get; set; } = new Betting();
        Betting split16_19 { get; set; } = new Betting();
        Betting split17_20 { get; set; } = new Betting();
        Betting split18_21 { get; set; } = new Betting();
        Betting split19_22 { get; set; } = new Betting();
        Betting split20_23 { get; set; } = new Betting();
        Betting split21_24 { get; set; } = new Betting();
        Betting split22_25 { get; set; } = new Betting();
        Betting split23_26 { get; set; } = new Betting();
        Betting split24_27 { get; set; } = new Betting();
        Betting split25_28 { get; set; } = new Betting();
        Betting split26_29 { get; set; } = new Betting();
        Betting split27_30 { get; set; } = new Betting();
        Betting split28_31 { get; set; } = new Betting();
        Betting split29_32 { get; set; } = new Betting();
        Betting split30_33 { get; set; } = new Betting();
        Betting split31_34 { get; set; } = new Betting();
        Betting split32_35 { get; set; } = new Betting();
        Betting split33_36 { get; set; } = new Betting();

        public RouletteWindow()
        {
            InitializeComponent();
            lbl_Money.Content = Player.wallet;
        }

        /// <summary>
        /// Selects spot to bet on
        /// Might need to return the button
        /// Binding, that should make this work
        /// </summary>
        public void btn1_example()
        {
            //this is the button on the 1, so it'll modify bet1
            //set btnSelected = btn1
        }

        private void bet_1(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(1))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 1;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_5(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(5))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 5;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_10(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(10))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 10;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_20(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(20))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 20;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_50(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(50))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 50;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_100(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(100))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 100;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_500(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(500))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 500;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_1000(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(1000))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 1000;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        private void bet_5000(object sender, RoutedEventArgs e)
        {
            //access currently selected button to get button's bet

            //place bet in this selected button's bet
            if (!bet1.Bet(5000))//(!btnSelected.bet.Bet(1))
            {
                lbl_InvalidBet.Content = "Not Enough Money";
            }
            else
            {
                lbl_InvalidBet.Content = "";
                totalBet += 5000;
            }
            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;

        }

        private void PlayRoulette(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int result = rand.Next(1, 37);

            //Display where the ball landed (on the number == result)

            //PayoutRoulette(result);
            PayoutRoulette(1);

            lbl_Bet.Content = bet1.currentBet;//btnSelected.bet.currentBet;
            totalBet = 0;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        public void PayoutRoulette(int result)
        {
            switch (result)
            {
                case 1:
                    bet1.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow3.Payout(3);
                    sqr1_2_4_5.Payout(9);
                    split1_2.Payout(18);
                    split1_4.Payout(18);
                    break;
                case 2:
                    bet2.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow2.Payout(3);
                    sqr1_2_4_5.Payout(9);
                    sqr2_3_5_6.Payout(9);
                    split1_2.Payout(18);
                    split2_3.Payout(18);
                    split2_5.Payout(18);
                    break;
                case 3:
                    bet3.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow1.Payout(3);
                    sqr2_3_5_6.Payout(9);
                    split2_3.Payout(18);
                    split3_6.Payout(18);
                    break;
                case 4:
                    bet4.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow3.Payout(3);
                    sqr1_2_4_5.Payout(9);
                    sqr4_5_7_8.Payout(9);
                    split1_4.Payout(18);
                    split4_5.Payout(18);
                    split4_7.Payout(18);
                    break;
                case 5:
                    bet5.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow2.Payout(3);
                    sqr1_2_4_5.Payout(9);
                    sqr4_5_7_8.Payout(9);
                    sqr2_3_5_6.Payout(9);
                    sqr5_6_8_9.Payout(9);
                    split2_5.Payout(18);
                    split4_5.Payout(18);
                    split5_6.Payout(18);
                    split5_8.Payout(18);
                    break;
                case 6:
                    bet6.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow1.Payout(3);
                    sqr2_3_5_6.Payout(9);
                    sqr5_6_8_9.Payout(9);
                    split3_6.Payout(18);
                    split5_6.Payout(18);
                    split6_9.Payout(18);
                    break;
                case 7:
                    bet7.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow3.Payout(3);
                    sqr4_5_7_8.Payout(9);
                    sqr7_8_10_11.Payout(9);
                    split4_7.Payout(18);
                    split7_8.Payout(18);
                    split7_10.Payout(18);
                    break;
                case 8:
                    bet8.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow1.Payout(3);
                    sqr4_5_7_8.Payout(9);
                    sqr5_6_8_9.Payout(9);
                    sqr7_8_10_11.Payout(9);
                    sqr8_9_11_12.Payout(9);
                    split5_8.Payout(18);
                    split7_8.Payout(18);
                    split8_9.Payout(18);
                    split8_11.Payout(18);
                    break;
                case 9:
                    bet9.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow1.Payout(3);
                    sqr5_6_8_9.Payout(9);
                    sqr8_9_11_12.Payout(9);
                    split6_9.Payout(18);
                    split8_9.Payout(18);
                    split9_12.Payout(18);
                    break;
                case 10:
                    bet10.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow3.Payout(3);
                    sqr7_8_10_11.Payout(9);
                    sqr10_11_13_14.Payout(9);
                    split7_10.Payout(18);
                    split10_11.Payout(18);
                    split10_13.Payout(18);
                    break;
                case 11:
                    bet11.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow2.Payout(3);
                    sqr7_8_10_11.Payout(9);
                    sqr8_9_11_12.Payout(9);
                    sqr10_11_13_14.Payout(9);
                    sqr11_12_14_15.Payout(9);
                    split8_11.Payout(18);
                    split10_11.Payout(18);
                    split11_12.Payout(18);
                    split11_14.Payout(18);
                    break;
                case 12:
                    bet12.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen1.Payout(3);
                    betRow1.Payout(3);
                    sqr8_9_11_12.Payout(9);
                    sqr11_12_14_15.Payout(9);
                    split9_12.Payout(18);
                    split11_12.Payout(18);
                    split12_15.Payout(18);
                    break;
                case 13:
                    bet13.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen2.Payout(3);
                    betRow3.Payout(3);
                    sqr10_11_13_14.Payout(9);
                    sqr13_14_16_17.Payout(9);
                    split10_13.Payout(18);
                    split13_14.Payout(18);
                    split13_16.Payout(18);
                    break;
                case 14:
                    bet14.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen2.Payout(3);
                    betRow2.Payout(3);
                    sqr10_11_13_14.Payout(9);
                    sqr11_12_14_15.Payout(9);
                    sqr13_14_16_17.Payout(9);
                    sqr14_15_17_18.Payout(9);
                    split11_14.Payout(18);
                    split13_14.Payout(18);
                    split14_15.Payout(18);
                    split14_17.Payout(18);
                    break;
                case 15:
                    bet15.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen2.Payout(3);
                    betRow1.Payout(3);
                    sqr11_12_14_15.Payout(9);
                    sqr14_15_17_18.Payout(9);
                    split12_15.Payout(18);
                    split14_15.Payout(18);
                    split15_18.Payout(18);
                    break;
                case 16:
                    bet16.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen2.Payout(3);
                    betRow3.Payout(3);
                    sqr13_14_16_17.Payout(9);
                    sqr16_17_19_20.Payout(9);
                    split13_16.Payout(18);
                    split16_17.Payout(18);
                    split16_19.Payout(18);
                    break;
                case 17:
                    bet17.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betLow.Payout(1);
                    betDozen2.Payout(3);
                    betRow2.Payout(3);
                    sqr13_14_16_17.Payout(9);
                    sqr14_15_17_18.Payout(9);
                    sqr16_17_19_20.Payout(9);
                    sqr17_18_20_21.Payout(9);
                    split14_17.Payout(18);
                    split16_17.Payout(18);
                    split17_18.Payout(18);
                    split17_20.Payout(18);
                    break;
                case 18:
                    bet18.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betLow.Payout(1);
                    betDozen2.Payout(3);
                    betRow1.Payout(3);
                    sqr14_15_17_18.Payout(9);
                    sqr17_18_20_21.Payout(9);
                    split15_18.Payout(18);
                    split17_18.Payout(18);
                    split18_21.Payout(18);
                    break;
                case 19:
                    bet19.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen2.Payout(3);
                    betRow3.Payout(3);
                    sqr16_17_19_20.Payout(9);
                    sqr19_20_22_23.Payout(9);
                    split16_19.Payout(18);
                    split19_20.Payout(18);
                    split19_22.Payout(18);
                    break;
                case 20:
                    bet20.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen2.Payout(3);
                    betRow2.Payout(3);
                    sqr16_17_19_20.Payout(9);
                    sqr17_18_20_21.Payout(9);
                    sqr19_20_22_23.Payout(9);
                    sqr20_21_23_24.Payout(9);
                    split17_20.Payout(18);
                    split19_20.Payout(18);
                    split20_21.Payout(18);
                    split20_23.Payout(18);
                    break;
                case 21:
                    bet21.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen2.Payout(3);
                    betRow1.Payout(3);
                    sqr17_18_20_21.Payout(9);
                    sqr20_21_23_24.Payout(9);
                    split18_21.Payout(18);
                    split20_21.Payout(18);
                    split21_24.Payout(18);
                    break;
                case 22:
                    bet22.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen2.Payout(3);
                    betRow3.Payout(3);
                    sqr19_20_22_23.Payout(9);
                    sqr22_23_25_26.Payout(9);
                    split19_22.Payout(18);
                    split22_23.Payout(18);
                    split22_25.Payout(18);
                    break;
                case 23:
                    bet23.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen2.Payout(3);
                    betRow2.Payout(3);
                    sqr19_20_22_23.Payout(9);
                    sqr20_21_23_24.Payout(9);
                    sqr22_23_25_26.Payout(9);
                    sqr23_24_26_27.Payout(9);
                    split20_23.Payout(18);
                    split22_23.Payout(18);
                    split23_24.Payout(18);
                    split23_26.Payout(18);
                    break;
                case 24:
                    bet24.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen2.Payout(3);
                    betRow1.Payout(3);
                    sqr20_21_23_24.Payout(9);
                    sqr23_24_26_27.Payout(9);
                    split21_24.Payout(18);
                    split23_24.Payout(18);
                    split24_27.Payout(18);
                    break;
                case 25:
                    bet25.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow3.Payout(3);
                    sqr22_23_25_26.Payout(9);
                    sqr25_26_28_29.Payout(9);
                    split22_25.Payout(18);
                    split25_26.Payout(18);
                    split25_28.Payout(18);
                    break;
                case 26:
                    bet26.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow2.Payout(3);
                    sqr22_23_25_26.Payout(9);
                    sqr23_24_26_27.Payout(9);
                    sqr25_26_28_29.Payout(9);
                    sqr26_27_29_30.Payout(9);
                    split23_26.Payout(18);
                    split25_26.Payout(18);
                    split26_27.Payout(18);
                    split26_29.Payout(18);
                    break;
                case 27:
                    bet27.Payout(36);
                    betRed.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow1.Payout(3);
                    sqr23_24_26_27.Payout(9);
                    sqr26_27_29_30.Payout(9);
                    split24_27.Payout(18);
                    split26_27.Payout(18);
                    split27_30.Payout(18);
                    break;
                case 28:
                    bet28.Payout(36);
                    betBlack.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow3.Payout(3);
                    sqr25_26_28_29.Payout(9);
                    sqr28_29_31_32.Payout(9);
                    split25_28.Payout(18);
                    split28_29.Payout(18);
                    split28_31.Payout(18);
                    break;
                case 29:
                    bet29.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow2.Payout(3);
                    sqr25_26_28_29.Payout(9);
                    sqr26_27_29_30.Payout(9);
                    sqr28_29_31_32.Payout(9);
                    sqr29_30_32_33.Payout(9);
                    split26_29.Payout(18);
                    split28_29.Payout(18);
                    split29_30.Payout(18);
                    split29_32.Payout(18);
                    break;
                case 30:
                    bet30.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow1.Payout(3);
                    sqr26_27_29_30.Payout(9);
                    sqr29_30_32_33.Payout(9);
                    split27_30.Payout(18);
                    split29_30.Payout(18);
                    split30_33.Payout(18);
                    break;
                case 31:
                    bet31.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow3.Payout(3);
                    sqr28_29_31_32.Payout(9);
                    sqr31_32_34_35.Payout(9);
                    split28_31.Payout(18);
                    split31_32.Payout(18);
                    split31_34.Payout(18);
                    break;
                case 32:
                    bet32.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow2.Payout(3);
                    sqr28_29_31_32.Payout(9);
                    sqr29_30_32_33.Payout(9);
                    sqr31_32_34_35.Payout(9);
                    sqr32_33_35_36.Payout(9);
                    split29_32.Payout(18);
                    split31_32.Payout(18);
                    split32_33.Payout(18);
                    split32_35.Payout(18);
                    break;
                case 33:
                    bet33.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow1.Payout(3);
                    sqr29_30_32_33.Payout(9);
                    sqr32_33_35_36.Payout(9);
                    split30_33.Payout(18);
                    split32_33.Payout(18);
                    split33_36.Payout(18);
                    break;
                case 34:
                    bet34.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow3.Payout(3);
                    sqr31_32_34_35.Payout(9);
                    split31_34.Payout(18);
                    split34_35.Payout(18);
                    break;
                case 35:
                    bet35.Payout(36);
                    betBlack.Payout(1);
                    betOdd.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow2.Payout(3);
                    sqr31_32_34_35.Payout(9);
                    sqr32_33_35_36.Payout(9);
                    split32_35.Payout(18);
                    split34_35.Payout(18);
                    split35_36.Payout(18);
                    break;
                case 36:
                    bet36.Payout(36);
                    betRed.Payout(1);
                    betEven.Payout(1);
                    betHigh.Payout(1);
                    betDozen3.Payout(3);
                    betRow1.Payout(3);
                    sqr32_33_35_36.Payout(9);
                    split33_36.Payout(18);
                    split35_36.Payout(18);
                    break;
                default:
                    break;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if(totalBet == 0)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                lbl_InvalidBet.Content = "Cannot exit while betting";
            }
        }
    }
}
