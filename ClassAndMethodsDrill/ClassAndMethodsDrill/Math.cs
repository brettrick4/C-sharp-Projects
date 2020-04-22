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
            int hotDogs = userNum * 2;
            Console.WriteLine("Do you think you could eat " + hotDogs + " before you burst?");
        }

        public void Total(int userNum)
        {
            int total = userNum - 1 ;
            Console.WriteLine("We actually only have " + total + " dogs left. Want all of 'em?");
        }

        public void Buns(int hotDogs)
        {
            int buns = hotDogs * 2;
            Console.WriteLine("Somehow we still have " + buns + " buns left!");
        }
    }
}
