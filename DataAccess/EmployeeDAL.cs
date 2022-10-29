using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDAL
    {
        private SqlConnection con;
        private DbContext db;
        public EmployeeDAL()
        {
            db = new DbContext();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> Employees = new List<Employee>();
            con = db.GetConnection();
            try
            {
                //List<Employee> Employees = _context.Employees.ToList();
                SqlCommand cmd = new SqlCommand("getAllEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = reader.GetInt32(0);
                        employee.Name = reader.GetString(1);
                        employee.Salary = reader.GetInt32(2);
                        if (reader.IsDBNull(3))
                        {
                            employee.DepartmentId = null;
                        }
                        else
                        {
                            employee.DepartmentId = reader.GetInt32(3);
                        }
                        Employees.Add(employee);
                    }
                }
                else
                {
                    Employees = null;
                }
            }
            catch (Exception ex)
            {
                status(true, ex.Message);

            }
            finally
            {
                con.Close();
            }
            return Employees;

        }

        private void status(bool v, string message)
        {
            throw new NotImplementedException();
        }
    }
}
