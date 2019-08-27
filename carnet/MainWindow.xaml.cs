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
using carnet.classes;
using System.Collections.ObjectModel;

namespace carnet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<People> contactList = new ObservableCollection<People>();

        public MainWindow()
        {
            InitializeComponent();

            //contactList.Add(new People("TOUDERT", "Malik"));
            //contactList.Add(new People("ALAIN", "Ingreed"));

            listCarnet.ItemsSource = contactList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            contactList.Add(new People(nameBox.Text, surnameBox.Text));
        }
    }
}
