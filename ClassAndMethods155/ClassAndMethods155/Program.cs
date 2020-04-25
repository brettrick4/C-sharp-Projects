using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods155
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money();
            Console.WriteLine("Think I'll make a beer run, but all I have is...");
            int myMon = Convert.ToInt32(Console.ReadLine());
            money1.Dollars(myMon);

            Console.WriteLine("Wait! Check the couch cusions. What did you find?");
            decimal change = Convert.ToDecimal(Console.ReadLine());
            int dollar = Convert.ToInt32(Math.Ceiling(change));
            int totalFunds = myMon + (myMon * 2 / 3); 
            money1.Dollars(dollar, totalFunds);

            Console.WriteLine("Also, we have a hundred and forty four bottles and cans to return.");
            string returnStr = Convert.ToString("144");
            int returns = Convert.ToInt32(returnStr);
            int newTotal = dollar + totalFunds;
            double canMoney = 14.4;
            double totalMoney = Convert.ToDouble(canMoney + newTotal);
            Console.WriteLine("Now we've got " + totalMoney + " bucks, maybe it'll be engough!");
            money1.Dollars(totalMoney);
            Console.ReadLine();
        }
    }
}
