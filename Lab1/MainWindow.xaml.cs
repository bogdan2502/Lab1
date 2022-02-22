using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Lab1
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
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            var d = Bday.DisplayDate.Day;
            var m = Bday.DisplayDate.Month;
            var y = Bday.DisplayDate.Year;

            var cd = DateTime.Now.Day;
            var cm = DateTime.Now.Month;
            var cy = DateTime.Now.Year;
            var yo = cy - y;

            if (cm < m && !((cm == m) && cd < d)) yo--;

            if (yo < 0 || yo >= 135)
            {
                MessageBox.Show("Wrong date, bro. Try again");
            }

            if (d == cd && m == cm)
            {
                MessageBox.Show("Happy Birthday, bro");
            }
    
            String zod = null;
            String chin = null;
            switch (m)
            {
                case 01:
                    if (d >= 20) {
                        zod = "Aquarius";
                    }else {
                        zod = "Capricorn";
                    }
                    break;
                case 02:
                    if (d >= 19) {
                        zod = "Pisces";
                    }else {
                        zod = "Aquarius";
                    }
                    break;
                case 03:
                    if (d >= 21) {
                        zod = "Aries";
                    }else {
                        zod = "Pisces";
                    }
                    break;
                case 04:
                    if (d >= 20) {
                        zod = "Taurus";
                    }else {
                        zod = "Aries";
                    }
                    break;
                case 05:
                    if (d >= 21) {
                        zod = "Gemini";
                    }else {
                        zod = "Taurus";
                    }
                    break;
                case 06:
                    if (d >= 21) {
                        zod = "Cancer";
                    }else {
                        zod = "Gemini";
                    }
                    break;
                case 07:
                    if (d >= 23) {
                        zod = "Leo";
                    }else {
                        zod = "Cancer";
                    }
                    break;
                case 08:
                    if (d >= 23) {
                        zod = "Virgo";
                    }else {
                        zod = "Leo";
                    }
                    break;
                case 09:
                    if (d >= 23) {
                        zod = "Libra";
                    }else {
                        zod = "Virgo";
                    }
                    break;
                case 10:
                    if (d >= 23) {
                        zod = "Scorpio";
                    }else {
                        zod = "Libra";
                    }
                    break;
                case 11:
                    if (d >= 23) {
                        zod = "Sagittarius";
                    }else {
                        zod = "Scorpio";
                    }
                    break;
                case 12:
                    if (d >= 22) {
                        zod = "Sagittarius";
                    }else {
                        zod = "Capricorn";
                    }
                    break;
            }
            int n = y % 12;
            switch (n)
            {
                case 0:
                    chin = "Monkey";
                    break;
                case 1:
                    chin = "Rooster";
                    break;
                case 2:
                    chin = "Dog";
                    break;
                case 3:
                    chin = "Pig";
                    break;
                case 4:
                    chin = "Rat";
                    break;
                case 5:
                    chin = "Ox";
                    break;
                case 6:
                    chin = "Tiger";
                    break;
                case 7:
                    chin = "Rabbit";
                    break;
                case 8:
                    chin = "Dragon";
                    break;
                case 9:
                    chin = "Snake";
                    break;
                case 10:
                    chin = "Horse";
                    break;
                case 11:
                    chin = "Goat";
                    break;
            }
            block1.Text = zod;
            block2.Text = chin;
            block0.Text = yo.ToString();
        }
        
    }
}