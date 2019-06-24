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
        public Session GetID(Session session)
        {
            string query = "SELECT TOP 1 Id FROM Sessions ORDER BY ID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), session);
        }

        private Session ReadTables(DataTable dataTable, Session session)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                session.Id = (int)dr["Id"];
            }
            return session;
        }
        public void UpdateTable(Session session)
        {
            string query = ($"INSERT INTO [Sessions] VALUES({session.Host.Number}, {session.Table.Number},'{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}', null,null)");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTablePayment(Session session)
        {
            string query = ($"UPDATE Sessions SET EndedAt = '{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}' WHERE Id = {session.Id}");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void SaveComments(Session session, string commnets)
        {
            string query = $"INSERT INTO Sessions(Comment) VALUES ('{commnets}') WHERE Id =  {session.Id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);


        }
    }
}
