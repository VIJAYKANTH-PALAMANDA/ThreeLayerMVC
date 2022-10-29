using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessObjects
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int? DepartmentId { get; set; }
    }
}
