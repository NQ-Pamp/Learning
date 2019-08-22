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
using SharpLord.Classes;

namespace SharpLord
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            string[] Lvl1Heroes = new string[10]{"Tiny", "Tusk", "Axe", "Razor", "Ogre", "BatRider", "Shadow Shaman", "Bloodseeker", "Enchantress", "Warlock"};
            string[] Lvl2Heroes = new string[7] { "Lina", "BeastMaster", "Juggernaut", "Puck", "Mistress", "Prophet", "Deboiseur" };
            string[] Lvl3Heroes = new string[5] { "Demon Fiend", "Crystal", "Lycan", "Tinker", "Sniper" };
            string[] Lvl4Heroes = new string[5] { "Mirana", "Sand King", "Arc", "Doom", "Temple Assassin" };
            string[] Alliances = new string[5] { "Savage", "Mage", "Druid", "Assassin", "Scrappy" };

            Hero[] myHeroes1 = new Hero[Lvl1Heroes.Length];
            Hero[] myHeroes2 = new Hero[Lvl2Heroes.Length];
            Hero[] myHeroes3 = new Hero[Lvl3Heroes.Length];
            Hero[] myHeroes4 = new Hero[Lvl4Heroes.Length];


            InitializeComponent();

            for (int i = 0; i < Lvl1Heroes.Length; i++)
            {
                myHeroes1[i] = new Hero()
                {
                    Name = Lvl1Heroes[i],
                    Lvl = 1,
                    Alliance = ""
                };
            }

            for (int i = 0; i < Lvl2Heroes.Length; i++)
            {
                myHeroes2[i] = new Hero()
                {
                    Name = Lvl2Heroes[i],
                    Lvl = 2,
                    Alliance = ""
                };
            }

            for (int i = 0; i < Lvl3Heroes.Length; i++)
            {
                myHeroes3[i] = new Hero()
                {
                    Name = Lvl3Heroes[i],
                    Lvl = 3,
                    Alliance = ""
                };
            }

            for (int i = 0; i < Lvl4Heroes.Length; i++)
            {
                myHeroes4[i] = new Hero()
                {
                    Name = Lvl4Heroes[i],
                    Lvl = 4,
                    Alliance = ""
                };
            }

            MessageBox.Show(myHeroes1);

            
        }
    }
}
