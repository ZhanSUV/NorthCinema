using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Sessions
    {
        public Sessions(int sessionId, int filmId, int hallId, DateTime dateSession, DateTime timeSession, int formatId)
        {
            SessionId = sessionId;
            FilmId = filmId;
            HallId = hallId;
            DateSession = dateSession;
            TimeSession = timeSession;
        }
        public int SessionId { get; private set; }
        public int FilmId { get; private set; }
        public int HallId { get; private set; }
        public DateTime DateSession { get; private set; }
        public DateTime TimeSession { get; private set; }
        public int FormatId { get; private set; }
    }
}
