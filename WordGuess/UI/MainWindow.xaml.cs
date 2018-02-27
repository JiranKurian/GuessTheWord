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
using UI.Properties;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Word = string.Empty;
        int OnGoing = 0;
        int QS = 0;
        int Active;

        int VQ1 = 0;
        int VQ2 = 0;
        int VQ3 = 0;
        int VQ4 = 0;
        int VQ5 = 0;
        int VQ6 = 0;
        int VQ7 = 0;
        int VQ8 = 0;
        int VQ9 = 0;
        int VQ10 = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OnGoing == 0) 
            {
                Blue.Opacity = .5;
                Red.Opacity = .5;
                Blue.Visibility = Visibility.Visible;
                Red.Visibility = Visibility.Visible;
            }
        }

        private void Blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OnGoing == 0)
            {
                Red.Visibility = Visibility.Hidden;
                Blue.Opacity = 1;
                OnGoing = 1;

                Clue.Text = "Choose a question";
                QuestionPanel.Visibility = Visibility.Visible;

                Active = 1;
            }
        }

        private void Blue_MouseEnter(object sender, MouseEventArgs e)
        {
            if (OnGoing == 0)
            {
                Blue.Opacity = 1;
                Mouse.OverrideCursor = Cursors.Hand;
            }
        }

        private void Blue_MouseLeave(object sender, MouseEventArgs e)
        {
            if (OnGoing == 0)
            {
                Blue.Opacity = .5;
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Red_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OnGoing == 0)
            {
                Blue.Visibility = Visibility.Hidden;
                Red.Opacity = 1;
                OnGoing = 1;

                Clue.Text = "Choose a question";
                QuestionPanel.Visibility = Visibility.Visible;

                Active = 0;
            }
        }

        private void Red_MouseEnter(object sender, MouseEventArgs e)
        {
            if (OnGoing == 0)
            {
                Red.Opacity = 1;
                Mouse.OverrideCursor = Cursors.Hand;
            }
        }

        private void Red_MouseLeave(object sender, MouseEventArgs e)
        {
            if (OnGoing == 0)
            {
                Red.Opacity = .5;
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            Close.Foreground = Brushes.Red;
            Mouse.OverrideCursor = Cursors.Hand;

        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            Close.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;

        }

        private void Q1_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W1"].ToString();
                Clue.Text = Settings.Default["C1"].ToString();

                Q1.Opacity = .5;
                Q1.IsEnabled = false;
                VQ1 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ1 == 0)
            {

                Mouse.OverrideCursor = Cursors.Hand;
                Q1.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q1.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));
                    }
        }

        private void Q1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ1 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q1.Foreground = Brushes.Black;
                Q1.Background = Brushes.White;

            }
        }

        private void Q2_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W2"].ToString();
                Clue.Text = Settings.Default["C2"].ToString();

                Q2.Opacity = .5;
                Q2.IsEnabled = false;
                VQ2 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ2 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q2.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q2.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));

            }
        }

        private void Q2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ2 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q2.Foreground = Brushes.Black;
                Q2.Background = Brushes.White;
            }
        }

        private void Q3_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W3"].ToString();
                Clue.Text = Settings.Default["C3"].ToString();

                Q3.Opacity = .5;
                Q3.IsEnabled = false;
                VQ3 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ3 == 0)
                
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q3.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q3.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));
            }
        }

        private void Q3_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ3 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q3.Foreground = Brushes.Black;
                Q3.Background = Brushes.White;
            }
        }

        private void Q4_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W4"].ToString();
                Clue.Text = Settings.Default["C4"].ToString();

                Q4.Opacity = .5;
                Q4.IsEnabled = false;
                VQ4 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ4 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q4.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q4.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));

            }
        }

        private void Q4_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ4 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q4.Foreground = Brushes.Black;
                Q4.Background = Brushes.White;
            }
        }

        private void Q5_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W5"].ToString();
                Clue.Text = Settings.Default["C5"].ToString();

                Q5.Opacity = .5;
                Q5.IsEnabled = false;
                VQ5 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ5 == 0)
                Mouse.OverrideCursor = Cursors.Hand;
            Q5.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Q5.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));
            {

            }
        }

        private void Q5_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ5 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q5.Foreground = Brushes.Black;
                Q5.Background = Brushes.White;
            }
        }

        private void Q6_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W6"].ToString();
                Clue.Text = Settings.Default["C6"].ToString();

                Q6.Opacity = .5;
                Q6.IsEnabled = false;
                VQ6 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q6_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ6 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q6.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q6.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));

            }
        }

        private void Q6_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ6 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q6.Foreground = Brushes.Black;
                Q6.Background = Brushes.White;
            }
        }

        private void Q7_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W7"].ToString();
                Clue.Text = Settings.Default["C7"].ToString();

                Q7.Opacity = .5;
                Q7.IsEnabled = false;
                VQ7 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q7_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ7 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q7.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q7.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));

            }
        }

        private void Q7_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ7 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q7.Foreground = Brushes.Black;
                Q7.Background = Brushes.White;
            }
        }

        private void Q8_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W8"].ToString();
                Clue.Text = Settings.Default["C8"].ToString();

                Q8.Opacity = .5;
                Q8.IsEnabled = false;
                VQ8 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q8_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ8 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q8.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q8.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));

            }
        }

        private void Q8_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ8 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q8.Foreground = Brushes.Black;
                Q8.Background = Brushes.White;
            }
        }

        private void Q9_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W9"].ToString();
                Clue.Text = Settings.Default["C9"].ToString();

                Q9.Opacity = .5;
                Q9.IsEnabled = false;
                VQ9 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q9_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ9 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q9.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q9.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));
            }
        }

        private void Q9_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ9 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q9.Foreground = Brushes.Black;
                Q9.Background = Brushes.White;
            }
        }

        private void Q10_Click(object sender, RoutedEventArgs e)
        {
            if (QS == 0)
            {
                Word = Settings.Default["W10"].ToString();
                Clue.Text = Settings.Default["C10"].ToString();

                Q10.Opacity = .5;
                Q10.IsEnabled = false;
                VQ10 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;
            }
        }

        private void Q10_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ10 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q10.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q10.Background = new SolidColorBrush(Color.FromRgb(255, 80, 80));
            }
        }

        private void Q10_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VQ10 == 0)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                Q10.Foreground = Brushes.Black;
                Q10.Background = Brushes.White;

            }
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {

        }

        private void A_MouseEnter(object sender, MouseEventArgs e)
        {
            A.Foreground = Brushes.Crimson;
        }

        private void A_MouseLeave(object sender, MouseEventArgs e)
        {
            A.Foreground = Brushes.Black;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_MouseEnter(object sender, MouseEventArgs e)
        {
            B.Foreground = Brushes.Crimson;
        }

        private void B_MouseLeave(object sender, MouseEventArgs e)
        {
            B.Foreground = Brushes.Black;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void C_MouseEnter(object sender, MouseEventArgs e)
        {
            C.Foreground = Brushes.Crimson;
        }

        private void C_MouseLeave(object sender, MouseEventArgs e)
        {
            C.Foreground = Brushes.Black;
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {

        }

        private void D_MouseEnter(object sender, MouseEventArgs e)
        {
            D.Foreground = Brushes.Crimson;
        }

        private void D_MouseLeave(object sender, MouseEventArgs e)
        {
            D.Foreground = Brushes.Black;
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E_MouseEnter(object sender, MouseEventArgs e)
        {
            E.Foreground = Brushes.Crimson;
        }

        private void E_MouseLeave(object sender, MouseEventArgs e)
        {
            E.Foreground = Brushes.Black;
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {

        }

        private void F_MouseEnter(object sender, MouseEventArgs e)
        {
            F.Foreground = Brushes.Crimson;
        }

        private void F_MouseLeave(object sender, MouseEventArgs e)
        {
            F.Foreground = Brushes.Black;
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {

        }

        private void G_MouseEnter(object sender, MouseEventArgs e)
        {
            G.Foreground = Brushes.Crimson;
        }

        private void G_MouseLeave(object sender, MouseEventArgs e)
        {
            G.Foreground = Brushes.Black;
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {

        }

        private void H_MouseEnter(object sender, MouseEventArgs e)
        {
            H.Foreground = Brushes.Crimson;
        }

        private void H_MouseLeave(object sender, MouseEventArgs e)
        {
            H.Foreground = Brushes.Black;
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {

        }

        private void I_MouseEnter(object sender, MouseEventArgs e)
        {
            I.Foreground = Brushes.Crimson;
        }

        private void I_MouseLeave(object sender, MouseEventArgs e)
        {
            I.Foreground = Brushes.Black;
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {

        }

        private void J_MouseEnter(object sender, MouseEventArgs e)
        {
            J.Foreground = Brushes.Crimson;
        }

        private void J_MouseLeave(object sender, MouseEventArgs e)
        {
            J.Foreground = Brushes.Black;
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {

        }

        private void K_MouseEnter(object sender, MouseEventArgs e)
        {
            K.Foreground = Brushes.Crimson;
        }

        private void K_MouseLeave(object sender, MouseEventArgs e)
        {
            K.Foreground = Brushes.Black;
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {

        }

        private void L_MouseEnter(object sender, MouseEventArgs e)
        {
            L.Foreground = Brushes.Crimson;
        }

        private void L_MouseLeave(object sender, MouseEventArgs e)
        {
            L.Foreground = Brushes.Black;
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {

        }

        private void M_MouseEnter(object sender, MouseEventArgs e)
        {
            M.Foreground = Brushes.Crimson;
        }

        private void M_MouseLeave(object sender, MouseEventArgs e)
        {
            M.Foreground = Brushes.Black;
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N_MouseEnter(object sender, MouseEventArgs e)
        {
            N.Foreground = Brushes.Crimson;
        }

        private void N_MouseLeave(object sender, MouseEventArgs e)
        {
            N.Foreground = Brushes.Black;
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {

        }

        private void O_MouseEnter(object sender, MouseEventArgs e)
        {
            O.Foreground = Brushes.Crimson;
        }

        private void O_MouseLeave(object sender, MouseEventArgs e)
        {
            O.Foreground = Brushes.Black;
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {

        }

        private void P_MouseEnter(object sender, MouseEventArgs e)
        {
            P.Foreground = Brushes.Crimson;
        }

        private void P_MouseLeave(object sender, MouseEventArgs e)
        {
           P.Foreground = Brushes.Black;
        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Q_MouseEnter(object sender, MouseEventArgs e)
        {
            Q.Foreground = Brushes.Crimson;
        }

        private void Q_MouseLeave(object sender, MouseEventArgs e)
        {
            Q.Foreground = Brushes.Black;
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {

        }

        private void R_MouseEnter(object sender, MouseEventArgs e)
        {
            R.Foreground = Brushes.Crimson;
        }

        private void R_MouseLeave(object sender, MouseEventArgs e)
        {
            R.Foreground = Brushes.Black;
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {

        }

        private void S_MouseEnter(object sender, MouseEventArgs e)
        {
            S.Foreground = Brushes.Crimson;
        }

        private void S_MouseLeave(object sender, MouseEventArgs e)
        {
            S.Foreground = Brushes.Black;
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {

        }

        private void T_MouseEnter(object sender, MouseEventArgs e)
        {
            T.Foreground = Brushes.Crimson;
        }

        private void T_MouseLeave(object sender, MouseEventArgs e)
        {
            T.Foreground = Brushes.Black;
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {

        }

        private void U_MouseEnter(object sender, MouseEventArgs e)
        {
            U.Foreground = Brushes.Crimson;
        }

        private void U_MouseLeave(object sender, MouseEventArgs e)
        {
            U.Foreground = Brushes.Black;
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {

        }

        private void V_MouseEnter(object sender, MouseEventArgs e)
        {
            V.Foreground = Brushes.Crimson;
        }

        private void V_MouseLeave(object sender, MouseEventArgs e)
        {
            V.Foreground = Brushes.Black;
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {

        }

        private void W_MouseEnter(object sender, MouseEventArgs e)
        {
            W.Foreground = Brushes.Crimson;
        }

        private void W_MouseLeave(object sender, MouseEventArgs e)
        {
            W.Foreground = Brushes.Black;
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {

        }

        private void X_MouseEnter(object sender, MouseEventArgs e)
        {
            X.Foreground = Brushes.Crimson;
        }

        private void X_MouseLeave(object sender, MouseEventArgs e)
        {
            X.Foreground = Brushes.Black;
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Y_MouseEnter(object sender, MouseEventArgs e)
        {
            Y.Foreground = Brushes.Crimson;
        }

        private void Y_MouseLeave(object sender, MouseEventArgs e)
        {
            Y.Foreground = Brushes.Black;
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Z_MouseEnter(object sender, MouseEventArgs e)
        {
            Z.Foreground = Brushes.Crimson;
        }

        private void Z_MouseLeave(object sender, MouseEventArgs e)
        {
            Z.Foreground = Brushes.Black;
        }
    }
}
