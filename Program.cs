using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            string DUI; 
            bool isQualified = false;
            Console.WriteLine("True or false; you have been charged with a DUI.");
            DUI = Console.ReadLine().ToLower();
            if (DUI == "false")
            {
                isQualified = true;
            }

            Console.WriteLine("How many tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (isQualified == true && tickets < 3 && age >= 15)
            {
                Console.WriteLine("You are qualified for car insurance.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not qualified for car insurance.");
            }
            Console.ReadLine();
        }

    }
}
