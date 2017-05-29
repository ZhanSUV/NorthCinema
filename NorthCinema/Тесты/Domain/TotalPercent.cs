using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class TotalPercent
    {
        public TotalPercent(int totalPercentId, int ticketId, int percentId)
        {
            TotalPercentId = totalPercentId;
            TicketId = ticketId;
            PercentId = percentId;
        }
        public int TotalPercentId { get; private set; }
        public int TicketId { get; private set; }
        public int PercentId { get; private set; }
    }
}
