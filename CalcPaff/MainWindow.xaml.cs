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

namespace CalcPaff
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string opeType = "plus";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;

            int.TryParse(numBox1.Text, out num1);
            int.TryParse(numBox2.Text, out num2);

            string result = ""; //Convert.ToString(num1 + num2);

            switch (opeType)
            {
                case "plus":
                    result = Convert.ToString(num1 + num2);

                    break;

                case "mult":
                    result = Convert.ToString(num1 * num2);

                    break;

                    case "div":
                    if (num2 > 0)
                    {
                        result = Convert.ToString(num1 / num2);
                    }
                    else
                    {
                        MessageBox.Show("Division par 0", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
            }

            if (Convert.ToString(num1) != numBox1.Text | Convert.ToString(num2) != numBox2.Text)
            {
                MessageBox.Show("Please enter a valid number.", "ERROR !", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                numBox1.Text = "0";
                numBox2.Text = "0";
                resultBlock.Text = "0";
            }
            else
            {
                resultBlock.Text = result;
            }
        }

        private void radioButtonPlus_Checked(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "+";
            opeType = "plus";
        }

        private void radioButtonDiv_Checked(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "/";
            opeType = "div";
        }

        private void radioButtonMult_Checked(object sender, RoutedEventArgs e)
        {
            operationLabel.Content = "X";
            opeType = "mult";
        }
    }
}
