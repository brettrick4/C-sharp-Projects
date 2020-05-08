using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Brett";
            var voiceMail = "You may leave a message, I may call you back...but I may not";
            Console.WriteLine("You have reached {0}'s voice mail. " + voiceMail, myName);
            Console.ReadLine();

            Message mess = new Message("Who is calling, please?", 2);
            Console.WriteLine("{0} Call back in {1} hours.", mess.Person, mess.Number);
            Console.ReadKey();
        }
    }
}
