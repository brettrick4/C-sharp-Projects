using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill160
{
    static class Program
    {
        static void Main(string[] args)
        {
            Cosmic cosmic1 = new Cosmic();
            Console.WriteLine("Pick a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            cosmic1.Comsmos(userNum1);

            Console.WriteLine("How many miles are between your home and your work, roughly?");
            int miles = Convert.ToInt16(Console.ReadLine());
            int yards = 1760;
            int distance = miles * yards;
            cosmic1.Distance(miles, yards);
            Console.WriteLine( miles + " miles is equivalent to " + distance + " yards.");
            Console.ReadLine();

            Console.WriteLine("How much water have you had to drink today?");
            int two = 2;
            int four = 4;
            Cosmic.Water(two, four);
            Console.WriteLine("You should be drinking at least " + Cosmic.Water(2, 4) + 
                " glasses a day.");
            Console.ReadLine();

            string a, b;
            cosmic1.SandBox(out a, out b);
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
