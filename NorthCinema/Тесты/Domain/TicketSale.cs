using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class TicketSale
    {
        public TicketSale(int ticketId, int sessionId, int placeId, DateTime birthDateVisitor, int totalCost)
        {
            TicketId = ticketId;
            SessionId = sessionId;
            PlaceId = placeId;
            BirthDateVisitor = birthDateVisitor;
            TotalCost = totalCost;
        }
        public int TicketId { get; private set; }
        public int SessionId { get; private set; }
        public int PlaceId { get; private set; }
        public DateTime BirthDateVisitor { get; private set; }
        public int TotalCost { get; private set; }
    }
}
