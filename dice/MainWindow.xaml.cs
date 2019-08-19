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

namespace dice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int diceResult = 0;
        Random myRandom = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, RoutedEventArgs e)
        {
            diceResult = myRandom.Next(1,7);

            resultBlock.Text = diceResult.ToString();
        }
    }
}
