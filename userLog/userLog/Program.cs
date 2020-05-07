using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace userLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write what ever you want, it'll be logged in a text file.");
            string words = Convert.ToString(Console.ReadLine());
            using (StreamWriter file = new StreamWriter("C:\\Users\\Student\\source\\Logs\\log.txt", true))
            {
                file.WriteLine(words);
                Console.WriteLine("C:\\Users\\Student\\source\\Logs\\log.txt");
            }
            
            Console.ReadLine();
        }
    }
}
