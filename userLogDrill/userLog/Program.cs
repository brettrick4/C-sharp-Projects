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
            using (StreamWriter file = File.AppendText("C:\\Users\\Student\\source\\Logs\\log.txt"))
            {
                file.WriteLine(words, file);
            }
            using (StreamReader log = File.OpenText("C:\\Users\\Student\\source\\Logs\\log.txt"))
            {
                DumpLog(log);
            }
        }
        public static void DumpLog(StreamReader log)
        {
            string line;
            while ((line = log.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
