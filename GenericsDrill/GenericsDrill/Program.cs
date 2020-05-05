using System;
using System.Collections.Generic;


namespace GenericsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Things = new List<int>();
            Things.Add(22);
            Things.Add(44);
            Things.Add(88);

            List<string> things = new List<string>();
            things.Add("Here I ");
            things.Add("go again ");
            things.Add("on my own.");

            foreach (string thing in things)
            {
                Console.WriteLine(things);
            }
            foreach (int Thing in Things)
            {
                Console.WriteLine(Things);
                Console.ReadLine();
            }
        }
    }
}
