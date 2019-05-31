using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using RestaurantModel;

namespace Restaurant_DAL
{
    public class Employee_DAO : Base
    {
        public List<Employee> GetEmployees()
        {
            string query = "SELECT Name, Role, Number FROM [Employees]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    Name = (String)dr["Name"],
                    Role = (char)(dr["Role"]),
                    Number = (int)dr["Number"]
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
