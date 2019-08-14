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

namespace WpfApp1
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

        private void yoButton_Click(object sender, RoutedEventArgs e)
        {
            string name = myTextBox.Text;
            Int32 age = Convert.ToInt32(ageTextBox.Text);
            string majMin = null;

            if (age>=18)
            {
                majMin = "You are capable ! ";
            }
            else
            {
                majMin = "You are not capable :( ";
            }

            MessageBox.Show("Yo " + name + " ! " + majMin,"First box",MessageBoxButton.OK,MessageBoxImage.Information);
        }

    }
}
