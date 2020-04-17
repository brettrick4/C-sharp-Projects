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
            
            Console.ReadLine();
			
			string DUI;
			bool isQualified = false;
            Console.WriteLine("True or false; you have been charged with a DUI.");
            DUI = Console.ReadLine()ToLower();
			if (DUI == "false")
			{
				isQualified = true;
			}
            

            Console.WriteLine("How many tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());


            if (age > 15 && isQualified == true && tickets < 3)
            {
                Console.WriteLine("You are qualified for car insurance.");
            }
            else
            {
                Console.WriteLine("You are not eligible for car insurance.");
            }
            Console.ReadLine();
        }

    }
}
