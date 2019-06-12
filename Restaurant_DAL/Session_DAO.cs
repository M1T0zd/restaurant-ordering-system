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
        public List<Session> GetID()
        {
            string query = "SELECT TOP 1 Id FROM Sessions ORDER BY ID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Session> ReadTables(DataTable dataTable)
        {
            List<Session> sessions = new List<Session>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Session session = new Session()
                {
                   
                    Id = (int)dr["Id"]
                };
                sessions.Add(session);
            }
            return sessions;
        }
        public void UpdateTable(Session session)
        {
            string query = ($"INSERT INTO [Sessions] VALUES(2, 3, 1,'{DateTime.Now}', null,null)");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private int ReadTable(DataTable dataTable)
        {
            DataRow dataRow = dataTable.Rows[0];

            int id = (int)dataRow["Id"];

            return id;
        }
        
    }
}
