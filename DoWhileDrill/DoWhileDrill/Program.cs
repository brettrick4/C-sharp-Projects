using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDrill
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(@"Hot enough for ya? 
Enter the current temperature.");
            int roomTemp = 70;
            int currentTemp = Convert.ToInt32(Console.ReadLine());
            bool isTooHot = currentTemp > roomTemp;
            bool isPerfect = currentTemp == roomTemp;

            do
            {
                switch (currentTemp)
                {
                    case 60:
                        Console.WriteLine("It's a little chilly.");
                        Console.WriteLine("Close that window, will you? Is it getting warmer?");
                        currentTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 70:
                        Console.WriteLine("70 is perfect. Don't touch that thermostat!");
                        isPerfect = true;
                        Console.ReadLine();
                        return;
                    case 80:
                        Console.WriteLine("80 is too hot! Open a window, turn on the fan!");
                        Console.WriteLine("Has is cooled down yet? What's the temperature now?");
                        currentTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("It's so hot I can't even move...");
                        Console.WriteLine("Am I dead...? Tell me it's not 100 anymore");
                        currentTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Hot enough for ya?");
                        Console.WriteLine("What's the temperature now?");
                        currentTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (isTooHot);
            
            Console.ReadLine();
        }
    }
}
