using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Who are you ?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " !");
            */

            Console.WriteLine("When were you born ?");
            string year = Console.ReadLine();
            int yearNum = int.Parse(year);

            int age = DateTime.Now.Year - yearNum;

            if (age < 25)
            {
                Console.WriteLine("Your age = " + age.ToString() + "." + " You are young.");
            }
            else
            {
                Console.WriteLine("Your age = " + age.ToString() + "." + " You are old.");
            }
            

            // Fermer console
            Console.ReadKey();
        }
    }
}
