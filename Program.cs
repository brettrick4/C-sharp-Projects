using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate: ");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Hours worked per week: ");
            int hours1 = Convert.ToInt32(Console.ReadLine());
             Console.ReadLine();

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate: ");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Hours worked per week: ");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1: ");
            int yearlyIncome = (rate1 * hours1) * 52;
            Console.WriteLine(yearlyIncome);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2: ");
            int annualIncome = (rate2 * hours2) * 52;
            Console.WriteLine(annualIncome);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money annually than Person 2?");
            bool trueOrfalse = yearlyIncome > annualIncome;
            Console.WriteLine(trueOrfalse);
            Console.ReadLine();

        }
    }
}
