using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
        int Ongoing2 = 0;
        int QS = 0;
        int finalcount = 0;
        int Active;  // 1-Blue and 0-Red
        int check = 0;

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
            if (Ongoing2 == 0)
            {
                Reset();
            }
        }

        private void Blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OnGoing == 0)
            {
                Red.Visibility = Visibility.Hidden;
                Blue.Opacity = 1;
                Red.Opacity = 1;
                OnGoing = 1;
                Ongoing2 = 1;

                Clue.Text = "Choose a hidden word";
                QuestionPanel.Visibility = Visibility.Visible;

                Active = 1;

                QuestionPanel.IsEnabled = true;
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
                Blue.Opacity = 1;
                OnGoing = 1;
                Ongoing2 = 1;

                Clue.Text = "Choose a hidden word";
                QuestionPanel.Visibility = Visibility.Visible;

                Active = 0;

                QuestionPanel.IsEnabled = true;
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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C1"].ToString();

                Q1.Opacity = .2;
                Q1.IsEnabled = false;
                VQ1 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q1.Foreground = Brushes.Black;
                Q1.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ1 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q1.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q1.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C2"].ToString();

                Q2.Opacity = .2;
                Q2.IsEnabled = false;
                VQ2 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q2.Foreground = Brushes.Black;
                Q2.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ2 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q2.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q2.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C3"].ToString();

                Q3.Opacity = .2;
                Q3.IsEnabled = false;
                VQ3 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q3.Foreground = Brushes.Black;
                Q3.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ3 == 0)

            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q3.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q3.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C4"].ToString();

                Q4.Opacity = .2;
                Q4.IsEnabled = false;
                VQ4 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q4.Foreground = Brushes.Black;
                Q4.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ4 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q4.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q4.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C5"].ToString();

                Q5.Opacity = .2;
                Q5.IsEnabled = false;
                VQ5 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q5.Foreground = Brushes.Black;
                Q5.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ5 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q5.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q5.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C6"].ToString();

                Q6.Opacity = .2;
                Q6.IsEnabled = false;
                VQ6 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q6.Foreground = Brushes.Black;
                Q6.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q6_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ6 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q6.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q6.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C7"].ToString();

                Q7.Opacity = .2;
                Q7.IsEnabled = false;
                VQ7 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q7.Foreground = Brushes.Black;
                Q7.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q7_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ7 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q7.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q7.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C8"].ToString();

                Q8.Opacity = .2;
                Q8.IsEnabled = false;
                VQ8 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q8.Foreground = Brushes.Black;
                Q8.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q8_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ8 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q8.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q8.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C9"].ToString();

                Q9.Opacity = .2;
                Q9.IsEnabled = false;
                VQ9 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q9.Foreground = Brushes.Black;
                Q9.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q9_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ9 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q9.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q9.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
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
                Word = Word.ToUpper();
                Clue.Text = Settings.Default["C10"].ToString();

                Q10.Opacity = .2;
                Q10.IsEnabled = false;
                VQ10 = 1;

                AlphabetPanel.Visibility = Visibility.Visible;
                GuessGrid.Visibility = Visibility.Visible;

                QS = 1;

                Mouse.OverrideCursor = Cursors.Arrow;
                Q10.Foreground = Brushes.Black;
                Q10.Background = Brushes.White;

                QuestionPanel.IsEnabled = false;
            }
        }

        private void Q10_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VQ10 == 0)
            {
                Mouse.OverrideCursor = Cursors.Hand;
                Q10.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                Q10.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
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
            AlphabetCheck('A');
            A.Opacity = .2;
            A.IsEnabled = false;
        }

        private void A_MouseEnter(object sender, MouseEventArgs e)
        {
            A.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void A_MouseLeave(object sender, MouseEventArgs e)
        {
            A.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('B');
            B.Opacity = .2;
            B.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void B_MouseEnter(object sender, MouseEventArgs e)
        {
            B.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void B_MouseLeave(object sender, MouseEventArgs e)
        {
            B.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('C');
            C.Opacity = .2;
            C.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void C_MouseEnter(object sender, MouseEventArgs e)
        {
            C.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void C_MouseLeave(object sender, MouseEventArgs e)
        {
            C.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('D');
            D.Opacity = .2;
            D.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void D_MouseEnter(object sender, MouseEventArgs e)
        {
            D.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void D_MouseLeave(object sender, MouseEventArgs e)
        {
            D.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('E');
            E.Opacity = .2;
            E.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void E_MouseEnter(object sender, MouseEventArgs e)
        {
            E.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void E_MouseLeave(object sender, MouseEventArgs e)
        {
            E.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('F');
            F.Opacity = .2;
            F.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void F_MouseEnter(object sender, MouseEventArgs e)
        {
            F.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void F_MouseLeave(object sender, MouseEventArgs e)
        {
            F.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('G');
            G.Opacity = .2;
            G.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void G_MouseEnter(object sender, MouseEventArgs e)
        {
            G.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void G_MouseLeave(object sender, MouseEventArgs e)
        {
            G.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('H');
            H.Opacity = .2;
            H.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void H_MouseEnter(object sender, MouseEventArgs e)
        {
            H.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void H_MouseLeave(object sender, MouseEventArgs e)
        {
            H.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('I');
            I.Opacity = .2;
            I.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void I_MouseEnter(object sender, MouseEventArgs e)
        {
            I.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void I_MouseLeave(object sender, MouseEventArgs e)
        {
            I.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('J');
            J.Opacity = .2;
            J.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void J_MouseEnter(object sender, MouseEventArgs e)
        {
            J.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void J_MouseLeave(object sender, MouseEventArgs e)
        {
            J.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('K');
            K.Opacity = .2;
            K.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void K_MouseEnter(object sender, MouseEventArgs e)
        {
            K.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void K_MouseLeave(object sender, MouseEventArgs e)
        {
            K.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('L');
            L.Opacity = .2;
            L.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void L_MouseEnter(object sender, MouseEventArgs e)
        {
            L.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void L_MouseLeave(object sender, MouseEventArgs e)
        {
            L.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('M');
            M.Opacity = .2;
            M.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void M_MouseEnter(object sender, MouseEventArgs e)
        {
            M.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void M_MouseLeave(object sender, MouseEventArgs e)
        {
            M.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('N');
            N.Opacity = .2;
            N.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void N_MouseEnter(object sender, MouseEventArgs e)
        {
            N.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void N_MouseLeave(object sender, MouseEventArgs e)
        {
            N.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('O');
            O.Opacity = .2;
            O.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void O_MouseEnter(object sender, MouseEventArgs e)
        {
            O.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void O_MouseLeave(object sender, MouseEventArgs e)
        {
            O.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('P');
            P.Opacity = .2;
            P.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void P_MouseEnter(object sender, MouseEventArgs e)
        {
            P.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void P_MouseLeave(object sender, MouseEventArgs e)
        {
            P.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('Q');
            Q.Opacity = .2;
            Q.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Q_MouseEnter(object sender, MouseEventArgs e)
        {
            Q.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Q_MouseLeave(object sender, MouseEventArgs e)
        {
            Q.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('R');
            R.Opacity = .2;
            R.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void R_MouseEnter(object sender, MouseEventArgs e)
        {
            R.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void R_MouseLeave(object sender, MouseEventArgs e)
        {
            R.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('S');
            S.Opacity = .2;
            S.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void S_MouseEnter(object sender, MouseEventArgs e)
        {
            S.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void S_MouseLeave(object sender, MouseEventArgs e)
        {
            S.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('T');
            T.Opacity = .2;
            T.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void T_MouseEnter(object sender, MouseEventArgs e)
        {
            T.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void T_MouseLeave(object sender, MouseEventArgs e)
        {
            T.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('U');
            U.Opacity = .2;
            U.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void U_MouseEnter(object sender, MouseEventArgs e)
        {
            U.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void U_MouseLeave(object sender, MouseEventArgs e)
        {
            U.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('V');
            V.Opacity = .2;
            V.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void V_MouseEnter(object sender, MouseEventArgs e)
        {
            V.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void V_MouseLeave(object sender, MouseEventArgs e)
        {
            V.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('W');
            W.Opacity = .2;
            W.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void W_MouseEnter(object sender, MouseEventArgs e)
        {
            W.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void W_MouseLeave(object sender, MouseEventArgs e)
        {
            W.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('X');
            X.Opacity = .2;
            X.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void X_MouseEnter(object sender, MouseEventArgs e)
        {
            X.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void X_MouseLeave(object sender, MouseEventArgs e)
        {
            X.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('Y');
            Y.Opacity = .2;
            Y.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Y_MouseEnter(object sender, MouseEventArgs e)
        {
            Y.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Y_MouseLeave(object sender, MouseEventArgs e)
        {
            Y.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            AlphabetCheck('Z');
            Z.Opacity = .2;
            Z.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Z_MouseEnter(object sender, MouseEventArgs e)
        {
            Z.Foreground = Brushes.Crimson;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Z_MouseLeave(object sender, MouseEventArgs e)
        {
            Z.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void AlphabetCheck(char alpha)
        {
            int count = 0;
            char[] array = Word.ToCharArray();
            foreach (char a in array)
            {
                ++count;
                if (a == alpha)
                {
                    switch (count)
                    {
                        case 1:
                            if (String.IsNullOrEmpty(_1.Text))
                            {
                                _1.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 2:
                            if (String.IsNullOrEmpty(_2.Text))
                            {
                                _2.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 3:
                            if (String.IsNullOrEmpty(_3.Text))
                            {
                                _3.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 4:
                            if (String.IsNullOrEmpty(_4.Text))
                            {
                                _4.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 5:
                            if (String.IsNullOrEmpty(_5.Text))
                            {
                                _5.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 6:
                            if (String.IsNullOrEmpty(_6.Text))
                            {
                                _6.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 7:
                            if (String.IsNullOrEmpty(_7.Text))
                            {
                                _7.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 8:
                            if (String.IsNullOrEmpty(_8.Text))
                            {
                                _8.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 9:
                            if (String.IsNullOrEmpty(_9.Text))
                            {
                                _9.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;

                        case 10:
                            if (String.IsNullOrEmpty(_10.Text))
                            {
                                _10.Text = alpha.ToString();
                                ++finalcount;
                                check = 1;
                            }
                            break;
                    }
                }
            }
            if (finalcount == 10)
            {
                Winner();
            }
            Check();
        }

        private void Check()
        {
            if (check == 0)
            {
                Storyboard storyboard = FindResource("WrongAnimation") as Storyboard;
                storyboard.Begin();
                Swap();
            }
            check = 0;
        }

        private void Winner()
        {
            Storyboard storyboard = FindResource("WinnerAnimaion") as Storyboard;
            storyboard.Begin();
            Fun_LogoEvent();
        }

        async Task Fun_LogoEvent()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(4500);
            });

            Clue.Text = "Winner";
            QuestionPanel.Visibility = Visibility.Hidden;
            AlphabetPanel.Visibility = Visibility.Hidden;
            GuessGrid.Visibility = Visibility.Hidden;
            Ongoing2 = 0;
        }

        private void Swap()
        {
            if (Active == 1)
            {
                Active = 0;
                Blue.Visibility = Visibility.Hidden;
                Red.Visibility = Visibility.Visible;
            }
            else
            {
                Active = 1;
                Blue.Visibility = Visibility.Visible;
                Red.Visibility = Visibility.Hidden;
            }
        }

        private void Reset()
        {
            _1.Clear();
            _2.Clear();
            _3.Clear();
            _4.Clear();
            _5.Clear();
            _6.Clear();
            _7.Clear();
            _8.Clear();
            _9.Clear();
            _10.Clear();

            Word = string.Empty;

            Blue.Opacity = .5;
            Red.Opacity = .5;
            Blue.Visibility = Visibility.Visible;
            Red.Visibility = Visibility.Visible;

            Clue.Text = "Welcome\nChoose the first team";

            QS = 0;
            finalcount = 0;
            check = 0;

            OnGoing = 0;

            A.Opacity = 1;
            A.IsEnabled = true;

            B.Opacity = 1;
            B.IsEnabled = true;

            C.Opacity = 1;
            C.IsEnabled = true;

            D.Opacity = 1;
            D.IsEnabled = true;

            E.Opacity = 1;
            E.IsEnabled = true;

            F.Opacity = 1;
            F.IsEnabled = true;


            G.Opacity = 1;
            G.IsEnabled = true;

            H.Opacity = 1;
            H.IsEnabled = true;

            I.Opacity = 1;
            I.IsEnabled = true;

            J.Opacity = 1;
            J.IsEnabled = true;

            K.Opacity = 1;
            K.IsEnabled = true;

            L.Opacity = 1;
            L.IsEnabled = true;

            M.Opacity = 1;
            M.IsEnabled = true;

            N.Opacity = 1;
            N.IsEnabled = true;


            O.Opacity = 1;
            O.IsEnabled = true;

            P.Opacity = 1;
            P.IsEnabled = true;

            Q.Opacity = 1;
            Q.IsEnabled = true;

            R.Opacity = 1;
            R.IsEnabled = true;

            S.Opacity = 1;
            S.IsEnabled = true;

            T.Opacity = 1;
            T.IsEnabled = true;

            U.Opacity = 1;
            U.IsEnabled = true;

            V.Opacity = 1;
            V.IsEnabled = true;

            W.Opacity = 1;
            W.IsEnabled = true;

            X.Opacity = 1;
            X.IsEnabled = true;

            Y.Opacity = 1;
            Y.IsEnabled = true;

            Z.Opacity = 1;
            Z.IsEnabled = true;
        }
    }
}
