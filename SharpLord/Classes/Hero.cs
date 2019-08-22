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

        //Init constructor
        public Hero(string name, int price, string alliance)
        {
            Name = name;
            Price = price;
            Alliance = alliance;
        }

        //Constructor for combat values
        public Hero(float attackspeed, int heroHp, int attackValue)
        {
            AttackSpeed = attackspeed;
            HeroHp = heroHp;
            AttackValue = attackValue;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public float AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public int HeroHp { get => heroHp; set => heroHp = value; }
        public int AttackValue { get => attackValue; set => attackValue = value; }
        public string Alliance { get => alliance; set => alliance = value; }
        public int Number { get => number; set => number = value; }
        public int Lvl { get => lvl; set => lvl = value; }

    }

    
}
