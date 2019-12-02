using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fixed.L
{
    public class JuniorEmployee : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }
}
