using CasinoSim.Static_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        int btnSelected = -1;
        List<Betting> bets = new List<Betting>();

        // 36:1
        Betting bet0 { get; set; } = new Betting();
        Betting bet1 { get; set; } = new Betting();
        Betting bet2 { get; set; } = new Betting();
        Betting bet3 { get; set; } = new Betting();
        Betting bet4 { get; set; } = new Betting();
        Betting bet5 { get; set; } = new Betting();
        Betting bet6 { get; set; } = new Betting();
        Betting bet7 { get; set; } = new Betting();
        Betting bet8 { get; set; } = new Betting();
        Betting bet9 { get; set; } = new Betting();
        Betting bet10 { get; set; } = new Betting();
        Betting bet11 { get; set; } = new Betting();
        Betting bet12 { get; set; } = new Betting();
        Betting bet13 { get; set; } = new Betting();
        Betting bet14 { get; set; } = new Betting();
        Betting bet15 { get; set; } = new Betting();
        Betting bet16 { get; set; } = new Betting();
        Betting bet17 { get; set; } = new Betting();
        Betting bet18 { get; set; } = new Betting();
        Betting bet19 { get; set; } = new Betting();
        Betting bet20 { get; set; } = new Betting();
        Betting bet21 { get; set; } = new Betting();
        Betting bet22 { get; set; } = new Betting();
        Betting bet23 { get; set; } = new Betting();
        Betting bet24 { get; set; } = new Betting();
        Betting bet25 { get; set; } = new Betting();
        Betting bet26 { get; set; } = new Betting();
        Betting bet27 { get; set; } = new Betting();
        Betting bet28 { get; set; } = new Betting();
        Betting bet29 { get; set; } = new Betting();
        Betting bet30 { get; set; } = new Betting();
        Betting bet31 { get; set; } = new Betting();
        Betting bet32 { get; set; } = new Betting();
        Betting bet33 { get; set; } = new Betting();
        Betting bet34 { get; set; } = new Betting();
        Betting bet35 { get; set; } = new Betting();
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

            bets.Add(bet0);
            bets.Add(bet1);
            bets.Add(bet2);
            bets.Add(bet3);
            bets.Add(bet4);
            bets.Add(bet5);
            bets.Add(bet6);
            bets.Add(bet7);
            bets.Add(bet8);
            bets.Add(bet9);
            bets.Add(bet10);
            bets.Add(bet11);
            bets.Add(bet12);
            bets.Add(bet13);
            bets.Add(bet14);
            bets.Add(bet15);
            bets.Add(bet16);
            bets.Add(bet17);
            bets.Add(bet18);
            bets.Add(bet19);
            bets.Add(bet20);
            bets.Add(bet21);
            bets.Add(bet22);
            bets.Add(bet23);
            bets.Add(bet24);
            bets.Add(bet25);
            bets.Add(bet26);
            bets.Add(bet27);
            bets.Add(bet28);
            bets.Add(bet29);
            bets.Add(bet30);
            bets.Add(bet31);
            bets.Add(bet32);
            bets.Add(bet33);
            bets.Add(bet34);
            bets.Add(bet35);
            bets.Add(bet36);
            bets.Add(betRed);
            bets.Add(betBlack);
            bets.Add(betOdd);
            bets.Add(betEven);
            bets.Add(betHigh);
            bets.Add(betLow);
            bets.Add(betDozen1);
            bets.Add(betDozen2);
            bets.Add(betDozen3);
            bets.Add(betRow1);
            bets.Add(betRow2);
            bets.Add(betRow3);
            bets.Add(sqr1_2_4_5);
            bets.Add(sqr2_3_5_6);
            bets.Add(sqr4_5_7_8);
            bets.Add(sqr5_6_8_9);
            bets.Add(sqr7_8_10_11);
            bets.Add(sqr8_9_11_12);
            bets.Add(sqr10_11_13_14);
            bets.Add(sqr11_12_14_15);
            bets.Add(sqr13_14_16_17);
            bets.Add(sqr14_15_17_18);
            bets.Add(sqr16_17_19_20);
            bets.Add(sqr17_18_20_21);
            bets.Add(sqr19_20_22_23);
            bets.Add(sqr20_21_23_24);
            bets.Add(sqr22_23_25_26);
            bets.Add(sqr23_24_26_27);
            bets.Add(sqr25_26_28_29);
            bets.Add(sqr26_27_29_30);
            bets.Add(sqr28_29_31_32);
            bets.Add(sqr29_30_32_33);
            bets.Add(sqr31_32_34_35);
            bets.Add(sqr32_33_35_36);
            bets.Add(split1_2);
            bets.Add(split2_3);
            bets.Add(split4_5);
            bets.Add(split5_6);
            bets.Add(split7_8);
            bets.Add(split8_9);
            bets.Add(split10_11);
            bets.Add(split11_12);
            bets.Add(split13_14);
            bets.Add(split14_15);
            bets.Add(split16_17);
            bets.Add(split17_18);
            bets.Add(split19_20);
            bets.Add(split20_21);
            bets.Add(split22_23);
            bets.Add(split23_24);
            bets.Add(split25_26);
            bets.Add(split26_27);
            bets.Add(split28_29);
            bets.Add(split29_30);
            bets.Add(split31_32);
            bets.Add(split32_33);
            bets.Add(split34_35);
            bets.Add(split35_36);
            bets.Add(split1_4);
            bets.Add(split2_5);
            bets.Add(split3_6);
            bets.Add(split4_7);
            bets.Add(split5_8);
            bets.Add(split6_9);
            bets.Add(split7_10);
            bets.Add(split8_11);
            bets.Add(split9_12);
            bets.Add(split10_13);
            bets.Add(split11_14);
            bets.Add(split12_15);
            bets.Add(split13_16);
            bets.Add(split14_17);
            bets.Add(split15_18);
            bets.Add(split16_19);
            bets.Add(split17_20);
            bets.Add(split18_21);
            bets.Add(split19_22);
            bets.Add(split20_23);
            bets.Add(split21_24);
            bets.Add(split22_25);
            bets.Add(split23_26);
            bets.Add(split24_27);
            bets.Add(split25_28);
            bets.Add(split26_29);
            bets.Add(split27_30);
            bets.Add(split28_31);
            bets.Add(split29_32);
            bets.Add(split30_33);
            bets.Add(split31_34);
            bets.Add(split32_35);
            bets.Add(split33_36);
        }

        /// <summary>
        /// Selects spot to bet on
        /// Might need to return the button
        /// Binding, that should make this work
        /// </summary>
        public void btn0(object sender, RoutedEventArgs e)
        {
            btnSelected = 0;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn1(object sender, RoutedEventArgs e)
        {
            btnSelected = 1;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn2(object sender, RoutedEventArgs e)
        {
            btnSelected = 2;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn3(object sender, RoutedEventArgs e)
        {
            btnSelected = 3;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn4(object sender, RoutedEventArgs e)
        {
            btnSelected = 4;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn5(object sender, RoutedEventArgs e)
        {
            btnSelected = 5;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn6(object sender, RoutedEventArgs e)
        {
            btnSelected = 6;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn7(object sender, RoutedEventArgs e)
        {
            btnSelected = 7;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn8(object sender, RoutedEventArgs e)
        {
            btnSelected = 8;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn9(object sender, RoutedEventArgs e)
        {
            btnSelected = 9;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn10(object sender, RoutedEventArgs e)
        {
            btnSelected = 10;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn11(object sender, RoutedEventArgs e)
        {
            btnSelected = 11;
            lbl_Bet.Content = GetButton().currentBet;
        }
        public void btn12(object sender, RoutedEventArgs e)
        {
            btnSelected = 12;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn13(object sender, RoutedEventArgs e)
        {
            btnSelected = 13;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn14(object sender, RoutedEventArgs e)
        {
            btnSelected = 14;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn15(object sender, RoutedEventArgs e)
        {
            btnSelected = 15;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn16(object sender, RoutedEventArgs e)
        {
            btnSelected = 16;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn17(object sender, RoutedEventArgs e)
        {
            btnSelected = 17;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn18(object sender, RoutedEventArgs e)
        {
            btnSelected = 18;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn19(object sender, RoutedEventArgs e)
        {
            btnSelected = 19;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn20(object sender, RoutedEventArgs e)
        {
            btnSelected = 20;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn21(object sender, RoutedEventArgs e)
        {
            btnSelected = 21;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn22(object sender, RoutedEventArgs e)
        {
            btnSelected = 22;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn23(object sender, RoutedEventArgs e)
        {
            btnSelected = 23;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn24(object sender, RoutedEventArgs e)
        {
            btnSelected = 24;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn25(object sender, RoutedEventArgs e)
        {
            btnSelected = 25;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn26(object sender, RoutedEventArgs e)
        {
            btnSelected = 26;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn27(object sender, RoutedEventArgs e)
        {
            btnSelected = 27;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn28(object sender, RoutedEventArgs e)
        {
            btnSelected = 28;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn29(object sender, RoutedEventArgs e)
        {
            btnSelected = 29;
            lbl_Bet.Content = GetButton().currentBet;
        }
        public void btn30(object sender, RoutedEventArgs e)
        {
            btnSelected = 30;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn31(object sender, RoutedEventArgs e)
        {
            btnSelected = 31;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn32(object sender, RoutedEventArgs e)
        {
            btnSelected = 32;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn33(object sender, RoutedEventArgs e)
        {
            btnSelected = 33;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn34(object sender, RoutedEventArgs e)
        {
            btnSelected = 34;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn35(object sender, RoutedEventArgs e)
        {
            btnSelected = 35;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn36(object sender, RoutedEventArgs e)
        {
            btnSelected = 36;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnRed(object sender, RoutedEventArgs e)
        {
            btnSelected = 37;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnBlack(object sender, RoutedEventArgs e)
        {
            btnSelected = 38;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnOdd(object sender, RoutedEventArgs e)
        {
            btnSelected = 39;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnEven(object sender, RoutedEventArgs e)
        {
            btnSelected = 40;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnLow(object sender, RoutedEventArgs e)
        {
            btnSelected = 41;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnHigh(object sender, RoutedEventArgs e)
        {
            btnSelected = 42;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnDozen1(object sender, RoutedEventArgs e)
        {
            btnSelected = 43;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnDozen2(object sender, RoutedEventArgs e)
        {
            btnSelected = 44;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnDozen3(object sender, RoutedEventArgs e)
        {
            btnSelected = 45;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnRow1(object sender, RoutedEventArgs e)
        {
            btnSelected = 46;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnRow2(object sender, RoutedEventArgs e)
        {
            btnSelected = 47;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btnRow3(object sender, RoutedEventArgs e)
        {
            btnSelected = 48;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn1_2_4_5(object sender, RoutedEventArgs e)
        {
            btnSelected = 49;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn2_3_5_6(object sender, RoutedEventArgs e)
        {
            btnSelected = 50;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn4_5_7_8(object sender, RoutedEventArgs e)
        {
            btnSelected = 51;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn5_6_8_9(object sender, RoutedEventArgs e)
        {
            btnSelected = 52;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn7_8_10_11(object sender, RoutedEventArgs e)
        {
            btnSelected = 53;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn8_9_11_12(object sender, RoutedEventArgs e)
        {
            btnSelected = 54;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn10_11_13_14(object sender, RoutedEventArgs e)
        {
            btnSelected = 55;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn11_12_14_15(object sender, RoutedEventArgs e)
        {
            btnSelected = 56;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn13_14_16_17(object sender, RoutedEventArgs e)
        {
            btnSelected = 57;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn14_15_17_18(object sender, RoutedEventArgs e)
        {
            btnSelected = 58;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn16_17_19_20(object sender, RoutedEventArgs e)
        {
            btnSelected = 59;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn17_18_20_21(object sender, RoutedEventArgs e)
        {
            btnSelected = 60;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn19_20_22_23(object sender, RoutedEventArgs e)
        {
            btnSelected = 61;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn20_21_23_24(object sender, RoutedEventArgs e)
        {
            btnSelected = 62;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn22_23_25_26(object sender, RoutedEventArgs e)
        {
            btnSelected = 63;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn23_24_26_27(object sender, RoutedEventArgs e)
        {
            btnSelected = 64;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn25_26_28_29(object sender, RoutedEventArgs e)
        {
            btnSelected = 65;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn26_27_29_30(object sender, RoutedEventArgs e)
        {
            btnSelected = 66;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn28_29_31_32(object sender, RoutedEventArgs e)
        {
            btnSelected = 67;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn29_30_32_33(object sender, RoutedEventArgs e)
        {
            btnSelected = 68;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn31_32_34_35(object sender, RoutedEventArgs e)
        {
            btnSelected = 69;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn32_33_35_36(object sender, RoutedEventArgs e)
        {
            btnSelected = 70;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn1_2(object sender, RoutedEventArgs e)
        {
            btnSelected = 71;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn2_3(object sender, RoutedEventArgs e)
        {
            btnSelected = 72;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn4_5(object sender, RoutedEventArgs e)
        {
            btnSelected = 73;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn5_6(object sender, RoutedEventArgs e)
        {
            btnSelected = 74;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn7_8(object sender, RoutedEventArgs e)
        {
            btnSelected = 75;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn8_9(object sender, RoutedEventArgs e)
        {
            btnSelected = 76;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn10_11(object sender, RoutedEventArgs e)
        {
            btnSelected = 77;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn11_12(object sender, RoutedEventArgs e)
        {
            btnSelected = 78;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn13_14(object sender, RoutedEventArgs e)
        {
            btnSelected = 79;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn14_15(object sender, RoutedEventArgs e)
        {
            btnSelected = 80;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn16_17(object sender, RoutedEventArgs e)
        {
            btnSelected = 81;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn17_18(object sender, RoutedEventArgs e)
        {
            btnSelected = 82;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn19_20(object sender, RoutedEventArgs e)
        {
            btnSelected = 83;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn20_21(object sender, RoutedEventArgs e)
        {
            btnSelected = 84;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn22_23(object sender, RoutedEventArgs e)
        {
            btnSelected = 85;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn23_24(object sender, RoutedEventArgs e)
        {
            btnSelected = 86;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn25_26(object sender, RoutedEventArgs e)
        {
            btnSelected = 87;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn26_27(object sender, RoutedEventArgs e)
        {
            btnSelected = 88;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn28_29(object sender, RoutedEventArgs e)
        {
            btnSelected = 89;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn29_30(object sender, RoutedEventArgs e)
        {
            btnSelected = 90;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn31_32(object sender, RoutedEventArgs e)
        {
            btnSelected = 91;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn32_33(object sender, RoutedEventArgs e)
        {
            btnSelected = 92;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn34_35(object sender, RoutedEventArgs e)
        {
            btnSelected = 93;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn35_36(object sender, RoutedEventArgs e)
        {
            btnSelected = 94;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn1_4(object sender, RoutedEventArgs e)
        {
            btnSelected = 95;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn2_5(object sender, RoutedEventArgs e)
        {
            btnSelected = 96;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn3_6(object sender, RoutedEventArgs e)
        {
            btnSelected = 97;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn4_7(object sender, RoutedEventArgs e)
        {
            btnSelected = 98;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn5_8(object sender, RoutedEventArgs e)
        {
            btnSelected = 99;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn6_9(object sender, RoutedEventArgs e)
        {
            btnSelected = 100;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn7_10(object sender, RoutedEventArgs e)
        {
            btnSelected = 101;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn8_11(object sender, RoutedEventArgs e)
        {
            btnSelected = 102;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn9_12(object sender, RoutedEventArgs e)
        {
            btnSelected = 103;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn10_13(object sender, RoutedEventArgs e)
        {
            btnSelected = 104;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn11_14(object sender, RoutedEventArgs e)
        {
            btnSelected = 105;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn12_15(object sender, RoutedEventArgs e)
        {
            btnSelected = 106;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn13_16(object sender, RoutedEventArgs e)
        {
            btnSelected = 107;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn14_17(object sender, RoutedEventArgs e)
        {
            btnSelected = 108;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn15_18(object sender, RoutedEventArgs e)
        {
            btnSelected = 109;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn16_19(object sender, RoutedEventArgs e)
        {
            btnSelected = 110;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn17_20(object sender, RoutedEventArgs e)
        {
            btnSelected = 111;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn18_21(object sender, RoutedEventArgs e)
        {
            btnSelected = 112;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn19_22(object sender, RoutedEventArgs e)
        {
            btnSelected = 113;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn20_23(object sender, RoutedEventArgs e)
        {
            btnSelected = 114;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn21_24(object sender, RoutedEventArgs e)
        {
            btnSelected = 115;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn22_25(object sender, RoutedEventArgs e)
        {
            btnSelected = 116;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn23_26(object sender, RoutedEventArgs e)
        {
            btnSelected = 117;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn24_27(object sender, RoutedEventArgs e)
        {
            btnSelected = 118;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn25_28(object sender, RoutedEventArgs e)
        {
            btnSelected = 119;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn26_29(object sender, RoutedEventArgs e)
        {
            btnSelected = 120;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn27_30(object sender, RoutedEventArgs e)
        {
            btnSelected = 121;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn28_31(object sender, RoutedEventArgs e)
        {
            btnSelected = 122;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn29_32(object sender, RoutedEventArgs e)
        {
            btnSelected = 123;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn30_33(object sender, RoutedEventArgs e)
        {
            btnSelected = 124;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn31_34(object sender, RoutedEventArgs e)
        {
            btnSelected = 125;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn32_35(object sender, RoutedEventArgs e)
        {
            btnSelected = 126;
            lbl_Bet.Content = GetButton().currentBet;
        }

        public void btn33_36(object sender, RoutedEventArgs e)
        {
            btnSelected = 127;
            lbl_Bet.Content = GetButton().currentBet;
        }

        private Betting GetButton()
        {
            switch (btnSelected)
            {
                case 0:
                    return bet0;
                case 1:
                    return bet1;
                case 2:
                    return bet2;
                case 3:
                    return bet3;
                case 4:
                    return bet4;
                case 5:
                    return bet5;
                case 6:
                    return bet6;
                case 7:
                    return bet7;
                case 8:
                    return bet8;
                case 9:
                    return bet9;
                case 10:
                    return bet10;
                case 11:
                    return bet11;
                case 12:
                    return bet12;
                case 13:
                    return bet13;
                case 14:
                    return bet14;
                case 15:
                    return bet15;
                case 16:
                    return bet16;
                case 17:
                    return bet17;
                case 18:
                    return bet18;
                case 19:
                    return bet19;
                case 20:
                    return bet20;
                case 21:
                    return bet21;
                case 22:
                    return bet22;
                case 23:
                    return bet23;
                case 24:
                    return bet24;
                case 25:
                    return bet25;
                case 26:
                    return bet26;
                case 27:
                    return bet27;
                case 28:
                    return bet28;
                case 29:
                    return bet29;
                case 30:
                    return bet30;
                case 31:
                    return bet32;
                case 32:
                    return bet32;
                case 33:
                    return bet33;
                case 34:
                    return bet34;
                case 35:
                    return bet35;
                case 36:
                    return bet36;
                case 37:
                    return betRed;
                case 38:
                    return betBlack;
                case 39:
                    return betOdd;
                case 40:
                    return betEven;
                case 41:
                    return betLow;
                case 42:
                    return betHigh;
                case 43:
                    return betDozen1;
                case 44:
                    return betDozen2;
                case 45:
                    return betDozen3;
                case 46:
                    return betRow1;
                case 47:
                    return betRow2;
                case 48:
                    return betRow3;
                case 49:
                    return sqr1_2_4_5;
                case 50:
                    return sqr2_3_5_6;
                case 51:
                    return sqr4_5_7_8;
                case 52:
                    return sqr5_6_8_9;
                case 53:
                    return sqr7_8_10_11;
                case 54:
                    return sqr8_9_11_12;
                case 55:
                    return sqr10_11_13_14;
                case 56:
                    return sqr11_12_14_15;
                case 57:
                    return sqr13_14_16_17;
                case 58:
                    return sqr14_15_17_18;
                case 59:
                    return sqr16_17_19_20;
                case 60:
                    return sqr17_18_20_21;
                case 61:
                    return sqr19_20_22_23;
                case 62:
                    return sqr20_21_23_24;
                case 63:
                    return sqr22_23_25_26;
                case 64:
                    return sqr23_24_26_27;
                case 65:
                    return sqr25_26_28_29;
                case 66:
                    return sqr26_27_29_30;
                case 67:
                    return sqr28_29_31_32;
                case 68:
                    return sqr29_30_32_33;
                case 69:
                    return sqr31_32_34_35;
                case 70:
                    return sqr32_33_35_36;
                case 71:
                    return split1_2;
                case 72:
                    return split2_3;
                case 73:
                    return split4_5;
                case 74:
                    return split5_6;
                case 75:
                    return split7_8;
                case 76:
                    return split8_9;
                case 77:
                    return split10_11;
                case 78:
                    return split11_12;
                case 79:
                    return split13_14;
                case 80:
                    return split14_15;
                case 81:
                    return split16_17;
                case 82:
                    return split17_18;
                case 83:
                    return split19_20;
                case 84:
                    return split20_21;
                case 85:
                    return split22_23;
                case 86:
                    return split23_24;
                case 87:
                    return split25_26;
                case 88:
                    return split26_27;
                case 89:
                    return split28_29;
                case 90:
                    return split29_30;
                case 91:
                    return split31_32;
                case 92:
                    return split32_33;
                case 93:
                    return split34_35;
                case 94:
                    return split35_36;
                case 95:
                    return split1_4;
                case 96:
                    return split2_5;
                case 97:
                    return split3_6;
                case 98:
                    return split4_7;
                case 99:
                    return split5_8;
                case 100:
                    return split6_9;
                case 101:
                    return split7_10;
                case 102:
                    return split8_11;
                case 103:
                    return split9_12;
                case 104:
                    return split10_13;
                case 105:
                    return split11_14;
                case 106:
                    return split12_15;
                case 107:
                    return split13_16;
                case 108:
                    return split14_17;
                case 109:
                    return split15_18;
                case 110:
                    return split16_19;
                case 111:
                    return split17_20;
                case 112:
                    return split18_21;
                case 113:
                    return split19_22;
                case 114:
                    return split20_23;
                case 115:
                    return split21_24;
                case 116:
                    return split22_25;
                case 117:
                    return split23_26;
                case 118:
                    return split24_27;
                case 119:
                    return split25_28;
                case 120:
                    return split26_29;
                case 121:
                    return split27_30;
                case 122:
                    return split28_31;
                case 123:
                    return split29_32;
                case 124:
                    return split30_33;
                case 125:
                    return split31_34;
                case 126:
                    return split32_35;
                case 127:
                    return split33_36;
                default:
                    return null;
            }
        }

        private void bet_1(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet < 10000 && totalBet < 200000)
            {
                if (!GetButton().Bet(1))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 1;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_5(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 9995 && totalBet <= 199995)
            {
                if (!GetButton().Bet(5))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 5;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_10(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 9990 && totalBet <= 199990)
            {
                if (!GetButton().Bet(10))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 10;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_20(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 9980 && totalBet <= 199980)
            {
                if (!GetButton().Bet(20))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 20;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_50(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 9950 && totalBet <= 199950)
            {
                if (!GetButton().Bet(50))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 50;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_100(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 9900 && totalBet <= 199900)
            {
                if (!GetButton().Bet(100))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 100;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_500(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 9500 && totalBet <= 199500)
            {
                if (!GetButton().Bet(500))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 500;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_1000(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 8000 && totalBet <= 198000)
            {
                if (!GetButton().Bet(1000))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 1000;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void bet_5000(object sender, RoutedEventArgs e)
        {
            if (btnSelected == -1)
            {
                lbl_InvalidBet.Content = "Select a place to bet on";
            }
            else if (GetButton().currentBet <= 5000 && totalBet <= 195000)
            {
                if (!GetButton().Bet(5000))
                {
                    lbl_InvalidBet.Content = "Not Enough Money";
                }
                else
                {
                    lbl_InvalidBet.Content = "";
                    totalBet += 5000;
                }
                lbl_Bet.Content = GetButton().currentBet;
                lbl_TotalBet.Content = totalBet;
                lbl_Money.Content = Player.wallet;
            }
            else if (totalBet == 200000)
            {
                lbl_InvalidBet.Content = "You've reached the Betting Limit";
            }
            else if (GetButton().currentBet == 10000)
            {
                lbl_InvalidBet.Content = "Bet somewhere else";
            }
        }

        private void PlayRoulette(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int result = rand.Next(0, 37);

            //Display where the ball landed (on the number == result)
            lbl_Result.Content = $"Last result: {result}";

            PayoutRoulette(result);
            //PayoutRoulette(23);

            lbl_Bet.Content = bet1.currentBet;
            totalBet = 0;
            lbl_TotalBet.Content = totalBet;
            lbl_Money.Content = Player.wallet;
        }

        public void PayoutRoulette(int result)
        {
            switch (result)
            {
                case 0:
                    bet0.Payout(40);
                    break;
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
                    break;
                case 23:
                    if(bet23.currentBet != 0 && betRed.currentBet != 0 && betHigh.currentBet != 0 && betDozen2.currentBet != 0 && betRow2.currentBet != 0 && sqr19_20_22_23.currentBet != 0 && sqr20_21_23_24.currentBet != 0 && sqr22_23_25_26.currentBet != 0 && sqr23_24_26_27.currentBet != 0 && split20_23.currentBet != 0 && split22_23.currentBet != 0 && split23_24.currentBet != 0 && split23_26.currentBet != 0)
                    {
                        //insert the clip/audio of Arin screaming for winning the Fortress on 23
                    }
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
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
                    bets.ForEach(bet => bet.currentBet = 0);
                    break;
                default:
                    break;
            }
        }

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
                lbl_InvalidBet.Content = "Cannot exit while betting";
            }
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            RulesPopup.IsOpen = true;
            RulesTxt.Text = "Start by selecting the space you are betting on\n" +
                "Select the chips you plan on betting\n" +
                "You can’t place more than $10,000 on a given space\n" +
                "You can select more places to bet\n" +
                "You can’t bet more than $200,000 on the board\n" +
                "Press the play button to start the roulette wheel\n" +
                "You can’t leave the game if you have placed bets on the board";
        }

        private void Rules_Exit(object sender, RoutedEventArgs e)
        {
            RulesPopup.IsOpen = false;
        }
    }
}