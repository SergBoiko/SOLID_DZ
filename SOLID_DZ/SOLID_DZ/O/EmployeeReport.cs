using SOLID_DZ.S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DZ.O
{
    public class EmployeeReport
    {
        public string TypeReport { get; set; }

        public void GenerateReport(Employee em)
        {
            if (TypeReport == "CSV")
            {
                
            }

            if (TypeReport == "PDF")
            {
                
            }
        }
    }
}
