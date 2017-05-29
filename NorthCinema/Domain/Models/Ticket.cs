using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Ticket
    {
        public Ticket(int ticketId, Session ticketSession, DateTime lastEdit, string ticketStatus, int price)
        {
            TicketId = ticketId;
            TicketSession = ticketSession;
            LastEdit = lastEdit;
            TicketStatus = ticketStatus;
            Price = price;
        }
        public int TicketId { get; private set; }
        public Session TicketSession { get; private set; }
        public DateTime LastEdit { get; private set; }
        public string TicketStatus { get; private set; }
        public int Price { get; private set; }

    }
}
