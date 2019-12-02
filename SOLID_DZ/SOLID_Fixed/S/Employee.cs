using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fixed.S
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
                
        public bool Add(Employee emp)
        {            
            return true;
        }
    }
}
