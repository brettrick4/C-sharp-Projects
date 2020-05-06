using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it?");
            string today = Convert.ToString(Console.ReadLine().ToLower());
            {
                try
                {
                    DaysAndConfused.DaysOfTheWeek dayName = (DaysAndConfused.DaysOfTheWeek) Enum.Parse(typeof(DaysAndConfused.DaysOfTheWeek), today, true);
                    string days = Convert.ToString(dayName);
                    Console.WriteLine("Wow, I forgot it's {0} already.", today, Enum.Parse(typeof(DaysAndConfused.DaysOfTheWeek), days));
                }

                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                Console.ReadLine();
            }
        }
    }
}
