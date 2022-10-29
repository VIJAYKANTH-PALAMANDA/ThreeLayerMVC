using BussinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class EmployeeBAL
    {
        private EmployeeDAL DataService = new EmployeeDAL();

        public List<Employee> GetEmployees()
        {
            return DataService.GetEmployees();
        }
    }
}
