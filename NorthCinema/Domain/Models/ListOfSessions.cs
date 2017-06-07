using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class ListOfSessions
    {
        public ListOfSessions(List<Session> sessions)
        {
            Sessions = sessions;
        }
        public List<Session> Sessions { get; set; }
        public void AddSessionInList(int sessionId, Film filmSession, Hall hallSession, DateTime dateSession, TimeSpan timeSession)
        {
            Session session = new Session(sessionId, filmSession, hallSession, dateSession, timeSession);
            Sessions.Add(session);
        }
    }
}
