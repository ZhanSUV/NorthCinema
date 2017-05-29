using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class CalendarOfDaysOfSessions
    {
        public CalendarOfDaysOfSessions(List<DayOfSessions> days)
        {
            Days = days;
        }
        public List<DayOfSessions> Days { get; private set; }
    }
}
