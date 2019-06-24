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
        public void UpdateTable(Session session)
        {
            session_DAO.UpdateTable(session);
        }
        public void UpdateTablePayment(Session session)
        {
            session_DAO.UpdateTablePayment(session);
        }
        public void GetSessionId(Session session)
        {
            session_DAO.GetID(session);     
        }
        public void SaveComments(Session session, string comments)
        {
            session_DAO.SaveComments(session, comments);
        }
        public void GetSessionIdforOccupiedTable(Session session)
        {
            session_DAO.GetIDforOccupiedTable(session);
        }
    }
}
