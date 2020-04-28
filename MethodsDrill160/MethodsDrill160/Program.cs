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
            Console.WriteLine("If your home is " + miles + " miles away from your work, " +
                "that is equivalent to " + distance + " yards.");
            Console.ReadLine();
        }
    }
}
