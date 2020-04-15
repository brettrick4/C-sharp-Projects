using System;



    class Program
    {
    static void Main()
        {
        Console.WriteLine(@"The Tech Academy
Student Daily Report");
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);
        Console.ReadLine();

        Console.WriteLine(@"Do you need help with anything?
Please answer ""true"" or ""false"".");
        bool isNeedHelp = true;
        Console.WriteLine();
        Console.ReadLine();
       
        Console.WriteLine(@"Where there any positive experiences you'd like to share?
Please give specifics.");
        string posEx = Console.ReadLine();

        Console.WriteLine(@"Is there any other feedback you'd like to provide?
Please be specific.");
        string feedBack = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string studyHours = Console.ReadLine();
        decimal studyHrs = Convert.ToDecimal(studyHours);
        Console.ReadLine(); 

        Console.WriteLine(@"Thank you for your answers. An instructor will respnde to you shortly.
Have a great day!");
        Console.ReadLine();
        }
    }

