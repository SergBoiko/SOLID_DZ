using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fixed.L
{
    public class SeniorEmployee : IWork, IEmployee
    {
        public string GetWorkDetails(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }
}
