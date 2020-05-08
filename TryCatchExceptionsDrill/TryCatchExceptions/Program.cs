using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int userAge = Convert.ToInt32(Console.ReadLine());

                DateTime thisYear = DateTime.Now;
                DateTime birthYear = thisYear.AddYears(-userAge);
                
                if (userAge <= 0)
                {
                    throw (new Exception());
                }
                if (userAge > 100)
                {
                    throw (new Exception());
                }
                Console.WriteLine("{0} years ago it was exactly {1}.", userAge, birthYear);
            }
            catch (FormatException)
            {
                Console.WriteLine("An error occurred.");
                Console.ReadKey();
            }

            catch 
            {
                Console.WriteLine("This wont work if you don't enter your real age.");
                Console.ReadLine();
            }
            
            Console.ReadLine();
            
        }    
    }
}
