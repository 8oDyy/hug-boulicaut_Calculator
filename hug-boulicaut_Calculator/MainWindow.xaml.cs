using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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

namespace hug_boulicaut_Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

     

        }


        double first_no = 0; //declaration des variables
        double second_no = 0;
        double result = 0;
        char operation;


        private void BTN_1_Click(object sender, RoutedEventArgs e) //declaration de chaque bouton
        {
            Display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            Display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            Display("3");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            Display("+");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            Display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            Display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            Display("6");
        }

        private void BTN_Less_Click(object sender, RoutedEventArgs e)
        {
            Display("-");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            Display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            Display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            Display("9");
        }

        private void BTN_Time_Click(object sender, RoutedEventArgs e)
        {
            Display("+");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            Display("0");
        }

        private void BTN_Egal_Click(object sender, RoutedEventArgs e)
        {
            Display("=");
        }
        

        private void BTN_Div_Click(object sender, RoutedEventArgs e)
        {
            Display("/");
        }
        private void BTN_LOG_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            //calculer sans passer par le '='
            result = Math.Log(first_no);
            TB_Display.Text = result.ToString();
        }
        private void BTN_SKRT_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            result = Math.Sqrt(first_no);
            TB_Display.Text = result.ToString();
        }
        private void BTN_COS_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            result = Math.Cos(first_no);
            TB_Display.Text = result.ToString();
        }

        private void BTN_SIN_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            result = Math.Sin(first_no);
            TB_Display.Text = result.ToString();
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            first_no = 0;
            second_no = 0;
            operation = '0';
            TB_Display.Text = "0";
        }

        public void Display(string num)//fonction pour afficher/stocker/calculé les nombres
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else if (num == "+" || num == "/" || num == "-" || num == "x" ) {
                first_no = double.Parse(TB_Display.Text);
                TB_Display.Text = "0";
                operation = char.Parse(num);
            }
            else if ( num == "=")
            {
                second_no = double.Parse(TB_Display.Text);
                switch (operation)
                {
                    case '+':
                        result = first_no + second_no;
                        TB_Display.Text = result.ToString();
                        break;

                    case '-':
                        result = first_no - second_no;
                        TB_Display.Text = result.ToString();
                        break;

                    case '*':
                        result = first_no * second_no;
                        TB_Display.Text = result.ToString();
                        break;

                    case '/':
                        result = first_no / second_no;
                        TB_Display.Text = result.ToString();
                        break;
                   
                }
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }
    }
}
