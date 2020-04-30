using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
        public void Quittable(Employee employee)
        {
            Console.WriteLine("I quit!");
        }
    }
}
