using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDrill3.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a whole number between 1 and ten billion.");
            long num1 = Convert.ToInt32(Console.ReadLine());
            long product = num1 * 50;
            Console.WriteLine("Your number times 50 = " + product);
            Console.ReadLine();

            Console.WriteLine("Enter any number, with or without a decimal point.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double total = num2 + 25;
            Console.WriteLine("Your number added to 25 = " + total);
            Console.ReadLine();

            Console.WriteLine("Enter another number with or without a decimal point.");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double quotient = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + quotient);
            Console.ReadLine();

            Console.WriteLine("Enter a whole number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int remainder = num4 % 7;
            Console.WriteLine("Your number divided by 7 gives a remainder of " + remainder);
            Console.ReadLine();

            Console.WriteLine("Now choose a number between 1 and 100");
            int num5 = Convert.ToInt32(Console.ReadLine());
            bool trueOrfalse = num5 > 50;
            Console.WriteLine("Your number is greater than 50 = " + trueOrfalse.ToString());
            Console.ReadLine();
        }
    }
}
