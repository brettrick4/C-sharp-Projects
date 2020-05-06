using System;
using System.Collections.Generic;


namespace GenericsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> emp1 = new Employee<int>();
            Employee<string> emp2 = new Employee<string>();
            emp1.Things = new List<int>();
            emp1.Things.Add(22);
            emp1.Things.Add(44);
            emp1.Things.Add(88);

            emp2.Things = new List<string>();
            emp2.Things.Add("Here I ");
            emp2.Things.Add("go again ");
            emp2.Things.Add("on my own.");

            foreach (int Thing in emp1.Things)
            {
                Console.WriteLine(Thing);
            }
            foreach (string Thing in emp2.Things)
            {
                Console.WriteLine(Thing);
                Console.ReadLine();
            }
        }
    }
}
