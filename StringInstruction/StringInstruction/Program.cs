using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInstruction
{
    class Program
    {
        static void Main()
        {
            string name = "Brett";
            string friendsName = "Bryan";
            string friendsDog = "EZ";
            string title = "at my friend's house.";
            string quote = "My friend " + friendsName + " asked, \"Hey there, " + name + "\". \nHave you seen my dog " + friendsDog + "\"?";

            title = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(quote);
            Console.ReadLine();

            //int length = name.Length;

            //bool trueOrfalse = name.Contains("t");
            //trueOrfalse = name.EndsWith("s");

            
            

            ////Console.WriteLine(trueOrfalse);
            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Bubba";
            name = "Joe";
            StringBuilder sb = new StringBuilder("with a tall tale...");

            sb.Append("\nMy name is Brett. My friends call me..." + name + "." +
                "\nI was born at an early age, some would say too soon.\nOn a dark and stormy moonlit summer afternoon.");
            sb.Insert(0, "Allow me to preface this short story ");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
