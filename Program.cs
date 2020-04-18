using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the age of your dog.");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            bool isPuppy = dogAge < 3 == true;
            bool isGrown = dogAge >= 3 == true;
            
            while (isPuppy)
            {
                Console.WriteLine("Your dog is a puppy.");
                Console.WriteLine("You should feed your dog puppy food.");
                break;
            }
            while (isGrown)
            {
                Console.WriteLine("Your dog is old enough for adult dog food.");
                break;
            }
        Console.ReadLine();
        }
    }
}
