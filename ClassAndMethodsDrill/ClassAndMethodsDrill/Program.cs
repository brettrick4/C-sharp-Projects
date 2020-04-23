using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            Math math1 = new Math();
            Console.WriteLine("How many hot dogs would you like?");
            int userNum = Convert.ToInt32(Console.ReadLine());
            math1.Dogs(userNum);
            math1.Total(userNum);
            math1.Buns(userNum);
            Console.ReadLine();
        }
    }
}