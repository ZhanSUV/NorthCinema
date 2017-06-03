using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfSessions
    {
        public ListOfSessions(List<Session> sessions)
        {
            Sessions = sessions;
        }
        public List<Session> Sessions { get; set; }
        public static void AddSession<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void EditSession<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void DeleteSession<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void ShowList()
        {

        }
        public void AddSessionInList(int sessionId, Film filmSession, Hall hallSession, DateTime dateSession, TimeSpan timeSession)
        {
            Session session = new Session(sessionId, filmSession, hallSession, dateSession, timeSession);
            Sessions.Add(session);
        }
    }
}
