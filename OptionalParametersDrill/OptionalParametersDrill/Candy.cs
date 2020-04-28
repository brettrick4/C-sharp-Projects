using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersDrill
{
    class Candy
    {
        public int Choc(int userNum1, int userNum2 = 5)
        {
            int userTotal = userNmu1 * userNum2;
            Console.WriteLine(userNum1 + " times " + userNum2 + " equals " + userTotal);
            return userTotal;
        }
    }
}
