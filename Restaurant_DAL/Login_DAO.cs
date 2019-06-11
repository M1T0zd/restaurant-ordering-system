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
    public class Login_DAO : Base
    {
        public List<Login> Db_Get_All_Login()
        {
            string query = "SELECT C.Username, C.Password, R.Role " +
                "FROM Credentials AS C JOIN Employees as E ON e.Number = c.EmployeeNumber JOIN EmployeeRole AS R ON R.Id = E.RoleId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> logins = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Login login = new Login()
                {
                    Password = (String)dr["Password"],
                    Username = (String)(dr["Username"]),
                    RoleName = (String)dr["Role"]                
                };
                logins.Add(login);
            }
            return logins;
        }
    }
}
