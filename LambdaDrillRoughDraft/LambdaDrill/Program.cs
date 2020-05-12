using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); {
            new Employee { ID = 1, employee = "Fred Garvin" };
            new Employee { ID = 2, employee = "Joe Shmoe" };
            new Employee { ID = 4, employee = "Guido Sarducci" };
            new Employee { ID = 5, employee = "Mary Underhill" };
            new Employee { ID = 7, employee = "Susan Bolt" };
            new Employee { ID = 9, employee = "Man Dalorean" };
            new Employee { ID = 11, employee = "Joe Binded" };
            new Employee { ID = 15, employee = "Kate Black" };
            new Employee { ID = 16, employee = "Gary Greetree" };
            new Employee { ID = 19, employee = "Juan Witowskivitch" };
            new Employee { ID = 22, employee = "Joe Budlong" };
        }
            Convert.ToString(employee);
            foreach (Employee emp in employee)
            {
                if (List<Employee>.Contains("Joe"))
                {
                    continue;
                }
                Console.WriteLine(emp);
            }
            List<Employee> newList = employee.Where(x => x.employee.ToList(employee) == "Joe");
            Console.WriteLine(newList);

            List<Employee> IdList = employee.Where(x => x.employee.ID > 5);
            //Convert.ToString(employee);
            //foreach (Employee emp in employee)
            //{
            //    if (emp.Contains("Joe")) Console.WriteLine(emp);
            //    //    {
            //    //        Console.WriteLine(emp);
            //    //    }
            //}
            Console.ReadLine();
        }
    }
}
