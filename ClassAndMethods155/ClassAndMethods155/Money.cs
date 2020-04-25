using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods155
{
    public class Money
    {
        public int Dollars(int myMon)
        {
            int yourMon = myMon * 2 / 3;
            int totalFunds = yourMon + myMon;
            Console.WriteLine("With my " + myMon + " and your " + yourMon + " we got " + totalFunds + ".");
            return totalFunds;
        }
        public int Dollars(decimal change, int totalFunds)
        {
            int dollar = Convert.ToInt32(Math.Ceiling(change));
            int newTotal = dollar + totalFunds;
            Console.WriteLine("Thats nearly " + dollar + ", which brings us to " +newTotal+ ", so far.");
            return newTotal;
        }
        public double Dollars(double newTotal)
        {
            double canMoney = Convert.ToDouble(144 * .1);
            double totalMoney = Convert.ToDouble(canMoney + newTotal);
            return canMoney;
        }
    }
}
