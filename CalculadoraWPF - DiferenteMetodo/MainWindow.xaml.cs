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

namespace CalculadoraWPF___DiferenteMetodo
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

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("0");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("1");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("2");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("3");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("4");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("5");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("6");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("7");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("8");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("9");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void btplus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleOperators("+");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void btsubtraction_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleOperators("-");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void btproduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleOperators("*");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void btdiv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleOperators("/");
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void btequal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleEquals(txtboxscreen.Text);
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }

        private void btonlyclean_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxscreen.Text.Length == 1)
                txtboxscreen.Text = "";
            else
            {
                if (txtboxscreen.Text.Length > 1)
                    txtboxscreen.Text = txtboxscreen.Text.Remove(txtboxscreen.Text.Length - 1);
                //txbScreen.Text = txbScreen.Text.Substring(0, txbScreen.Text.Length - 1);
                else
                    txtboxscreen.Clear();
            }
        }

        private void btdot_Click(object sender, RoutedEventArgs e)
        {
            //Button Clean
            try
            {
                txtboxscreen.Clear();
            }
            catch (Exception)
            {
                throw (new Exception("Error in the system"));
            }
        }
        private void HandleNumbers(string value)
        {
            if (String.IsNullOrEmpty(txtboxscreen.Text))
                txtboxscreen.Text = value;
            else
                txtboxscreen.Text += value;
        }
        private bool IsOperator(string PosOperador)
        {
            if (PosOperador == "+" || PosOperador == "-" || PosOperador == "*" || PosOperador == "/")
                return true;
            return PosOperador == "+" || PosOperador == "-" || PosOperador == "*" || PosOperador == "/";
        }
        private void HandleOperators(string value)
        {
            if (!String.IsNullOrEmpty(txtboxscreen.Text) && !ContainsOtherOperators(txtboxscreen.Text))
                txtboxscreen.Text += value;
        }
        private bool ContainsOtherOperators(string screenContent)
        {
            return screenContent.Contains("+") || screenContent.Contains("-") || screenContent.Contains("*") || screenContent.Contains("/");
        }
        private string FindOperador(string screenContent)
        {
            foreach (char c in screenContent)
            {
                if (IsOperator(c.ToString()))
                    return c.ToString();
            }
            return screenContent;
        }
        private void HandleEquals(string screenContent)
        {
            string op = FindOperador(screenContent);
            if (!String.IsNullOrEmpty(op))
            {
                switch (op)
                {
                    case "+":
                        txtboxscreen.Text = Sum();
                        break;
                    case "-":
                        txtboxscreen.Text = Rest();
                        break;
                    case "*":
                        txtboxscreen.Text = Mult();
                        break;
                    case "/":
                        txtboxscreen.Text = Div();
                        break;
                }
            }
        }
        private string Sum()
        {
            string[] numbers = txtboxscreen.Text.Split("+");
            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);
            return Math.Round(n1 + n2, 12).ToString();
        }
        private string Rest()
        {
            string[] numbers = txtboxscreen.Text.Split("-");
            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);
            return Math.Round(n1 - n2, 12).ToString();
        }
        private string Mult()
        {
            string[] numbers = txtboxscreen.Text.Split("*");
            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);
            return Math.Round(n1 * n2, 12).ToString();
        }
        private string Div()
        {
            string[] numbers = txtboxscreen.Text.Split("/");
            double.TryParse(numbers[0], out double n1);
            double.TryParse(numbers[1], out double n2);
            return Math.Round(n1 / n2, 12).ToString();
        }
    }
}
