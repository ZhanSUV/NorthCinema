using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Session
    {
        public Session(int sessionId,Film filmSession, Hall hallSession, DateTime dateSession, DateTime timeSession)
        {
            SessionId = sessionId;
            FilmSession = filmSession;
            HallSession = hallSession;
            DateSession = dateSession;
            TimeSession = timeSession;
        }
        public int SessionId { get; private set; }
        public Film FilmSession { get; private set; }
        public Hall HallSession { get; private set; }
        public DateTime DateSession { get; private set; }
        public DateTime TimeSession { get; private set; }
    }
}
