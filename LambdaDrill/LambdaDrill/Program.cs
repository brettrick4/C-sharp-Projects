﻿using System;
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
            List<Employee> employee = new List<Employee>() {
            new Employee { ID = 1, employee = "Fred Garvin" },
            new Employee { ID = 2, employee = "Joe Shmoe" },
            new Employee { ID = 4, employee = "Guido Sarducci" },
            new Employee { ID = 5, employee = "Mary Underhill" },
            new Employee { ID = 7, employee = "Susan Bolt" },
            new Employee { ID = 9, employee = "Man Dalorean" },
            new Employee { ID = 11, employee = "Joe Binded" },
            new Employee { ID = 15, employee = "Kate Black" },
            new Employee { ID = 16, employee = "Gary Greetree" },
            new Employee { ID = 19, employee = "Juan Witowskivitch" },
            new Employee { ID = 22, employee = "Joe Budlong" },
            };

            //var newEmployee = employee.Where(x => x.employee == "Joe");
            //Console.WriteLine(newEmployee);

            //foreach(Employee employe in employee.Where(x => (x.employee == "Joe")))
            //{
            //    Console.WriteLine(employee);

            //}
            List<string> newList = Employee.Where(x => x.employee == "Joe");
            Console.WriteLine(newList);

            //foreach (string emp in employee)
            //{
            //    if (emp.StartsWith("Joe"))
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
