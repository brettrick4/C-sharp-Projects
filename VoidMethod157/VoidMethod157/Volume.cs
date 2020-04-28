using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod157
{
    class Volume
    {
        public void Beer(int pintGlass, int ounces = 16)
        {
            int beerSteins = pintGlass * 2;
            Console.WriteLine("If you drink " + pintGlass + " pints of beer, you have had " +
                "the equivalent of " + beerSteins + " beer steins. A normal pint glass holds " 
                 + ounces + " ounces. That's alot of beer!");
        }
    }
}
