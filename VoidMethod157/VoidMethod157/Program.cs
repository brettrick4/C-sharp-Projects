using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod157
{
    class Program
    {
        static void Main(string[] args)
        {
            Volume volume1 = new Volume();
            Console.WriteLine("Are you drinking enough beer? " +
                "How many pints of beer do you drink in a day?");
            int pintGlass = Convert.ToInt32(Console.ReadLine());
            int ounces = 16;
            volume1.Beer(pintGlass, ounces);
            Console.ReadLine();
        }
    }
}
