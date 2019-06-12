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
    public class Session_DAO : Base
    {
        public int UpdateTable(Session session)
        {
            string query = ($"INSERT INTO [Sessions] OUTPUT inserted.Id VALUES(2, 3, 1, '2019-06-12 16:32:00', null, null)");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteEditOutputQuery(query, sqlParameters));
        }

        private int ReadTable(DataTable dataTable)
        {
            DataRow dataRow = dataTable.Rows[0];

            int id = (int)dataRow["Id"];

            return id;
        }
    }
}
