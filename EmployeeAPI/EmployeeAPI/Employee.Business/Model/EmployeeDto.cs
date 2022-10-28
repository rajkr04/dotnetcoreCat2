using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business.Model
{
    public class EmployeeDto
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public string EmpAddress { get; set; }
        public string Dept { get; set; }
        public int? Salary { get; set; }
    }
}
