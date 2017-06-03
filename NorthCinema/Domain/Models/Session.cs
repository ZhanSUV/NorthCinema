using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Session
    {
        public Session(int sessionId,Film filmSession, Hall hallSession, DateTime dateSession, TimeSpan timeSession)
        {
            SessionId = sessionId;
            FilmSession = filmSession;
            HallSession = hallSession;
            DateSession = dateSession;
            TimeSession = timeSession;
        }
        public int SessionId { get; set; }
        public Film FilmSession { get; set; }
        public Hall HallSession { get; set; }
        public DateTime DateSession { get; set; }
        public TimeSpan TimeSession { get; set; }
    }
}
