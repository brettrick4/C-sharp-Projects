using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill160
{
    class Cosmic
    {
        public void Comsmos(int userNum1) 
        {
            decimal total = Convert.ToDecimal(userNum1) / 2;
            Console.WriteLine(userNum1 + " divided by two = " + total);
        }

        public int Distance(int miles, int yards)
        {
            int distance = miles * 1760;
            return distance;
        }

        public void SandBox(out string a, out string b)
        {
            a = "Whatever you do, ";
            b = "don't pee in the sandbox.";
        }
        public static int Water(int one, int two)
        {
            return one * two;
        }
    }
}