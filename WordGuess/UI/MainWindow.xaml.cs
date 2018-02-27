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

        }

        private void Blue_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Blue_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Blue_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Red_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Red_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Red_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q1_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W1"].ToString();
            Clue.Text= Settings.Default["C1"].ToString();
        }

        private void Q1_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q1_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q2_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W2"].ToString();
            Clue.Text = Settings.Default["C2"].ToString();
        }

        private void Q2_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q2_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q3_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W3"].ToString();
            Clue.Text = Settings.Default["C3"].ToString();
        }

        private void Q3_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q3_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q4_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W4"].ToString();
            Clue.Text = Settings.Default["C4"].ToString();
        }

        private void Q4_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q4_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q5_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W5"].ToString();
            Clue.Text = Settings.Default["C5"].ToString();
        }

        private void Q5_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q5_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q6_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W6"].ToString();
            Clue.Text = Settings.Default["C6"].ToString();
        }

        private void Q6_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q6_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q7_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W7"].ToString();
            Clue.Text = Settings.Default["C7"].ToString();
        }

        private void Q7_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q7_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q8_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W8"].ToString();
            Clue.Text = Settings.Default["C8"].ToString();
        }

        private void Q8_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q8_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q9_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W9"].ToString();
            Clue.Text = Settings.Default["C9"].ToString();
        }

        private void Q9_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q9_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Q10_Click(object sender, RoutedEventArgs e)
        {
            Word = Settings.Default["W10"].ToString();
            Clue.Text = Settings.Default["C10"].ToString();
        }

        private void Q10_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Q10_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
