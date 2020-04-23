using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsDrill
{
    public class Math
    {
        public void Dogs(int userNum)
        {
            Math math1 = new Math();
            int hotDogs = userNum * 2;
            Console.WriteLine("Do you think you could eat " + hotDogs + " before you burst?");
        }

        public void Total(int userNum)
        {
            int total = userNum - 1 ;
            Console.WriteLine("We actually only have " + total + " left.");
            if ( total > 1)
            {
                Console.WriteLine("Want the rest of 'em?");
            }
            else if ( total == 1)
            {
                Console.WriteLine("You get the last one!");
            }
            Console.ReadLine();
        }

        public void Buns(int hotDogs)
        {
            int buns = hotDogs * 2;
            Console.WriteLine(@"Somehow we still have " + buns + " buns left!\n" +
                "How does that always happen?");
        }
    }
}
