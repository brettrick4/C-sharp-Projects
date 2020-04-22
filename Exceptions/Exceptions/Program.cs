using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(@"Enter a number to divide each number in the list by.
2, 24, 40, 77, 190");
            int userNum = Convert.ToInt32(Console.ReadLine());
            List<int> numList = new List<int>() { 2, 24, 40, 77, 190 };
            numList.Remove(1);

            foreach (int num in numList)
            {
                int quotient = num / userNum;
                Console.WriteLine(num + " divided by " + userNum + " equals " + quotient);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number."); 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot be divided by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}



