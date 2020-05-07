using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        //private static int Hour;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            DateTime time = DateTime.Now;
            TimeSpan later = new TimeSpan(0, userNumber, 0, 0);
            DateTime hoursLater = time.Add(later);
            Console.WriteLine("Right now the time is " + time);
            Console.WriteLine("In {0} hours, the time will be {1} ", userNumber, hoursLater);

            Console.ReadLine();
        }
    }
}
