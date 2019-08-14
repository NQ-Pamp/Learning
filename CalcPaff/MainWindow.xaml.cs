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

            string result = Convert.ToString(num1 + num2);

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
    }
}
