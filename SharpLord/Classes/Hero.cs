using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpLord.Classes;

namespace SharpLord.Classes
{
    class Hero
    {

        private string _name;
        private int price;
        private int heroHp;
        private float attackSpeed;
        private int attackValue;
        private string alliance;
        private int number;
        private int _lvl;
        private bool _isOnBench;

        private static int _heroPool1 = 40;
        private static int _heroPool2 = 30;
        private static int _heroPool3 = 20;
        private static int _heroPool4 = 10;

        //empty constructor
        public Hero()
        {

        }

        //Init constructor
        public Hero(string name, int lvl, string alliance)
        {
            Name = name;
            Lvl = lvl;
            Alliance = alliance;
        }

        //Constructor for combat values
        public Hero(float attackspeed, int heroHp, int attackValue)
        {
            AttackSpeed = attackspeed;
            HeroHp = heroHp;
            AttackValue = attackValue;
        }

        public string Name { get => _name; set => _name = value; }
        public int Price { get => price; set => price = value; }
        public float AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public int HeroHp { get => heroHp; set => heroHp = value; }
        public int AttackValue { get => attackValue; set => attackValue = value; }
        public string Alliance
        {
            get => alliance;
            set {
                if (value == "Savage" || value == "Mage" || value == "Druid" || value == "Knights" || value == "Assassin" || value == "Scrappy")
                {
                    alliance = value;
                } 
                else
                {
                    alliance = "No alliance";
                }
            }
        }
        public int Number { get => number; set => number = value; }
        public int Lvl { get => _lvl; set => _lvl = value; }
        public bool IsOnBench { get => _isOnBench; set => _isOnBench = value; }
        public static int HeroPool1 { get => _heroPool1; set => _heroPool1 = value; }
        public static int HeroPool2 { get => _heroPool2; set => _heroPool2 = value; }
        public static int HeroPool3 { get => _heroPool3; set => _heroPool3 = value; }
        public static int HeroPool4 { get => _heroPool4; set => _heroPool4 = value; }
    }

    
}
