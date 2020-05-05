using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new Employee { ID = 22, employeeA = "Joe Shmoe" };
            Employee employeeB = new Employee { ID = 22, employeeA = "Joe Binden" };
            
            Console.WriteLine(employeeA.ID == employeeB.ID);
            Console.ReadLine();
             
        }
    }
}
