using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods155
{
    class Program
    {
        static void Main(string[] args, int dollar, int totalMoney)
        {
            Money money1 = new Money();
            Console.WriteLine("Think I'll make a beer run, but all I have is...");
            int myMon = Convert.ToInt32(Console.ReadLine());
            money1.Dollars(myMon);
            money1.Dollars(dollar);
            money1.Dollars(totalMoney);
            Console.ReadLine();
        }
    }
}
