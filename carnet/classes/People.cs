using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carnet.classes
{

    class People
    {
        private string _name;
        private string _surname;
        private string _city;
        private int _cp;
        private string _tel;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string City { get => _city; set => _city = value; }
        public int Cp { get => _cp; set => _cp = value; }
        public string Tel { get => _tel; set => _tel = value; }

        public People(string name, string surname, string city, int cp, string tel)
        {
            Name = name;
            Surname = surname;
            City = city;
            Cp = cp;
            Tel = tel;
        }


        public People(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public People()
        {

        }

        public String CompleteName()
        {
            return Name + " " + Surname;
        }

    }
}
