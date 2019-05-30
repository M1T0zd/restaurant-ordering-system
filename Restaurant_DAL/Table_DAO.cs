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
    public class Table_DAO : Base
    {
        public List<Table> GetTables()
        {
            //
            string query = "SELECT Name, EmpRole, Number FROM [Tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                 
                    Number = (int)dr["Number"]
                };
                tables.Add(table);
            }
            return tables;
        }
    }
}
