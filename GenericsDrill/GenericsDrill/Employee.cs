using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDrill
{
    class Employee<T>
    {
        T _Things;

        public Employee(T things)
        {
            this._Things = things;
        }
        public void Write()
        {
            Console.WriteLine(this._Things);
        }
    }
}
