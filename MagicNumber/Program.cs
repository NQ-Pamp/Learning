using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = new Random().Next(20) + 1;

            NewGame(baseNum);

            Win(baseNum);

            Console.ReadKey();
        }

        static int PickNumber()
        {
            string myNumber = Console.ReadLine();

            int pickedNum;

            while (int.TryParse(myNumber, out pickedNum) == false)
            {
                Console.WriteLine("This is not a number. Please enter a valid number.");
                myNumber = Console.ReadLine(); 
            }
            return pickedNum;
        }

        static void Win(int baseNum)
        {
            Console.WriteLine("Good job ! Magic number was " + baseNum);

        }

        static void NewGame(int baseNum)
        {
            Console.WriteLine("Pick a number between 1 and 20");

            // check number is valid
            int pickedNum = PickNumber();


            while (pickedNum != baseNum)
            {
                if (pickedNum > baseNum)
                {
                    Console.WriteLine("It's less.");
                }
                else
                {
                    Console.WriteLine("It's more.");
                }
                pickedNum = PickNumber();
            }
        }

    }
}
