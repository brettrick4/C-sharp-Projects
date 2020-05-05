using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadDrill
{
    public class Employee : Person
    {

        public static bool operator ==(Employee employeeC, Employee employeeD)
        {
            if (employeeC.ID == employeeD.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employeeC, Employee employeeD)
        {
            if (employeeC.ID != employeeD.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
