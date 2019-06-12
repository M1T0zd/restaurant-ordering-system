using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Restaurant_Logic
{
    public class Session_Service
    {
        Session_DAO session_DAO = new Session_DAO();
        List<Session> sessions = new List<Session>();
        public void UpdateTable(Session session)
        {
            session_DAO.UpdateTable(session);
            sessions = session_DAO.GetID();
            foreach (Session session1 in sessions)
            {
                session.Id = session1.Id;
            }
        }
        
    }
}
