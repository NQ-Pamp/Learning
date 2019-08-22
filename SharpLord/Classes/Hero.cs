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

        private string name;
        private int price;
        private int heroHp;
        private float attackSpeed;
        private int attackValue;
        private string alliance;
        private int number;
        private int lvl;

        public Hero()
        {

        }

        public Hero(string name, int price, string alliance)
        {
            Name = name;
            Price = price;
            Alliance = alliance;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public float AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public int HeroHp { get => heroHp; set => heroHp = value; }
        public int AttackValue { get => attackValue; set => attackValue = value; }
        public string Alliance { get => alliance; set => alliance = value; }
        public int Number { get => number; set => number = value; }
        public int Lvl { get => lvl; set => lvl = value; }

        private string[] Lvl1Heroes = new string[10] { "Tiny", "Tusk", "Axe", "Razor", "Ogre", "BatRider", "Shadow Shaman", "Bloodseeker","Enchantress","Warlock" };
        private string[] Lvl2Heroes = new string[7] { "Lina", "BeastMaster", "Juggernaut", "Puck", "Mistress","Prophet","Deboiseur"};
        private string[] Lvl3Heroes = new string[5] { "Demon Fiend", "Crystal", "Lycan", "Tinker", "Sniper" };
        private string[] Lvl4Heroes = new string[5] { "Mirana", "Sand King", "Arc", "Doom", "Temple Assassin" };

        public string[] Lvl1Heroes1 { get => Lvl1Heroes; set => Lvl1Heroes = value; }

        Hero tusk = new Hero("Tusk", 1, "Savage");
        Hero Tiny = new Hero("Tiny", 1, "Warrior");
        Hero Axe = new Hero("Axe", 1, "Warriror");



    }

    
}
