using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods155
{
    public class Money
    {
        public void Dollars(int myMon)
        {
            int yourMon = myMon * 2 / 3;
            int totalFunds = yourMon + myMon;
            Console.WriteLine(@"With my " +myMon+ " and with your " +yourMon+ " that gives us " +totalFunds+ " bucks.");
        }
        public void Dollars(decimal dollar)
        {
            Console.WriteLine("Wait! Check the couch cusions. What did you find?");
            decimal change = Convert.ToDecimal(Console.ReadLine());
            int dollars = Convert.ToInt32(Math.Ceiling(change));
            Console.WriteLine("Thats nearly " + dollars + "!");
        }
        public void Dollars(string cans, int dollars)
        {
            Console.WriteLine("How many bottles and cans do we have to return?");
            string returnsStr = Convert.ToString(Console.ReadLine());
            int returns = Convert.ToInt32(returnsStr);
            decimal totalCans = Convert.ToDecimal(returns * .1);
            int totalReturns = Convert.ToInt32(Math.Ceiling(totalCans));
            int totalMoney = totalReturns + dollars;
            Console.WriteLine("That gives us about " + totalMoney + " bucks.");
            Console.ReadLine();
        }
    }
}
