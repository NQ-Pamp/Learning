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
            //string[,] AlliancesEx = new string[2, 3];

            Hero[] myHeroes1 = new Hero[Config.Lvl1Heroes.Length];
            Hero[] myHeroes2 = new Hero[Config.Lvl2Heroes.Length];
            Hero[] myHeroes3 = new Hero[Config.Lvl3Heroes.Length];

            List<Hero> allHeroes = new List<Hero>();

            InitializeComponent();

            for (int i = 0; i < Config.Lvl1Heroes.Length; i++)
            {
                string heroName = Config.Lvl1Heroes[i];

                if (Config.heroArchers.Contains(Name))
                {
                    Alliance = Config.archers;
                }

                myHeroes1[i] = new Hero()
                {
                    Name = heroName,
                    Lvl = 1,
                    Alliance = ""
                };
                allHeroes.Add(myHeroes1[i]);
                Hero.HeroPool1--;
            }

            for (int i = 0; i < Config.Lvl2Heroes.Length; i++)
            {
                myHeroes2[i] = new Hero()
                {
                    Name = Config.Lvl2Heroes[i],
                    Lvl = 2,
                    //Alliance = ""
                };
                allHeroes.Add(myHeroes2[i]);
                Hero.HeroPool2--;
            }

            for (int i = 0; i < Config.Lvl3Heroes.Length; i++)
            {
                myHeroes3[i] = new Hero()
                {
                    Name = Config.Lvl3Heroes[i],
                    Lvl = 3,
                    //Alliance = ""
                };
                allHeroes.Add(myHeroes3[i]);
                Hero.HeroPool3--;
            }

            var shopHeroes = new List<Hero>();
            Random rand = new Random();

            while (shopHeroes.Count < 5)
            {
                
                shopHeroes.Add(allHeroes[rand.Next(allHeroes.Count)]); 
            }

            Console.Write("Select a Hero among these : ");
            foreach (var heroes in shopHeroes)
            {
                Console.Write(heroes.Name + " / ");
            }

            string selectedHero = Console.ReadLine();

            foreach (var hero in shopHeroes)
            {
                if ( selectedHero == hero.Name)
                {
                    Console.WriteLine("You Bought : " + selectedHero);
                }

            }
            /*
            foreach (var heroes in myHeroes1)
            {
                Console.WriteLine(heroes.Name.ToString() + " Lvl : " + heroes.Lvl.ToString());
            }

            foreach (var heroes in myHeroes2)
            {
                Console.WriteLine(heroes.Name.ToString() + " Lvl : " + heroes.Lvl.ToString());
            }

            foreach (var heroes in myHeroes3)
            {
                Console.WriteLine(heroes.Name.ToString() + " Lvl : " + heroes.Lvl.ToString());
            }

            foreach (var heroes in myHeroes4)
            {
                Console.WriteLine(heroes.Name.ToString() + " Lvl : " + heroes.Lvl.ToString());
            }

            foreach (var heroes in allHeroes)
            {
                Console.Write(heroes + " / ");
            }
            */

            Console.ReadLine();

            
        }

    }
}
