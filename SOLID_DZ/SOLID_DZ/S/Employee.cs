using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DZ.S
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool Add(Employee employee)
        {
            return true;
        }

        public void GenerateReport(Employee em)
        {

        }
    }
}
