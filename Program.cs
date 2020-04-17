using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the weight of the package to be sent.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the width of the package in inches.");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width > 50)
            {
                Console.WriteLine("The package is too wide to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            
            Console.WriteLine("Now enter the height of the package in inches.");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height > 50)
            {
                Console.WriteLine("This package is too tall to be shipped by Package Express. Good Day to you;");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Go ahead, enter the package length, if you feel lucky.");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length > 50)
            {
                Console.WriteLine("Too long. I said good day!");
                Console.ReadLine();
                return;
            }

            int total = (height * width * length * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + total);
            Console.ReadLine();
        }
    }
}
