using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class TotalPercent
    {
        public TotalPercent(int percentId, int ticketId)
        {
            PercentId = percentId;
            TicketId = ticketId;
        }
        public int PercentId { get; set; }
        public int TicketId { get; set; }
    }
}
