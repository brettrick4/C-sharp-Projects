using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy candy1 = new Candy();
            Console.WriteLine("Enter a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a second number. Or don't, it's cool either way.");
            string userNum2 = (Console.ReadLine());
            if (userNum2 == "")
            {
                candy1.Choc(userNum1);
            }
            else
            {
                int userNum3 = Convert.ToInt32(userNum2);
                candy1.Choc(userNum1, userNum3);
            }
            Console.ReadLine();
        }
    }
}