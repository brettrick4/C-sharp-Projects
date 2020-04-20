using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
        Console.WriteLine("Complete this sentence: Early to bed,");
        Console.WriteLine("0: early to rise; make a person healthy, wealthy and wise.");
        Console.WriteLine("1: the early bird gets the worm!");
        Console.WriteLine("2: you can lead him to water, but you can't make him drink.");
        int phrase = Convert.ToInt32(Console.ReadLine());

        string[] wordArray = new string[3];
        wordArray[0] = "early to rise; make a person healthy, wealthy and wise";
        wordArray[1] = "the early bird gets the worm";
        wordArray[2] = "you can lead him to water but you can't make him drink.";
        Console.WriteLine("Early to bed, " + wordArray[phrase]);

        int[] numArray = { 2, 3, 5, 7 };
        Console.WriteLine("Enter a number between 0 and 3."); 
        int prime = Convert.ToInt32(Console.ReadLine());
        if (prime > 3)
        {
            Console.WriteLine("I said between 0 and 3, numbskull!");
        }
        Console.WriteLine(numArray[prime] + " is a prime number.");
        Console.ReadLine();

        Console.WriteLine("Pick a number between 0 and 4");
        int greeting = Convert.ToInt32(Console.ReadLine());
        List<string> wordList = new List<string>();
        wordList.Add("Hello");
        wordList.Add("Howdy");
        wordList.Add("Hey");
        wordList.Add("Hi There");
        wordList.Add("Greetings");

        Console.WriteLine(wordList[greeting]);
        Console.ReadLine();    
        }
    }
