using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class DayOfSessions
    {
        public DayOfSessions(DateTime fullDate, DayOfWeek day, ListOfSessions sessions)
        {
            FullDate = fullDate;
            Day = day;
            Sessions = sessions;
        }
        public DateTime FullDate { get; private set; }
        public DayOfWeek Day { get; private set; }
        public ListOfSessions Sessions { get; private set; }
    }
}
