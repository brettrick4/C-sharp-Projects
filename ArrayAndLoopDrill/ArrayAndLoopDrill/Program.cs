using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type in a name you might find in the South.");
        string southernName = Console.ReadLine();
        string[] southernNames = { "Bubba ", "Elmer ", "Laviticus ", "Leeroy ", "Cletus ", southernName };
        for (int j = 0; j < southernNames.Length; j++)
        {
            Console.WriteLine(southernNames[j]);
        }
        Console.ReadLine();

        //Infinite loop 
        int x = 0;
        //Fix the infinite loop by adding one to i each time-- while (x = 1) < 100) becomes while (x += 1) > 100)
        while ((x += 1) < 100)
        {
            Console.WriteLine("To infinity and beyond!");
            if (x > 10)
            {
                break;
            }
        }
        Console.ReadLine();

        //Loop using < operator
        Console.WriteLine("Please enter your IQ.");
        List<int> IQScores = new List<int>() { 121, 118, 133, 139, 141 };
        int myIQ = Convert.ToInt32(Console.ReadLine());

        foreach (int score in IQScores)
        {
            if (myIQ < 120)
            {
                Console.WriteLine("Sorry, your IQ is not high enough to enroll in the Tech Academy");
                break;
            }
            else
            {
                Console.WriteLine("You have a nice high IQ! You may continue on with enrollment.");
                break;
            }
        }
        Console.ReadLine();

        //Loop using <= operator
        Console.WriteLine("What's your best golf score?");
        List<int> golfScores = new List<int>();
        int myScore = Convert.ToInt32(Console.ReadLine());
        golfScores.Add(myScore);
        golfScores.Add(88);
        golfScores.Add(93);
        golfScores.Add(99);
        golfScores.Add(108);
        golfScores.Add(118);
        golfScores.Add(121);

        foreach (int score in golfScores)
        {
            if (score <= 108)
            {
                Console.WriteLine(score + " is a great golf score!");
                break;
            }
            else
            {
                Console.WriteLine("Keep practicing!");
                break;
            }
        }
        Console.ReadLine();

        Console.WriteLine("Guess my Mom's name! Is it: Karolin, Kristina, Kathy, Kathleen, or Kate?");
        string guess = Console.ReadLine();
        string[] names = new string[5];
        names[0] = "Karolin";
        names[1] = "Kristina";
        names[2] = "Kathy";
        names[3] = "Kathleen";
        names[4] = "Kate";

        foreach (string name in names)
        {
            string searchString = "Kathy";
            int index = Array.IndexOf(names, searchString);

            for (int i = 0; i < names.Length; i++)
            {
                if (guess == names[2])
                {
                    Console.WriteLine("That's right, Kathy! The index of the array that represents Kathy is: \"{0}\"", index);
                    break;
                }
                if (names.Contains(guess))
                {
                    Console.WriteLine("Nope, guess again.");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess a name from the list.");
                    break;
                }
            }
        }

        
        Console.ReadLine();

        Console.WriteLine("Who are the characters in the Flintstones family?");
        string chars = Convert.ToString(Console.ReadLine());
        List<string> match = new List<string>();
        match.Add("Fred");
        match.Add("Barney");
        match.Add("Wilma");
        match.Add("Betty");
        match.Add("Fred");
        match.Add("Bamm-bamm");
        match.Add("Pebbles");

        foreach (string mat in match)
        {
            Console.WriteLine(mat);
        }
        if (chars == "Fred")
        {
            Console.WriteLine("Yep, he's the main character.");
        }
        if (match.Contains(chars)) 
        {
            Console.WriteLine("That is one of the characters.");
        }
        else
        {
            Console.WriteLine("That is not on the list of Flintstone characters");
        }
        
        string checkString = "Fred";
        int y = match.IndexOf(checkString);
        Console.WriteLine("That's right, {0} is one of the characters, and the index is: {1}",chars, y);
        Console.ReadLine();

        Console.WriteLine("West coast state capitols.");
        string userEntry = Convert.ToString(Console.ReadLine());
        List<string> capitols = new List<string>();
        capitols.Add("Salem");
        capitols.Add("Olympia");
        capitols.Add("Sacramento");
        capitols.Add("Salem");

        foreach (string capitol in capitols)
        {
            Console.WriteLine(userEntry);
        }
        string lookString = "Salem";
        int s = capitols.IndexOf(lookString);
        Console.WriteLine("The repeated capitol is {0}", s);
        Console.ReadLine();
    }
}

